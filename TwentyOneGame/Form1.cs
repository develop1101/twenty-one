//==========================================================================
// Twenty One Game
// This program lets the user roll the two dices twice! 
// If the total number of the first roll and the second roll is 21, you win.
// If the total number is equal to or more than 15, you can roll the Third dice.
// When you roll the third dice, you win if the total number of the first roll and
// the second roll and the the number of the third dice equal to 21.
//=============================================================================//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwentyOneGame
{
    public partial class TwentyOne : Form
    {
        // variables for Dice1, Dice2, and Dice3
        int dice1, dice2, dice3;

        // variable for a total number
        int total = 0;

        // create a Random object
        Random random = new Random();

        public TwentyOne()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //********************** Roll the Dice Button Click Handler *************************
        private void btnRollDice_Click(object sender, EventArgs e)
        {
            // call RolltheDice() method to roll the two dices for the first time
            RolltheDice();
            // print the number of dice1 and the number of dice2 and the total to the first Label.
            lblTotal1.Text = dice1 + " + " + dice2 + " = " + total.ToString();

            // call RolltheDice() method to roll the two dices for the second time
            RolltheDice();
            // print the number of dice1 and the number of dice2 and the total to the second Label.
            lblTotal2.Text = dice1 + " + " + dice2 + " = " + total.ToString();

            // add the total number of the first roll and the second roll.
            total += total;

            // if the total equals to 21,
            if (total == 21)
            {
                // pop up the message to inform the user wins the game.
                MessageBox.Show("You won!");
                // disable the roll the dice button.
                btnRollDice.Enabled = false;
            }
            // if the total equals to or more than 15
            else if(total >= 15)
            {
                // pop up the message to inform that the user can roll one more dice
                MessageBox.Show("Roll the Third Dice!");
                // disable the first dice and the second dice
                lblDice1.Enabled = false;
                lblDice2.Enabled = false;
                // enable the third dice
                lblDice3.Enabled = true;

                // call the DiceThree() method for the third dice.
                DiceThree();
                // set the random number between 1 to 6 to dice3.
                dice3 = random.Next(1, 6);
                // print the random number to the dice3 label.
                lblDice3.Text = dice3.ToString();

                // add the dice3 number to the total number
                total += dice3;
                // print the total number
                lblTotal3.Text = total.ToString();
                
                // if the total number is equal to 21, pop up the winning message and disable the roll dice button.
                if (total == 21)
                {
                    MessageBox.Show("You won!");
                    btnRollDice.Enabled = false;
                }
                // else, pop up the losing message and disable the roll dice button.
                else
                {
                    MessageBox.Show("You lose!");
                    btnRollDice.Enabled = false;
                }
            }
            // else, pop up the losing message and disable the roll dice button
            else
            {
                MessageBox.Show("You lose!");
                btnRollDice.Enabled = false;
            }
            
        }// end the roll dice button click handler

        //*********************** Reset Button Click Hander *************************
        private void btnReset_Click(object sender, EventArgs e)
        {
            // enable the roll the dice button
            btnRollDice.Enabled = true;
            
            // enable the dice1 and dice2 
            lblDice1.Enabled = true;
            lblDice2.Enabled = true;
            // disable the dice3
            lblDice3.Enabled = false;

            // set three dices to null
            lblDice1.Text = "";
            lblDice2.Text = "";
            lblDice3.Text = "";

            // set three total labels to null
            lblTotal1.Text = "";
            lblTotal2.Text = "";
            lblTotal3.Text = "";

            // set total to zero
            total = 0;
        }

        //************************ RolltheDice() Method *******************
        private void RolltheDice()
        {
            // Call the DiceOne() method
            DiceOne();
            // set the dice1 as the random number between 1 to 6
            dice1 = random.Next(1, 6);
            // print the random number
            lblDice1.Text = dice1.ToString();

            // Call the DiceTwo() method
            DiceTwo();
            // set the dice2 as the random number between 1 to 6
            dice2 = random.Next(1, 6);
            // print the random number 
            lblDice2.Text = dice2.ToString();

            // add the dice1 and dice2 number to total
            total = dice1 + dice2;

        }

        //********************* DiceOne() method **********************
        private void DiceOne()
        {
            switch (dice1)
            {
                case 1:
                    lblDice1.Text = "1";
                    break;
                case 2:
                    lblDice1.Text = "2";
                    break;
                case 3:
                    lblDice1.Text = "3";
                    break;
                case 4:
                    lblDice1.Text = "4";
                    break;
                case 5:
                    lblDice1.Text = "5";
                    break;
                case 6:
                    lblDice1.Text = "6";
                    break;
            }
        }
        //*************************** DiceTwo() method *********************
        private void DiceTwo()
        {
            switch (dice2)
            {
                case 1:
                    lblDice2.Text = "1";
                    break;
                case 2:
                    lblDice2.Text = "2";
                    break;
                case 3:
                    lblDice2.Text = "3";
                    break;
                case 4:
                    lblDice2.Text = "4";
                    break;
                case 5:
                    lblDice2.Text = "5";
                    break;
                case 6:
                    lblDice2.Text = "6";
                    break;
            }
        }
        //************************ DiceThree() method **********************
        private void DiceThree()
        {
            switch (dice3)
            {
                case 1:
                    lblDice3.Text = "1";
                    break;
                case 2:
                    lblDice3.Text = "2";
                    break;
                case 3:
                    lblDice3.Text = "3";
                    break;
                case 4:
                    lblDice3.Text = "4";
                    break;
                case 5:
                    lblDice3.Text = "5";
                    break;
                case 6:
                    lblDice3.Text = "6";
                    break;
            }
        }
    }
}
