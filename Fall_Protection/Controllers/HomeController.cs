using Fall_Protection.Data.Context;
using Fall_Protection.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Fall_Protection.Controllers
{
    public class HomeController : Controller
    {
        private readonly DatabaseContext _context;

        public HomeController(DatabaseContext context)
        {
            _context = context;

        }

        public IActionResult Index()
        {
            int totalUsers = GetTotalClientes();

            int totalInativos = GetTotalClientesInativos();

            int totalAtivos= GetTotalClientesAtivos();

            int totalPendentes = GetTotalClientesPendentes();


            ViewBag.TotalClientes = totalUsers;
            ViewBag.ClientesInativos = totalInativos;
            ViewBag.ClientesAtivos = totalAtivos;
            ViewBag.ClientesPendentes = totalPendentes;

            return View();
        }

        private int GetTotalClientes()
        {
            return _context.Clientes.Count();
        }

        private int GetTotalClientesInativos()
        {
            return _context.Clientes.Count(c => c.StatusCliente == StatusEnum.Inativo);
        }

        private int GetTotalClientesAtivos()
        {
            return _context.Clientes.Count(c => c.StatusCliente == StatusEnum.Ativo);
        }

        private int GetTotalClientesPendentes()
        {
            return _context.Clientes.Count(c => c.StatusCliente == StatusEnum.Pendente);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult PesquisarCliente(string termo)
        {
            var usuariosEncontrados = _context.Pessoas
                .Where(t => t.Nome.Contains(termo) || t.TipoPessoa.Contains(termo))
                .ToList();

            return RedirectToAction ("Index","Pessoa", usuariosEncontrados);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Erro()
        {
            return View();
        }
    }
}