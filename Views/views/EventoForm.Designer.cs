namespace Views.views
{
    partial class EventoForm
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
            competencia_combobox = new ComboBox();
            atleta_combobox = new ComboBox();
            estado_combobox = new ComboBox();
            fecha_inicio_usercontrol = new usercontrol.DateInput();
            fecha_final_usercontrol = new usercontrol.DateInput();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            back_button = new Button();
            SuspendLayout();
            // 
            // competencia_combobox
            // 
            competencia_combobox.FormattingEnabled = true;
            competencia_combobox.Location = new Point(284, 76);
            competencia_combobox.Name = "competencia_combobox";
            competencia_combobox.Size = new Size(200, 23);
            competencia_combobox.TabIndex = 0;
            // 
            // atleta_combobox
            // 
            atleta_combobox.FormattingEnabled = true;
            atleta_combobox.Location = new Point(284, 132);
            atleta_combobox.Name = "atleta_combobox";
            atleta_combobox.Size = new Size(200, 23);
            atleta_combobox.TabIndex = 1;
            // 
            // estado_combobox
            // 
            estado_combobox.FormattingEnabled = true;
            estado_combobox.Location = new Point(284, 187);
            estado_combobox.Name = "estado_combobox";
            estado_combobox.Size = new Size(200, 23);
            estado_combobox.TabIndex = 2;
            // 
            // fecha_inicio_usercontrol
            // 
            fecha_inicio_usercontrol.Location = new Point(284, 227);
            fecha_inicio_usercontrol.Name = "fecha_inicio_usercontrol";
            fecha_inicio_usercontrol.Size = new Size(326, 31);
            fecha_inicio_usercontrol.TabIndex = 3;
            // 
            // fecha_final_usercontrol
            // 
            fecha_final_usercontrol.Location = new Point(284, 281);
            fecha_final_usercontrol.Name = "fecha_final_usercontrol";
            fecha_final_usercontrol.Size = new Size(326, 31);
            fecha_final_usercontrol.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(284, 344);
            button1.Name = "button1";
            button1.Size = new Size(200, 23);
            button1.TabIndex = 5;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += register_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(284, 58);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 6;
            label1.Text = "Competencia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(284, 114);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 7;
            label2.Text = "Atleta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(284, 169);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 8;
            label3.Text = "Estado";
            // 
            // back_button
            // 
            back_button.Location = new Point(24, 21);
            back_button.Name = "back_button";
            back_button.Size = new Size(75, 23);
            back_button.TabIndex = 9;
            back_button.Text = "Atras";
            back_button.UseVisualStyleBackColor = true;
            back_button.Click += back_button_Click;
            // 
            // EventoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(back_button);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(fecha_final_usercontrol);
            Controls.Add(fecha_inicio_usercontrol);
            Controls.Add(estado_combobox);
            Controls.Add(atleta_combobox);
            Controls.Add(competencia_combobox);
            Name = "EventoForm";
            Text = "Form1";
            Load += EventoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox competencia_combobox;
        private ComboBox atleta_combobox;
        private ComboBox estado_combobox;
        private usercontrol.DateInput fecha_inicio_usercontrol;
        private usercontrol.DateInput fecha_final_usercontrol;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button back_button;
    }
}