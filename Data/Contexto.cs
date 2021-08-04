using JuegoFinal.Entidades;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JuegoFinal.Data
{
    public class Contexto : IdentityDbContext<Usuarios, IdentityRole<int>, int>
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
        public Contexto() { }

        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Puntajes> Puntajes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source= Data/MatchGame.db");
        }
    }
}
