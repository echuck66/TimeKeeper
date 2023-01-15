using TimeKeeper.Data;
using TimeKeeper.Pages;
using TimeKeeper.ViewModels;

namespace TimeKeeper;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddSingleton<MainPage>();
		builder.Services.AddSingleton<MainViewModel>();

		builder.Services.AddTransient<MyProjectsPage>();
		builder.Services.AddTransient<MyProjectsViewModel>();

		builder.Services.AddTransient<ProjectDetailsPage>();
		builder.Services.AddTransient<ProjectDetailsViewModel>();

		builder.Services.AddTransient<SprintDetailsPage>();
		builder.Services.AddTransient<SprintDetailsViewModel>();

		builder.Services.AddTransient<TimeEntryPage>();
		builder.Services.AddTransient<TimeEntryViewModel>();

		builder.Services.AddTransient<TimeSheetsPage>();
		builder.Services.AddTransient<TimeSheetsViewModel>();

		builder.Services.AddTransient<TimeSheetDetailsPage>();
		builder.Services.AddTransient<TimeSheetDetailsViewModel>();

        builder.Services.AddTransient<SprintTaskDetailsPage>();
        builder.Services.AddTransient<SprintTaskDetailsViewModel>();

		builder.Services.AddTransient<ProjectsDatabase>();
		builder.Services.AddTransient<SprintsDatabase>();
		builder.Services.AddTransient<SprintTasksDatabase>();
		builder.Services.AddTransient<TimeEntryDatabase>();
		builder.Services.AddTransient<TimeSheetDatabase>();


        return builder.Build();
	}
}
