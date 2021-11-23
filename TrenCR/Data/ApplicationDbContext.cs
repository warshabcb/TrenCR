using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrenCR.Data;
using TrenCR.Model;

namespace TrenCR.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<SanJose_Cartago> SC { get; set; }
        public DbSet<Cartago_SanJose> CS { get; set; }
        public DbSet<Boletos> Boletos { get; set; }


    }

}
