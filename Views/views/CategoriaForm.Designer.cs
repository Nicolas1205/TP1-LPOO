namespace Views.views
{
    partial class CategoriaForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            back_button = new Button();
            nombre_textbox = new TextBox();
            descripcion_textbox = new TextBox();
            register_button = new Button();
            label1 = new Label();
            label2 = new Label();
            success_label = new Label();
            categoriaDataGridView = new DataGridView();
            edit_button = new Button();
            delete_button = new Button();
            ((System.ComponentModel.ISupportInitialize)(categoriaDataGridView)).BeginInit();
            SuspendLayout();

            // back_button
            back_button.Location = new Point(12, 12);
            back_button.Name = "back_button";
            back_button.Size = new Size(75, 23);
            back_button.TabIndex = 0;
            back_button.Text = "Atrás";
            back_button.UseVisualStyleBackColor = true;
            back_button.Click += new EventHandler(back_button_Click);

            // nombre_textbox
            nombre_textbox.Location = new Point(291, 128);
            nombre_textbox.Name = "nombre_textbox";
            nombre_textbox.Size = new Size(234, 23);
            nombre_textbox.TabIndex = 1;

            // descripcion_textbox
            descripcion_textbox.Location = new Point(291, 187);
            descripcion_textbox.Name = "descripcion_textbox";
            descripcion_textbox.Size = new Size(234, 23);
            descripcion_textbox.TabIndex = 2;

            // register_button
            register_button.Location = new Point(291, 230);
            register_button.Name = "register_button";
            register_button.Size = new Size(75, 23);
            register_button.TabIndex = 3;
            register_button.Text = "Registrar";
            register_button.UseVisualStyleBackColor = true;
            register_button.Click += new EventHandler(register_button_Click);

            // label1
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(117, 128);
            label1.Name = "label1";
            label1.Size = new Size(59, 19);
            label1.TabIndex = 4;
            label1.Text = "Nombre";

            // label2
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(117, 190);
            label2.Name = "label2";
            label2.Size = new Size(78, 19);
            label2.TabIndex = 5;
            label2.Text = "Descripción";

            // success_label
            success_label.AutoSize = true;
            success_label.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            success_label.Location = new Point(291, 260);
            success_label.Name = "success_label";
            success_label.Size = new Size(0, 19);
            success_label.TabIndex = 6;

            // categoriaDataGridView
            categoriaDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            categoriaDataGridView.Location = new Point(117, 300);
            categoriaDataGridView.Name = "categoriaDataGridView";
            categoriaDataGridView.Size = new Size(600, 150);
            categoriaDataGridView.TabIndex = 7;
            categoriaDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // edit_button
            edit_button.Location = new Point(117, 470);
            edit_button.Name = "edit_button";
            edit_button.Size = new Size(75, 23);
            edit_button.TabIndex = 8;
            edit_button.Text = "Editar";
            edit_button.UseVisualStyleBackColor = true;
            edit_button.Click += new EventHandler(edit_button_Click);

            // delete_button
            delete_button.Location = new Point(210, 470);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(75, 23);
            delete_button.TabIndex = 9;
            delete_button.Text = "Borrar";
            delete_button.UseVisualStyleBackColor = true;
            delete_button.Click += new EventHandler(delete_button_Click);

            // CategoriaForm
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.Add(delete_button);
            Controls.Add(edit_button);
            Controls.Add(categoriaDataGridView);
            Controls.Add(success_label);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(register_button);
            Controls.Add(descripcion_textbox);
            Controls.Add(nombre_textbox);
            Controls.Add(back_button);
            Name = "CategoriaForm";
            Text = "CategoriaForm";
            Load += new EventHandler(CategoriaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(categoriaDataGridView)).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button back_button;
        private TextBox nombre_textbox;
        private TextBox descripcion_textbox;
        private Button register_button;
        private Label label1;
        private Label label2;
        private Label success_label;
        private DataGridView categoriaDataGridView;
        private Button edit_button;
        private Button delete_button;
    }
}
