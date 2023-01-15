using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeKeeper.Models;
using SQLite;

namespace TimeKeeper.Data
{
    public class ProjectsDatabase : TimeKeeperDatabase<Project, ObjectStatus>
    {
        

        public override async Task<int> DeleteAsync(Project model)
        {
            await Init();
            return 0; // await Database.DeleteAsync(model);
        }

        public override async Task<List<Project>> GetAllAsync()
        {
            await Init();
            return await Database.Table<Project>().ToListAsync();
        }

        public override async Task<Project> GetAsync(int id)
        {
            await Init();
            return await Database.Table<Project>().FirstOrDefaultAsync(p => p.Id == id);
        }

        public override async Task<List<Project>> GetByStatusAsync(ObjectStatus status)
        {
            await Init();
            return await Database.Table<Project>().Where(p => p.Status == status).ToListAsync();
        }

        public override async Task<int> SaveAsync(Project model)
        {
            await Init();
            var updateCt = 0;
            if (model.Id != 0)
                updateCt =  await Database.UpdateAsync(model);
            else
                updateCt = await Database.InsertAsync(model);

            return updateCt;
        }
    }
}
