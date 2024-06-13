namespace demka2
{
    partial class CreateOrderForm
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
            this.nameConferenceTextBox = new System.Windows.Forms.TextBox();
            this.amountGuestsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.equipmentTextBox = new System.Windows.Forms.TextBox();
            this.createOrderButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.amountGuestsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // nameConferenceTextBox
            // 
            this.nameConferenceTextBox.Location = new System.Drawing.Point(133, 12);
            this.nameConferenceTextBox.Name = "nameConferenceTextBox";
            this.nameConferenceTextBox.Size = new System.Drawing.Size(260, 20);
            this.nameConferenceTextBox.TabIndex = 0;
            // 
            // amountGuestsNumericUpDown
            // 
            this.amountGuestsNumericUpDown.Location = new System.Drawing.Point(133, 38);
            this.amountGuestsNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.amountGuestsNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amountGuestsNumericUpDown.Name = "amountGuestsNumericUpDown";
            this.amountGuestsNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.amountGuestsNumericUpDown.TabIndex = 1;
            this.amountGuestsNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // equipmentTextBox
            // 
            this.equipmentTextBox.Location = new System.Drawing.Point(133, 64);
            this.equipmentTextBox.Name = "equipmentTextBox";
            this.equipmentTextBox.Size = new System.Drawing.Size(260, 20);
            this.equipmentTextBox.TabIndex = 2;
            // 
            // createOrderButton
            // 
            this.createOrderButton.Location = new System.Drawing.Point(133, 90);
            this.createOrderButton.Name = "createOrderButton";
            this.createOrderButton.Size = new System.Drawing.Size(260, 23);
            this.createOrderButton.TabIndex = 3;
            this.createOrderButton.Text = "Создать заказ";
            this.createOrderButton.UseVisualStyleBackColor = true;
            this.createOrderButton.Click += new System.EventHandler(this.createOrderButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Количество гостей";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Оборудование";
            // 
            // CreateOrderForm
            // 
            this.ClientSize = new System.Drawing.Size(405, 126);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createOrderButton);
            this.Controls.Add(this.equipmentTextBox);
            this.Controls.Add(this.amountGuestsNumericUpDown);
            this.Controls.Add(this.nameConferenceTextBox);
            this.Name = "CreateOrderForm";
            this.Text = "Создание заказа";
            ((System.ComponentModel.ISupportInitialize)(this.amountGuestsNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameConferenceTextBox;
        private System.Windows.Forms.NumericUpDown amountGuestsNumericUpDown;
        private System.Windows.Forms.TextBox equipmentTextBox;
        private System.Windows.Forms.Button createOrderButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}