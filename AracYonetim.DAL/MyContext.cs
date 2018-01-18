using AracYonetim.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracYonetim.DAL
{
  public  class MyContext:DbContext
    {
        public MyContext():base("name=MyCon") { }
        public virtual DbSet<Marka>Markalar { get; set; }
        public virtual DbSet<Arac> Araclar { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //fluentapi vs ...
            modelBuilder.Entity<Arac>()
                .Property(x => x.Model)
                .HasMaxLength(200)
                .IsRequired();
        }
    }
}
