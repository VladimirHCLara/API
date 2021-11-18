using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YouHungry.Models
{
    public class Context : DbContext
    {

        //falo pro Entity que terei as tabelas abaixo

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Restaurante> Restaurantes { get; set; }
        public DbSet<Prato> Pratos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //responsável por configurar o Entity Framework
            //Vamos ter que trocar pra mysql
            optionsBuilder.UseMySQL("server=10.0.0.90:3306;database=Desafio;user=adminmysql;password=EVOGrupo32021@#");

            //optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\MSSQLLocalDB;Database=Cursomvc;Integrated Security=true");

            //optionsBuilder.UseMySQL(connectionString: @"Server=10.0.0.90:3306;Database=Desafio;Integrated Security=true");
        }

    }
}
