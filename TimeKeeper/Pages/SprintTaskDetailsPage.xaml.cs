using TimeKeeper.ViewModels;
namespace TimeKeeper.Pages;

public partial class SprintTaskDetailsPage : ContentPage
{
	public SprintTaskDetailsPage(SprintTaskDetailsViewModel vm)
	{
		InitializeComponent();
		BindingContext= vm;
	}
}