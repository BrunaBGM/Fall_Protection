using Fall_Protection.Data.Context;
using Fall_Protection.Data.Entities;
using Fall_Protection.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Eventing.Reader;

namespace Fall_Protection.Controllers
{
    public class PessoaController : Controller
    {
        private readonly DatabaseContext _context;

        public PessoaController(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var clientes = await _context.Clientes.Include(c => c.Pessoa).ToListAsync();
            return View(clientes);
        }

        public IActionResult CadastroPessoaFisica()
        {
            return View();
        }

        public IActionResult CadastroPessoaJuridica()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CadastroPessoaFisica(PessoaFisica pessoaFisica)
        {
            try
            {
                if (pessoaFisica.PessoaFisicaId == 0)
                {
                    _context.PessoasFisica.Add(pessoaFisica);
                    _context.SaveChanges();

                    Cliente cliente = new Cliente
                    {
                        PessoaId = pessoaFisica.PessoaId,
                        DataCadastro = DateTime.Now,
                        StatusCliente = StatusEnum.Ativo
                    };

                    cliente.GerarNumeroContratoAleatorio();

                    _context.Clientes.Add(cliente);
                    _context.SaveChanges();

                    return RedirectToAction("Index");
                }
                else
                {
                    var pessoaFisicaEntity = await _context.PessoasFisica
                        .Include(pf => pf.Pessoa)
                        .Include(pf => pf.Endereco)
                        .FirstOrDefaultAsync(p => p.PessoaFisicaId == pessoaFisica.PessoaFisicaId);

                    if (pessoaFisicaEntity != null)
                    {
                        pessoaFisicaEntity.Pessoa.Nome = pessoaFisica.Pessoa.Nome;
                        pessoaFisicaEntity.Pessoa.Email = pessoaFisica.Pessoa.Email;
                        pessoaFisicaEntity.Pessoa.Telefone = pessoaFisica.Pessoa.Telefone;
                        pessoaFisicaEntity.Cpf = pessoaFisica.Cpf;
                        pessoaFisicaEntity.Rg = pessoaFisica.Rg;
                        pessoaFisicaEntity.DataNascimento = pessoaFisica.DataNascimento;
                        pessoaFisicaEntity.Genero = pessoaFisica.Genero;
                        pessoaFisicaEntity.Endereco.Cep = pessoaFisica.Endereco.Cep;
                        pessoaFisicaEntity.Endereco.Logradouro = pessoaFisica.Endereco.Logradouro;
                        pessoaFisicaEntity.Endereco.Numero = pessoaFisica.Endereco.Numero;
                        pessoaFisicaEntity.Endereco.Complemento = pessoaFisica.Endereco.Complemento;
                        pessoaFisicaEntity.Endereco.Bairro = pessoaFisica.Endereco.Bairro;
                        pessoaFisicaEntity.Endereco.Cidade = pessoaFisica.Endereco.Cidade;
                        pessoaFisicaEntity.Endereco.Estado = pessoaFisica.Endereco.Estado;
                        pessoaFisicaEntity.Endereco.Pais = pessoaFisica.Endereco.Pais;
                        
                        _context.Update(pessoaFisicaEntity);
                        _context.SaveChanges();
                    }
                }

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao cadastrar Pessoa Física: {ex.Message}");

                return RedirectToAction("Erro");
            }
        }

        [HttpPost]
        public async Task<IActionResult> CadastroPessoaJuridica(PessoaJuridica pessoaJuridica)
        {
            try
            {
                if (pessoaJuridica.PessoaJuridicaId == 0)
                {
                    
                    _context.PessoasJuridica.Add(pessoaJuridica);
                    _context.SaveChanges();

                    Cliente cliente = new Cliente
                    {
                        PessoaId = pessoaJuridica.PessoaId,
                        StatusCliente = StatusEnum.Ativo
                    };

                    cliente.GerarNumeroContratoAleatorio();

                    _context.Clientes.Add(cliente);
                    _context.SaveChanges();

                    return RedirectToAction("Index");
                }
                else
                {
                    var existingPessoaJuridica = await _context.PessoasJuridica
                        .Include(pf => pf.Pessoa)
                        .Include(pf => pf.Endereco)
                        .FirstOrDefaultAsync(p => p.PessoaJuridicaId == pessoaJuridica.PessoaJuridicaId);

                    if (existingPessoaJuridica != null)
                    {
                        existingPessoaJuridica.Pessoa.Nome = pessoaJuridica.Pessoa.Nome;
                        existingPessoaJuridica.Pessoa.Email = pessoaJuridica.Pessoa.Email;
                        existingPessoaJuridica.Pessoa.Telefone = pessoaJuridica.Pessoa.Telefone;
                        existingPessoaJuridica.Cnpj = pessoaJuridica.Cnpj;
                        existingPessoaJuridica.Endereco.Cep = pessoaJuridica.Endereco.Cep;
                        existingPessoaJuridica.Endereco.Logradouro = pessoaJuridica.Endereco.Logradouro;
                        existingPessoaJuridica.Endereco.Numero = pessoaJuridica.Endereco.Numero;
                        existingPessoaJuridica.Endereco.Complemento = pessoaJuridica.Endereco.Complemento;
                        existingPessoaJuridica.Endereco.Bairro = pessoaJuridica.Endereco.Bairro;
                        existingPessoaJuridica.Endereco.Cidade = pessoaJuridica.Endereco.Cidade;
                        existingPessoaJuridica.Endereco.Estado = pessoaJuridica.Endereco.Estado;
                        existingPessoaJuridica.Endereco.Pais = pessoaJuridica.Endereco.Pais;

                        _context.Update(existingPessoaJuridica);
                        _context.SaveChanges();
                    }

                    return RedirectToAction("Index");
                }

               
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Erro ao cadastrar Pessoa Jurídica: {ex.Message}");
                return RedirectToAction("Erro");
            }
        }

        [HttpGet]
        public async Task<IActionResult> Editar(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var pessoaFisica = await _context.PessoasFisica
                .Include(pf => pf.Pessoa)
                .Include(pf => pf.Endereco)
                .FirstOrDefaultAsync(pf => pf.PessoaId == id);

            if (pessoaFisica != null)
                return View("CadastroPessoaFisica", pessoaFisica);

            var pessoaJuridica = await _context.PessoasJuridica
                .Include(pj => pj.Pessoa)
                .Include(pj => pj.Endereco)
                .FirstOrDefaultAsync(pj => pj.PessoaId == id);

            if (pessoaJuridica != null)
                return View("CadastroPessoaJuridica", pessoaJuridica);

            return NotFound();

        }
        public async Task<IActionResult> Deletar(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            try
            {
                var pessoa = await _context.Pessoas.FindAsync(id);

                if (pessoa == null)
                {
                    return NotFound("Pessoa não encontrada");
                }

                _context.Pessoas.Remove(pessoa);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao deletar Pessoa: {ex.Message}");
                throw;
            }
        }
    }
}
