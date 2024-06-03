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
            invalid_credentials_label = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // password_textbox
            // 
            password_textbox.Location = new Point(211, 195);
            password_textbox.Name = "password_textbox";
            password_textbox.Size = new Size(202, 23);
            password_textbox.TabIndex = 1;
            // 
            // login_btn
            // 
            login_btn.Location = new Point(562, 339);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(121, 34);
            login_btn.TabIndex = 2;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = true;
            login_btn.Click += login_btn_Click;
            // 
            // username_textbox
            // 
            username_textbox.Location = new Point(211, 127);
            username_textbox.Name = "username_textbox";
            username_textbox.Size = new Size(202, 23);
            username_textbox.TabIndex = 3;
            // 
            // invalid_credentials_label
            // 
            invalid_credentials_label.AutoSize = true;
            invalid_credentials_label.Location = new Point(340, 50);
            invalid_credentials_label.Name = "invalid_credentials_label";
            invalid_credentials_label.Size = new Size(0, 15);
            invalid_credentials_label.TabIndex = 4;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 17.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(29, 127);
            label1.Name = "label1";
            label1.Size = new Size(109, 33);
            label1.TabIndex = 5;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 17.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(29, 195);
            label2.Name = "label2";
            label2.Size = new Size(138, 33);
            label2.TabIndex = 6;
            label2.Text = "Contraseña";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 17.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(199, 18);
            label3.Name = "label3";
            label3.Size = new Size(295, 33);
            label3.TabIndex = 7;
            label3.Text = "Menu de Inicio de Sesion";
            // 
            // Form1
            // 
            ClientSize = new Size(695, 398);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(invalid_credentials_label);
            Controls.Add(username_textbox);
            Controls.Add(login_btn);
            Controls.Add(password_textbox);
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox password_textbox;
        private Button login_btn;
        private TextBox username_textbox;
        private Label invalid_credentials_label;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}