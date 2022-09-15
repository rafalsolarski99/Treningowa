namespace Aplikacjatreningowa.Strony;

public partial class Startowa : ContentPage
{
	public Startowa()
	{
		InitializeComponent();
	}

	public void OnButtonClicked(object sender, EventArgs args)
	{
		App.Current.MainPage = new NavigationPage(new Strony.Glowna());
	}
}