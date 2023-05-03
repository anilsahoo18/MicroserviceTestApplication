using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserService.Database.Entites
{
    public class EmployeeDataaccess
    {
      private readonly List<Employee> Listobj = new List<Employee>();
        public EmployeeDataaccess()
        {

            Listobj.Add(new Employee { id = 1, Name = "Ajit", City = "Jharsuguda" });
            Listobj.Add(new Employee { id = 2, Name = "Sujit", City = "Jajpur" });
            Listobj.Add(new Employee { id = 3, Name = "Rujit", City = "Jaipur" });
        }

        public List<Employee> allrecord()
        {
            return Listobj;
        }
    }
}
