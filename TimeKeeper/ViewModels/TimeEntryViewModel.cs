using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeKeeper.Data;

namespace TimeKeeper.ViewModels
{
    public partial class TimeEntryViewModel : ObservableObject
    {
        TimeEntryDatabase db;

        public TimeEntryViewModel(TimeEntryDatabase database)
        {
            db =  database;
        }

        [ObservableProperty]
        string projectName;

        [ObservableProperty]
        string projectIdentifier;

        [ObservableProperty]
        string sprintIdentifier;

        [ObservableProperty]
        string taskIdentifier;

        [ObservableProperty]
        string taskName;
        [ObservableProperty]
        Guid taskId;
        [ObservableProperty]
        Guid timeSheetId;
        [ObservableProperty]
        DateTime? startTime;
        [ObservableProperty]
        DateTime? endTime;
        [ObservableProperty]
        string note;
        [ObservableProperty]
        bool taskCompleted;

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
