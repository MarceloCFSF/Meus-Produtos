using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Meus_Produtos.Models;

    public class ClientContext : DbContext
    {
        public ClientContext (DbContextOptions<ClientContext> options)
            : base(options)
        {
        }

        public DbSet<Meus_Produtos.Models.Client> Client { get; set; }
    }
