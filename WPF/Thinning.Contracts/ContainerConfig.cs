﻿namespace Thinning.Contracts
{
    using Autofac;
    using Thinning.Algorithm;
    using Thinning.Contracts.Algorithm;
    using Thinning.Infrastructure.Interfaces;

    public class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Test>().As<ITest>();
            builder.RegisterType<KMM>().As<IKMM>();
            builder.RegisterType<ZhangSuen>().As<IZhangSuen>();

            return builder.Build();
        }
    }
}
