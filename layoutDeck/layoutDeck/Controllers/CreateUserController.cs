using System;
using layoutDeck.UI;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using layoutDeck.Models;

namespace layoutDeck.Controllers
{
    class CreateUserController
    {
        public Boolean CreateUser(String firstName, String lastName, String email, String password, String passwordRepeat)
        {
            LoginPage loginPage = new LoginPage();
            String errorMessage = "Error with variabels\n";

            if (!RegexName(firstName)) errorMessage += "First name can only contain letters\n"; 
            if (!RegexName(lastName)) errorMessage += "Last name can only contain letters\n"; 
            if (!RegexEmail(email)) errorMessage += "Email is not correct\n";
            if (password.Length < 8) errorMessage += "Password needs to be at least 8 characters long\n";
            if (password != passwordRepeat) errorMessage += "passwords don't match";

            if (RegexName(firstName) && RegexName(lastName) && RegexEmail(email) && password.Length >= 8 && password == passwordRepeat)
            {
                //loginPage.userList.Add(new User(firstName, lastName, email, password));
                loginPage.DisplayAlert("alert", "Bruger oprettet", "ok");
                return true;
            }
            else
            {
                loginPage.DisplayAlert("alert", errorMessage, "ok");
                return false;
            }
        }
        private Boolean RegexName(String name)
        {
            Boolean regex = false;
            regex = Regex.IsMatch(name, @"^[a-zA-Z æøåÆØÅ]+$");
            return regex;
        }
        private Boolean RegexEmail(String name)
        {
            Boolean regex = false;
            regex = Regex.IsMatch(name, @"^[ÆØÅæøåA-Za-z0-9._%+-]+@(?:[ÆØÅæøåA-Za-z0-9-]+\.)+[A-Za-z]{2,6}$");
            return regex;
        }
    }
}
