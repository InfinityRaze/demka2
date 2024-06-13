namespace demka2
{
    partial class AddShiftForm
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
            this.dateStartPicker = new System.Windows.Forms.DateTimePicker();
            this.dateEndPicker = new System.Windows.Forms.DateTimePicker();
            this.addButton = new System.Windows.Forms.Button();
            this.usersListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // dateStartPicker
            // 
            this.dateStartPicker.Location = new System.Drawing.Point(12, 12);
            this.dateStartPicker.Name = "dateStartPicker";
            this.dateStartPicker.Size = new System.Drawing.Size(200, 20);
            this.dateStartPicker.TabIndex = 0;
            // 
            // dateEndPicker
            // 
            this.dateEndPicker.Location = new System.Drawing.Point(12, 38);
            this.dateEndPicker.Name = "dateEndPicker";
            this.dateEndPicker.Size = new System.Drawing.Size(200, 20);
            this.dateEndPicker.TabIndex = 1;
            // 
            // usersListBox
            // 
            this.usersListBox.FormattingEnabled = true;
            this.usersListBox.Location = new System.Drawing.Point(12, 64);
            this.usersListBox.Name = "usersListBox";
            this.usersListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.usersListBox.Size = new System.Drawing.Size(200, 95);
            this.usersListBox.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 165);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // AddShiftForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 201);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.usersListBox);
            this.Controls.Add(this.dateEndPicker);
            this.Controls.Add(this.dateStartPicker);
            this.Name = "AddShiftForm";
            this.Text = "Add New Shift";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateStartPicker;
        private System.Windows.Forms.DateTimePicker dateEndPicker;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox usersListBox;
    }
}