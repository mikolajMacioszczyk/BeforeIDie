using System.Collections.Generic;
using System.Threading.Tasks;
using BeforeIDie.Models;

namespace BeforeIDie.Db.Repository
{
    public interface IGoalRepository
    {
        Task<IEnumerable<Goal>> GetAllAsync();
        Task<IEnumerable<Goal>> GetPlannedAsync();
        Task<IEnumerable<Goal>> GetRealizedAsync();
        Task<Goal> GetByIdAsync(int id);
        Task<Goal> GetRealizedByIdAsync(int id);
        Task<bool> CreateAsync(Goal created);
        Task<bool> UpdateAsync(int id, Goal updated);
        Task<bool> UpdateRealizedAsync(int id, Goal updated);
        Task<bool> DeleteAsync(int id);
        Task SaveChangesAsync();
    }
}