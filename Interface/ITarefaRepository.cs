using System.Collections.Generic;
using System.Threading.Tasks;
using dotnet_app_roberto.Models;

namespace DotnetAppRoberto2.Repositories
{
    public interface ITarefaRepository
    {
        Task<IEnumerable<Tarefa>> GetTarefasAsync();
        Task<Tarefa> GetTarefaByIdAsync(int id);
        Task AddTarefaAsync(Tarefa tarefa);
        Task UpdateTarefaAsync(Tarefa tarefa);
        Task DeleteTarefaAsync(int id);
    }
}