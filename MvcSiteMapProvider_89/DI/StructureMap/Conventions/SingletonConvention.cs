using System;
using StructureMap.Configuration.DSL;
using StructureMap.Graph;

namespace MvcSiteMapProvider_89.DI.StructureMap.Conventions
{
    public class SingletonConvention
        : IRegistrationConvention
    {
        public void Process(Type type, Registry registry)
        {
            registry.For(type).Singleton();
        }
    }
}
