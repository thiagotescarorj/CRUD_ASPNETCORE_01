using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUD01.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD01.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult Index()
        {
            List<Departamento> lista = new List<Departamento>();
            lista.Add(new Departamento { Id = 1, Nome = "Eletrônicos" });
            lista.Add(new Departamento { Id = 2, Nome = "Vestuário" });

            return View(lista);
        }
    }
}