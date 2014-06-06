using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CMS.Admin
{
    public partial class Contents : System.Web.UI.Page
    {
        private int _currentContentId;

        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = CMS.Site.HeadTitle + " - Управление контентом";
            _currentContentId = Convert.ToInt32(Request.QueryString["delete"]);

            if (Session["UpdateDbOk"] != null)
            {
                UpdateStateLabel.CssClass = "updateok";
                UpdateStateLabel.Text = Session["UpdateDbOk"].ToString();
                Session.Remove("UpdateDbOk");
            }
            else if (Session["UpdateDbNotOk"] != null)
            {
                UpdateStateLabel.CssClass = "updatenotok";
                UpdateStateLabel.Text = Session["UpdateDbNotOk"].ToString();
                Session.Remove("UpdateDbNotOk");
            }

            if (IsPostBack)
                _currentContentId = 1;
        }
    }
}