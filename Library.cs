using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EntertainmentManager
{
    public partial class Library : Form
    {
        private IEnumerable<Item> Items;
        private string Username;
        private Item? FocusedItem;
        private Print Print;

        public Library(IEnumerable<Item> items, string username, Print print)
        {
            InitializeComponent();
            Username = username;
            Items = items;
            Print = print;
            LoadData(Items);
        }

        public async void LoadData(IEnumerable<Item>? source)
        {
            if (source == null)
            {
                source = await SQLiteDataAccess.LoadItems(Username);
                if (source == null)
                {
                    Print.SomethingWrong();
                    return;
                }
                Items = source;
            }
            Items = source;
            LibraryGrid.DataSource = source.ToList();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            LoadData(null);
        }

        private void Sort_Click(object sender, EventArgs e)
        {
            // only one ganre, tag
            IEnumerable<Item> filtered = Items;
            if (GenreBox.Text.Length > 0)
            {
                filtered = filtered.Where(i => i.Genre.ToLower().Contains(GenreBox.Text.ToLower()));
            }
            if (TagBox.Text.Length > 0)
            {
                filtered = filtered.Where(i => i.Tags.ToLower().Contains(TagBox.Text.ToLower()));
            }
            if (YearBox.Text.Length > 0)
            {
                filtered = filtered.Where(i => i.Released.ToLower().Contains(YearBox.Text.ToLower()));
            }
            if (TypeBox.Text.Length > 0)
            {
                filtered = filtered.Where(i => i.Type.ToLower().Equals(TypeBox.Text.ToLower()));
            }
            if (!StatusBox.Text.Equals("Default"))
            {
                filtered = filtered.Where(i => i.Status.ToLower().Equals(StatusBox.Text.ToLower()));
            }
            LoadData(filtered);
        }

        private async void LibraryGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (!await Edit(e))
            {
                MessageBox.Show("Invalid edit operation");
            }
        }

        private async Task<bool> Edit(DataGridViewCellEventArgs e)
        {
            if (FocusedItem == null) { return false; }

            Item changed = Items.ElementAt(e.RowIndex);

            if (changed.Title.Length > SQLiteDataAccess.CHARACTER_LIMIT || changed.Type.Length > SQLiteDataAccess.CHARACTER_LIMIT ||
                changed.Released.Length > SQLiteDataAccess.CHARACTER_LIMIT || changed.Runtime.Length > SQLiteDataAccess.CHARACTER_LIMIT ||
                changed.Genre.Length > SQLiteDataAccess.CHARACTER_LIMIT || changed.Tags.Length > SQLiteDataAccess.CHARACTER_LIMIT ||
                changed.Rating.ToString().Length > SQLiteDataAccess.CHARACTER_LIMIT || changed.Progress.ToString().Length > SQLiteDataAccess.CHARACTER_LIMIT ||
                changed.Status.Length > SQLiteDataAccess.CHARACTER_LIMIT)
            {
                return false;
            }

            Item item = new Item(changed);

            if (item.Equals(FocusedItem)) { return true; }

            if (!await SQLiteDataAccess.EditItem(item)) { return false; }

            Print.Clear();
            Print.Info(item);
            return true;
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            if (FocusedItem == null) { return; }

            DialogResult res = MessageBox.Show("Do you want to proceed?", "Confirmation", MessageBoxButtons.YesNo);
            if (res == DialogResult.No) { return; }

            if (!await SQLiteDataAccess.DeleteItem(FocusedItem))
            {
                MessageBox.Show("Could't delete. Please try again."); // TODO
                return;
            }
            LoadData(null);
        }

        private void LibraryGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) { return; } // Header
            if (FocusedItem != null && FocusedItem.Equals(Items.ElementAt(e.RowIndex))) { return; }

            FocusedItem = new Item(Items.ElementAt(e.RowIndex));
            Print.Clear();
            Print.Info(FocusedItem);
            Print.LoadPoster(FocusedItem);
        }

        private void LibraryGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Invalid data type.");
        }
    }
}
