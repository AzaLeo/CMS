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
            int state = (int)(Session["UpdateState"] ?? -1);
            if (state > 0)
            {
                UpdateStateLabel.CssClass = "updateok";
                UpdateStateLabel.Text = "Данные успешно обновлены!";
                Session.Remove("UpdateState");
            }
            else if (state == 0)
            {
                UpdateStateLabel.CssClass = "updatenotok";
                UpdateStateLabel.Text = "При редактировании изменения не производились";
                Session.Remove("UpdateState");
            }
            
        }
    }
}