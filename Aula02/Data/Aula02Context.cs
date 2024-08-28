using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Aula02.Models;

namespace Aula02.Data
{
    public class Aula02Context : DbContext
    {
        public Aula02Context (DbContextOptions<Aula02Context> options)
            : base(options)
        {
        }

        public DbSet<Aula02.Models.Pessoa> Pessoa { get; set; } = default!;
    }
}
