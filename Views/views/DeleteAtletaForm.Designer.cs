namespace Views.views
{
    partial class DeleteAtletaForm
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
            atleta_combobox = new ComboBox();
            atletas_combobox = new Label();
            delete_atleta_btn = new Button();
            SuspendLayout();
            // 
            // atleta_combobox
            // 
            atleta_combobox.FormattingEnabled = true;
            atleta_combobox.Location = new Point(305, 128);
            atleta_combobox.Name = "atleta_combobox";
            atleta_combobox.Size = new Size(192, 23);
            atleta_combobox.TabIndex = 0;
            // 
            // atletas_combobox
            // 
            atletas_combobox.AutoSize = true;
            atletas_combobox.Location = new Point(305, 97);
            atletas_combobox.Name = "atletas_combobox";
            atletas_combobox.Size = new Size(157, 15);
            atletas_combobox.TabIndex = 1;
            atletas_combobox.Text = "Seleccionar atleta a eliminar:";
            // 
            // delete_atleta_btn
            // 
            delete_atleta_btn.Location = new Point(305, 170);
            delete_atleta_btn.Name = "delete_atleta_btn";
            delete_atleta_btn.Size = new Size(192, 23);
            delete_atleta_btn.TabIndex = 2;
            delete_atleta_btn.Text = "Eliminar";
            delete_atleta_btn.UseVisualStyleBackColor = true;
            delete_atleta_btn.Click += delete_atleta_btn_Click;
            // 
            // DeleteAtletaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(delete_atleta_btn);
            Controls.Add(atletas_combobox);
            Controls.Add(atleta_combobox);
            Name = "DeleteAtletaForm";
            Text = "DeleteAtletaForm";
            Load += DeleteAtletaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox atleta_combobox;
        private Label atletas_combobox;
        private Button delete_atleta_btn;
    }
}