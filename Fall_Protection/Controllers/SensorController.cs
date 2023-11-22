using Fall_Protection.Data.Context;
using Microsoft.AspNetCore.Mvc;

namespace Fall_Protection.Controllers
{
    public class SensorController : Controller
    {
        private readonly DatabaseContext _context;

        public SensorController(DatabaseContext context) 
        { 
            _context = context;
        }    
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastrar() 
        {
            return View();
        }
    }
}
