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
    public partial class TimeSheetsViewModel : ObservableObject
    {
        TimeSheetDatabase db;

        public TimeSheetsViewModel(TimeSheetDatabase database)
        {
            db = database;
        }


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
