using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminService.DataAccess
{
    public class AdminRepositaryService : IAdminService
    {
        private readonly List<Admin> list = new List<Admin>();

        public AdminRepositaryService()
        {
            list.Add(new Admin { Id = 100, Name = "Tushar", City = "Bihar" });
            list.Add(new Admin { Id = 101, Name = "Girija", City = "Pune" });
        }
        public List<Admin> AllAdminRecord()
        {
            return list;
        }
        public Admin SingleAdminRecord(int id)
        {
            return list.Where(k => k.Id == id).FirstOrDefault();
        }
    }
}
