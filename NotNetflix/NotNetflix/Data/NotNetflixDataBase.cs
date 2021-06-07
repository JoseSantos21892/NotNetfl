﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NotNetflix.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotNetflix.Data
{
    public class NotNetflixDataBase : IdentityDbContext
    {
        //construroe da classe NotNetflixDataBase
        //indicar onde está a BD à qual as tabelas estão associadas
        public NotNetflixDataBase(DbContextOptions<NotNetflixDataBase> options):base(options){}
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);

            //inserir dados da base de dados aqui
            /*modelbuilder.Entity<Filme>().HasData(
                new Filme { Id = 1, }
                )*/
        }

        public DbSet<Filme> Filme { get; set; }
        public DbSet<Fotografias> Fotografia { get; set; }
        public DbSet<Genero> Genero { get; set; }
        public DbSet<GeneroFilme> GeneroFilme { get; set; }
        public DbSet<Utilizador> Utilizador { get; set; }
        public DbSet<UtilizadorFilme> UtilizadorFilme { get; set; }
    }
}
