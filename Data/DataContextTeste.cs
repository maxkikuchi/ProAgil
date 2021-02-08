using Microsoft.EntityFrameworkCore;
using ProAgil.WebAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProAgil.WebAPI.Data
{
    public class DataContextTeste : DbContext
    {
        public DataContextTeste(DbContextOptions<DataContextTeste> options) : base(options){}

        public DbSet<Evento> Eventos { get; set; }
    }
}
