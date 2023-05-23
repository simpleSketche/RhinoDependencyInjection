using Autofac;
using BussinessLogics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCPractice
{
    public static class Application
    {

        public static string Run(string msg)
        {
            IContainer container = ContainerConfig.Configure();

            string resp = "";

            using (var scope = container.BeginLifetimeScope())
            {
                IBussinessLogic app = scope.Resolve<IBussinessLogic>();
                resp = app.run();
            }

            return msg + resp;
        }
    }
}
