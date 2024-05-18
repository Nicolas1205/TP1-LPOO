namespace Views
{
    partial class Form1
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
            password_textbox = new TextBox();
            login_btn = new Button();
            username_textbox = new TextBox();
            SuspendLayout();
            // 
            // password_textbox
            // 
            password_textbox.Location = new Point(327, 151);
            password_textbox.Name = "password_textbox";
            password_textbox.Size = new Size(100, 23);
            password_textbox.TabIndex = 1;
            // 
            // login_btn
            // 
            login_btn.Location = new Point(327, 209);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(100, 23);
            login_btn.TabIndex = 2;
            login_btn.Text = "login";
            login_btn.UseVisualStyleBackColor = true;
            login_btn.Click += login_btn_Click;
            // 
            // username_textbox
            // 
            username_textbox.Location = new Point(327, 95);
            username_textbox.Name = "username_textbox";
            username_textbox.Size = new Size(100, 23);
            username_textbox.TabIndex = 3;
            // 
            // Form1
            // 
            ClientSize = new Size(695, 398);
            Controls.Add(username_textbox);
            Controls.Add(login_btn);
            Controls.Add(password_textbox);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox password_textbox;
        private Button login_btn;
        private TextBox username_textbox;
    }
}