﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp_models.LearnBlazorModels
{
    public class Demo_Product
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsActive { get; set; }
        public List<Demo_ProductDrop> ProductProperties { get; set; }

    }
}
