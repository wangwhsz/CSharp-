﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
namespace BLL
{
    public class UserManager
    {
        public User login(string admin)
        {
            return new UserServices().login(admin);
        }
    }
}
