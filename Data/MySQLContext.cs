using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Context
{
    public class MySQLContext : DbContext
    {

        public MySQLContext()
        {
                
        }

        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options)
        {                
        }

        DbSet<Alunos> Alunos { get; set; }
        DbSet<Verbs> Verbs { get; set; }
    }
}
