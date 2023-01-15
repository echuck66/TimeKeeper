using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeKeeper.Models;

namespace TimeKeeper.Data
{
    public class TimeSheetDatabase : TimeKeeperDatabase<TimeSheet, TimeEntryStatus>
    {
        public override async Task<int> DeleteAsync(TimeSheet model)
        {
            await Init();
            return await Database.DeleteAsync(model);
        }

        public override async Task<List<TimeSheet>> GetAllAsync()
        {
            await Init();
            return await Database.Table<TimeSheet>().ToListAsync();
        }

        public override async Task<TimeSheet> GetAsync(int id)
        {
            await Init();
            return await Database.Table<TimeSheet>().FirstOrDefaultAsync(s => s.Id == id);
        }

        public override async Task<List<TimeSheet>> GetByStatusAsync(TimeEntryStatus status)
        {
            await Init();
            return await Database.Table<TimeSheet>().Where(s => s.Status == status).ToListAsync();
        }

        public override async Task<int> SaveAsync(TimeSheet model)
        {
            await Init();

            if (model.Id != 0)
                return await Database.UpdateAsync(model);
            else
                return await Database.InsertAsync(model);
        }
    }
}
