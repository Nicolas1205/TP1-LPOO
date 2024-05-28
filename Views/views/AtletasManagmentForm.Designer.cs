namespace Views.views
{
    partial class AtletasManagmentForm
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
            components = new System.ComponentModel.Container();
            register_atleta_btn = new Button();
            update_atleta_btn = new Button();
            delete_atleta_btn = new Button();
            atletas_gridview = new DataGridView();
            atletaServiceBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)atletas_gridview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)atletaServiceBindingSource).BeginInit();
            SuspendLayout();
            // 
            // register_atleta_btn
            // 
            register_atleta_btn.Location = new Point(12, 92);
            register_atleta_btn.Name = "register_atleta_btn";
            register_atleta_btn.Size = new Size(150, 23);
            register_atleta_btn.TabIndex = 0;
            register_atleta_btn.Text = "Registrar Atleta";
            register_atleta_btn.UseVisualStyleBackColor = true;
            register_atleta_btn.Click += register_atleta_btn_Click;
            // 
            // update_atleta_btn
            // 
            update_atleta_btn.Location = new Point(12, 136);
            update_atleta_btn.Name = "update_atleta_btn";
            update_atleta_btn.Size = new Size(150, 23);
            update_atleta_btn.TabIndex = 1;
            update_atleta_btn.Text = "Actualizar Atleta";
            update_atleta_btn.UseVisualStyleBackColor = true;
            update_atleta_btn.Click += update_atleta_btn_Click;
            // 
            // delete_atleta_btn
            // 
            delete_atleta_btn.Location = new Point(12, 177);
            delete_atleta_btn.Name = "delete_atleta_btn";
            delete_atleta_btn.Size = new Size(150, 23);
            delete_atleta_btn.TabIndex = 2;
            delete_atleta_btn.Text = "Eliminar Atleta";
            delete_atleta_btn.UseVisualStyleBackColor = true;
            delete_atleta_btn.Click += delete_atleta_btn_Click;
            // 
            // atletas_gridview
            // 
            atletas_gridview.AutoGenerateColumns = false;
            atletas_gridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            atletas_gridview.DataSource = atletaServiceBindingSource;
            atletas_gridview.Location = new Point(209, 53);
            atletas_gridview.Name = "atletas_gridview";
            atletas_gridview.RowTemplate.Height = 25;
            atletas_gridview.Size = new Size(542, 266);
            atletas_gridview.TabIndex = 3;
            // 
            // atletaServiceBindingSource
            // 
            atletaServiceBindingSource.DataSource = typeof(services.AtletaService);
            // 
            // AtletasManagmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(atletas_gridview);
            Controls.Add(delete_atleta_btn);
            Controls.Add(update_atleta_btn);
            Controls.Add(register_atleta_btn);
            Name = "AtletasManagmentForm";
            Text = "AtletasManagmentForm";
            Load += AtletasManagmentForm_Load;
            ((System.ComponentModel.ISupportInitialize)atletas_gridview).EndInit();
            ((System.ComponentModel.ISupportInitialize)atletaServiceBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button register_atleta_btn;
        private Button update_atleta_btn;
        private Button delete_atleta_btn;
        private DataGridView atletas_gridview;
        private BindingSource atletaServiceBindingSource;
    }
}