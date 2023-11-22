using Fall_Protection.Data.Context;
using Fall_Protection.Data.Entities;
using Fall_Protection.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fall_Protection.Controllers
{
    public class PessoaController : Controller
    {
        private readonly DatabaseContext _context;

        public PessoaController(DatabaseContext context)
        {
            _context = context;
        }

        public IActionResult Listar()
        {
            return View(/* await _context.Pessoa.ToListAsync()*/);
        }

        public async Task<IActionResult> Detalhes(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var pessoa = await _context.Pessoas.FirstOrDefaultAsync(m => m.PessoaId == id);
            if (pessoa == null)
            {
                return NotFound("Cliente não encontrado");
            }

            return View(pessoa);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]


        public async Task<IActionResult> CadastrarPessoaFisica(PessoaFisica pf)
        {
            if (ModelState.IsValid)
            {
                if (pf.PessoaId == 0)
                {
                    Cliente novoCliente = new Cliente
                    {
                        DataCadastro = DateTime.Now,
                        StatusCliente = StatusEnum.Ativo,     
                    };

                    novoCliente.GerarNumeroContratoAleatorio();

                    // Adiciona o cliente ao contexto
                    _context.Add(novoCliente);

                    // Adiciona a pessoa física ao contexto
                    pf.PessoaId = novoCliente.PessoaId; // Associando a chave estrangeira
                    _context.Add(pf);
                }
                else
                {
                    PessoaFisica pfBanco = _context.PessoasFisica.Include(i => i.Pessoa).FirstOrDefault(m => m.PessoaId == pf.PessoaId);

                    if (pfBanco == null)
                        return NotFound();

                    pfBanco.Pessoa.Nome = pf.Pessoa.Nome;
                    pfBanco.Pessoa.Email = pf.Pessoa.Email;
                    pfBanco.Pessoa.Telefone = pf.Pessoa.Telefone;
                    pfBanco.Cpf= pf.Cpf;
                    pfBanco.Rg = pf.Rg;
                    pfBanco.Genero = pf.Genero;
                    pfBanco.DataNascimento = pf.DataNascimento;
                    pfBanco.Endereco.Cep = pf.Endereco.Cep;
                    pfBanco.Endereco.Logradouro = pf.Endereco.Logradouro;
                    pfBanco.Endereco.Numero = pf.Endereco.Numero;
                    pfBanco.Endereco.Complemento = pf.Endereco.Complemento;
                    pfBanco.Endereco.Bairro = pf.Endereco.Bairro;
                    pfBanco.Endereco.Cidade = pf.Endereco.Cidade;
                    pfBanco.Endereco.Estado = pf.Endereco.Estado;
                    pfBanco.Endereco.Pais = pf.Endereco.Pais;
                   
                }

                await _context.SaveChangesAsync();
            }

            return RedirectToAction("Listar");
        }
        public async Task<IActionResult> Editar(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var pessoa = await _context.Pessoas.FindAsync(id);

            if (pessoa == null)
                return NotFound("Cliente não encontrado");

            return View(pessoa);
        }
        public async Task<IActionResult> Deletar(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var pessoa = await _context.Pessoas.FirstOrDefaultAsync(m => m.PessoaId == id);
            if (pessoa == null)
            {
                return NotFound("Cliente não encontrado");
            }
            return View(pessoa);
        }
    }
}
