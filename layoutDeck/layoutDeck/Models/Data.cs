using System;
using System.Collections.Generic;
using System.Text;
using layoutDeck.UI;

namespace layoutDeck.Models
{
    class Data
    {

        public IList<User> MakeUsers()
        {
            IList<User> list = new List<User>();
            list.Add(new User("user1", "last1", "user1@mail.com", "kode1234"));
            list.Add(new User("user2", "last2", "user2@mail.com", "kode1234"));
            list.Add(new User("user3", "last3", "user3@mail.com", "kode1234"));
            list.Add(new User("user4", "last4", "user4@mail.com", "kode1234"));
            list.Add(new User("user5", "last5", "user5@mail.com", "kode1234"));
            list.Add(new User("user6", "last6", "user6@mail.com", "kode1234"));
            list.Add(new User("user7", "last7", "user7@mail.com", "kode1234"));
            list.Add(new User("user8", "last8", "user8@mail.com", "kode1234"));

            return list;
        }
    }
}
