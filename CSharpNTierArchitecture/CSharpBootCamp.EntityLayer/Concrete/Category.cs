﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBootCamp.EntityLayer.Concrete
{
    //Field -> int x;
    
    // Variable  ->
    //void Test()
    //{
    //    int y;
    //}

    // Property ->  public int z { get; set; }
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}