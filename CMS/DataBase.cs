using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CMS
{
    public class DataBase
    {
        private CMSEntities _cmsEntity;
        private IQueryable<Contents> _result;

        public DataBase()
        {
            _cmsEntity = new CMSEntities();
            _result = from result in _cmsEntity.Contents
                      where result.Publish == "true"
                      select result;
        }

        public List<Contents> GetToMainContent()
        {
            return _result.Where(r => r.Position == "MainContent").ToList();
        }

        public List<Contents> GetToSideBarContent()
        {
            return _result.Where(r => r.Position == "SideBar").ToList();
        }
    }
}