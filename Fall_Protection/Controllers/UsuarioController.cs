using Fall_Protection.Data.Context;
using Fall_Protection.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fall_Protection.Controllers;

public class UsuarioController : Controller
{
    private readonly DatabaseContext _context;

    public UsuarioController(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        return View(await _context.Usuarios.ToListAsync());
    }

    public async Task<IActionResult> Detalhes(int id)
    {
        if (id == 0)
        {
            return NotFound();
        }

        var usuario = await _context.Usuarios.FirstOrDefaultAsync(m => m.UsuarioId == id);
        if (usuario == null)
        {
            return NotFound("Usuário não encontrado");
        }

        return View(usuario);
    }

    public IActionResult Cadastrar()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CadastrarCliente(Usuario usuario)
    {
        if (ModelState.IsValid)
        {
                _context.Add(usuario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(usuario);
    }
    public async Task<IActionResult> Editar(int id)
    {
        if(id == 0)
        {
            return NotFound();
        }

        var usuario = await _context.Usuarios.FindAsync(id);

        if (usuario == null)
            return NotFound("Usuário não encontrado");

        return View(usuario);
    }

    [HttpPost]
    public async Task<IActionResult> Editar(int id, [Bind("UsuarioId,Nome,Email,Senha,DataNascimento")] Usuario usuario)
    {
        if(id != usuario.UsuarioId)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(usuario);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) 
            {
                if (!UsuarioExists(usuario.UsuarioId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToAction(nameof(Index));
        }

        return View(usuario);
    }

    public async Task<IActionResult> Deletar(int id)
    {
        if(id == 0)
        {
            return NotFound();
        }

        var usuario = await _context.Usuarios.FirstOrDefaultAsync(m => m.UsuarioId == id);
        if(usuario == null)
        {
            return NotFound("Usuário não encontrado");
        }
        return View(usuario);
    }
    private bool UsuarioExists(int usuarioId)
    {
        throw new NotImplementedException();
    }
}
