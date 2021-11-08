using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace AutoGuistModel
{
    public partial class AutoGeistEntitiesModel : DbContext
    {
        public AutoGeistEntitiesModel()
            : base("name=AutoGeistEntitiesModel")
        {
        }

        public virtual DbSet<Car> Car { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Order> Order { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(e => e.LastName)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .Property(e => e.PurchaseDate)
                .IsFixedLength();
        }
    }
}
