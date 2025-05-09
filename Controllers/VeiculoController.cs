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

        // criando o create para receber os dados
        public IActionResult Create() 
        { 
            return View();
        
        }
        [HttpPost]
        public async Task<IActionResult> Create(Veiculo veiculo)
        {
            if (ModelState.IsValid)
            {
                _context.Veiculo.Add(veiculo);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View();

        }

        // criação da função get para edição dos veiculos

        public async Task <IActionResult> Edit(int? id)
        {
            if (id == null) // regra para quando o id for nulo
                return NotFound();

            var dados = await _context.Veiculo.FindAsync(id);
            if (dados == null)
                return NotFound();


            return View(dados);
        }
        [HttpPost]
        public async Task <IActionResult> Edit(int id, Veiculo veiculo)
        {
            if(id !=veiculo.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                _context.Update(veiculo);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View();
        }

        // visualizar dados
        public async Task <IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Veiculo.FindAsync(id);

            if(dados ==null)
                return NotFound();

            return View(dados); 
        }

        // criacao do delate 

        public async Task<IActionResult> Delate(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Veiculo.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DelateConfirmed(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Veiculo.FindAsync(id);

            if (dados == null)
                return NotFound();

            _context.Veiculo.Remove(dados);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
