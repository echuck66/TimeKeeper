using TimeKeeper.ViewModels;

namespace TimeKeeper.Pages;

public partial class SprintDetailsPage : ContentPage
{
	public SprintDetailsPage(SprintDetailsViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}