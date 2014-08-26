using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DoctorPatientApp.Models
{
    public class DocPatientDbContext: DbContext
    {
        public DbSet<Article> Articles { set; get; }
    }
}