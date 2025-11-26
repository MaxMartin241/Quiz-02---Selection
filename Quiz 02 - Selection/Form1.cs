namespace Quiz_02___Selection
{
    public partial class Form1 : Form
    {
        int grade;
        int temp;
        String coat;
        public Form1()
        {
            InitializeComponent();
        }

        private void q04InstructionButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The user will enter the temperature in the first text box and answer if they brought a jacket in the second text box.  The output will be:\r\n\r\n“You should be comfortable” if If they brought a jacket and the temperature is below 15 , or they did not bring a jacket and the temperature is above 15\r\n\r\nIf they brought a jacket and the temperature is above 15 “You will be too hot”\r\n\r\nIf they did not bring a jacket and the temperature is below 15 “You are going to be cold”\r\n\r\nMake sure you add a try catch so there are no runtime errors.\r\n  For full marks use exactly three if statements ");
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void bonusButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Change the text in this message box to answer the question:  Provide an example to explain why you would choose 'if..else if' instead of repeated 'if' statements");
        }

        private void q1Button_Click(object sender, EventArgs e)
        {
            if (q1TextBox.Text == "banana")
            {
                q1OutputLabel.Text = "SECERET UNLOCKED";
            }
        }

        private void q2Button_Click(object sender, EventArgs e)
        {
            if (q2TextBox.Text == "r")
            {
                q3LabelGood.Text = "ROCK ON";
            }
            else if (q2TextBox.Text == "c")
            {
                q3LabelGood.Text = "GIDDY UP";
            }
        }

        private void q3Button_Click(object sender, EventArgs e)
        {
            try
            {
                grade = Convert.ToInt16(q3TextBox.Text);
                switch (grade)
                {
                    case <= 49:
                        q3OutputLabel.Text = "Fail";
                        break;

                    case >= 50 when grade < 80:
                        q3OutputLabel.Text = "passed";
                        break;
                    case >= 80:
                        q3OutputLabel.Text = "Excellent Effort";
                        break;
                }
            }
            catch
            {
                q3OutputLabel.Text = "Invalid response try a number like 67";
            }

        }

        private void q4Button_Click(object sender, EventArgs e)
        {
            try
            {
                temp = Convert.ToInt16(q4TempTextBox.Text);
                coat = q4CoatTextBox.Text;

                if (temp >= 15 && coat == "no" || temp < 15 && coat == "yes" || temp == 15)
                {
                    q4OutputLabel.Text = "You should be good";
                }
                else if (temp >= 15 && coat == "yes")
                {
                    q4OutputLabel.Text = "TOO hot";
                }
                else if (temp < 15 && coat == "no")
                {
                    q4OutputLabel.Text = "TOO cold";
                }
            }
            catch
            {
                q4OutputLabel.Text = "try 16 and yes make sure your putting it in right";
            }
        }
    }
}
