using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Extensions
{
   public static class ServiceCollectionExtensions
    {
        //neyi genişletmek istiyorsak onu this ile veriyorduk.
        public static IServiceCollection AddDependencyResolvers(this IServiceCollection serviceCollection,ICoreModule[] modules)
        {
            foreach (var module in modules)// birden fazla module'ü eklememizi sağlıyor
            {
                module.Load(serviceCollection);
            }
            return ServiceTool.Create(serviceCollection);// Core katmanıda dahil olmak üzere ekleyeceğimiz bütün injectionları bir arada
                                                         // toplayabileceğimiz yapıya dönüştü
        
        }

    }
}
