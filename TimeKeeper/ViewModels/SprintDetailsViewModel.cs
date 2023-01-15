using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TimeKeeper.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeKeeper.Data;

namespace TimeKeeper.ViewModels
{
    public partial class SprintDetailsViewModel : ObservableObject
    {
        SprintsDatabase db;

        public SprintDetailsViewModel(SprintsDatabase database)
        {
            tasks = new ObservableCollection<SprintTask>();
            db = database;
        }

        [ObservableProperty]
        string sprintIdentifier;

        [ObservableProperty]
        Guid projectId;

        [ObservableProperty]
        string title;
        [ObservableProperty]
        string objective;
        [ObservableProperty]
        DateTime? startDate;
        [ObservableProperty] 
        DateTime? endDate;
        [ObservableProperty] 
        ObjectStatus status;

        [ObservableProperty]
        ObservableCollection<SprintTask> tasks;


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
