using Microsoft.EntityFrameworkCore;
using ProAgil.WebAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProAgil.WebAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        public DbSet<Evento> Eventos { get; set; }

        public DbSet<Teste> Testes { get; set; }
        
        public DbSet<TesteB> TesteB { get; set; }
    }
}
