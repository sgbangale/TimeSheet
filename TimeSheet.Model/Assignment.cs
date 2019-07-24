using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TimeSheet.Model
{
    public class Assignment
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Client")]
        public int ClientId { get; set; }
        [ForeignKey("Provider")]
        public int ProviderId { get; set; }

        public virtual ICollection<Timesheet> Timesheets { get; set; }

        public Assignment()
        {
            this.Timesheets = new HashSet<Timesheet>();
        }
    }
}
