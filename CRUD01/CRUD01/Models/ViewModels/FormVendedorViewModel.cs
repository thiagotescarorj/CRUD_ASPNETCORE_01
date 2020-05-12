using System.Collections.Generic;

namespace CRUD01.Models.ViewModels
{
    public class FormVendedorViewModel
    {
        public Vendedor Vendedor { get; set; }
        public ICollection<Departamento> Departamentos { get; set; }
    }
}
