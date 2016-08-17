using InvViewer.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace InvViewer.DAL
{
    public class InventoryContext : DbContext
    {

        public InventoryContext()
            : base("InventoryContext")
        {
        }

        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Building> Buildings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}