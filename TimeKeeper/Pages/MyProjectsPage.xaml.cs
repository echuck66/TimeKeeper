using TimeKeeper.ViewModels;

namespace TimeKeeper.Pages;

public partial class MyProjectsPage : ContentPage
{
    MyProjectsViewModel viewmodel;

	public MyProjectsPage(MyProjectsViewModel vm)
	{
		InitializeComponent();
        viewmodel = vm;
        BindingContext = viewmodel;
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
        Task.Run(() => viewmodel.LoadProjects());
    }
}