using Library.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data
{
    public class AllatContext :DbContext
    {
        string conn = "Server = 127.0.0.1; User ID=root; Password=; Database = AllatkakDB;";
        public DbSet<Pet> Pet { get; set; }
        public DbSet<Gazda> Gazda { get; set; }

        public AllatContext()
        {

        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server = (localdb)\\MSSQLLocalDB; Database = AllatkakDB; Trusted_Connection = True;");
            optionsBuilder.UseMySql(conn, ServerVersion.AutoDetect(conn));
        }
    }
}
