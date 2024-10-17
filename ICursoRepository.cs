// Diretório: Repositories/Interfaces/ICursoRepository.cs
using ProjetoBusca.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoBusca.Repositories.Interfaces
{
    public interface ICursoRepository
    {
        Task<IEnumerable<Curso>> GetCursosAsync();
        Task<Curso?> GetCursoByIdAsync(int id);
        Task AddCursoAsync(Curso curso);
    }
}