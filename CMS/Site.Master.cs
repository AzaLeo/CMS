using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CMS
{
    public partial class Site : System.Web.UI.MasterPage
    {
        public const string HeadTitle = "Тестовый сайт для SSA";
        private CMSEntities _cmsEntity;

        protected void Page_Load(object sender, EventArgs e)
        {
            _cmsEntity = new CMSEntities();

             var query = from result in _cmsEntity.Contents
                                   where result.Publish == "true"
                                   select result;

             Repeater1.DataSource = query.ToList();
             Repeater1.DataBind();
        }
    }
}