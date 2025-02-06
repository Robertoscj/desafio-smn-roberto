using dotnet_app_roberto.Models;
using DotnetAppRoberto2.Repositories;
using DotnetAppRoberto2.Services;
using Microsoft.AspNetCore.Mvc;

namespace DotnetAppRoberto2.Controllers
{
    [Route("api/tarefa")]
    [ApiController]
    public class TarefaController : ControllerBase
    {
        private readonly ITarefaRepository _tarefaRepository;
        private readonly EmailService _emailService;

        public TarefaController(ITarefaRepository tarefaRepository, EmailService emailService)
        {
            _tarefaRepository = tarefaRepository;
            _emailService = emailService;
        }

        [HttpGet]
        public async Task<IActionResult> GetTarefas()
        {
            var tarefas = await _tarefaRepository.GetTarefasAsync();
            return Ok(tarefas);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTarefa([FromBody] Tarefa tarefa)
        {
            if (ModelState.IsValid)
            {
                await _tarefaRepository.AddTarefaAsync(tarefa);
                _emailService.SendEmail(tarefa.UsuarioEmail, "Nova Tarefa Atribuída", $"Você recebeu uma nova tarefa: {tarefa.Mensagem}");
                return Ok(new { message = "Tarefa criada com sucesso." });
            }
            return BadRequest("Dados inválidos.");
        }

        [HttpPost("{id}/concluir")]
        public async Task<IActionResult> ConcluirTarefa(int id)
        {
            var tarefa = await _tarefaRepository.GetTarefaByIdAsync(id);
            if (tarefa == null) return NotFound();

            tarefa.Concluida = true;
            await _tarefaRepository.UpdateTarefaAsync(tarefa);
            _emailService.SendEmail("gestor@empresa.com", "Tarefa Concluída", $"A tarefa '{tarefa.Mensagem}' foi concluída.");

            return Ok(new { message = "Tarefa concluída com sucesso." });
        }
    }
}