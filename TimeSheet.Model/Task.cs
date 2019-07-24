using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TimeSheet.Model
{
    public class Task
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public double NoOfHours { get; set; }
    }
}
