﻿using System;
using System.ComponentModel.DataAnnotations;

namespace TimeSheet.Model
{
    public class Provider
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
