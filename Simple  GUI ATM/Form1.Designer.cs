namespace Simple__GUI_ATM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            loginbutton = new Button();
            Registerbutton = new Button();
            accBox = new TextBox();
            pinBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 31);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 0;
            label1.Text = "Chile's Simple ATM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 126);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 1;
            label2.Text = "Acc";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 179);
            label3.Name = "label3";
            label3.Size = new Size(24, 15);
            label3.TabIndex = 2;
            label3.Text = "Pin";
            // 
            // loginbutton
            // 
            loginbutton.Location = new Point(274, 250);
            loginbutton.Name = "loginbutton";
            loginbutton.Size = new Size(75, 23);
            loginbutton.TabIndex = 3;
            loginbutton.Text = "Log In";
            loginbutton.UseVisualStyleBackColor = true;
            // 
            // Registerbutton
            // 
            Registerbutton.Location = new Point(274, 289);
            Registerbutton.Name = "Registerbutton";
            Registerbutton.Size = new Size(75, 23);
            Registerbutton.TabIndex = 4;
            Registerbutton.Text = "Register";
            Registerbutton.UseVisualStyleBackColor = true;
            // 
            // accBox
            // 
            accBox.Location = new Point(109, 126);
            accBox.Name = "accBox";
            accBox.Size = new Size(150, 23);
            accBox.TabIndex = 5;
            // 
            // pinBox
            // 
            pinBox.Location = new Point(109, 176);
            pinBox.Name = "pinBox";
            pinBox.Size = new Size(150, 23);
            pinBox.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 334);
            Controls.Add(pinBox);
            Controls.Add(accBox);
            Controls.Add(Registerbutton);
            Controls.Add(loginbutton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button loginbutton;
        private Button Registerbutton;
        private TextBox accBox;
        private TextBox pinBox;
    }
}