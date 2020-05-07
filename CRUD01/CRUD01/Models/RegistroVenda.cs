using CRUD01.Models.Enums;
using System;

namespace CRUD01.Models
{
    public class RegistroVenda
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Total { get; set; }
        public StatusVendedor Status { get; set; }
        public Vendedor Vendedor { get; set; }

        public RegistroVenda()
        {
        }

        public RegistroVenda(int id, DateTime data, double total, StatusVendedor status, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Total = total;
            Status = status;
            Vendedor = vendedor;
        }
    }
}