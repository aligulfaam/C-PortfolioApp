namespace MyPortfolio;

public partial class BioPage : ContentPage
{
	public BioPage()
	{
		InitializeComponent();
	}

	private void BtngitHub_Clicked(object sender, EventArgs e)
	{
        Navigation.PushModalAsync(new GITHUB());
    }

	private void BtnPrevious_Clicked(object sender, EventArgs e)
	{
		Navigation.PopModalAsync();
	}
}