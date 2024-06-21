namespace Views.views
{
    partial class AtletaForm
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
        /// 

        private System.Windows.Forms.RadioButton rbtnDNI;
        private System.Windows.Forms.RadioButton rbtnApellido;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ListBox lstAtletas;
        private void InitializeComponent()
        {

            this.rbtnDNI = new System.Windows.Forms.RadioButton();
            this.rbtnApellido = new System.Windows.Forms.RadioButton();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lstAtletas = new System.Windows.Forms.ListBox();

            this.rbtnDNI.AutoSize = true;
            this.rbtnDNI.Location = new System.Drawing.Point(550, 65);
            this.rbtnDNI.Name = "rbtnDNI";
            this.rbtnDNI.Size = new System.Drawing.Size(45, 19);
            this.rbtnDNI.TabIndex = 15;
            this.rbtnDNI.TabStop = true;
            this.rbtnDNI.Text = "DNI";
            this.rbtnDNI.UseVisualStyleBackColor = true;

            this.rbtnApellido.AutoSize = true;
            this.rbtnApellido.Location = new System.Drawing.Point(550, 100);
            this.rbtnApellido.Name = "rbtnApellido";
            this.rbtnApellido.Size = new System.Drawing.Size(69, 19);
            this.rbtnApellido.TabIndex = 16;
            this.rbtnApellido.TabStop = true;
            this.rbtnApellido.Text = "Apellido";
            this.rbtnApellido.UseVisualStyleBackColor = true;

            this.btnConsultar.Location = new System.Drawing.Point(550, 140);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(100, 23);
            this.btnConsultar.TabIndex = 17;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);

            this.lstAtletas.FormattingEnabled = true;
            this.lstAtletas.ItemHeight = 15;
            this.lstAtletas.Location = new System.Drawing.Point(50, 400);
            this.lstAtletas.Name = "lstAtletas";
            this.lstAtletas.Size = new System.Drawing.Size(700, 200);
            this.lstAtletas.TabIndex = 18;

            this.Controls.Add(this.rbtnDNI);
            this.Controls.Add(this.rbtnApellido);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.lstAtletas);

            back_button = new Button();
            nombre_textbox = new TextBox();
            apellido_textbox = new TextBox();
            birthday_textbox = new TextBox();
            email_textbox = new TextBox();
            register_button = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            validbirthday_label = new Label();
            validemail_label = new Label();
            success_label = new Label();
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            dni_textbox = new TextBox();
            dni_label = new Label();
            SuspendLayout();

            back_button.Location = new Point(12, 12);
            back_button.Name = "back_button";
            back_button.Size = new Size(75, 23);
            back_button.TabIndex = 0;
            back_button.Text = "Atras";
            back_button.UseVisualStyleBackColor = true;
            back_button.Click += back_button_Click;

            nombre_textbox.Location = new Point(291, 128);
            nombre_textbox.Name = "nombre_textbox";
            nombre_textbox.Size = new Size(234, 23);
            nombre_textbox.TabIndex = 1;

            apellido_textbox.Location = new Point(291, 187);
            apellido_textbox.Name = "apellido_textbox";
            apellido_textbox.Size = new Size(234, 23);
            apellido_textbox.TabIndex = 2;

            birthday_textbox.Location = new Point(291, 252);
            birthday_textbox.Name = "birthday_textbox";
            birthday_textbox.PlaceholderText = "dd/mm/yyyy";
            birthday_textbox.Size = new Size(234, 23);
            birthday_textbox.TabIndex = 3;
            birthday_textbox.TextChanged += birthday_textbox_TextChanged;

            email_textbox.Location = new Point(291, 321);
            email_textbox.Name = "email_textbox";
            email_textbox.PlaceholderText = "johndoe@example.com";
            email_textbox.Size = new Size(234, 23);
            email_textbox.TabIndex = 4;
            email_textbox.TextChanged += email_textbox_TextChanged;

            register_button.Location = new Point(591, 375);
            register_button.Name = "register_button";
            register_button.Size = new Size(180, 23);
            register_button.TabIndex = 5;
            register_button.Text = "Registrar";
            register_button.UseVisualStyleBackColor = true;
            register_button.Click += register_button_Click;

            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(117, 128);
            label1.Name = "label1";
            label1.Size = new Size(59, 19);
            label1.TabIndex = 6;
            label1.Text = "Nombre";

            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(117, 191);
            label2.Name = "label2";
            label2.Size = new Size(58, 19);
            label2.TabIndex = 7;
            label2.Text = "Apellido";

            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(117, 256);
            label3.Name = "label3";
            label3.Size = new Size(136, 19);
            label3.TabIndex = 8;
            label3.Text = "Fecha de Nacimiento";

            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(117, 325);
            label4.Name = "label4";
            label4.Size = new Size(121, 19);
            label4.TabIndex = 9;
            label4.Text = "Correo Electronico";

            validbirthday_label.AutoSize = true;
            validbirthday_label.Location = new Point(540, 190);
            validbirthday_label.Name = "validbirthday_label";
            validbirthday_label.Size = new Size(0, 15);
            validbirthday_label.TabIndex = 10;
 
            validemail_label.AutoSize = true;
            validemail_label.Location = new Point(552, 242);
            validemail_label.Name = "validemail_label";
            validemail_label.Size = new Size(0, 15);
            validemail_label.TabIndex = 11;

            success_label.AutoSize = true;
            success_label.Location = new Point(415, 347);
            success_label.Name = "success_label";
            success_label.Size = new Size(0, 15);
            success_label.TabIndex = 12;

            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;

            dni_textbox.Location = new Point(291, 61);
            dni_textbox.Name = "dni_textbox";
            dni_textbox.Size = new Size(234, 23);
            dni_textbox.TabIndex = 13;
 
            dni_label.AutoSize = true;
            dni_label.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dni_label.Location = new Point(117, 65);
            dni_label.Name = "dni_label";
            dni_label.Size = new Size(33, 19);
            dni_label.TabIndex = 14;
            dni_label.Text = "DNI";
 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dni_label);
            Controls.Add(dni_textbox);
            Controls.Add(success_label);
            Controls.Add(validemail_label);
            Controls.Add(validbirthday_label);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(register_button);
            Controls.Add(email_textbox);
            Controls.Add(birthday_textbox);
            Controls.Add(apellido_textbox);
            Controls.Add(nombre_textbox);
            Controls.Add(back_button);
            Name = "AtletaForm";
            Text = "Form1";
            Load += AtletaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button back_button;
        private TextBox nombre_textbox;
        private TextBox apellido_textbox;
        private TextBox birthday_textbox;
        private TextBox email_textbox;
        private Button register_button;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label validbirthday_label;
        private Label validemail_label;
        private Label success_label;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private TextBox dni_textbox;
        private Label dni_label;
    }
}