using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using flowbox.shared.Models;

namespace flowbox.shared.Infra
{
    public class MyDbContext : DbContext
    {
        public MyDbContext()
        {
        }

        public DbSet<Produto> Produtos { get; set; }
    }
}
