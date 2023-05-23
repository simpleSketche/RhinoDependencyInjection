using Rhino;
using Rhino.Commands;
using Rhino.Geometry;
using Rhino.Input;
using Rhino.Input.Custom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogics
{
    public class BussinessLogic : IBussinessLogic
    {
        public string run()
        {
            string msg = "Business logic has been implemented through IoC pattern!";
            RhinoApp.WriteLine(msg);
            return msg;
        }
    }

}
