namespace demka2
{
    partial class HeadOfDepartmentForm
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
            this.usersButton = new System.Windows.Forms.Button();
            this.ordersButton = new System.Windows.Forms.Button();
            this.shiftsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usersButton
            // 
            this.usersButton.Location = new System.Drawing.Point(12, 12);
            this.usersButton.Name = "usersButton";
            this.usersButton.Size = new System.Drawing.Size(75, 23);
            this.usersButton.TabIndex = 0;
            this.usersButton.Text = "Сотрудники";
            this.usersButton.UseVisualStyleBackColor = true;
            this.usersButton.Click += new System.EventHandler(this.usersButton_Click);
            // 
            // ordersButton
            // 
            this.ordersButton.Location = new System.Drawing.Point(12, 41);
            this.ordersButton.Name = "ordersButton";
            this.ordersButton.Size = new System.Drawing.Size(75, 23);
            this.ordersButton.TabIndex = 1;
            this.ordersButton.Text = "Заказы";
            this.ordersButton.UseVisualStyleBackColor = true;
            this.ordersButton.Click += new System.EventHandler(this.ordersButton_Click);
            // 
            // shiftsButton
            // 
            this.shiftsButton.Location = new System.Drawing.Point(12, 70);
            this.shiftsButton.Name = "shiftsButton";
            this.shiftsButton.Size = new System.Drawing.Size(75, 23);
            this.shiftsButton.TabIndex = 2;
            this.shiftsButton.Text = "Смены";
            this.shiftsButton.UseVisualStyleBackColor = true;
            this.shiftsButton.Click += new System.EventHandler(this.shiftsButton_Click);
            // 
            // HeadOfDepartmentForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.shiftsButton);
            this.Controls.Add(this.ordersButton);
            this.Controls.Add(this.usersButton);
            this.Name = "HeadOfDepartmentForm";
            this.Text = "Head Of Department";
            this.ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button usersButton;
        private System.Windows.Forms.Button ordersButton;
        private System.Windows.Forms.Button shiftsButton;
    }
}