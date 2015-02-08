using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hello_Nancy
{
    public class HelloWorld : Nancy.NancyModule
    {
        public HelloWorld()
        {
            Get["/"] = _ => "Hello World!";
        }
    }
}