using System.Net;
using TimeKeeper.ViewModels;

namespace TimeKeeper.Pages;

public partial class ProjectDetailsPage : ContentPage
{
    ProjectDetailsViewModel viewmodel;

	public ProjectDetailsPage(ProjectDetailsViewModel vm)
	{
		InitializeComponent();
        viewmodel= vm;
        BindingContext = viewmodel;
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
        Task.Run(() => viewmodel.LoadProjectData());
    }
}