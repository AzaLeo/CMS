using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace CMS.Admin
{
    public partial class DeleteContent : System.Web.UI.Page
    {
        private int _currentContentId;
        private CMSEntities _cmsEntity;

        protected void Page_Load(object sender, EventArgs e)
        {
            _cmsEntity = new CMSEntities();
            _currentContentId = Convert.ToInt32(Request.QueryString["delete"]);

            var query = from content in _cmsEntity.Contents
                        where content.ContentId == _currentContentId
                        select content;

            foreach (var content in query)
                _cmsEntity.Contents.Remove(content);

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
                Session["UpdateDbOk"] = "Данные успешно удалены!";
            else
                Session["UpdateDbNotOk"] = "Данные не были удалены!";

            Response.Redirect("~/Admin/Contents.aspx");
        }
    }
}