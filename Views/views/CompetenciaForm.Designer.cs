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
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            registrar_button = new Button();
            back_button = new Button();
            fecha_inicio_datatimepicker = new DateTimePicker();
            fecha_final_datetimepicker = new DateTimePicker();
            categoria_combobox = new ComboBox();
            disciplina_combobox = new ComboBox();
            label2 = new Label();
            label6 = new Label();
            update_button = new Button();
            delete_button = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // estado_combobox
            // 
            estado_combobox.FormattingEnabled = true;
            estado_combobox.Items.AddRange(new object[] { "programado", "postergado", "reprogramado" });
            estado_combobox.Location = new Point(151, 199);
            estado_combobox.Name = "estado_combobox";
            estado_combobox.Size = new Size(200, 23);
            estado_combobox.TabIndex = 0;
            // 
            // nombre_textbox
            // 
            nombre_textbox.Location = new Point(151, 72);
            nombre_textbox.Name = "nombre_textbox";
            nombre_textbox.Size = new Size(200, 23);
            nombre_textbox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(47, 72);
            label1.Name = "label1";
            label1.Size = new Size(59, 19);
            label1.TabIndex = 6;
            label1.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(47, 117);
            label3.Name = "label3";
            label3.Size = new Size(80, 19);
            label3.TabIndex = 8;
            label3.Text = "Fecha Inicio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(47, 154);
            label4.Name = "label4";
            label4.Size = new Size(76, 19);
            label4.TabIndex = 9;
            label4.Text = "Fecha Final";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(47, 190);
            label5.Name = "label5";
            label5.Size = new Size(50, 19);
            label5.TabIndex = 10;
            label5.Text = "Estado";
            // 
            // registrar_button
            // 
            registrar_button.Location = new Point(147, 328);
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
            // fecha_inicio_datatimepicker
            // 
            fecha_inicio_datatimepicker.Location = new Point(151, 117);
            fecha_inicio_datatimepicker.Name = "fecha_inicio_datatimepicker";
            fecha_inicio_datatimepicker.Size = new Size(200, 23);
            fecha_inicio_datatimepicker.TabIndex = 13;
            // 
            // fecha_final_datetimepicker
            // 
            fecha_final_datetimepicker.Location = new Point(151, 154);
            fecha_final_datetimepicker.Name = "fecha_final_datetimepicker";
            fecha_final_datetimepicker.Size = new Size(200, 23);
            fecha_final_datetimepicker.TabIndex = 14;
            // 
            // categoria_combobox
            // 
            categoria_combobox.FormattingEnabled = true;
            categoria_combobox.Location = new Point(151, 236);
            categoria_combobox.Name = "categoria_combobox";
            categoria_combobox.Size = new Size(200, 23);
            categoria_combobox.TabIndex = 15;
            // 
            // disciplina_combobox
            // 
            disciplina_combobox.FormattingEnabled = true;
            disciplina_combobox.Location = new Point(151, 278);
            disciplina_combobox.Name = "disciplina_combobox";
            disciplina_combobox.Size = new Size(200, 23);
            disciplina_combobox.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 236);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 17;
            label2.Text = "Categoria";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(47, 286);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 18;
            label6.Text = "Disciplina:";
            // 
            // update_button
            // 
            update_button.Location = new Point(448, 328);
            update_button.Name = "update_button";
            update_button.Size = new Size(91, 23);
            update_button.TabIndex = 19;
            update_button.Text = "Actualizar";
            update_button.UseVisualStyleBackColor = true;
            update_button.Click += update_button_Click;
            // 
            // delete_button
            // 
            delete_button.Location = new Point(600, 328);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(75, 23);
            delete_button.TabIndex = 20;
            delete_button.Text = "Borrar";
            delete_button.UseVisualStyleBackColor = true;
            delete_button.Click += delete_button_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(390, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(384, 298);
            dataGridView1.TabIndex = 21;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // CompetenciaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(delete_button);
            Controls.Add(update_button);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(disciplina_combobox);
            Controls.Add(categoria_combobox);
            Controls.Add(fecha_final_datetimepicker);
            Controls.Add(fecha_inicio_datatimepicker);
            Controls.Add(back_button);
            Controls.Add(registrar_button);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(nombre_textbox);
            Controls.Add(estado_combobox);
            Name = "CompetenciaForm";
            Text = "Competencia";
            Load += CompetenciaForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox estado_combobox;
        private TextBox nombre_textbox;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button registrar_button;
        private Button back_button;
        private DateTimePicker fecha_inicio_datatimepicker;
        private DateTimePicker fecha_final_datetimepicker;
        private ComboBox categoria_combobox;
        private ComboBox disciplina_combobox;
        private Label label2;
        private Label label6;
        private Button update_button;
        private Button delete_button;
        private DataGridView dataGridView1;
    }
}