using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CMS.Admin
{
    public partial class EditContent : System.Web.UI.Page
    {
        private int _currentContentId;
        private CMSEntities _cmsEntity;

        protected void Page_Load(object sender, EventArgs e)
        {
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
            Session["UpdateState"] = _cmsEntity.SaveChanges();
            Response.Redirect("~/Admin/Contents.aspx");
        }

        void Contents_stateSave()
        {
            throw new NotImplementedException();
        }

        private IQueryable<CMS.Contents> GetContentById(int id)
        {
            var query = from content in _cmsEntity.Contents
                        where content.ContentId == id
                        select content;
            return query;
        }
    }
}