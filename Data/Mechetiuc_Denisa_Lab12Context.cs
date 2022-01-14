using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mechetiuc_Denisa_Lab12.Models;

namespace Mechetiuc_Denisa_Lab12.Data
{
    public class Mechetiuc_Denisa_Lab12Context : DbContext
    {
        public Mechetiuc_Denisa_Lab12Context (DbContextOptions<Mechetiuc_Denisa_Lab12Context> options)
            : base(options)
        {
        }

        public DbSet<Mechetiuc_Denisa_Lab12.Models.ShopList> ShopList { get; set; }
    }
}
