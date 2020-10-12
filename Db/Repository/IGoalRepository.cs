using System.Collections.Generic;
using System.Threading.Tasks;
using BeforeIDie.Models;

namespace BeforeIDie.Db.Repository
{
    public interface IGoalRepository
    {
        Task<IEnumerable<Goal>> GetAllAsync();
        Task<Goal> GetByIdAsync(int id);
        Task<bool> CreateAsync(Goal created);
        Task<bool> UpdateAsync(int id, Goal updated);
        Task<bool> ChangeStatusAsync(int id, Status status);
        Task<bool> DeleteAsync(int id);
        Task SaveChangesAsync();
    }
}