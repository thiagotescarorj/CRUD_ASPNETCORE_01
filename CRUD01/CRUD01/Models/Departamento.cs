using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD01.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        //Um departamento possi vários vendedores
        public ICollection<Vendedor> Vendedores { get; set; } = new List<Vendedor>();

        public Departamento()
        {
        }

        public Departamento(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public void AdcicionarVendedor(Vendedor vendedor)
        {
            Vendedores.Add(vendedor);
        }

        public double TotalVendas(DateTime dataInicio, DateTime dataFim)
        {
            return Vendedores.Sum(vendedor => vendedor.TotalVandas(dataInicio, dataFim));
        }
    }
}
