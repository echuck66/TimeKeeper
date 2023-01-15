using TimeKeeper.ViewModels;

namespace TimeKeeper.Pages;

public partial class TimeEntryPage : ContentPage
{
	public TimeEntryPage(TimeEntryViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}