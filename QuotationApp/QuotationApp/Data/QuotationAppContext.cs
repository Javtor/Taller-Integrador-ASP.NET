using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace QuotationApp.Models
{
    public class QuotationAppContext : DbContext
    {
        public QuotationAppContext (DbContextOptions<QuotationAppContext> options)
            : base(options)
        {
        }

        public DbSet<QuotationApp.Models.EventQuotation> EventQuotation { get; set; }
    }
}
