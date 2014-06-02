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

            var query = from content in _cmsEntity.Contents
                        where content.ContentId == _currentContentId
                        select content;

            foreach (var r in query)
            {
                LabelIdResult.Text = r.ContentId.ToString();
                TextBoxTitle.Text = r.Title;
                CheckBoxPublish.Checked = Convert.ToBoolean(r.Publish);
                DropDownListAccessLevel.SelectedValue = r.AccessLevel;
                CheckBoxShowTitle.Checked = Convert.ToBoolean(r.ShowTitle);
                DropDownListPosition.SelectedValue = r.Position;
            }
        }

        
    }
}