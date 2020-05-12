using System;
using System.Collections.Generic;
using System.Linq;

namespace CRUD01.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime Nascimento { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento{ get; set; }
        public int DepartamentoId { get; set; }
        public ICollection<RegistroVenda> Vendas { get; set; } = new List<RegistroVenda>();


        public Vendedor()
        {
        }

        public Vendedor(int id, string name, string email, DateTime nascimento, double salarioBase, Departamento departamento)
        {
            Id = id;
            Nome = name;
            Email = email;
            Nascimento = nascimento;
            SalarioBase = salarioBase;
        }

        public void AdicionarVendas(RegistroVenda registro)
        {
            Vendas.Add(registro);
        }

        public void RemoverVendas(RegistroVenda registro)
        {
            Vendas.Remove(registro);
        }

        public double TotalVandas(DateTime dataInicio, DateTime dataFim)
        {
            return Vendas.Where(registro => registro.Data >= dataInicio && registro.Data <= dataFim).Sum(registro => registro.Total);
        }
    }
}
