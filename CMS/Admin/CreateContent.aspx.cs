using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.Data.Entity.Infrastructure;

namespace CMS.Admin
{
    public partial class CreateContent : System.Web.UI.Page
    {
        CMSEntities _cmsEntity;

        protected void Page_Load(object sender, EventArgs e)
        {
            _cmsEntity = new CMSEntities();
            Page.Title = CMS.Site.HeadTitle + " - Создание нового контента";
            LoadInDropDownListInXml();
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

        protected void ButtonCreateContent_Click(object sender, EventArgs e)
        {
            _cmsEntity.Contents.Add(new CMS.Contents { Title = TextBoxTitle.Text,
                                                       Publish = CheckBoxPublish.Checked.ToString(),
                                                       AccessLevel = DropDownListAccessLevel.SelectedValue,
                                                       ShowTitle = CheckBoxShowTitle.Checked.ToString(),
                                                       Position = DropDownListPosition.SelectedValue,
                                                       Text = TextBoxText.Text });
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
                Session["UpdateDbOk"] = "Данные успешно добавлены!";
            else
                Session["UpdateDbNotOk"] = "Данные не были добавлены!";

            Response.Redirect("~/Admin/Contents.aspx");
        }
    }
}