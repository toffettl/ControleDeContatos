using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ControleDeContatos.Data;
using ControleDeContatos.Models;

namespace ControleDeContatos.Controllers
{
    public class ContatoController : Controller
    {
        private readonly ControleDeContatosContext _context;

        public ContatoController(ControleDeContatosContext context)
        {
            _context = context;
        }

        // GET: Contato
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Editar()
        {
            return View();
        }
        public IActionResult Apagar()
        {
            return View();
        }
    }
}

