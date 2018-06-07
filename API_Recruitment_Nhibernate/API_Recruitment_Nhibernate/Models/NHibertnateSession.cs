using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_Recruitment_Nhibernate.Models
{
    public class NHibertnateSession
    {
        public static ISession OpenSession()
        {
            var configuration = new Configuration();
            var configurationPath = HttpContext.Current.Server.MapPath(@"~\Models\Nhibernate\hibernate.cfg.xml");
            configuration.Configure(configurationPath);
            var nhanviensConfiguration = HttpContext.Current.Server.MapPath(@"~\Models\Nhibernate\nhanviens.hbm.xml");
            configuration.AddFile(nhanviensConfiguration);
            var phieutuyenConfiguration = HttpContext.Current.Server.MapPath(@"~\Models\Nhibernate\phieutuyendung.hbm.xml");
            configuration.AddFile(phieutuyenConfiguration);
            ISessionFactory sessionFactory = configuration.BuildSessionFactory();
            return sessionFactory.OpenSession();
        }
    }
}