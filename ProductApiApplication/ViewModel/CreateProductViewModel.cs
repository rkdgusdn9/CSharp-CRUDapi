﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductApiApplication.ViewModel
{
    public class CreateProductViewModel
    {
        [Required]
        public string Name { get; set; }
    }
}