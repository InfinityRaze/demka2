namespace demka2
{
    partial class UsersForm
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
            this.addUserButton = new System.Windows.Forms.Button();
            this.fireUserButton = new System.Windows.Forms.Button();
            this.usersListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(12, 12);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(75, 23);
            this.addUserButton.TabIndex = 0;
            this.addUserButton.Text = "Добавить";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // fireUserButton
            // 
            this.fireUserButton.Location = new System.Drawing.Point(12, 41);
            this.fireUserButton.Name = "fireUserButton";
            this.fireUserButton.Size = new System.Drawing.Size(75, 23);
            this.fireUserButton.TabIndex = 1;
            this.fireUserButton.Text = "Уволить";
            this.fireUserButton.UseVisualStyleBackColor = true;
            this.fireUserButton.Click += new System.EventHandler(this.fireUserButton_Click);
            // 
            // usersListBox
            // 
            this.usersListBox.FormattingEnabled = true;
            this.usersListBox.Location = new System.Drawing.Point(93, 12);
            this.usersListBox.Name = "usersListBox";
            this.usersListBox.Size = new System.Drawing.Size(303, 238);
            this.usersListBox.TabIndex = 2;
            // 
            // UsersForm
            // 
            this.ClientSize = new System.Drawing.Size(408, 261);
            this.Controls.Add(this.usersListBox);
            this.Controls.Add(this.fireUserButton);
            this.Controls.Add(this.addUserButton);
            this.Name = "UsersForm";
            this.Text = "Users Management";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Button fireUserButton;
        private System.Windows.Forms.ListBox usersListBox;
    }
}