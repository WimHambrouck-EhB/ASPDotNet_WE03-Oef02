using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Werkcollege03.Oef02.Models;

namespace Werkcollege03.Oef02.Data
{
    public class Werkcollege03Oef02Context : DbContext
    {
        public Werkcollege03Oef02Context (DbContextOptions<Werkcollege03Oef02Context> options)
            : base(options)
        {
        }

        public DbSet<ToDo> ToDo { get; set; }
    }
}
