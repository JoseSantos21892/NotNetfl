﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NotNetflix.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NotNetflix.Data
{
    public class ApplicationUser : IdentityUser
    {

        /// <summary>
        /// recolhe a data de registo de um utilizador
        /// </summary>
        public DateTime DataRegisto { get; set; }

        //[ForeignKey(nameof(cliente))]
        //public int UtilizadorFK { get; set; }
        [ForeignKey("userId")]
        public virtual Utilizador user { get; set; }
    }
    public class NotNetflixDataBase : IdentityDbContext<ApplicationUser>
    {
        //construtor da classe NotNetflixDataBase
        //indicar onde está a BD à qual as tabelas estão associadas
        public NotNetflixDataBase(DbContextOptions<NotNetflixDataBase> options):base(options){}
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);

            modelbuilder.Entity<IdentityRole>().HasData(
             new IdentityRole { Id = "u", Name = "Utilizador", NormalizedName = "UTILIZADOR" },
             new IdentityRole { Id = "g", Name = "Gestor", NormalizedName = "GESTOR" }
             );

            modelbuilder.Entity<Genero>().HasData(
                new Genero { Id = 1, Genre = "Ação"},
                new Genero { Id = 2, Genre = "Aventura" },
                new Genero { Id = 3, Genre = "Comédia" },
                new Genero { Id = 4, Genre = "Documentário" },
                new Genero { Id = 5, Genre = "Drama" },
                new Genero { Id = 6, Genre = "Fantasia" },
                new Genero { Id = 7, Genre = "Musical" },
                new Genero { Id = 8, Genre = "Terror" },
                new Genero { Id = 9, Genre = "Thriller" },
                new Genero { Id = 10, Genre = "Romance" }
                );
        }

        public DbSet<Filme> Filme { get; set; }
        public DbSet<Fotografia> Fotografia { get; set; }
        public DbSet<Genero> Genero { get; set; }
        public DbSet<Utilizador> Utilizador { get; set; }
        public DbSet<UtilizadorFilme> UtilizadorFilme { get; set; }
    }
}
