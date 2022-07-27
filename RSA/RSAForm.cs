using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace RSA
{
    public partial class RSAForm : Form
    {
        string EncryptMessage;
        string DecryptMessage;
        string inputMessage;
        int nValue;
        int key;
        public RSAForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(InputTextFeld.Text.Length == 0) // if there is a input
            {
                MessageBox.Show("Please provide a valid input in the Plaintext text box", "Alert", MessageBoxButtons.OK,MessageBoxIcon.Warning);

            }
            else if (Encryptcheck.Checked == true)
            {
                Random random = new Random(); 
                int p = Program.GeneratePrimes(random.Next(64, 100), false); // choose a random number and use the gerate primes function to create a largest prime number
                int temp = Program.GeneratePrimes(random.Next(64, 100), false);
                int q = (temp == p) ? Program.GeneratePrimes(random.Next(64, 100), false) : temp; // check if p and q is same if is true change q to somthing else
                int n = p * q; // find n 
                int phin = (p - 1) * (q - 1); // find phin
                int eValue = Program.GeneratePrimes(phin, true); // generate a random prime value use phin and is also coprime with phin
                int d = key = Program.ExtendedEuclidean(eValue, phin); // slove d
                //Console.WriteLine("p is {0} and q is {1}, n is {2} and phin is {3}, e is {4}, D is {5}", p, q, n, phin, eValue, d, "\n");

                string str = inputMessage = InputTextFeld.Text; // get the input text
                var bytesform = Encoding.UTF8.GetBytes(str); // conver string to binary
                List<string> decryptResult = new List<string>();
                List<string> es = new List<string>();
                foreach (var i in bytesform) // for each byt in the list encrpt the value and decrpt the value save in a list
                {
                    int Encrypt = Program.square(i, eValue, n);
                    int Decrypt = Program.square(Encrypt, d, n);
                    decryptResult.Add((Encoding.ASCII.GetString(BitConverter.GetBytes(Decrypt))).Replace("\0", string.Empty));
                    //encryptResult.Add((Encoding.ASCII.GetString(BitConverter.GetBytes(Math.Sqrt(Encrypt)))).Replace("\0", string.Empty));
                    var charChar = Convert.ToChar((int)Math.Sqrt(Encrypt));
                    var b = Encoding.UTF8.GetBytes(charChar.ToString());
                    es.Add((Encoding.ASCII.GetString(b)).Replace("\0", string.Empty));
                }
                KeyText.Text = d.ToString(); // output text to key
                textBox1.Text = n.ToString(); // output text to n
                nValue = n;
                EncryptMessage = String.Join("", es);//String.Join("", encryptResult);
                DecryptMessage = String.Join("", decryptResult);
                OutputTextFeld.Text = (Encryptcheck.Checked == true) ? EncryptMessage : DecryptMessage; // out put the encrypt or decrpt message
            }else if (DecryptCheck.Checked == true)
            {
                if (KeyText.Text.Length <= 0 || textBox1.Text.Length <=0) // check if there is a input
                {
                    MessageBox.Show("Please provide a valid value of key or N", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    nValue = Convert.ToInt32(textBox1.Text.ToString()); // get the n for input
                    key = Convert.ToInt32(KeyText.Text.ToString()); // get the key form input
                    string str = inputMessage = InputTextFeld.Text; // conver string to bytes
                    var bytesform = Encoding.UTF8.GetBytes(str);
                    List<string> decryptResult = new List<string>();
                    foreach (var i in bytesform) // for each bytes decrpt the message 
                    {
                        int Decrypt = Program.square(i, key, nValue);
                        decryptResult.Add((Encoding.ASCII.GetString(BitConverter.GetBytes(Decrypt))).Replace("\0", string.Empty)); //add the message to list
                    }
                    DecryptMessage = String.Join("", decryptResult);// combine
                }

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //Encrypt check box event
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (DecryptCheck.Checked)
            {
                Encryptcheck.Checked = false;
                checkCheckBox();
            }
        }
        //Decrypt check box event
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (Encryptcheck.Checked)
            {
                DecryptCheck.Checked = false;
                checkCheckBox();
            }
        }

        private void checkCheckBox()
        {
            // change text basic on the check box that is check
            InputText.Text= (Encryptcheck.Checked == true)? "Plaintext: " : "Ciphertext:"; 
            OutputText.Text = (Encryptcheck.Checked == true) ? "Ciphertext: " : "Plaintext: ";
            label1.Visible =  textBox1.Visible = (Encryptcheck.Checked == true) ? false : true;

            //Assgin the value if exit
            if (Encryptcheck.Checked)
            {
                InputTextFeld.Text = (inputMessage != null)?inputMessage:"";
                OutputTextFeld.Text = EncryptMessage;
                KeyText.Text = key.ToString();
            }
            if (DecryptCheck.Checked)
            {
                InputTextFeld.Text = EncryptMessage;
                OutputTextFeld.Text = DecryptMessage;
                KeyText.Text = key.ToString();
            }

        }

        private void InputTextFeld_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
