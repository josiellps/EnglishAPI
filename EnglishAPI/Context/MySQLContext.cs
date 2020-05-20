using EnglishAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishAPI.Context
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
    }
}
