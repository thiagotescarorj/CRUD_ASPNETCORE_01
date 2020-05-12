using CRUD01.Data;
using CRUD01.Models;
using System.Collections.Generic;
using System.Linq;

namespace CRUD01.Servicos
{
    public class ServicoDepartamento
    {
        private readonly CRUD01Context _context;

        public ServicoDepartamento(CRUD01Context context)
        {
            _context = context;
        }

        public List<Departamento> EncontreTodos()
        {
            return _context.Departamento.OrderBy(x => x.Nome).ToList();
        }
    }
}
