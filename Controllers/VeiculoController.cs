using AppTeste.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Microsoft.EntityFrameworkCore;

namespace AppTeste.Controllers
{
    public class VeiculoController : Controller
    {
        private readonly AppDbContext _context;
        public VeiculoController(AppDbContext context) 
        {
            _context = context;
        }

        // recebendo requisicoes

        public async Task<IActionResult> Index()
        {
            // recebendo dados
            var dados = await _context.Veiculo.ToListAsync();
            return View(dados);
        }
    }
}
