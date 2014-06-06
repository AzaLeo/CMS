using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace CMS.Admin
{
    public partial class EditContent : System.Web.UI.Page
    {
        private int _currentContentId;
        private CMSEntities _cmsEntity;

        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = CMS.Site.HeadTitle + " - Редактирование контента";
            LoadInDropDownListInXml();
            _cmsEntity = new CMSEntities();
            _currentContentId = Convert.ToInt32(Request.QueryString["id"]);

            if (!IsPostBack)
            {
                foreach (var r in GetContentById(_currentContentId))
                {
                    LabelIdResult.Text = r.ContentId.ToString();
                    TextBoxTitle.Text = r.Title;
                    CheckBoxPublish.Checked = Convert.ToBoolean(r.Publish);
                    DropDownListAccessLevel.SelectedValue = r.AccessLevel;
                    CheckBoxShowTitle.Checked = Convert.ToBoolean(r.ShowTitle);
                    DropDownListPosition.SelectedValue = r.Position;
                    TextBoxText.Text = r.Text;
                }
            }
        }

        protected void ButtonSaveContent_Click(object sender, EventArgs e)
        {
            foreach (var r in GetContentById(_currentContentId))
            {
                r.Title = TextBoxTitle.Text;
                r.Publish = CheckBoxPublish.Checked.ToString();
                r.AccessLevel = DropDownListAccessLevel.SelectedValue;
                r.ShowTitle = CheckBoxShowTitle.Checked.ToString();
                r.Position = DropDownListPosition.SelectedValue;
                r.Text = TextBoxText.Text;
            }

            int change = 0;

            try
            {
                change = _cmsEntity.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                Session["UpdateDbNotOk"] = ex.Message;
                Response.Redirect("~/Admin/Contents.aspx");
            }

            if (change > 0)
                Session["UpdateDbOk"] = "Данные успешно обновлены!";
            else
                Session["UpdateDbNotOk"] = "Данные не были обновлены!";

            Response.Redirect("~/Admin/Contents.aspx");
        }

        private IQueryable<CMS.Contents> GetContentById(int id)
        {
            var query = from content in _cmsEntity.Contents
                        where content.ContentId == id
                        select content;
            return query;
        }

        private void LoadInDropDownListInXml()
        {
            XElement dataXML = XElement.Load(Server.MapPath("DataForDropDownList.xml"));

            foreach (XElement name in dataXML.Elements("Roles").Elements("Role"))
            {
                DropDownListAccessLevel.Items.Add(name.Value);
            }

            foreach (XElement name in dataXML.Elements("Positions").Elements("Position"))
            {
                DropDownListPosition.Items.Add(name.Value);
            }
        }
    }
}