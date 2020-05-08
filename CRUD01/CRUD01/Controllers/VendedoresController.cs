using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUD01.Services;
using Microsoft.AspNetCore.Mvc;

namespace CRUD01.Controllers
{
    public class VendedoresController : Controller
    {
        private readonly ServicoVendedor _servicoVendedor;

        public VendedoresController(ServicoVendedor servicoVendedor)
        {
            _servicoVendedor = servicoVendedor;
        }

        public IActionResult Index()
        {
            var lista = _servicoVendedor.EncontreTodos();
            return View(lista);
        }
    }
}