﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework_Core
{
    public class EFAbout2DAL<T> : GenericRespository<About2>, IAbout2DAL
    {
    }
}
