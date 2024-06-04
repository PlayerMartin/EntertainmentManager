using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntertainmentManager
{
    public class User
    {
        public string Username { get; } 
        public string Password { get; }

        public User(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }
    }
}
