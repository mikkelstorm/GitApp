using System;
using System.Collections.Generic;
using layoutDeck.Controllers;
using layoutDeck.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace layoutDeck.UI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked_CreateAccount(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new CreateAccountPage());
        }
        private void Button_Clicked_SignIn(object sender, EventArgs e)
        {
            LoginController loginController = new LoginController();

            Boolean verify = loginController.VerifyAccount(entryEmail.Text, entryPassword.Text);
            if (verify) Navigation.PushModalAsync(new MainPage());
            else DisplayAlert("Alert", "Username or password is wrong", "OK");
        }

        
        private void Button_Clicked_MakeUsers(object sender, EventArgs e)
        {
            
        }
    }
}