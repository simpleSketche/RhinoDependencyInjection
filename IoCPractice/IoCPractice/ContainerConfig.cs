using Autofac;
using BussinessLogics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IoCPractice
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            // whenever looking for IBussinessLogic, return BussinessLogic instance
            builder.RegisterType<BussinessLogic>().As<IBussinessLogic>();

            return builder.Build();
        }
    }
}
