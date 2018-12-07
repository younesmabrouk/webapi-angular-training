using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TnAcademy.Models;

namespace TnAcademy.Context
{
    public class TnAcademyContext : DbContext
    {
        public TnAcademyContext(): base("TnAcademyConnection")
        {
        }

        public DbSet<Teacher> Teachers { get; set; }
    }
}