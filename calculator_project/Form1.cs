namespace calculator_project
{
    public partial class Form1 : Form
    {
        string operater = "";
        decimal calculated = 0;

        public void GetResultValue()
        {
            if (result.Text != "" && result.Text != "+" && result.Text != "-" && result.Text != "/" && result.Text != "*")
            {
                calculated = Convert.ToDecimal(result.Text);
                
            }
        }

        //public void checkOprator()
        //{
        //    if (result.Text = "+" || result.Text = "-" || result.Text = "/" || result.Text != "x")
        //    {

        //    }

        //}
        public Form1()
        {
            InitializeComponent();
            
        }
        private void button1_Click(object sender, EventArgs e)

        {
            
            string data = result.Text;

            result.Text = String.Empty;


        }

        private void button2_Click(object sender, EventArgs e)

        {

            result.Text = "%";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (result.Text == "+" || result.Text == "-" || result.Text == "/" || result.Text == "*" || result.Text == "%")
            {
                result.Text = "7";

            }
            else
            {
                string data = result.Text;
                result.Text = data + "7";

            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            GetResultValue();
            operater = "*";
            result.Text = "*";

        }
        private void button4_Click(object sender, EventArgs e)
        {
            GetResultValue();
            operater = "/";
            result.Text = "/";

        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (result.Text == "+" || result.Text == "-" || result.Text == "/" || result.Text == "*" || result.Text == "%")
            {
                result.Text = "8";

            }
            else
            {
                string data = result.Text;
                result.Text = data + "8";

            }

        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (result.Text == "+" || result.Text == "-" || result.Text == "/" || result.Text == "*" || result.Text == "%")
            {
                result.Text = "9";

            }
            else
            {
                string data = result.Text;
                result.Text = data + "9";

            }

        }
        private void button8_Click(object sender, EventArgs e)
        {
           
            GetResultValue();
            operater = "-";
            result.Text = "-";

        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (result.Text == "+" || result.Text == "-" || result.Text == "/" || result.Text == "*" || result.Text == "%")
            {
                result.Text = "4";

            }
            else
            {
                string data = result.Text;
                result.Text = data + "4";

            }

        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (result.Text == "+" || result.Text == "-" || result.Text == "/" || result.Text == "*" || result.Text == "%")
            {
                result.Text = "5";

            }
            else
            {
                string data = result.Text;
                result.Text = data + "5";

            }

        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (result.Text == "+" || result.Text == "-" || result.Text == "/" || result.Text == "*" || result.Text == "%")
            {
                result.Text = "6";

            }
            else
            {
                string data = result.Text;
                result.Text = data + "6";

            }

        }
        private void button12_Click(object sender, EventArgs e)
        {
            
                                                               
            
            GetResultValue();
            
                
;           operater = "+";
            result.Text = "+";

        }
        private void button13_Click(object sender, EventArgs e)
        {
            if (result.Text =="+" || result.Text =="-" || result.Text == "/" || result.Text == "*" || result.Text == "%")
            {
                result.Text =  "1";

            }
            else
            {
                string data = result.Text;
                result.Text = data + "1";

            }
             

        }
        private void button14_Click(object sender, EventArgs e)
        {
            if (result.Text == "+" || result.Text == "-" || result.Text == "/" || result.Text == "*" || result.Text == "%")
            {
                result.Text = "2";

            }
            else
            {
                string data = result.Text;
                result.Text = data + "2";

            }

        }
        private void button15_Click(object sender, EventArgs e)
        {
            if (result.Text == "+" || result.Text == "-" || result.Text == "/" || result.Text == "*" || result.Text == "%")
            {
                result.Text = "3";

            }
            else
            {
                string data = result.Text;
                result.Text = data + "3";

            }

        }
        private void button16_Click(object sender, EventArgs e)
        {
            string data = result.Text;
            if(data.Contains("("))
                {
                result.Text = data + ")";
            }
            else
            {
                result.Text = "(" + data;
            }
            

        }
        private void button17_Click(object sender, EventArgs e)
        {
            string data = result.Text;
            result.Text = data+ "0";

        }
        private void button18_Click(object sender, EventArgs e)
        {
            result.Text = ".";

        }
        private void button19_Click(object sender, EventArgs e)
        {
            string data = result.Text;
            result.Text = data.Remove(data.Length - 1);

        }

        private void button20_Click(object sender, EventArgs e)
        {
            decimal firstNum = calculated;
            decimal secondNum = Convert.ToDecimal(result.Text);

            switch(operater)
            {
                case "+":
                    calculated = (firstNum + secondNum);
                    result.Text = calculated.ToString();
                    break;
                case "-":
                    calculated = (firstNum - secondNum);
                    result.Text = calculated.ToString();
                    break;
                case "*":
                    calculated = (firstNum * secondNum);
                    result.Text = calculated.ToString();
                    break;
                case "/":
                    calculated = (firstNum /secondNum);
                    result.Text = calculated.ToString();
                    break;
                case "%":
                    calculated = (firstNum % secondNum);
                    result.Text = calculated.ToString();
                    break;





            }
            




        }
        private void button21_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 EmployeeForm = new Form2();
            EmployeeForm.ShowDialog();
            //EmployeeForm.Show();


        }

    }
}