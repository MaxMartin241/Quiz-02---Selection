namespace Quiz_02___Selection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            q1TextBox = new TextBox();
            q1Button = new Button();
            q1OutputLabel = new Label();
            label7 = new Label();
            label8 = new Label();
            q2OutputLabel = new Label();
            q2Button = new Button();
            q2TextBox = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label9 = new Label();
            label12 = new Label();
            label13 = new Label();
            q3OutputLabel = new Label();
            q3Button = new Button();
            q3TextBox = new TextBox();
            label15 = new Label();
            label16 = new Label();
            label14 = new Label();
            q04InstructionButton = new Button();
            label17 = new Label();
            q4OutputLabel = new Label();
            q4Button = new Button();
            q4TempTextBox = new TextBox();
            label19 = new Label();
            q4CoatTextBox = new TextBox();
            label20 = new Label();
            label18 = new Label();
            bonusButton = new Button();
            q3LabelGood = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(219, 23);
            label1.TabIndex = 0;
            label1.Text = "Quiz 02 - Selection";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(274, 23);
            label2.TabIndex = 1;
            label2.Text = "Q01 Simple If  - 2 marks";
            // 
            // label3
            // 
            label3.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(12, 120);
            label3.Name = "label3";
            label3.Size = new Size(738, 121);
            label3.TabIndex = 2;
            label3.Text = "The user will enter the secret password.  If they enter 'banana'  then 'SECRET UNLOCKED' will be output in the label.";
            // 
            // label4
            // 
            label4.BackColor = Color.SkyBlue;
            label4.Location = new Point(787, -3);
            label4.Name = "label4";
            label4.Size = new Size(14, 1273);
            label4.TabIndex = 3;
            // 
            // label5
            // 
            label5.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(12, 241);
            label5.Name = "label5";
            label5.Size = new Size(769, 46);
            label5.TabIndex = 4;
            label5.Text = "-----------------------------------------";
            // 
            // label6
            // 
            label6.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(23, 287);
            label6.Name = "label6";
            label6.Size = new Size(282, 121);
            label6.TabIndex = 5;
            label6.Text = "What is the secret password?";
            // 
            // q1TextBox
            // 
            q1TextBox.Location = new Point(282, 324);
            q1TextBox.Name = "q1TextBox";
            q1TextBox.Size = new Size(200, 25);
            q1TextBox.TabIndex = 6;
            // 
            // q1Button
            // 
            q1Button.Location = new Point(558, 324);
            q1Button.Name = "q1Button";
            q1Button.Size = new Size(150, 46);
            q1Button.TabIndex = 7;
            q1Button.Text = "Code Me!";
            q1Button.UseVisualStyleBackColor = true;
            q1Button.Click += q1Button_Click;
            // 
            // q1OutputLabel
            // 
            q1OutputLabel.BorderStyle = BorderStyle.FixedSingle;
            q1OutputLabel.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            q1OutputLabel.ForeColor = SystemColors.Control;
            q1OutputLabel.Location = new Point(23, 420);
            q1OutputLabel.Name = "q1OutputLabel";
            q1OutputLabel.Size = new Size(738, 121);
            q1OutputLabel.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(23, 568);
            label7.Name = "label7";
            label7.Size = new Size(296, 23);
            label7.TabIndex = 9;
            label7.Text = "Q02 - If... Else - 3 marks";
            // 
            // label8
            // 
            label8.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(23, 622);
            label8.Name = "label8";
            label8.Size = new Size(738, 238);
            label8.TabIndex = 10;
            label8.Text = resources.GetString("label8.Text");
            // 
            // q2OutputLabel
            // 
            q2OutputLabel.BorderStyle = BorderStyle.FixedSingle;
            q2OutputLabel.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            q2OutputLabel.ForeColor = SystemColors.Control;
            q2OutputLabel.Location = new Point(12, 1101);
            q2OutputLabel.Name = "q2OutputLabel";
            q2OutputLabel.Size = new Size(738, 121);
            q2OutputLabel.TabIndex = 15;
            // 
            // q2Button
            // 
            q2Button.Location = new Point(533, 919);
            q2Button.Name = "q2Button";
            q2Button.Size = new Size(150, 46);
            q2Button.TabIndex = 14;
            q2Button.Text = "Code Me!";
            q2Button.UseVisualStyleBackColor = true;
            q2Button.Click += q2Button_Click;
            // 
            // q2TextBox
            // 
            q2TextBox.Location = new Point(271, 925);
            q2TextBox.Name = "q2TextBox";
            q2TextBox.Size = new Size(200, 25);
            q2TextBox.TabIndex = 13;
            // 
            // label10
            // 
            label10.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(12, 888);
            label10.Name = "label10";
            label10.Size = new Size(282, 199);
            label10.TabIndex = 12;
            label10.Text = "Do you prefer rock and roll (enter r) or country (enter c) music?";
            // 
            // label11
            // 
            label11.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.Control;
            label11.Location = new Point(1, 842);
            label11.Name = "label11";
            label11.Size = new Size(769, 46);
            label11.TabIndex = 11;
            label11.Text = "-----------------------------------------";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(807, 9);
            label9.Name = "label9";
            label9.Size = new Size(373, 23);
            label9.TabIndex = 16;
            label9.Text = "Q03 - Multiple Decisions- 5 marks";
            // 
            // label12
            // 
            label12.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.Control;
            label12.Location = new Point(807, 57);
            label12.Name = "label12";
            label12.Size = new Size(999, 162);
            label12.TabIndex = 17;
            label12.Text = resources.GetString("label12.Text");
            // 
            // label13
            // 
            label13.Font = new Font("Consolas", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(255, 255, 128);
            label13.Location = new Point(807, 219);
            label13.Name = "label13";
            label13.Size = new Size(999, 116);
            label13.TabIndex = 18;
            label13.Text = "ICS3U for full marks use a Switch Statement, ICS3C for full marks use if / else if OR Switch for full marks.";
            // 
            // q3OutputLabel
            // 
            q3OutputLabel.BorderStyle = BorderStyle.FixedSingle;
            q3OutputLabel.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            q3OutputLabel.ForeColor = SystemColors.Control;
            q3OutputLabel.Location = new Point(817, 471);
            q3OutputLabel.Name = "q3OutputLabel";
            q3OutputLabel.Size = new Size(913, 70);
            q3OutputLabel.TabIndex = 22;
            // 
            // q3Button
            // 
            q3Button.Location = new Point(1330, 384);
            q3Button.Name = "q3Button";
            q3Button.Size = new Size(150, 46);
            q3Button.TabIndex = 21;
            q3Button.Text = "Code Me!";
            q3Button.UseVisualStyleBackColor = true;
            q3Button.Click += q3Button_Click;
            // 
            // q3TextBox
            // 
            q3TextBox.Location = new Point(1078, 390);
            q3TextBox.Name = "q3TextBox";
            q3TextBox.Size = new Size(200, 25);
            q3TextBox.TabIndex = 20;
            // 
            // label15
            // 
            label15.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = SystemColors.Control;
            label15.Location = new Point(807, 371);
            label15.Name = "label15";
            label15.Size = new Size(282, 121);
            label15.TabIndex = 19;
            label15.Text = "What is your grade?";
            // 
            // label16
            // 
            label16.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = SystemColors.Control;
            label16.Location = new Point(807, 331);
            label16.Name = "label16";
            label16.Size = new Size(999, 29);
            label16.TabIndex = 23;
            label16.Text = "-------------------------------------------------------";
            // 
            // label14
            // 
            label14.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.Control;
            label14.Location = new Point(817, 559);
            label14.Name = "label14";
            label14.Size = new Size(971, 86);
            label14.TabIndex = 24;
            label14.Text = "Q04 - Complex Statements ICS3U Only -5 marks -(bonus for ICS3C)";
            // 
            // q04InstructionButton
            // 
            q04InstructionButton.Location = new Point(886, 648);
            q04InstructionButton.Name = "q04InstructionButton";
            q04InstructionButton.Size = new Size(817, 52);
            q04InstructionButton.TabIndex = 25;
            q04InstructionButton.Text = "Click here for instructions for question 04";
            q04InstructionButton.UseVisualStyleBackColor = true;
            q04InstructionButton.Click += q04InstructionButton_Click;
            // 
            // label17
            // 
            label17.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = SystemColors.Control;
            label17.Location = new Point(807, 692);
            label17.Name = "label17";
            label17.Size = new Size(999, 29);
            label17.TabIndex = 30;
            label17.Text = "-------------------------------------------------------";
            // 
            // q4OutputLabel
            // 
            q4OutputLabel.BorderStyle = BorderStyle.FixedSingle;
            q4OutputLabel.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            q4OutputLabel.ForeColor = SystemColors.Control;
            q4OutputLabel.Location = new Point(833, 941);
            q4OutputLabel.Name = "q4OutputLabel";
            q4OutputLabel.Size = new Size(913, 70);
            q4OutputLabel.TabIndex = 29;
            q4OutputLabel.Click += label18_Click;
            // 
            // q4Button
            // 
            q4Button.Location = new Point(1553, 755);
            q4Button.Name = "q4Button";
            q4Button.Size = new Size(150, 46);
            q4Button.TabIndex = 28;
            q4Button.Text = "Code Me!";
            q4Button.UseVisualStyleBackColor = true;
            q4Button.Click += q4Button_Click;
            // 
            // q4TempTextBox
            // 
            q4TempTextBox.Location = new Point(1293, 761);
            q4TempTextBox.Name = "q4TempTextBox";
            q4TempTextBox.Size = new Size(200, 25);
            q4TempTextBox.TabIndex = 27;
            // 
            // label19
            // 
            label19.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label19.ForeColor = SystemColors.Control;
            label19.Location = new Point(817, 745);
            label19.Name = "label19";
            label19.Size = new Size(439, 83);
            label19.TabIndex = 26;
            label19.Text = "What is the temperature in degrees Celcius?";
            // 
            // q4CoatTextBox
            // 
            q4CoatTextBox.Location = new Point(1293, 858);
            q4CoatTextBox.Name = "q4CoatTextBox";
            q4CoatTextBox.Size = new Size(200, 25);
            q4CoatTextBox.TabIndex = 32;
            // 
            // label20
            // 
            label20.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label20.ForeColor = SystemColors.Control;
            label20.Location = new Point(817, 842);
            label20.Name = "label20";
            label20.Size = new Size(439, 83);
            label20.TabIndex = 31;
            label20.Text = "Did you bring a coat (y/n)?";
            // 
            // label18
            // 
            label18.Font = new Font("Consolas", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label18.ForeColor = Color.FromArgb(255, 255, 128);
            label18.Location = new Point(817, 1047);
            label18.Name = "label18";
            label18.Size = new Size(999, 48);
            label18.TabIndex = 33;
            label18.Text = "Error handling Required in  Q03 and Q04 (Try/Catch)";
            // 
            // bonusButton
            // 
            bonusButton.Location = new Point(1193, 1112);
            bonusButton.Name = "bonusButton";
            bonusButton.Size = new Size(225, 96);
            bonusButton.TabIndex = 34;
            bonusButton.Text = "Bonus Question +1 marks";
            bonusButton.UseVisualStyleBackColor = true;
            bonusButton.Click += bonusButton_Click;
            // 
            // q3LabelGood
            // 
            q3LabelGood.AutoSize = true;
            q3LabelGood.Location = new Point(33, 970);
            q3LabelGood.Name = "q3LabelGood";
            q3LabelGood.Size = new Size(0, 18);
            q3LabelGood.TabIndex = 35;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1818, 1055);
            Controls.Add(q3LabelGood);
            Controls.Add(bonusButton);
            Controls.Add(label18);
            Controls.Add(q4CoatTextBox);
            Controls.Add(label20);
            Controls.Add(label17);
            Controls.Add(q4OutputLabel);
            Controls.Add(q4Button);
            Controls.Add(q4TempTextBox);
            Controls.Add(label19);
            Controls.Add(q04InstructionButton);
            Controls.Add(label14);
            Controls.Add(label16);
            Controls.Add(q3OutputLabel);
            Controls.Add(q3Button);
            Controls.Add(q3TextBox);
            Controls.Add(label15);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label9);
            Controls.Add(q2OutputLabel);
            Controls.Add(q2Button);
            Controls.Add(q2TextBox);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(q1OutputLabel);
            Controls.Add(q1Button);
            Controls.Add(q1TextBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Quiz 02 'Iffing'";
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
        private TextBox q1TextBox;
        private Button q1Button;
        private Label q1OutputLabel;
        private Label label7;
        private Label label8;
        private Label q2OutputLabel;
        private Button q2Button;
        private TextBox q2TextBox;
        private Label label10;
        private Label label11;
        private Label label9;
        private Label label12;
        private Label label13;
        private Label q3OutputLabel;
        private Button q3Button;
        private TextBox q3TextBox;
        private Label label15;
        private Label label16;
        private Label label14;
        private Button q04InstructionButton;
        private Label label17;
        private Label q4OutputLabel;
        private Button q4Button;
        private TextBox q4TempTextBox;
        private Label label19;
        private TextBox q4CoatTextBox;
        private Label label20;
        private Label label18;
        private Button bonusButton;
        private Label q3LabelGood;
    }
}
