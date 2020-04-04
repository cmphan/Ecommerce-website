﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce.Model
{
    public class OrderDetails
    {
        [Key]
        public int DetailId { get; set; }
        public int DetailProductQuantity { get; set; }
        public int OrderId { get; set; }
        public Orders Orders { get; set; }
        public int ProductId { get; set; }
        public List<Products> Products { get; set; }

    }
}