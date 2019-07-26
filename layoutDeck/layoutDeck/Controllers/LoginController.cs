using System;
using layoutDeck.UI;
using System.Collections.Generic;
using System.Text;

namespace layoutDeck.Controllers
{
    class LoginController
    {
        public Boolean VerifyAccount(String email, String password)
        {
            Boolean verified = false;

            {
                if(email == "admin" && password == "admin") verified = true;
            }

            return verified;
        }
    }
}
