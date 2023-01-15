using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeKeeper.Data;
using TimeKeeper.Models;

namespace TimeKeeper.ViewModels
{
    public partial class SprintTaskDetailsViewModel : ObservableObject
    {
        SprintTasksDatabase db;

        public SprintTaskDetailsViewModel(SprintTasksDatabase database)
        {
            db = database;
        }

        [ObservableProperty]
        string taskIdentifier;

        [ObservableProperty]
        Guid projectId ;
        [ObservableProperty]
        Guid sprintId ;
        [ObservableProperty]
        Models.TaskStatus status ;
        [ObservableProperty]
        string name ;
        [ObservableProperty]
        string description ;
        [ObservableProperty]
        TimeSpan? estimatedTimeTotal ;
        [ObservableProperty]
        TimeSpan? estimatedTimeToCompletion ;
        [ObservableProperty]
        TimeSpan? totalTimeRecorded ;
        [ObservableProperty]
        ObservableCollection<TimeEntry> timeEntries;


        [RelayCommand]
        void Save()
        {

        }

        [RelayCommand]
        async Task Close()
        {
            await Shell.Current.GoToAsync("..");
        }

        [RelayCommand]
        void Delete()
        {

        }

    }
}
