using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ef.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Hospital")
        {
        }

        public virtual DbSet<Patientdetail> Patientdetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patientdetail>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Patientdetail>()
                .Property(e => e.Contact)
                .IsUnicode(false);
        }
    }
}
