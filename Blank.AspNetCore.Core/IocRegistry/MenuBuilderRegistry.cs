using Blank.AspNetCore.Abstract;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Loader;
using System.Text;

namespace Blank.AspNetCore.Core.IocRegistry
{
    public class MenuBuilderRegistry : Registry
    {
        public MenuBuilderRegistry()
        {
            Scan(x => {
                x.Assembly(AssemblyLoadContext.Default.LoadFromAssemblyName(new AssemblyName(IocConfig.GetConfig().ImplProject)));
                x.AddAllTypesOf<IMenuBuilder>();
            });
        }
    }
}