namespace demka2
{
    partial class ShiftsForm
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
            this.shiftsGridView = new System.Windows.Forms.DataGridView();
            this.loadShiftsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.shiftsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // shiftsGridView
            // 
            this.shiftsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shiftsGridView.Location = new System.Drawing.Point(12, 12);
            this.shiftsGridView.Name = "shiftsGridView";
            this.shiftsGridView.Size = new System.Drawing.Size(600, 300);
            this.shiftsGridView.TabIndex = 0;
            // 
            // loadShiftsButton
            // 
            this.loadShiftsButton.Location = new System.Drawing.Point(12, 318);
            this.loadShiftsButton.Name = "loadShiftsButton";
            this.loadShiftsButton.Size = new System.Drawing.Size(75, 23);
            this.loadShiftsButton.TabIndex = 1;
            this.loadShiftsButton.Text = "Загрузить";
            this.loadShiftsButton.UseVisualStyleBackColor = true;
            this.loadShiftsButton.Click += new System.EventHandler(this.loadShiftsButton_Click);
            // 
            // ShiftsForm
            // 
            this.ClientSize = new System.Drawing.Size(624, 361);
            this.Controls.Add(this.loadShiftsButton);
            this.Controls.Add(this.shiftsGridView);
            this.Name = "ShiftsForm";
            this.Text = "Смены";
            ((System.ComponentModel.ISupportInitialize)(this.shiftsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView shiftsGridView;
        private System.Windows.Forms.Button loadShiftsButton;
    }
}