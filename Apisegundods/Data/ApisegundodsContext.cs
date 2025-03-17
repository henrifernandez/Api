using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Apisegundods.models;

namespace Apisegundods.Data
{
    public class ApisegundodsContext : DbContext
    {
        public ApisegundodsContext (DbContextOptions<ApisegundodsContext> options)
            : base(options)
        {
        }

        public DbSet<Apisegundods.models.alunos> alunos { get; set; } = default!;
        public DbSet<Apisegundods.models.Professor> Professor { get; set; } = default!;
        public DbSet<Apisegundods.models.Escola> Escola { get; set; } = default!;
    }
}
