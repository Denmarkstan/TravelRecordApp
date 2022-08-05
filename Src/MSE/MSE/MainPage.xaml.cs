namespace MSE;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}
    //https://github.com/eincioch/xamarin-forms-goodlooking-UI-2020       to pick a certain ready-made ui you want to implement
    //https://github.com/Amaro96/MbongoUIApp    current
    private async void OnGetStartedClicked(object sender, EventArgs e)
	{
        //stkWelcome.IsVisible=false;
        //      stkRegistration.IsVisible = true;
        await Navigation.PushAsync(new RegistrationPage());
    }
}

