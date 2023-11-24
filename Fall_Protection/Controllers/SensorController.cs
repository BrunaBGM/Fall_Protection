using Fall_Protection.Data.Context;
using Fall_Protection.Data.Entities;
using Fall_Protection.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fall_Protection.Controllers
{
    public class SensorController : Controller
    {
        private readonly DatabaseContext _context;

        public SensorController(DatabaseContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var sensores = await _context.Sensores.ToListAsync();
            return View(sensores);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Cadastrar(Sensor sensor)
        {
            try
            {
                if (sensor.SensorId == 0)
                {

                    _context.Sensores.Add(sensor);
                    _context.SaveChanges();

                    return RedirectToAction("Index");
                }
                else
                {
                    var sensorEntity = _context.Sensores.FirstOrDefault(s => s.SensorId == sensor.SensorId);

                    if (sensorEntity != null)
                    {
                        sensorEntity.DispositivoModelo = sensor.DispositivoModelo;
                        sensorEntity.DispositivoNumeroSerie = sensor.DispositivoNumeroSerie;
                        sensorEntity.StatusSensor = sensor.StatusSensor;
                        sensorEntity.PrecoAparelho = sensor.PrecoAparelho;
                        sensorEntity.DataAlteracao = DateTime.Now;

                        _context.Update(sensorEntity);
                        _context.SaveChanges();
                    }

                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao cadastrar sensor: {ex.Message}");
                return RedirectToAction("Erro");
            }

        }

        [HttpGet]
        public async Task<IActionResult> Detalhes(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var sensorEntity = await _context.Sensores.FirstOrDefaultAsync(m => m.SensorId == id);

            if (sensorEntity == null)
            {
                return NotFound("Sensor não encontrado");
                        
            }

            return View("Cadastrar", sensorEntity);


        }
        public async Task<IActionResult> Deletar(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            try
            {
                var sensorEntity = await _context.Sensores.FindAsync(id);

                if (sensorEntity == null)
                {
                    return NotFound("Sensor não encontrado");
                }

                _context.Sensores.Remove(sensorEntity);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao deletar sensor: {ex.Message}");
                throw;
            }
        }
    }
}

