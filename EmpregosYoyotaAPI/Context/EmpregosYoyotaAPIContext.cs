using EmpregosYoyotaAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using MySql.Data.Entity;

namespace EmpregosYoyotaAPI.Context
{
    public class EmpregosYoyotaAPIContext: DbContext
    {
        public EmpregosYoyotaAPIContext()
            : base("DefaultConnection")
        { 
        
        }

        public DbSet<Emprego> Empregos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<EmpregoCategoria> EmpregoCategorias { get; set; }
        public DbSet<Mensagem> Mensagens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<EmpregoCategoria>().HasKey(e => new { e.CategoriaId, e.EmpregoId });

            base.OnModelCreating(modelBuilder);
        }
    }
}