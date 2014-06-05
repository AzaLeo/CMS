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
        protected void Page_Load(object sender, EventArgs e)
        {
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
        }
    }
}