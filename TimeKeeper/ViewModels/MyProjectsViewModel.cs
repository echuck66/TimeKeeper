using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TimeKeeper.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeKeeper.Pages;
using TimeKeeper.Data;

namespace TimeKeeper.ViewModels
{
    public partial class MyProjectsViewModel : ObservableObject
    {
        ProjectsDatabase db;

        public MyProjectsViewModel(ProjectsDatabase database)
        {
            MyProjects = new ObservableCollection<Project>();
            db = database;
        }

        [ObservableProperty]
        string newProjectName;

        [ObservableProperty]
        ObservableCollection<Project> myProjects;

        [RelayCommand]
        async Task AddProject()
        {
            // add new project
            if (string.IsNullOrWhiteSpace(NewProjectName))
                return;

            Project newProj = MyProjects.FirstOrDefault(p => p.Name.ToLower() == NewProjectName.ToLower());

            if (newProj == null)
            {
                newProj = new Project
                {
                    Name = NewProjectName,
                    Status = ObjectStatus.Plannning
                };
                MyProjects.Add(newProj);
                // Save the new project
                await db.SaveAsync(newProj);
                // Navigate to the new project:
                await Shell.Current.GoToAsync($"{nameof(ProjectDetailsPage)}?Id={newProj.Id}");
            }

            newProjectName = string.Empty;
        }

        [RelayCommand]
        async Task OpenProject(Project project)
        {
            if (project == null)
                return;

            await Shell.Current.GoToAsync($"{nameof(ProjectDetailsPage)}?Id={project.Id}");

        }

        [RelayCommand]
        async Task DeleteProject(Project project)
        {
            var deleteCt = await db.DeleteAsync(project);

            if (deleteCt > 0)
            {
                if (MyProjects.Any(p => p.Id == project.Id))
                {
                    MyProjects.Remove(project);
                }
            }
        }

        [RelayCommand]
        async Task Close()
        {
            await Shell.Current.GoToAsync("..");
        }

        public async Task LoadProjects()
        {
            var projects = await db.GetAllAsync();
            MyProjects.Clear();
            foreach(var project in projects)
            {
                MyProjects.Add(project);
            }
        }
    }
}
