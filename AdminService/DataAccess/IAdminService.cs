﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminService.DataAccess
{
    public interface IAdminService
    {
        List<Admin> AllAdminRecord();
        Admin SingleAdminRecord(int id);
    }
}
