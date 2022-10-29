using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApp.Controllers
{
    public class HomeController
    {
        public string Index(int? a, string name, string surname)
        {
            if(a==null)
            return $"First Controller a deyer yoxdur {name} {surname}";
            return $"First Controller {a} {name} {surname} ";
            
        }
        public string Test()
        {

            Index(name: "Irada", a: 555, surname: "feyzullayeva");
            return "Home controller's Test method";
        }
    }
}
