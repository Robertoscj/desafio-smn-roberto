using Dotnet.Database;
using dotnet_app_roberto.Models;
using Microsoft.EntityFrameworkCore;

namespace DotnetAppRoberto2.Repositories
{
    public class TarefaRepository : ITarefaRepository
    {
        private readonly AppDbContext _context;

        public TarefaRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Tarefa>> GetTarefasAsync()
        {
            return await _context.Tarefas.ToListAsync();
        }

        public async Task<Tarefa> GetTarefaByIdAsync(int id)
        {
            return await _context.Tarefas.FindAsync(id);
        }

        public async Task AddTarefaAsync(Tarefa tarefa)
        {
            _context.Tarefas.Add(tarefa);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateTarefaAsync(Tarefa tarefa)
        {
            _context.Tarefas.Update(tarefa);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTarefaAsync(int id)
        {
            var tarefa = await _context.Tarefas.FindAsync(id);
            if (tarefa != null)
            {
                _context.Tarefas.Remove(tarefa);
                await _context.SaveChangesAsync();
            }
        }

        Task<IEnumerable<Tarefa>> ITarefaRepository.GetTarefasAsync()
        {
            throw new NotImplementedException();
        }

        Task<Tarefa> ITarefaRepository.GetTarefaByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

       

    }
}