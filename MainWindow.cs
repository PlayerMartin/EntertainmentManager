using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.Json;
using System.ComponentModel.DataAnnotations;
using EntertainmentManager.JsonManagers;


namespace EntertainmentManager
{
    public partial class MainWindow : Form
    {
        private string Username = "";
        private Print Print;
        private Item? CurrItem;

        public MainWindow()
        {
            InitializeComponent();
            Authenticate();
            Print = new Print(InfoBox, ThumbnailPicture);
            this.BringToFront();
        }

        private void LoadUserData()
        {
            ViewProfileButton.Text = Username;
        }

        private void Authenticate()
        {
            Auth auth = new Auth();
            auth.ShowDialog();
            if (!auth.Authenticated)
            {
                this.Close();
                return;
            }
            Username = auth.Username;
            this.Show();
            LoadUserData();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            Clear();
            this.Hide();
            Authenticate();
        }

        /// <summary>
        /// Cleaning up after logout.
        /// </summary>
        private void Clear()
        {
            Username = "";
            InfoBox.Text = string.Empty;
            ThumbnailPicture.Image = null;
            SearchBox.Text = string.Empty;
            TypeBox.Text = string.Empty;
            ReleaseYearBox.Text = string.Empty;
            CurrItem = null;
            OwnedForms.ToList().ForEach(f => f.Close());
        }

        /// <summary>
        /// Requests item from online database based on users input.
        /// Displays the image and info.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void SearchButton_Click(object sender, EventArgs e)
        {
            Print.Clear(true);
            CurrItem = await APIDataAcess.RequestItem(SearchBox.Text, TypeBox.Text, ReleaseYearBox.Text);
            if (CurrItem == null)
            {
                Print.NotFound();
            }
            else
            {
                Print.Info(CurrItem);
                Print.LoadPoster(CurrItem);
                CurrItem.Owner = Username;
            }
        }

        /// <summary>
        /// Adds the latest searched for item to the library.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void AddButton_Click(object sender, EventArgs e)
        {
            //if (CurrItem == null)
            //{
            //    // Open new window and select stuff
            //    return;
            //}
            if (CurrItem != null && !await SQLiteDataAccess.SaveItem(CurrItem))
            {
                Print.ItemAlreadyInLibrary();
            }

            // Update all open libraries
            OwnedForms.ToList().ForEach(l =>
            {
                if (l.GetType() == typeof(Library))
                {
                    ((Library)l).LoadData(null);
                }
            });
        }

        /// <summary>
        /// Opens a new library window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ShowLibraryButton_Click(object sender, EventArgs e)
        {
            IEnumerable<Item>? items = await SQLiteDataAccess.LoadItems(Username);
            if (items == null)
            {
                Print.Error("Couldn't load data");
                return;
            }
            Library lib = new Library(items, Username, Print);
            lib.Location = new Point(this.Location.X + this.Width, this.Location.Y);
            lib.Owner = this;
            lib.Show();
        }

        /// <summary>
        /// Shows statistics about users library.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void StatisticsButton_Click(object sender, EventArgs e)
        {
            IEnumerable<Item>? items = await SQLiteDataAccess.LoadItems(Username);
            if (items == null)
            {
                Print.Error("Couldn't load data");
                return;
            }
            Print.Statistics(new Statistics(items));
        }

        /// <summary>
        /// Exports data to UserData/username.json
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ExportButton_Click(object sender, EventArgs e)
        {
            Export export = new Export(Environment.CurrentDirectory, Username);
            IEnumerable<Item>? items = await SQLiteDataAccess.LoadItems(Username);
            if (items == null) 
            { 
                MessageBox.Show("Data couldn't be loaded.");
                return;
            } 

            if (!export.Serialize(items))
            {
                MessageBox.Show("Export failed.");
                return;
            }
            MessageBox.Show($"Data saved to UserData folder");
        }

        /// <summary>
        /// Imports data from UserData/username.json
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ImportButton_Click(object sender, EventArgs e)
        {
            Import import = new Import(Environment.CurrentDirectory, Username);
            List<Item>? items = await import.Deserialize();
            if (items == null)
            {
                MessageBox.Show("Import failed.");
                return;
            }

            items.ForEach(i => i.Owner = Username);

            if (!await SQLiteDataAccess.SaveItem(items, Username, true))
            {
                MessageBox.Show("Saving data failed.");
                return;
            }

            MessageBox.Show("Import successful!");
        }
    }
}
