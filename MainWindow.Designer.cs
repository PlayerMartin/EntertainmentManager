namespace EntertainmentManager
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            ThumbnailPicture = new PictureBox();
            SearchBox = new TextBox();
            ReleaseYearBox = new TextBox();
            TypeBox = new TextBox();
            SearchButton = new Button();
            InfoBox = new TextBox();
            AddButton = new Button();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            ImportButton = new ToolStripMenuItem();
            ExportButton = new ToolStripMenuItem();
            LogOutButton = new ToolStripMenuItem();
            libraryToolStripMenuItem = new ToolStripMenuItem();
            ShowLibraryButton = new ToolStripMenuItem();
            profileToolStripMenuItem = new ToolStripMenuItem();
            ViewProfileButton = new ToolStripMenuItem();
            StatisticsButton = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            gettingStartedToolStripMenuItem = new ToolStripMenuItem();
            possibleTypesToolStripMenuItem = new ToolStripMenuItem();
            roadmapToolStripMenuItem = new ToolStripMenuItem();
            aboutEntertainmentManagerToolStripMenuItem = new ToolStripMenuItem();
            aboutEntertainmentManagerToolStripMenuItem1 = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)ThumbnailPicture).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // ThumbnailPicture
            // 
            ThumbnailPicture.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ThumbnailPicture.BackColor = SystemColors.GradientInactiveCaption;
            ThumbnailPicture.ErrorImage = (Image)resources.GetObject("ThumbnailPicture.ErrorImage");
            ThumbnailPicture.Location = new Point(12, 36);
            ThumbnailPicture.Name = "ThumbnailPicture";
            ThumbnailPicture.Size = new Size(361, 520);
            ThumbnailPicture.SizeMode = PictureBoxSizeMode.Zoom;
            ThumbnailPicture.TabIndex = 1;
            ThumbnailPicture.TabStop = false;
            // 
            // SearchBox
            // 
            SearchBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SearchBox.Location = new Point(12, 570);
            SearchBox.Name = "SearchBox";
            SearchBox.PlaceholderText = "Name";
            SearchBox.Size = new Size(295, 31);
            SearchBox.TabIndex = 2;
            // 
            // ReleaseYearBox
            // 
            ReleaseYearBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ReleaseYearBox.Location = new Point(313, 570);
            ReleaseYearBox.Name = "ReleaseYearBox";
            ReleaseYearBox.PlaceholderText = "Year";
            ReleaseYearBox.Size = new Size(106, 31);
            ReleaseYearBox.TabIndex = 3;
            // 
            // TypeBox
            // 
            TypeBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            TypeBox.Location = new Point(425, 570);
            TypeBox.Name = "TypeBox";
            TypeBox.PlaceholderText = "Type";
            TypeBox.Size = new Size(127, 31);
            TypeBox.TabIndex = 4;
            // 
            // SearchButton
            // 
            SearchButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SearchButton.Location = new Point(12, 607);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(407, 43);
            SearchButton.TabIndex = 5;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // InfoBox
            // 
            InfoBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            InfoBox.BackColor = SystemColors.ActiveCaption;
            InfoBox.BorderStyle = BorderStyle.None;
            InfoBox.ImeMode = ImeMode.NoControl;
            InfoBox.Location = new Point(379, 36);
            InfoBox.Multiline = true;
            InfoBox.Name = "InfoBox";
            InfoBox.PlaceholderText = "Info";
            InfoBox.ReadOnly = true;
            InfoBox.Size = new Size(173, 520);
            InfoBox.TabIndex = 6;
            InfoBox.TabStop = false;
            InfoBox.TextAlign = HorizontalAlignment.Center;
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddButton.Location = new Point(425, 607);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(127, 43);
            AddButton.TabIndex = 9;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, libraryToolStripMenuItem, profileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(578, 33);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { ImportButton, ExportButton, LogOutButton });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(92, 29);
            toolStripMenuItem1.Text = "Settings";
            // 
            // ImportButton
            // 
            ImportButton.Name = "ImportButton";
            ImportButton.Size = new Size(270, 34);
            ImportButton.Text = "Import";
            ImportButton.Click += ImportButton_Click;
            // 
            // ExportButton
            // 
            ExportButton.Name = "ExportButton";
            ExportButton.Size = new Size(270, 34);
            ExportButton.Text = "Export";
            ExportButton.Click += ExportButton_Click;
            // 
            // LogOutButton
            // 
            LogOutButton.Name = "LogOutButton";
            LogOutButton.Size = new Size(270, 34);
            LogOutButton.Text = "Log Out";
            LogOutButton.Click += LogOutButton_Click;
            // 
            // libraryToolStripMenuItem
            // 
            libraryToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ShowLibraryButton });
            libraryToolStripMenuItem.Name = "libraryToolStripMenuItem";
            libraryToolStripMenuItem.Size = new Size(81, 29);
            libraryToolStripMenuItem.Text = "Library";
            // 
            // ShowLibraryButton
            // 
            ShowLibraryButton.Name = "ShowLibraryButton";
            ShowLibraryButton.Size = new Size(216, 34);
            ShowLibraryButton.Text = "Show Library";
            ShowLibraryButton.Click += ShowLibraryButton_Click;
            // 
            // profileToolStripMenuItem
            // 
            profileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ViewProfileButton, StatisticsButton });
            profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            profileToolStripMenuItem.Size = new Size(78, 29);
            profileToolStripMenuItem.Text = "Profile";
            // 
            // ViewProfileButton
            // 
            ViewProfileButton.Name = "ViewProfileButton";
            ViewProfileButton.Size = new Size(211, 34);
            ViewProfileButton.Text = "ProfileName";
            // 
            // StatisticsButton
            // 
            StatisticsButton.Name = "StatisticsButton";
            StatisticsButton.Size = new Size(211, 34);
            StatisticsButton.Text = "Statistics";
            StatisticsButton.Click += StatisticsButton_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gettingStartedToolStripMenuItem, possibleTypesToolStripMenuItem, roadmapToolStripMenuItem, aboutEntertainmentManagerToolStripMenuItem, aboutEntertainmentManagerToolStripMenuItem1 });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(65, 29);
            helpToolStripMenuItem.Text = "Help";
            // 
            // gettingStartedToolStripMenuItem
            // 
            gettingStartedToolStripMenuItem.Name = "gettingStartedToolStripMenuItem";
            gettingStartedToolStripMenuItem.Size = new Size(349, 34);
            gettingStartedToolStripMenuItem.Text = "Getting Started";
            // 
            // possibleTypesToolStripMenuItem
            // 
            possibleTypesToolStripMenuItem.Name = "possibleTypesToolStripMenuItem";
            possibleTypesToolStripMenuItem.Size = new Size(349, 34);
            possibleTypesToolStripMenuItem.Text = "Possible Types";
            // 
            // roadmapToolStripMenuItem
            // 
            roadmapToolStripMenuItem.Name = "roadmapToolStripMenuItem";
            roadmapToolStripMenuItem.Size = new Size(349, 34);
            roadmapToolStripMenuItem.Text = "Roadmap";
            // 
            // aboutEntertainmentManagerToolStripMenuItem
            // 
            aboutEntertainmentManagerToolStripMenuItem.Name = "aboutEntertainmentManagerToolStripMenuItem";
            aboutEntertainmentManagerToolStripMenuItem.Size = new Size(349, 34);
            aboutEntertainmentManagerToolStripMenuItem.Text = "Privacy Policy";
            // 
            // aboutEntertainmentManagerToolStripMenuItem1
            // 
            aboutEntertainmentManagerToolStripMenuItem1.Name = "aboutEntertainmentManagerToolStripMenuItem1";
            aboutEntertainmentManagerToolStripMenuItem1.Size = new Size(349, 34);
            aboutEntertainmentManagerToolStripMenuItem1.Text = "About EntertainmentManager";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(578, 662);
            Controls.Add(AddButton);
            Controls.Add(InfoBox);
            Controls.Add(SearchButton);
            Controls.Add(TypeBox);
            Controls.Add(ReleaseYearBox);
            Controls.Add(SearchBox);
            Controls.Add(ThumbnailPicture);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(600, 718);
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EntertainmentManager";
            ((System.ComponentModel.ISupportInitialize)ThumbnailPicture).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox ThumbnailPicture;
        private TextBox SearchBox;
        private TextBox ReleaseYearBox;
        private TextBox TypeBox;
        private Button SearchButton;
        private TextBox InfoBox;
        private Button AddButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem ImportButton;
        private ToolStripMenuItem ExportButton;
        private ToolStripMenuItem libraryToolStripMenuItem;
        private ToolStripMenuItem profileToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem gettingStartedToolStripMenuItem;
        private ToolStripMenuItem possibleTypesToolStripMenuItem;
        private ToolStripMenuItem roadmapToolStripMenuItem;
        private ToolStripMenuItem aboutEntertainmentManagerToolStripMenuItem;
        private ToolStripMenuItem ViewProfileButton;
        private ToolStripMenuItem StatisticsButton;
        private ToolStripMenuItem ShowLibraryButton;
        private ToolStripMenuItem aboutEntertainmentManagerToolStripMenuItem1;
        private ToolStripMenuItem LogOutButton;
    }
}
