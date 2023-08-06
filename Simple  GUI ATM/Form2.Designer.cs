namespace Simple__GUI_ATM
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            nameBox = new TextBox();
            lnameBox = new TextBox();
            comboBox1 = new ComboBox();
            addressBox = new TextBox();
            sexComboBox = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            regPinBox = new TextBox();
            signUpbutton = new Button();
            exitButton = new Button();
            label9 = new Label();
            accInpBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(235, 24);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Register";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 77);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 130);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 2;
            label3.Text = "L Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(334, 88);
            label4.Name = "label4";
            label4.Size = new Size(24, 15);
            label4.TabIndex = 3;
            label4.Text = "Sex";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 197);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 4;
            label5.Text = "Occupation";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(327, 205);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 5;
            label6.Text = "DOB";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(327, 302);
            label7.Name = "label7";
            label7.Size = new Size(24, 15);
            label7.TabIndex = 6;
            label7.Text = "Pin";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(30, 292);
            label8.Name = "label8";
            label8.Size = new Size(49, 15);
            label8.TabIndex = 7;
            label8.Text = "Address";
            // 
            // nameBox
            // 
            nameBox.Location = new Point(96, 80);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(149, 23);
            nameBox.TabIndex = 8;
            // 
            // lnameBox
            // 
            lnameBox.Location = new Point(90, 127);
            lnameBox.Name = "lnameBox";
            lnameBox.Size = new Size(145, 23);
            lnameBox.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Student", "Self-employed", "Goverment employed", "Unemployed" });
            comboBox1.Location = new Point(114, 189);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 10;
            // 
            // addressBox
            // 
            addressBox.Location = new Point(90, 289);
            addressBox.Multiline = true;
            addressBox.Name = "addressBox";
            addressBox.Size = new Size(132, 23);
            addressBox.TabIndex = 11;
            // 
            // sexComboBox
            // 
            sexComboBox.FormattingEnabled = true;
            sexComboBox.Items.AddRange(new object[] { "Male", "Female" });
            sexComboBox.Location = new Point(388, 85);
            sexComboBox.Name = "sexComboBox";
            sexComboBox.Size = new Size(121, 23);
            sexComboBox.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(377, 199);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(135, 23);
            dateTimePicker1.TabIndex = 13;
            // 
            // regPinBox
            // 
            regPinBox.Location = new Point(377, 299);
            regPinBox.Name = "regPinBox";
            regPinBox.Size = new Size(100, 23);
            regPinBox.TabIndex = 14;
            // 
            // signUpbutton
            // 
            signUpbutton.Location = new Point(402, 353);
            signUpbutton.Name = "signUpbutton";
            signUpbutton.Size = new Size(75, 23);
            signUpbutton.TabIndex = 15;
            signUpbutton.Text = "Sign Up";
            signUpbutton.UseVisualStyleBackColor = true;
            signUpbutton.Click += signUpbutton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(402, 398);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 16;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 359);
            label9.Name = "label9";
            label9.Size = new Size(71, 15);
            label9.TabIndex = 17;
            label9.Text = "Account No";
            // 
            // accInpBox
            // 
            accInpBox.Location = new Point(121, 360);
            accInpBox.Name = "accInpBox";
            accInpBox.Size = new Size(100, 23);
            accInpBox.TabIndex = 18;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 450);
            Controls.Add(accInpBox);
            Controls.Add(label9);
            Controls.Add(exitButton);
            Controls.Add(signUpbutton);
            Controls.Add(regPinBox);
            Controls.Add(dateTimePicker1);
            Controls.Add(sexComboBox);
            Controls.Add(addressBox);
            Controls.Add(comboBox1);
            Controls.Add(lnameBox);
            Controls.Add(nameBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox nameBox;
        private TextBox lnameBox;
        private ComboBox comboBox1;
        private TextBox addressBox;
        private ComboBox sexComboBox;
        private DateTimePicker dateTimePicker1;
        private TextBox regPinBox;
        private Button signUpbutton;
        private Button exitButton;
        private Label label9;
        private TextBox accInpBox;
    }
}