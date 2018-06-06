using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate;
using NHibernate.Cfg;

namespace API_Candidate_Nhibernate.Models
{
    public class NHibertnateSession
    {
        public static ISession OpenSession()
        {
            var configuration = new Configuration();
            var configurationPath = HttpContext.Current.Server.MapPath(@"~\Models\Nhibernate\hibernate.cfg.xml");
            configuration.Configure(configurationPath);
            var chucvuConfigurationFile = HttpContext.Current.Server.MapPath(@"~\Models\Nhibernate\Chucvu.hbm.xml");
            configuration.AddFile(chucvuConfigurationFile);
            var phieutuyendungConfigurationFile = HttpContext.Current.Server.MapPath(@"~\Models\Nhibernate\phieutuyendung.hbm.xml");
            configuration.AddFile(phieutuyendungConfigurationFile);
            var tinhtrangphieutuyendungConfigurationFile = HttpContext.Current.Server.MapPath(@"~\Models\Nhibernate\tinhtrangphieutuyendung.hbm.xml");
            configuration.AddFile(tinhtrangphieutuyendungConfigurationFile);
            ISessionFactory sessionFactory = configuration.BuildSessionFactory();
            return sessionFactory.OpenSession();
        }
    }
}