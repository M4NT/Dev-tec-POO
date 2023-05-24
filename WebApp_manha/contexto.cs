﻿using Microsoft.EntityFrameworkCore;
using WebApp_manha.Entidades;

namespace WebApp_manha
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> opt) : base(opt) 
        {

        }

        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<Categorias> Categorias { get; set; }
        public DbSet<PermissaoEntidade> PERMISSAO { get; set; }
    }

}
