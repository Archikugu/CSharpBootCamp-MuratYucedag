﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBootCamp.EntityLayer.Concrete
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string FullName => $"{CustomerName} {CustomerSurname.ToUpper()}";
        public string CustomerDistrict { get; set; }
        public string CustomerCity { get; set; }

    }
}