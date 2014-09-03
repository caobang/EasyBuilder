using EasyBuilder.Core.Application;
using EasyBuilder.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using EasyBuilder.Core.ObjectContainers.Unity;
using EasyBuilder.Core.ObjectContainers.Extension;
using EasyBuilder.Core.Repositories.EntityFramework;
using EasyBuilder.Core.Repositories;
using EasyBuilder.Core.Cryptographies.EntLib;

namespace EasyBuilder
{
    // 注意: 有关启用 IIS6 或 IIS7 经典模式的说明，
    // 请访问 http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            

            //初始化数据库
            Database.SetInitializer<EasyBuilderDbContext>(new EasyBuilderInitializer());

            //配置初始化
            AppRuntime.Create()
                .UsingMD5Cryptography("MD5Cng")
                .UsingUnityObjectContainer(container =>
                {
                    container.RegisterType<DbContext, EasyBuilderDbContext>()
                        .RegisterType<IEFRepositoryContext, EFRepositoryContext>()
                        .RegisterType<IRepository, EFRepository>();

                    //服务类程序集自动注入，需要所有注入的接口继承IAssemblyDependency
                    container.RegisterAssemblyTypes("EasyBuilder.Services");

                }).Start();




        }
    }
}