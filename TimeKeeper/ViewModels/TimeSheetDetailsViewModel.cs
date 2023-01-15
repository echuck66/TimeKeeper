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
    public partial class TimeSheetDetailsViewModel : ObservableObject
    {
        TimeSheetDatabase db;

        public TimeSheetDetailsViewModel(TimeSheetDatabase database) 
        {
            timeEntries = new ObservableCollection<TimeEntry>();
            db = database;
        }

        [ObservableProperty]
        string sprintIdentifier;

        [ObservableProperty]
        string projectIdentifier;

        [ObservableProperty]
        Guid projectId;
        [ObservableProperty]
        Guid sprintId;
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
