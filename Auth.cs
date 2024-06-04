using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntertainmentManager
{
    public partial class Auth : Form
    {
        private const string SALT = "GetEntertained";
        public bool Authenticated { get; private set; } = false;
        public string Username { get; private set; } = "";
        private Print Print;

        public Auth()
        {
            InitializeComponent();
            Print = new Print(ErrorBox);
        }

        private User? GetUser(bool register)
        {
            Print.Clear();
            if (PasswordBox.Text.Length == 0 || UsernameBox.Text.Length == 0)
            {
                Print.FieldsCannotEmpty();
                return null;
            }

            if (UsernameBox.Text.Any(char.IsWhiteSpace)) 
            {
                Print.UsernameWhitespace();
                return null;
            }

            if (register && PasswordBox.Text != PasswordAgainBox.Text)
            {
                Print.PasswordsNotMatch();
                return null;
            }

            return new User(UsernameBox.Text, HashString(SALT + PasswordBox.Text));
        }

        private static string HashString(string input)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] hashBytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            User? user = GetUser(false);
            if (user == null) { return; }
            
            if (await Login(user))
            {
                Authenticated = true;
                Username = user.Username;
                this.Close();
            } else
            {
                Print.InvalidCredentials();
            }
        }

        private async Task<bool> Login(User user)
        {
            if (await SQLiteDataAccess.LoadUser(user) == null)
            {
                Print.SomethingWrong();
                return false;
            }
            return true;
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (!PasswordAgainBox.Enabled)
            {
                PasswordAgainBox.Enabled = true;
                PasswordAgainBox.Visible = true;
                LoginButton.Enabled = false;
                LoginButton.Visible = false;
                return;
            }

            User? user = GetUser(true);
            if (user == null) { return; }
            if (Register(user))
            {
                Authenticated = true;
                Username = user.Username;
                this.Close();
            }
        }

        private bool Register(User user)
        {
            Result r = SQLiteDataAccess.SaveUser(user);
            if (r.Equals(Result.FAILURE))
            {
                Print.SomethingWrong();
                return false;
            } else if (r.Equals(Result.NOT_UNIQUE))
            {
                Print.UsernameTaken();
                return false;
            }
            return true;
        }
    }
}
