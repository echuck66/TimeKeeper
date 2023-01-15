using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeKeeper.Models;

namespace TimeKeeper.Data
{
    public abstract class TimeKeeperDatabase<T,S> where T : class where S : Enum
    {
        public SQLiteAsyncConnection Database;

        public TimeKeeperDatabase()
        {
        }

        public async Task Init()
        {
            if (Database is not null)
                return;

            Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
            var createProjectsTableResult = await Database.CreateTableAsync<Project>();
            var createSprintsTableResult = await Database.CreateTableAsync<Sprint>();
            var createSprintTasksTableResult = await Database.CreateTableAsync<SprintTask>();
            var createTimeEntriesTableResult = await Database.CreateTableAsync<TimeEntry>();
            var createTimeSheetsTableResult = await Database.CreateTableAsync<TimeSheet>();

            //var createProjectSettingsTableResult = await Database.CreateTableAsync<ProjectSettings>();
            //var createUserSettingsTableResult = await Database.CreateTableAsync<UserSettings>();

        }

        public abstract Task<List<T>> GetAllAsync();

        public abstract Task<List<T>> GetByStatusAsync(S status);

        public abstract Task<T> GetAsync(int id);

        public abstract Task<int> SaveAsync(T model);

        public abstract Task<int> DeleteAsync(T model);
    }
}
