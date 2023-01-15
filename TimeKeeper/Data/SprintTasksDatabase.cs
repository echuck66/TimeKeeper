using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using TimeKeeper.Models;

namespace TimeKeeper.Data
{
    public class SprintTasksDatabase : TimeKeeperDatabase<SprintTask, Models.TaskStatus>
    {
        public override async Task<int> DeleteAsync(SprintTask model)
        {
            await Init();
            return await Database.DeleteAsync(model);
        }

        public override async Task<List<SprintTask>> GetAllAsync()
        {
            await Init();
            return await Database.Table<SprintTask>().ToListAsync();
        }

        public override async Task<SprintTask> GetAsync(int id)
        {
            await Init();
            return await Database.Table<SprintTask>()
                .Where(s => s.Id == id)
                .FirstOrDefaultAsync();
        }

        public override async Task<List<SprintTask>> GetByStatusAsync(Models.TaskStatus status)
        {
            await Init();
            return await Database.Table<SprintTask>()
                .Where(s => s.Status == status)
                .ToListAsync();
        }

        public override async Task<int> SaveAsync(SprintTask model)
        {
            await Init();

            if (model.Id != 0)
                return await Database.UpdateAsync(model);
            else
                return await Database.InsertAsync(model);
        }
    }
}
