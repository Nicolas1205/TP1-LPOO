namespace Views.views.usercontrol
{
    partial class DateInput
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            date_input_textbox = new TextBox();
            valid_input_label = new Label();
            SuspendLayout();
            // 
            // date_input_textbox
            // 
            date_input_textbox.Location = new Point(0, 3);
            date_input_textbox.Name = "date_input_textbox";
            date_input_textbox.PlaceholderText = "dd/mm/yyyy";
            date_input_textbox.Size = new Size(160, 23);
            date_input_textbox.TabIndex = 0;
            date_input_textbox.TextChanged += date_input_textbox_TextChanged;
            // 
            // valid_input_label
            // 
            valid_input_label.AutoSize = true;
            valid_input_label.Location = new Point(169, 11);
            valid_input_label.Name = "valid_input_label";
            valid_input_label.Size = new Size(0, 15);
            valid_input_label.TabIndex = 1;
            // 
            // DateInput
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(valid_input_label);
            Controls.Add(date_input_textbox);
            Name = "DateInput";
            Size = new Size(326, 31);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox date_input_textbox;
        private Label valid_input_label;
    }
}
