﻿using AutoMapper;
using SimpleInjector;
using SimpleInjector.Packaging;

namespace $safeprojectname$.Infrastructure
{
    public class AutoMapperPackage : IPackage
    {
        public void RegisterServices(Container container)
        {
            //var config = new MapperConfiguration(cfg => {
            //    cfg.AddProfiles(typeof(CustomerProfile));
            //});

            //container.RegisterSingleton(config);
            //container.Register(() => config.CreateMapper(container.GetInstance));
        }
    }
}