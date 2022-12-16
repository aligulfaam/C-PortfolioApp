using System.Windows.Input;

namespace MyPortfolio;

public partial class GITHUB : ContentPage
{
    public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
    public GITHUB()
	{
		InitializeComponent(); 
		BindingContext = this;
    }

	private void BtncontactPage_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new ContactPage());
    }

	private void BtnPrevious_Clicked(object sender, EventArgs e)
	{
		Navigation.PopModalAsync();

	}

}