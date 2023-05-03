using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Database.Entites;

namespace UserService.Controllers
{
    
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        EmployeeDataaccess obj = new EmployeeDataaccess();

        [Route("api/Employee/Allrecord")]
        [HttpGet]
        public ActionResult Allrecord()
        {

            return Ok(obj.allrecord());
        }
    }
}
