using TimeKeeper.ViewModels;

namespace TimeKeeper.Pages;

public partial class TimeSheetsPage : ContentPage
{
	public TimeSheetsPage(TimeSheetsViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}