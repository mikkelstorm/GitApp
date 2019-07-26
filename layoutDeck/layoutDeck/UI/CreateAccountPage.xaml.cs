using System;
using layoutDeck.Controllers;
using layoutDeck.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace layoutDeck.UI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateAccountPage : ContentPage
    {
        public CreateAccountPage()
        {
            InitializeComponent();
        }

        public void Button_Clicked_SignUp(object sender, EventArgs e)
        {
            CreateUserController createUser = new CreateUserController();
            LoginPage loginPage = new LoginPage();
            Boolean signUpBool = false;
            signUpBool = createUser.CreateUser(entryFirstName.Text, entryLastName.Text, entryEmail.Text, entryPassword.Text, entryPasswordRepeat.Text);

            if (signUpBool) Navigation.PushModalAsync(new LoginPage());
        }
    }
}