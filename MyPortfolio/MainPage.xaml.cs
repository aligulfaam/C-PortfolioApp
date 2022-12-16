
namespace MyPortfolio;

public partial class MainPage : ContentPage
{


	public MainPage()
	{
		InitializeComponent();
	}

	private void bioPage_Clicked(object sender, EventArgs e)
	{
		Navigation.PushModalAsync(new BioPage());
	}
}

