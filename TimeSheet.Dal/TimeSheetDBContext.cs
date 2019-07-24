using Microsoft.EntityFrameworkCore;
using System;
using TimeSheet.Model;

namespace TimeSheet.Dal
{
    public class TimeSheetDBContext : DbContext
    {
        public TimeSheetDBContext()
        {
        }

        // public virtual DbSet<TimeSheet> TimeSheets
        // {
        //     get;
        //     set;
        // }
        //public virtual DbSet<EmployeeDetail> EmployeeDetails
        //{
        //    get;
        //    set;
        //}
        
    }
}
