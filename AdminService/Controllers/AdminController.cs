using AdminService.DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminService.Controllers
{
   
    [ApiController]
    public class AdminController : ControllerBase
    {
        public IAdminService dataAccess;
        public AdminController (IAdminService _dataAccess)
        {
            dataAccess = _dataAccess;
        }

        [Route("api/Admin/AllAdminRecord")]
        [HttpGet]
        public IActionResult AllAdminRecord()
        {
            return Ok(dataAccess.AllAdminRecord());
        }

        [Route("api/Admin/SingleAdminRecord/{Adminid?}")]
        [HttpGet]
        public IActionResult SingleAdminRecord(int id)
        {
            return Ok(dataAccess.SingleAdminRecord(id));
        }

    }
}
