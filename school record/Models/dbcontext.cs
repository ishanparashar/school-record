using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace school_record.Models
{
    public class dbcontext:DbContext
    {
        public dbcontext() : base("DefaultConnection") { }
        public DbSet<stumodel> stu { get; set; }

    }
}