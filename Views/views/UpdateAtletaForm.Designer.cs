namespace Views.views
{
    partial class UpdateAtletaForm
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
            label1 = new Label();
            atleta_combobox = new ComboBox();
            dni_textbox = new TextBox();
            nombre_textbox = new TextBox();
            apellido_textbox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            update_atleta_btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 34);
            label1.Name = "label1";
            label1.Size = new Size(182, 15);
            label1.TabIndex = 0;
            label1.Text = "Seleccionar atleta para modificar:";
            // 
            // atleta_combobox
            // 
            atleta_combobox.FormattingEnabled = true;
            atleta_combobox.Location = new Point(24, 68);
            atleta_combobox.Name = "atleta_combobox";
            atleta_combobox.Size = new Size(204, 23);
            atleta_combobox.TabIndex = 1;
            atleta_combobox.SelectedIndexChanged += atleta_combobox_SelectedIndexChanged;
            // 
            // dni_textbox
            // 
            dni_textbox.Location = new Point(346, 94);
            dni_textbox.Name = "dni_textbox";
            dni_textbox.Size = new Size(268, 23);
            dni_textbox.TabIndex = 2;
            // 
            // nombre_textbox
            // 
            nombre_textbox.Location = new Point(346, 154);
            nombre_textbox.Name = "nombre_textbox";
            nombre_textbox.Size = new Size(268, 23);
            nombre_textbox.TabIndex = 3;
            // 
            // apellido_textbox
            // 
            apellido_textbox.Location = new Point(346, 223);
            apellido_textbox.Name = "apellido_textbox";
            apellido_textbox.Size = new Size(268, 23);
            apellido_textbox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(346, 68);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 5;
            label2.Text = "DNI:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(350, 129);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 6;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(352, 198);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 7;
            label4.Text = "Apellido";
            // 
            // update_atleta_btn
            // 
            update_atleta_btn.Location = new Point(346, 275);
            update_atleta_btn.Name = "update_atleta_btn";
            update_atleta_btn.Size = new Size(268, 23);
            update_atleta_btn.TabIndex = 8;
            update_atleta_btn.Text = "Actualizar";
            update_atleta_btn.UseVisualStyleBackColor = true;
            update_atleta_btn.Click += update_atleta_btn_Click;
            // 
            // UpdateAtletaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(update_atleta_btn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(apellido_textbox);
            Controls.Add(nombre_textbox);
            Controls.Add(dni_textbox);
            Controls.Add(atleta_combobox);
            Controls.Add(label1);
            Name = "UpdateAtletaForm";
            Text = "UpdateAtletaForm";
            Load += UpdateAtletaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox atleta_combobox;
        private TextBox dni_textbox;
        private TextBox nombre_textbox;
        private TextBox apellido_textbox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button update_atleta_btn;
    }
}