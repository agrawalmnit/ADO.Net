using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Class10
    {
        // get home

        public ActionResult Index()
        {
            Class9 db = new Class9();
            List<Employee> obj = db.GetEmployees();
            return View(obj);
        }
    }
}
