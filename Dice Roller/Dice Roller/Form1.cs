using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dice_Roller
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();          
        }
              

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "0";
            maskedTextBox2.Text = "0";
            maskedTextBox3.Text = "0";
            maskedTextBox4.Text = "0";
            maskedTextBox5.Text = "0";
            maskedTextBox6.Text = "0";
            maskedTextBox7.Text = "0";
            maskedTextBox8.Text = "0";
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            int numberRolled1 = Int32.Parse(maskedTextBox1.Text);
            int numberRolled2 = Int32.Parse(maskedTextBox2.Text);
            int numberRolled3 = Int32.Parse(maskedTextBox3.Text);
            int numberRolled4 = Int32.Parse(maskedTextBox4.Text);
            int numberRolled5 = Int32.Parse(maskedTextBox5.Text);
            int numberRolled6 = Int32.Parse(maskedTextBox6.Text);
            int numberRolled7 = Int32.Parse(maskedTextBox7.Text);
            int modifier = Int32.Parse(maskedTextBox8.Text);

            int d4 = 0;
            int d6 = 0;
            int d8 = 0;
            int d10 = 0;
            int d12 = 0;
            int d20 = 0;
            int d100 = 0;

            for (int x = 1; x <= numberRolled1; x++)
            {
                int number = rand.Next(1, 5);
                string holder = number.ToString();
                textBox1.AppendText(holder + " "); 
                d4 = d4 + number;
            }

            for (int x = 1; x <= numberRolled2; x++)
            {
                int number = rand.Next(1, 7);
                string holder = number.ToString();
                textBox1.AppendText(holder + " ");
                d6 = d6 + number;
            }

            for (int x = 1; x <= numberRolled3; x++)
            {
                int number = rand.Next(1, 9);
                string holder = number.ToString();
                textBox1.AppendText(holder + " ");
                d8 = d8 + number;
            }

            for (int x = 1; x <= numberRolled4; x++)
            {
                int number = rand.Next(1, 11);
                string holder = number.ToString();
                textBox1.AppendText(holder + " ");
                d10 = d10 + number;
            }

            for (int x = 1; x <= numberRolled5; x++)
            {
                int number = rand.Next(1, 13);
                string holder = number.ToString();
                textBox1.AppendText(holder + " ");
                d12 = d12 + number;
            }

            for (int x = 1; x <= numberRolled6; x++)
            {
                int number = rand.Next(1, 21);
                string holder = number.ToString();
                textBox1.AppendText(holder + " ");
                d20 = d20 + number;
            }

            for (int x = 1; x <= numberRolled7; x++)
            {
                int number = rand.Next(1, 101);
                string holder = number.ToString();
                textBox1.AppendText(holder + " ");
                d100 = d100 + number;
            }

            string mod = modifier.ToString();
            int result = d4 + d6 + d8 + d10 + d12 + d20 + d100 + modifier;
            string display = result.ToString();
            textBox1.AppendText(mod + "\r\n" + display + "\r\n \r\n");
        }

        
    }
}
