using TimeKeeper.ViewModels;

namespace TimeKeeper.Pages;

public partial class TimeSheetDetailsPage : ContentPage
{
	public TimeSheetDetailsPage(TimeSheetDetailsViewModel vm)
	{
		InitializeComponent();
		BindingContext= vm;
	}
}