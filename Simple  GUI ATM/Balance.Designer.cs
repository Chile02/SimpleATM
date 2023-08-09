namespace Simple__GUI_ATM
{
    partial class Balance
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
            accNum = new Label();
            accBalance = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // accNum
            // 
            accNum.AutoSize = true;
            accNum.Location = new Point(108, 76);
            accNum.Name = "accNum";
            accNum.Size = new Size(102, 15);
            accNum.TabIndex = 0;
            accNum.Text = "Account Number:";
            // 
            // accBalance
            // 
            accBalance.AutoSize = true;
            accBalance.Location = new Point(109, 134);
            accBalance.Name = "accBalance";
            accBalance.Size = new Size(48, 15);
            accBalance.TabIndex = 1;
            accBalance.Text = "Balance";
            // 
            // button1
            // 
            button1.Location = new Point(246, 292);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Balance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 354);
            Controls.Add(button1);
            Controls.Add(accBalance);
            Controls.Add(accNum);
            Name = "Balance";
            Text = "Balance";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label accNum;
        private Label accBalance;
        private Button button1;
    }
}