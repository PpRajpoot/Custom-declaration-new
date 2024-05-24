using DomainProducer;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.DBContext
{
    public class ProducerContext : DbContext
    {
        public ProducerContext(DbContextOptions options) : base(options)
        {

        }
        // Parameterless constructor
        public ProducerContext() : base()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-C6L5N55;Initial Catalog=CumtomDeclaration;Integrated Security=True");
            }
        }

        public DbSet<ClsAddresses> T_Addresses { get; set; }
        public DbSet<ClsDeclaration> T_Declaration { get; set; }
        public DbSet<ClsEvent> T_Event { get; set; }
        public DbSet<ClsGoodsItem> T_GoodsItem { get; set; }
        public DbSet<ClsMaterialCommodityMapping> T_MaterialCommodityMapping { get; set; }
        public DbSet<ClsMessage> T_Message { get; set; }
        public DbSet<ClsCompany> T_Company { set; get; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed data for ClsCompany
            modelBuilder.Entity<ClsCompany>().HasData(
          new ClsCompany { companyId = 1, TIN = 10001, Name = "Global Connect", Email = "globalConnect@gmail.com", AddressID = 1, CreatedOn = DateTime.UtcNow, UpdatedOn = DateTime.UtcNow },
          new ClsCompany { companyId = 2, TIN = 10002, Name = "Swift Imports", Email = "swiftImports@gmail.com", AddressID = 2, CreatedOn = DateTime.UtcNow, UpdatedOn = DateTime.UtcNow },
          new ClsCompany { companyId = 3, TIN = 10003, Name = "Export Experts", Email = "exportExperts@gmail.com", AddressID = 3, CreatedOn = DateTime.UtcNow, UpdatedOn = DateTime.UtcNow },
          new ClsCompany { companyId = 4, TIN = 10004, Name = "Trade Navigation", Email = "tradeNavigation@gmail.com", AddressID = 4, CreatedOn = DateTime.UtcNow, UpdatedOn = DateTime.UtcNow }
      );

            // Seed data for ClsAddresses
            modelBuilder.Entity<ClsAddresses>().HasData(
          new ClsAddresses { Address = "a", City = "a_city", pincode = 000000, AddressID = Guid.NewGuid(), CreatedOn = DateTime.UtcNow, UpdatedOn = DateTime.UtcNow },
          new ClsAddresses { Address = "b", City = "b_city", pincode = 000000, AddressID = Guid.NewGuid(), CreatedOn = DateTime.UtcNow, UpdatedOn = DateTime.UtcNow },
          new ClsAddresses { Address = "c", City = "c_city", pincode = 000000, AddressID = Guid.NewGuid(), CreatedOn = DateTime.UtcNow, UpdatedOn = DateTime.UtcNow },
          new ClsAddresses { Address = "d", City = "d_city", pincode = 000000, AddressID = Guid.NewGuid(), CreatedOn = DateTime.UtcNow, UpdatedOn = DateTime.UtcNow }
      );

            modelBuilder.Entity<ClsMaterialCommodityMapping>().HasData(
          new ClsMaterialCommodityMapping { CommodityCode = 8517, MaterialType = "Electronic", Price = Convert.ToDecimal(1000), DutyPercentage = Convert.ToDecimal(0.40), CreatedOn = DateTime.UtcNow, UpdatedOn = DateTime.UtcNow },
          new ClsMaterialCommodityMapping { CommodityCode = 6101, MaterialType = "Clothing", Price = Convert.ToDecimal(2000), DutyPercentage = Convert.ToDecimal(0.30), CreatedOn = DateTime.UtcNow, UpdatedOn = DateTime.UtcNow },
          new ClsMaterialCommodityMapping { CommodityCode = 7206, MaterialType = "Steel", Price = Convert.ToDecimal(3000), DutyPercentage = Convert.ToDecimal(0.20), CreatedOn = DateTime.UtcNow, UpdatedOn = DateTime.UtcNow },
          new ClsMaterialCommodityMapping { CommodityCode = 3901, MaterialType = "Plastic", Price = Convert.ToDecimal(4000), DutyPercentage = Convert.ToDecimal(0.10), CreatedOn = DateTime.UtcNow, UpdatedOn = DateTime.UtcNow },
          new ClsMaterialCommodityMapping { CommodityCode = 2709, MaterialType = "CrudeOil", Price = Convert.ToDecimal(5000), DutyPercentage = Convert.ToDecimal(0.50), CreatedOn = DateTime.UtcNow, UpdatedOn = DateTime.UtcNow }
      );

            //modelBuilder.Entity<ClsEvent>().OwnsOne(
            //    jsondata => jsondata.events,
            //    builder =>
            //    {
            //        builder.ToJson()
            //    }
            //    );

            // You can add other configurations here if needed

            base.OnModelCreating(modelBuilder);
        }
    }
}
