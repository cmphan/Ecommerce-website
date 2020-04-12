﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce.Model
{
    public class Cart
    {
        [Key]
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public Products Products { get; set; }
        public int Quantity { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}