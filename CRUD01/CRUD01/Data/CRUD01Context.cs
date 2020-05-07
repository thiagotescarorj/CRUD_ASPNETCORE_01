using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUD01.Models;

namespace CRUD01.Data
{
    public class CRUD01Context : DbContext
    {
        public CRUD01Context (DbContextOptions<CRUD01Context> options)
            : base(options)
        {
        }

        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Vendedor> Vendedor { get; set; }
        public DbSet<RegistroVenda> RegistroVenda { get; set; }
    }
}
