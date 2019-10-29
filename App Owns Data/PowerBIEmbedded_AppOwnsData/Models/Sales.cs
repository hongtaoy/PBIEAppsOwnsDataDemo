using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace PowerBIEmbedded_AppOwnsData.Models
{
    public class Sale
    {
        public int ID { get; set; }
        public string State { get; set; }
        public string Sales { get; set; }
        public int Quantity { get; set; }
        public string Unit_Price { get; set; }
    }

    public class SalesDBContext : DbContext
    {
        public DbSet<Sale> Sales { get; set; }
    }
}