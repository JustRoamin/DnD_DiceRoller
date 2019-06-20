/* Creator:     Joshua M. Haddix
 * Created:     5/12/19
 * Updated:     6/20/19
 * version:     v1.01
 * Project Description: Dice Roller to be used for Dungeons and Dragons 
*/
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

        //  Clear Button: resets all values entered previously to zero and clears the output text box
        private void button1_Click(object sender, EventArgs e)
        {
            clear();
        }

        //  Roll Button: Simulates a dice roll based on previously inputted information
        private void button2_Click(object sender, EventArgs e)
        {
            if (checkValidation() == false)
                validator();
            else
                roll();
        }

        // Helper function to insure that the entered values are integers stopping exception errors being thrown by non-integer values
        private void validator()
        {
            for (int x = 0; x < 8; x++)
            {
                int checker;
                bool check1 = int.TryParse(maskedTextBox1.Text, out checker);
                bool check2 = int.TryParse(maskedTextBox2.Text, out checker);
                bool check3 = int.TryParse(maskedTextBox3.Text, out checker);
                bool check4 = int.TryParse(maskedTextBox4.Text, out checker);
                bool check5 = int.TryParse(maskedTextBox5.Text, out checker);
                bool check6 = int.TryParse(maskedTextBox6.Text, out checker);
                bool check7 = int.TryParse(maskedTextBox7.Text, out checker);
                bool check8 = int.TryParse(maskedTextBox8.Text, out checker);

                if (check1 == false)
                {
                    maskedTextBox1.Text = "0";
                }
                else if (check2 == false)
                {
                    maskedTextBox2.Text = "0";
                }
                else if (check3 == false)
                {
                    maskedTextBox3.Text = "0";
                }
                else if (check4 == false)
                {
                    maskedTextBox4.Text = "0";
                }
                else if (check5 == false)
                {
                    maskedTextBox5.Text = "0";
                }
                else if (check6 == false)
                {
                    maskedTextBox6.Text = "0";
                }
                else if (check7 == false)
                {
                    maskedTextBox7.Text = "0";
                }
                else if (check8 == false)
                {
                    maskedTextBox8.Text = "0";
                }
            }

        }

        // Rolling simulation function: After integers values have been confirmed they are parsed and used as limits to determine how many
        // times each individual type of dice is rolled randomly. All of these values are then added together and the result is returned.
        private void roll()
        {
            Random rand = new Random();

            int d4 = 0;
            int d6 = 0;
            int d8 = 0;
            int d10 = 0;
            int d12 = 0;
            int d20 = 0;
            int d100 = 0;

            int numberRolled1 = Int32.Parse(maskedTextBox1.Text);
            int numberRolled2 = Int32.Parse(maskedTextBox2.Text);
            int numberRolled3 = Int32.Parse(maskedTextBox3.Text);
            int numberRolled4 = Int32.Parse(maskedTextBox4.Text);
            int numberRolled5 = Int32.Parse(maskedTextBox5.Text);
            int numberRolled6 = Int32.Parse(maskedTextBox6.Text);
            int numberRolled7 = Int32.Parse(maskedTextBox7.Text);
            int modifier = Int32.Parse(maskedTextBox8.Text);

            d4 = rollAssistance(numberRolled1, 4);
            d6 = rollAssistance(numberRolled2, 6);
            d8 = rollAssistance(numberRolled3, 8);
            d10 = rollAssistance(numberRolled4, 10);
            d12 = rollAssistance(numberRolled5, 12);
            d20 = rollAssistance(numberRolled6, 20);
            d100 = rollAssistance(numberRolled7, 100);

            string mod = modifier.ToString();
            int result = d4 + d6 + d8 + d10 + d12 + d20 + d100 + modifier;
            string display = result.ToString();
            textBox1.AppendText(mod + "\r\n" + display + "\r\n \r\n");

        }

        //  Attempts to convert text box characters to integers, if this fails a false is returned to the individual check1-8
        //  if any of the individuals are false then the input is not valid and the validator will be run.
        private bool checkValidation()
        {
            int checker;
            bool check1 = int.TryParse(maskedTextBox1.Text, out checker);
            bool check2 = int.TryParse(maskedTextBox2.Text, out checker);
            bool check3 = int.TryParse(maskedTextBox3.Text, out checker);
            bool check4 = int.TryParse(maskedTextBox4.Text, out checker);
            bool check5 = int.TryParse(maskedTextBox5.Text, out checker);
            bool check6 = int.TryParse(maskedTextBox6.Text, out checker);
            bool check7 = int.TryParse(maskedTextBox7.Text, out checker);
            bool check8 = int.TryParse(maskedTextBox8.Text, out checker);

            if (check1 == false |
                check2 == false |
                check3 == false |
                check4 == false |
                check5 == false |
                check6 == false |
                check7 == false |
                check8 == false)
                return false;
            else
                return true;
        }

        //sets the input text boxes to 0's and the output textbox to be blank; reducing tedium on the users end to empty previous entries 
        private void clear()
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

        // simulates each dice types roll by the same number of times as the end condition. The dice type passed variable is used to determine
        // the different faces possible for that given dice. 
        private int rollAssistance(int endCondition, int diceType)
        {
            Random rand = new Random();
            int dice = 0;
            int faces = diceType + 1;

            for (int x = 1; x <= endCondition; x++)           //  Upper limit variable 
            {
                int number = rand.Next(1, faces);       //  Options for dice face are variable
                string holder = number.ToString();
                textBox1.AppendText(holder + " ");
                dice = dice + number;
            }
            return dice;
        }

    }
}
