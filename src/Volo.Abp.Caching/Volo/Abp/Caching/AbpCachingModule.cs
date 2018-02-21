﻿using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.Threading;

namespace Volo.Abp.Caching
{
    [DependsOn(typeof(AbpThreadingModule))]
    public class AbpCachingModule : AbpModule
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddMemoryCache();
            services.AddDistributedMemoryCache();

            services.AddAssemblyOf<AbpCachingModule>();

            services.AddSingleton(typeof(IDistributedCache<>), typeof(DistributedCache<>));
        }
    }
}
