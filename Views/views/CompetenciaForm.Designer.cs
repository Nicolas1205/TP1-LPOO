namespace Views.views
{
    partial class CompetenciaForm
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
            estado_combobox = new ComboBox();
            nombre_textbox = new TextBox();
            descripcion_textbox = new TextBox();
            fecha_inicio_usercontrol = new usercontrol.DateInput();
            fecha_final_usercontrol = new usercontrol.DateInput();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            registrar_button = new Button();
            back_button = new Button();
            SuspendLayout();
            // 
            // estado_combobox
            // 
            estado_combobox.FormattingEnabled = true;
            estado_combobox.Items.AddRange(new object[] { "programado", "postergado", "reprogramado" });
            estado_combobox.Location = new Point(306, 301);
            estado_combobox.Name = "estado_combobox";
            estado_combobox.Size = new Size(121, 23);
            estado_combobox.TabIndex = 0;
            // 
            // nombre_textbox
            // 
            nombre_textbox.Location = new Point(306, 64);
            nombre_textbox.Name = "nombre_textbox";
            nombre_textbox.Size = new Size(159, 23);
            nombre_textbox.TabIndex = 1;
            // 
            // descripcion_textbox
            // 
            descripcion_textbox.Location = new Point(306, 108);
            descripcion_textbox.Multiline = true;
            descripcion_textbox.Name = "descripcion_textbox";
            descripcion_textbox.Size = new Size(159, 46);
            descripcion_textbox.TabIndex = 2;
            // 
            // fecha_inicio_usercontrol
            // 
            fecha_inicio_usercontrol.Location = new Point(306, 186);
            fecha_inicio_usercontrol.Name = "fecha_inicio_usercontrol";
            fecha_inicio_usercontrol.Size = new Size(326, 31);
            fecha_inicio_usercontrol.TabIndex = 3;
            // 
            // fecha_final_usercontrol
            // 
            fecha_final_usercontrol.Location = new Point(306, 239);
            fecha_final_usercontrol.Name = "fecha_final_usercontrol";
            fecha_final_usercontrol.Size = new Size(326, 31);
            fecha_final_usercontrol.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(141, 72);
            label1.Name = "label1";
            label1.Size = new Size(59, 19);
            label1.TabIndex = 6;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(141, 139);
            label2.Name = "label2";
            label2.Size = new Size(79, 19);
            label2.TabIndex = 7;
            label2.Text = "Descripcion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(141, 198);
            label3.Name = "label3";
            label3.Size = new Size(80, 19);
            label3.TabIndex = 8;
            label3.Text = "Fecha Inicio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(141, 251);
            label4.Name = "label4";
            label4.Size = new Size(76, 19);
            label4.TabIndex = 9;
            label4.Text = "Fecha Final";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(141, 305);
            label5.Name = "label5";
            label5.Size = new Size(50, 19);
            label5.TabIndex = 10;
            label5.Text = "Estado";
            // 
            // registrar_button
            // 
            registrar_button.Location = new Point(572, 401);
            registrar_button.Name = "registrar_button";
            registrar_button.Size = new Size(204, 23);
            registrar_button.TabIndex = 11;
            registrar_button.Text = "Registrar";
            registrar_button.UseVisualStyleBackColor = true;
            registrar_button.Click += registrar_button_Click;
            // 
            // back_button
            // 
            back_button.Location = new Point(14, 9);
            back_button.Name = "back_button";
            back_button.Size = new Size(75, 23);
            back_button.TabIndex = 12;
            back_button.Text = "Atras";
            back_button.UseVisualStyleBackColor = true;
            back_button.Click += back_button_Click;
            // 
            // CompetenciaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(back_button);
            Controls.Add(registrar_button);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(fecha_final_usercontrol);
            Controls.Add(fecha_inicio_usercontrol);
            Controls.Add(descripcion_textbox);
            Controls.Add(nombre_textbox);
            Controls.Add(estado_combobox);
            Name = "CompetenciaForm";
            Text = "Competencia";
            Load += CompetenciaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox estado_combobox;
        private TextBox nombre_textbox;
        private TextBox descripcion_textbox;
        private usercontrol.DateInput fecha_inicio_usercontrol;
        private usercontrol.DateInput fecha_final_usercontrol;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button registrar_button;
        private Button back_button;
    }
}