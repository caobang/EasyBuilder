using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuilder.Core.ObjectContainers.Extension
{
    public static class ObjectContainerExtension
    {
        public static IObjectContainer RegisterAssemblyTypes(this IObjectContainer objectContainer, string assemblyName, LifeStyle life = LifeStyle.Transient)
        {
            Assembly assembly = AppDomain.CurrentDomain.Load(assemblyName);
            if (assembly == null)
                throw new Exception("程序集不存在!");
            var types = assembly.GetTypes().Where(t => t.IsClass && t.GetInterface("IAssemblyDependency") != null);
            foreach (Type type in types)
            {
                Type from = type.GetInterfaces().Where(t => t.GetInterface("IAssemblyDependency") != null).First();
                objectContainer.RegisterType(from, type, life);
            }
            return objectContainer;
        }
    }
}
