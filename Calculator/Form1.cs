namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()

        {
            InitializeComponent();
        }

        string op;
        double result;


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null && textBox1.Text == "0")
            {
                textBox1.Text = "0";

            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "12";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text + ",";

        }

        //BU KISIMDA ��LEMLER� YAPACA�IMIZ ���N B�R�NC� SAYI �LE �K�NC� SAYI LAZIM VE BUNLARI DOUBLE T�R�NDE ATIYORUZ

        double firstnumber;
        double secondnumber;
        private void button12_Click(object sender, EventArgs e)
        {
            firstnumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = null;
            op = "/";

        }

        private void button15_Click(object sender, EventArgs e)
        {
            firstnumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = null;
            op = "*";

        }

        private void button13_Click(object sender, EventArgs e)
        {
            firstnumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = null;
            op = "+";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            firstnumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = null;
            op = "-";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }


        
        
        private void button16_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
                {
                textBox1.Text = "De�er Bekleniyor!";
                return;
                }
            
            
                secondnumber = Convert.ToDouble(textBox1.Text);
                if (op == "+")
                {
                    result = (firstnumber + secondnumber);
                    textBox1.Text = Convert.ToString(result);
                    firstnumber = result; ;
                }
                else if (op == "-")
                {
                    result = (firstnumber - secondnumber);
                    textBox1.Text = Convert.ToString(result);
                    firstnumber = result;
                }
                else if (op == "*")
                {
                    result = (firstnumber * secondnumber);
                    textBox1.Text = Convert.ToString(result);
                    firstnumber = result;
                }
                else
                {
                    if (secondnumber == 0)
                    {
                        textBox1.Text = "!Tan�ms�z";
                        return;
                    }
                    else
                    {
                        result = (firstnumber / secondnumber);
                        textBox1.Text = Convert.ToString(result);
                        firstnumber = result;
                    }
                }
            }
        }
    }

