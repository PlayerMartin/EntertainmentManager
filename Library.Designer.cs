namespace EntertainmentManager
{
    partial class Library
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Refresh = new Button();
            LibraryGrid = new DataGridView();
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ownerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            typeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            releasedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            runtimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            posterDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            genreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tagsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ratingDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            progressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            itemBindingSource = new BindingSource(components);
            Sort = new Button();
            GenreBox = new TextBox();
            YearBox = new TextBox();
            TypeBox = new TextBox();
            StatusBox = new ComboBox();
            DeleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)LibraryGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource).BeginInit();
            SuspendLayout();
            // 
            // Refresh
            // 
            Refresh.Anchor = AnchorStyles.Bottom;
            Refresh.Location = new Point(9, 540);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(128, 45);
            Refresh.TabIndex = 5;
            Refresh.Text = "Refresh";
            Refresh.UseVisualStyleBackColor = true;
            Refresh.Click += Refresh_Click;
            // 
            // LibraryGrid
            // 
            LibraryGrid.AllowUserToAddRows = false;
            LibraryGrid.AllowUserToOrderColumns = true;
            LibraryGrid.AllowUserToResizeRows = false;
            LibraryGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LibraryGrid.AutoGenerateColumns = false;
            LibraryGrid.BackgroundColor = SystemColors.GradientInactiveCaption;
            LibraryGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LibraryGrid.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, ownerDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, typeDataGridViewTextBoxColumn, releasedDataGridViewTextBoxColumn, runtimeDataGridViewTextBoxColumn, posterDataGridViewTextBoxColumn, genreDataGridViewTextBoxColumn, tagsDataGridViewTextBoxColumn, ratingDataGridViewTextBoxColumn, progressDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn });
            LibraryGrid.DataSource = itemBindingSource;
            LibraryGrid.EditMode = DataGridViewEditMode.EditOnF2;
            LibraryGrid.Location = new Point(12, 12);
            LibraryGrid.Name = "LibraryGrid";
            LibraryGrid.RowHeadersWidth = 62;
            LibraryGrid.Size = new Size(960, 522);
            LibraryGrid.TabIndex = 8;
            LibraryGrid.CellClick += LibraryGrid_CellClick;
            LibraryGrid.CellEndEdit += LibraryGrid_CellEndEdit;
            LibraryGrid.DataError += LibraryGrid_DataError;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn.HeaderText = "ID";
            iDDataGridViewTextBoxColumn.MinimumWidth = 8;
            iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            iDDataGridViewTextBoxColumn.ReadOnly = true;
            iDDataGridViewTextBoxColumn.Visible = false;
            iDDataGridViewTextBoxColumn.Width = 150;
            // 
            // ownerDataGridViewTextBoxColumn
            // 
            ownerDataGridViewTextBoxColumn.DataPropertyName = "Owner";
            ownerDataGridViewTextBoxColumn.HeaderText = "Owner";
            ownerDataGridViewTextBoxColumn.MinimumWidth = 8;
            ownerDataGridViewTextBoxColumn.Name = "ownerDataGridViewTextBoxColumn";
            ownerDataGridViewTextBoxColumn.ReadOnly = true;
            ownerDataGridViewTextBoxColumn.Visible = false;
            ownerDataGridViewTextBoxColumn.Width = 150;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Title";
            titleDataGridViewTextBoxColumn.MinimumWidth = 8;
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            titleDataGridViewTextBoxColumn.Width = 80;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            typeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            typeDataGridViewTextBoxColumn.HeaderText = "Type";
            typeDataGridViewTextBoxColumn.MinimumWidth = 8;
            typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            typeDataGridViewTextBoxColumn.Width = 85;
            // 
            // releasedDataGridViewTextBoxColumn
            // 
            releasedDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            releasedDataGridViewTextBoxColumn.DataPropertyName = "Released";
            releasedDataGridViewTextBoxColumn.HeaderText = "Released";
            releasedDataGridViewTextBoxColumn.MinimumWidth = 8;
            releasedDataGridViewTextBoxColumn.Name = "releasedDataGridViewTextBoxColumn";
            releasedDataGridViewTextBoxColumn.Width = 117;
            // 
            // runtimeDataGridViewTextBoxColumn
            // 
            runtimeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            runtimeDataGridViewTextBoxColumn.DataPropertyName = "Runtime";
            runtimeDataGridViewTextBoxColumn.HeaderText = "Runtime";
            runtimeDataGridViewTextBoxColumn.MinimumWidth = 8;
            runtimeDataGridViewTextBoxColumn.Name = "runtimeDataGridViewTextBoxColumn";
            runtimeDataGridViewTextBoxColumn.Width = 114;
            // 
            // posterDataGridViewTextBoxColumn
            // 
            posterDataGridViewTextBoxColumn.DataPropertyName = "Poster";
            posterDataGridViewTextBoxColumn.HeaderText = "Poster";
            posterDataGridViewTextBoxColumn.MinimumWidth = 8;
            posterDataGridViewTextBoxColumn.Name = "posterDataGridViewTextBoxColumn";
            posterDataGridViewTextBoxColumn.ReadOnly = true;
            posterDataGridViewTextBoxColumn.Visible = false;
            posterDataGridViewTextBoxColumn.Width = 150;
            // 
            // genreDataGridViewTextBoxColumn
            // 
            genreDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            genreDataGridViewTextBoxColumn.HeaderText = "Genre";
            genreDataGridViewTextBoxColumn.MinimumWidth = 8;
            genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            genreDataGridViewTextBoxColumn.Width = 94;
            // 
            // tagsDataGridViewTextBoxColumn
            // 
            tagsDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            tagsDataGridViewTextBoxColumn.DataPropertyName = "Tags";
            tagsDataGridViewTextBoxColumn.HeaderText = "Tags";
            tagsDataGridViewTextBoxColumn.MinimumWidth = 8;
            tagsDataGridViewTextBoxColumn.Name = "tagsDataGridViewTextBoxColumn";
            tagsDataGridViewTextBoxColumn.Width = 83;
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            ratingDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ratingDataGridViewTextBoxColumn.DataPropertyName = "Rating";
            ratingDataGridViewTextBoxColumn.HeaderText = "Rating";
            ratingDataGridViewTextBoxColumn.MinimumWidth = 8;
            ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            ratingDataGridViewTextBoxColumn.Width = 99;
            // 
            // progressDataGridViewTextBoxColumn
            // 
            progressDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            progressDataGridViewTextBoxColumn.DataPropertyName = "Progress";
            progressDataGridViewTextBoxColumn.HeaderText = "Progress";
            progressDataGridViewTextBoxColumn.MinimumWidth = 8;
            progressDataGridViewTextBoxColumn.Name = "progressDataGridViewTextBoxColumn";
            progressDataGridViewTextBoxColumn.Width = 117;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.MinimumWidth = 8;
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.Width = 96;
            // 
            // itemBindingSource
            // 
            itemBindingSource.DataSource = typeof(Item);
            // 
            // Sort
            // 
            Sort.Anchor = AnchorStyles.Bottom;
            Sort.Location = new Point(701, 540);
            Sort.Name = "Sort";
            Sort.Size = new Size(128, 45);
            Sort.TabIndex = 4;
            Sort.Text = "Sort";
            Sort.UseVisualStyleBackColor = true;
            Sort.Click += Sort_Click;
            // 
            // GenreBox
            // 
            GenreBox.Anchor = AnchorStyles.Bottom;
            GenreBox.Location = new Point(143, 549);
            GenreBox.Name = "GenreBox";
            GenreBox.PlaceholderText = "Genre";
            GenreBox.Size = new Size(124, 31);
            GenreBox.TabIndex = 0;
            GenreBox.TextAlign = HorizontalAlignment.Center;
            // 
            // YearBox
            // 
            YearBox.Anchor = AnchorStyles.Bottom;
            YearBox.Location = new Point(273, 549);
            YearBox.Name = "YearBox";
            YearBox.PlaceholderText = "Year";
            YearBox.Size = new Size(124, 31);
            YearBox.TabIndex = 1;
            YearBox.TextAlign = HorizontalAlignment.Center;
            // 
            // TypeBox
            // 
            TypeBox.Anchor = AnchorStyles.Bottom;
            TypeBox.Location = new Point(403, 549);
            TypeBox.Name = "TypeBox";
            TypeBox.PlaceholderText = "Type";
            TypeBox.Size = new Size(124, 31);
            TypeBox.TabIndex = 2;
            TypeBox.TextAlign = HorizontalAlignment.Center;
            // 
            // StatusBox
            // 
            StatusBox.Anchor = AnchorStyles.Bottom;
            StatusBox.FormattingEnabled = true;
            StatusBox.Items.AddRange(new object[] { "COMPLETED", "WATCHING", "DEFAULT" });
            StatusBox.Location = new Point(533, 547);
            StatusBox.Name = "StatusBox";
            StatusBox.Size = new Size(162, 33);
            StatusBox.TabIndex = 3;
            StatusBox.Text = "Status";
            // 
            // DeleteButton
            // 
            DeleteButton.Anchor = AnchorStyles.Bottom;
            DeleteButton.BackColor = Color.Red;
            DeleteButton.Location = new Point(852, 542);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(120, 45);
            DeleteButton.TabIndex = 6;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // Library
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(984, 597);
            Controls.Add(DeleteButton);
            Controls.Add(StatusBox);
            Controls.Add(TypeBox);
            Controls.Add(YearBox);
            Controls.Add(GenreBox);
            Controls.Add(Sort);
            Controls.Add(LibraryGrid);
            Controls.Add(Refresh);
            MinimumSize = new Size(1006, 653);
            Name = "Library";
            StartPosition = FormStartPosition.Manual;
            Text = "Library";
            ((System.ComponentModel.ISupportInitialize)LibraryGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Refresh;
        private DataGridView LibraryGrid;
        private BindingSource itemBindingSource;
        private Button Sort;
        private TextBox GenreBox;
        private TextBox YearBox;
        private TextBox TypeBox;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ownerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn releasedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn runtimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn posterDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tagsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn progressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private ComboBox StatusBox;
        private Button DeleteButton;
    }
}