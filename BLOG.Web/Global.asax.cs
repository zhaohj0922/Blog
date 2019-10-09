using Autofac;
using Autofac.Integration.Mvc;
using BLOG.BLL;
using BLOG.DAL;
using BLOG.IBLL;
using BLOG.IDAL;
using BLOG.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace BLOG.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        private static IContainer Container { get; set; }
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //数据库初始值设定项
            Database.SetInitializer<DBContext>(null);

            //Autofac 依赖注入开始
            var builder = new ContainerBuilder();
            //根据名称约定（服务层的接口和实现均以Contract结尾），实现服务接口和服务实现的依赖
            builder.RegisterAssemblyTypes(Assembly.Load("BLOG.IBLL"), Assembly.Load("BLOG.BLL")).Where(t => t.Name.EndsWith("Contract")).AsImplementedInterfaces().PropertiesAutowired().InstancePerDependency();
            // 根据名称约定（数据访问层的接口和实现均以Repository结尾），实现数据访问接口和数据访问实现的依赖
            builder.RegisterAssemblyTypes(Assembly.Load("BLOG.IDAL"), Assembly.Load("BLOG.DAL")).Where(t => t.Name.EndsWith("Repository")).AsImplementedInterfaces().PropertiesAutowired().InstancePerDependency();
            builder.RegisterControllers(Assembly.GetExecutingAssembly()).PropertiesAutowired();
            Container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(Container));
            //Autofac 依赖注入结束
        }
    }
}
