using TimeKeeper.Pages;

namespace TimeKeeper;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(MyProjectsPage), typeof(MyProjectsPage));
		Routing.RegisterRoute(nameof(ProjectDetailsPage), typeof(ProjectDetailsPage));
		Routing.RegisterRoute(nameof(SprintDetailsPage), typeof(SprintDetailsPage));
		Routing.RegisterRoute(nameof(SprintTaskDetailsPage), typeof(SprintTaskDetailsPage));
		Routing.RegisterRoute(nameof(TimeEntryPage), typeof(TimeEntryPage));
		Routing.RegisterRoute(nameof(TimeSheetDetailsPage), typeof(TimeSheetDetailsPage));	
		Routing.RegisterRoute(nameof(TimeSheetsPage), typeof(TimeSheetsPage));

	}
}
