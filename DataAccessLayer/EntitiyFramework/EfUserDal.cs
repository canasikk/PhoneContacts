﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntitiyFramework
{
    public class EfUserDal:GenericRepository<User>,IUserDal
    {
    }
}
