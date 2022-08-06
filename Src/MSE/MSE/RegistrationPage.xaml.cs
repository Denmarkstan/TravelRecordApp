namespace MSE;

public partial class RegistrationPage : ContentPage
{

    public RegistrationPage()
	{
		InitializeComponent();
	}

    

    
    private async void OnRegisterClicked(object sender, EventArgs e)
    {
        stkShowIndicator.IsVisible = true;
        btnGetStarted.IsVisible=false;
        //await Navigation.PushAsync(new RegistrationPage());
    }
}