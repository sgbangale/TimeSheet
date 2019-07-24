using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TimeSheet.Model
{
    public class Timesheet
    {
        public Timesheet()
        {
            this.Tasks = new HashSet<Task>();
        }

        [Key]
        public int Id { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }
    }
}
