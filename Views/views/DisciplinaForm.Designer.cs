namespace Views.views
{
    partial class DisciplinaForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView disciplinaDataGridView;
        private Button backButton;
        private Button addButton;
        private Button updateButton;
        private Button deleteButton;
        private TextBox idTextBox;
        private TextBox nombreTextBox;
        private TextBox descripcionTextBox;
        private Label idLabel;
        private Label nombreLabel;
        private Label descripcionLabel;

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
            this.disciplinaDataGridView = new System.Windows.Forms.DataGridView();
            this.backButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.descripcionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // disciplinaDataGridView
            // 
            this.disciplinaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.disciplinaDataGridView.Location = new System.Drawing.Point(12, 12);
            this.disciplinaDataGridView.Name = "disciplinaDataGridView";
            this.disciplinaDataGridView.RowTemplate.Height = 25;
            this.disciplinaDataGridView.Size = new System.Drawing.Size(776, 150);
            this.disciplinaDataGridView.TabIndex = 0;
            this.disciplinaDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.disciplinaDataGridView_CellClick);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(713, 415);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Volver";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(632, 206);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Agregar";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(632, 251);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 3;
            this.updateButton.Text = "Actualizar";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(632, 296);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Eliminar";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(122, 207);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(100, 23);
            this.idTextBox.TabIndex = 5;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(122, 252);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 23);
            this.nombreTextBox.TabIndex = 6;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.Location = new System.Drawing.Point(122, 297);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(100, 23);
            this.descripcionTextBox.TabIndex = 7;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(12, 210);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(18, 15);
            this.idLabel.TabIndex = 8;
            this.idLabel.Text = "ID";
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(12, 255);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(51, 15);
            this.nombreLabel.TabIndex = 9;
            this.nombreLabel.Text = "Nombre";
            // 
            // descripcionLabel
            // 
            this.descripcionLabel.AutoSize = true;
            this.descripcionLabel.Location = new System.Drawing.Point(12, 300);
            this.descripcionLabel.Name = "descripcionLabel";
            this.descripcionLabel.Size = new System.Drawing.Size(69, 15);
            this.descripcionLabel.TabIndex = 10;
            this.descripcionLabel.Text = "Descripción";
            // 
            // DisciplinaForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.descripcionLabel);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.disciplinaDataGridView);
            this.Name = "DisciplinaForm";
            ((System.ComponentModel.ISupportInitialize)(this.disciplinaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
