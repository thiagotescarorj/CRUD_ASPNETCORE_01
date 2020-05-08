using CRUD01.Data;
using CRUD01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD01.Services
{
    public class ServicoVendedor
    {
        private readonly CRUD01Context _context;

        public ServicoVendedor(CRUD01Context context)
        {
            _context = context;
        }

        public List<Vendedor> EncontreTodos()
        {
            return _context.Vendedor.ToList();
        }
    }
}
