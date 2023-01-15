using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using TimeKeeper.Models;

namespace TimeKeeper.Data
{
    public class TimeEntryDatabase : TimeKeeperDatabase<TimeEntry, TimeEntryStatus>
    {
        public override async Task<int> DeleteAsync(TimeEntry model)
        {
            await Init();
            return await Database.DeleteAsync(model);
        }

        public override async Task<List<TimeEntry>> GetAllAsync()
        {
            await Init();
            return await Database.Table<TimeEntry>().ToListAsync();
        }

        public override async Task<TimeEntry> GetAsync(int id)
        {
            await Init();
            return await Database.Table<TimeEntry>().FirstOrDefaultAsync(s => s.Id == id);
        }

        public override async Task<List<TimeEntry>> GetByStatusAsync(TimeEntryStatus status)
        {
            await Init();
            return await Database.Table<TimeEntry>().Where(s => s.Status == status).ToListAsync();
        }

        public override async Task<int> SaveAsync(TimeEntry model)
        {
            await Init();

            if (model.Id != 0)
                return await Database.UpdateAsync(model);
            else
                return await Database.InsertAsync(model);
        }
    }
}
