﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstPractice_Ecom.EF.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CatName { get; set; }

        //public virtual ICollection<Product> Products { get; set; }
        //public Category()
        //{
        //    Products = new List<Product>();
        //}
    }
}