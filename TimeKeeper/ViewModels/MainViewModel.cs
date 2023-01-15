using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.ComponentModel;
using TimeKeeper.Models;
using TimeKeeper.Pages;

namespace TimeKeeper.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        public MainViewModel()
        {

        }

        [RelayCommand]
        async Task GoToProjects()
        {
            await Shell.Current.GoToAsync($"{nameof(MyProjectsPage)}");
        }

        [RelayCommand]
        async Task GoToTimeEntry()
        {
            await Shell.Current.GoToAsync($"{nameof(TimeEntryPage)}");
        }

        [RelayCommand]
        async Task GoToTimeSheets()
        {
            await Shell.Current.GoToAsync($"{nameof(TimeSheetsPage)}");
        }
    }
}
