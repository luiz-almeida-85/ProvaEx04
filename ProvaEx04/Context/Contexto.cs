using ProvaWeb2Ex4.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime;
using System.Web;

namespace ProvaEx04.Context
{
    public class Contexto : DbContext

    {
        public DbSet<Professor> Professors { get; set; }
    }
}