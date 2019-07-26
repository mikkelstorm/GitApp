using System;
using System.Collections.Generic;
using System.Text;

namespace layoutDeck.Models
{
    public class User
    {
        private String firstName;
        private String lastName;
        private String email;
        private String password;
        public User(String firstName, String lastName, String email, String password)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.password = password;
        }
        public String FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public String LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public String Email
        {
            get { return email; }
            set { email = value; }
        }
        public String Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
