namespace EntertainmentManager
{
    partial class Auth
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
            UsernameBox = new TextBox();
            PasswordBox = new TextBox();
            LoginButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            RegisterButton = new Button();
            PasswordAgainBox = new TextBox();
            ErrorBox = new TextBox();
            SuspendLayout();
            // 
            // UsernameBox
            // 
            UsernameBox.Location = new Point(155, 151);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.PlaceholderText = "Username";
            UsernameBox.Size = new Size(180, 31);
            UsernameBox.TabIndex = 0;
            UsernameBox.TextAlign = HorizontalAlignment.Center;
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(155, 188);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.PasswordChar = '*';
            PasswordBox.PlaceholderText = "Password";
            PasswordBox.Size = new Size(180, 31);
            PasswordBox.TabIndex = 1;
            PasswordBox.TextAlign = HorizontalAlignment.Center;
            PasswordBox.UseSystemPasswordChar = true;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(182, 225);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(112, 34);
            LoginButton.TabIndex = 2;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 9);
            label1.Name = "label1";
            label1.Size = new Size(472, 46);
            label1.TabIndex = 3;
            label1.Text = "Welcome to";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Yu Gothic", 18F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkMagenta;
            label2.Location = new Point(14, 44);
            label2.Name = "label2";
            label2.Size = new Size(470, 64);
            label2.TabIndex = 4;
            label2.Text = "Entertainment Manager";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Location = new Point(107, 111);
            label3.Name = "label3";
            label3.Size = new Size(136, 34);
            label3.TabIndex = 5;
            label3.Text = "Please login or ";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(239, 111);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(159, 34);
            RegisterButton.TabIndex = 3;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // PasswordAgainBox
            // 
            PasswordAgainBox.Enabled = false;
            PasswordAgainBox.Location = new Point(155, 225);
            PasswordAgainBox.Name = "PasswordAgainBox";
            PasswordAgainBox.PasswordChar = '*';
            PasswordAgainBox.PlaceholderText = "Password";
            PasswordAgainBox.Size = new Size(180, 31);
            PasswordAgainBox.TabIndex = 2;
            PasswordAgainBox.TextAlign = HorizontalAlignment.Center;
            PasswordAgainBox.UseSystemPasswordChar = true;
            PasswordAgainBox.Visible = false;
            // 
            // ErrorBox
            // 
            ErrorBox.BackColor = SystemColors.GradientInactiveCaption;
            ErrorBox.BorderStyle = BorderStyle.None;
            ErrorBox.Enabled = false;
            ErrorBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ErrorBox.ForeColor = Color.Red;
            ErrorBox.Location = new Point(341, 148);
            ErrorBox.Multiline = true;
            ErrorBox.Name = "ErrorBox";
            ErrorBox.ReadOnly = true;
            ErrorBox.Size = new Size(145, 108);
            ErrorBox.TabIndex = 8;
            ErrorBox.TabStop = false;
            ErrorBox.TextAlign = HorizontalAlignment.Center;
            // 
            // Auth
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(495, 278);
            Controls.Add(ErrorBox);
            Controls.Add(PasswordAgainBox);
            Controls.Add(RegisterButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LoginButton);
            Controls.Add(PasswordBox);
            Controls.Add(UsernameBox);
            MaximumSize = new Size(517, 334);
            MinimumSize = new Size(517, 334);
            Name = "Auth";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Auth";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UsernameBox;
        private TextBox PasswordBox;
        private Button LoginButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button RegisterButton;
        private TextBox PasswordAgainBox;
        private TextBox ErrorBox;
    }
}