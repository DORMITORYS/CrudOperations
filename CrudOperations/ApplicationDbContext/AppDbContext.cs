using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tables.Models;

namespace CrudOperations.ApplicationDbContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("Assignment3")
        {

        }

        public virtual DbSet<Candidate> Candidates { get; set; }
        public virtual DbSet<Certificate> Certificates { get; set; }
        public virtual DbSet<Result> Results { get; set; }
    }
}
