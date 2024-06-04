using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EntertainmentManager
{
    public class Print
    {
        private TextBox Box;
        private PictureBox? PictureBox;

        public Print(TextBox box)
        {
            Box = box;
        }

        public Print(TextBox box, PictureBox pictureBox) : this(box)
        {
            PictureBox = pictureBox;
        }

        public void CouldntLoadImage()
        {
            Box.Text += "Couldn't load image" + Environment.NewLine;
        }

        public void ErrorWStatusCode(HttpStatusCode code)
        {
            Box.Text = "Error: Request failed with status code " + code + Environment.NewLine;
        }

        public void Error(string message)
        {
            Box.Text = "Error: " + message + Environment.NewLine;
        }

        public void Info(Item item)
        {
            Box.Text += item.ToString();
        }

        public void ItemAlreadyInLibrary()
        {
            Box.Text += "Item already in library." + Environment.NewLine;
        }

        public void FieldsCannotEmpty()
        {
            Box.Text = "Fields cannot be left empty." + Environment.NewLine;
        }

        public void PasswordsNotMatch()
        {
            Box.Text = "Passwords do not match." + Environment.NewLine;
        }

        public void InvalidCredentials()
        {
            Box.Text = "Provided credentials are invalid." + Environment.NewLine;
        }

        public void SomethingWrong()
        {
            Box.Text = "Something went wrong. Please try again." + Environment.NewLine;
        }

        public void UsernameTaken()
        {
            Box.Text = "Username is taken." + Environment.NewLine;
        }

        public void UsernameWhitespace()
        {
            Box.Text = "Username cannot contain whitespaces." + Environment.NewLine;
        }

        public void NotFound()
        {
            Box.Text = "Did not find what you are looking for." + Environment.NewLine;
        }

        public void Statistics(Statistics s)
        {
            if (s.ItemCount() == 0)
            {
                Box.Text = "No items in library";
                return;
            }
            StringBuilder sb = new StringBuilder();
            sb.Append($"Items in library: {s.ItemCount()}");
            sb.Append( Environment.NewLine );
            sb.Append($"Average rating: {s.AverageRating()}");
            sb.Append( Environment.NewLine );
            sb.Append($"The most common genre: {s.MostCommonGenre()}");
            sb.Append(Environment.NewLine);
            Box.Text = sb.ToString();
        }

        public void Clear(bool clearPicture = false)
        {
            Box.Text = "";
            if (PictureBox != null && clearPicture)
            {
                PictureBox.Image = null;
            }
        }

        public async void LoadPoster(Item item)
        {
            if (PictureBox == null) { return; }

            try
            {
                using (HttpClient client = new HttpClient())
                using (HttpResponseMessage response = await client.GetAsync(item.Poster))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        // Read the image as a stream
                        using (var stream = await response.Content.ReadAsStreamAsync())
                        {
                            PictureBox.Image = new Bitmap(stream);
                        }
                    }
                    else
                    {
                        PictureBox.Image = null;
                        CouldntLoadImage();
                    }
                }
            }
            catch (Exception)
            {
                PictureBox.Image = null;
                CouldntLoadImage();
            }
        }
    }
}
