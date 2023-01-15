using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using TimeKeeper.Models;

namespace TimeKeeper.Data
{
    public class SprintsDatabase : TimeKeeperDatabase<Sprint, ObjectStatus>
    {

        public override async Task<int> DeleteAsync(Sprint model)
        {
            await Init();
            return await Database.DeleteAsync(model);
        }

        public override async Task<List<Sprint>> GetAllAsync()
        {
            await Init();
            return await Database.Table<Sprint>().ToListAsync();
        }

        public override async Task<Sprint> GetAsync(int id)
        {
            await Init();
            return await Database.Table<Sprint>()
                .Where(s => s.Id == id)
                .FirstOrDefaultAsync();
        }

        public override async Task<List<Sprint>> GetByStatusAsync(ObjectStatus status)
        {
            await Init();
            return await Database.Table<Sprint>().Where(s => s.Status == status).ToListAsync();
        }

        public override async Task<int> SaveAsync(Sprint model)
        {
            await Init();

            if (model.Id != 0)
                return await Database.UpdateAsync(model);
            else
                return await Database.InsertAsync(model);
        }
    }
}
