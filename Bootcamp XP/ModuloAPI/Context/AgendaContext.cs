using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore; // Corrigido "EntitiFrameworkCore" para "EntityFrameworkCore"
using ModuloAPI.Entities;

namespace ModuloAPI.Context
{
    public class AgendaContext : DbContext // Corrigido "dbContext" para "DbContext"
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {
        }

        public DbSet<Contato> Contatos { get; set; } // Adicionado espaço entre a propriedade e as chaves
    }
}
