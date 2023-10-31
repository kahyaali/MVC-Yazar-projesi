﻿using EntityLayer.Concrete; // Heading sınıfını kullanabilmek için ekledik
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IHeadingDal:IRepository<Heading>
    {
    }
}