using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace CMS.Admin
{
    public partial class CreateContent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
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
    }
}