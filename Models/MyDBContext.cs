using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elevén.Models
{
    public class MyDBContext : DbContext
    {
        public DbSet<Factura> Factura { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder) => optionBuilder.UseSqlServer("Data Source=LAPTOP-VBI96KNK\\SQLEXPRESS;Initial Catalog=ElevenFacturas;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

    }
}
