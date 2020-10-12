using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeforeIDie.Models;
using Microsoft.EntityFrameworkCore;

namespace BeforeIDie.Db.Repository
{
    public class GoalPlannedRepository : IGoalRepository
    {
        private readonly Context _db;
    
        public GoalPlannedRepository(Context db)
        {
            _db = db;
        }
    
        public async Task<IEnumerable<Goal>> GetAllAsync()
        {
            return await _db.GoalItems.Where(g => g.Status == Status.Planned).ToListAsync();
        }

        public async Task<Goal> GetByIdAsync(int id)
        {
            return await _db.GoalItems.Where(g => g.Status == Status.Planned).FirstOrDefaultAsync(g => g.Id == id);
        }

        public async Task<bool> CreateAsync(Goal created)
        {
            await _db.AddAsync(created);
            return true;
        }

        public async Task<bool> UpdateAsync(int id, Goal updated)
        {
            var fromDb = await _db.GoalItems.Where(g => g.Status == Status.Planned).FirstOrDefaultAsync(g => g.Id == id);
            if (fromDb == null) { return false; }

            Update(fromDb, updated);
            return true;
        }

        public async Task<bool> ChangeStatusAsync(int id, Status status)
        {
            var fromDb = await GetByIdAsync(id);
            if (fromDb == null) { return false; }

            fromDb.Status = status;
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var fromDb = await _db.GoalItems.Where(g => g.Status == Status.Planned).FirstOrDefaultAsync(g => g.Id == id);
            if (fromDb == null) { return false; }

            _db.GoalItems.Remove(fromDb);
            return true;
        }

        public async Task SaveChangesAsync()
        {
            await _db.SaveChangesAsync();
        }
        
        private void Update(Goal original, Goal updated)
        {
            original.Description = updated.Description;
            original.Localization = updated.Localization;
            original.Title = updated.Title;
            original.ImgUrl = updated.ImgUrl;
        }
    }
}