using Gerocery.ViewModels;

namespace Gerocery;

public partial class Login : ContentPage
{
    LoginViewModel _login;
	public Login(LoginViewModel loginpage)
	{
        _login = loginpage;
        this.BindingContext = loginpage;
		InitializeComponent();
		
		
	}

    //private async void Button_Clicked(object sender, EventArgs e)
    //{
    //    if (string.IsNullOrEmpty(name.Text))
        
    //        DisplayAlert("Error", "Please enter email", "cancel");

    //   else if (string.IsNullOrEmpty(password.Text))

    //        DisplayAlert("Error", "Please enter password", "cancel");

    //    else

    //  await  Navigation.PushAsync(new Page1());
    //}
}