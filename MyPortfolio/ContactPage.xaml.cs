namespace MyPortfolio;

public partial class ContactPage : ContentPage
{
	public ContactPage()
	{
		InitializeComponent();
	}

	private void BtnPrevious_Clicked(object sender, EventArgs e)
	{
		Navigation.PopModalAsync();
	}
}