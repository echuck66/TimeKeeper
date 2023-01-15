using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TimeKeeper.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using TimeKeeper.Data;
using System.ComponentModel;

namespace TimeKeeper.ViewModels
{
    [QueryProperty("ProjectId", "Id")]
    public partial class ProjectDetailsViewModel : ObservableObject
    {
        ProjectsDatabase db;

        public ProjectDetailsViewModel(ProjectsDatabase database)
        {
            sprints = new ObservableCollection<Sprint>();
            statusValues = new ObservableCollection<ObjectStatusSelector>();
            statusValues.Add(new ObjectStatusSelector { Status = ObjectStatus.Plannning, Description = "Planning" });
            statusValues.Add(new ObjectStatusSelector { Status = ObjectStatus.Open, Description = "Open" });
            statusValues.Add(new ObjectStatusSelector { Status = ObjectStatus.Closed, Description = "Closed" });

            db = database;

        }

        [ObservableProperty]
        Project myProject;

        [ObservableProperty]
        int projectId;

        [ObservableProperty]
        string projectIdentifier;

        [ObservableProperty]
        string projectName;

        [ObservableProperty]
        string newSprintName;

        [ObservableProperty]
        ObjectStatus? status;

        [ObservableProperty]
        ObservableCollection<Sprint> sprints;

        [ObservableProperty]
        ObservableCollection<ObjectStatusSelector> statusValues;

        [ObservableProperty]
        ObjectStatusSelector selectedStatusValue;

        public async Task LoadProjectData()
        {
            if (this.ProjectId != 0)
            {
                var project = await db.GetAsync(this.ProjectId);
                if (project != null)
                {
                    this.ProjectName = project.Name;
                    this.ProjectIdentifier = project.ProjectIdentifier;
                    this.Status = project.Status;

                    this.SelectedStatusValue = StatusValues
                        .Where(v => v.Status == project.Status)
                        .FirstOrDefault();

                    this.MyProject = project;
                }
            }
        }

        [RelayCommand]
        async Task Save()
        {
            MyProject.ProjectIdentifier = this.ProjectIdentifier;
            MyProject.Name = this.ProjectName;
            MyProject.Status = this.SelectedStatusValue.Status;

            await db.SaveAsync(MyProject);
        }

        [RelayCommand]
        async Task Delete()
        {

        }

        [RelayCommand]
        async Task AddSprint()
        {

        }

        [RelayCommand]
        async Task OpenSprint()
        {

        }

        [RelayCommand]
        async Task DeleteSprint()
        {

        }

        [RelayCommand]
        async Task Close()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
