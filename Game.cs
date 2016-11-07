using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            Random ranNumberGenerator = new Random();
            int randomNumber;
            randomNumber = ranNumberGenerator.Next(1, 11);

            string inputGuess = guessTextBox.Text;
            int guess = Convert.ToInt32(inputGuess);

            if (randomNumber == guess)
            { answerLabel.Text = "Random number: "+randomNumber+"\n Your Guess: " + guess + " is the magic number!!!! Congrats!!"; }
            else if (guess > randomNumber)
            { answerLabel.Text = "Random number: " + randomNumber + "\n Your Guess: " + guess + " is too high. "; }
            else if (guess < randomNumber)
            { answerLabel.Text= "Random number: " + randomNumber + "\n Your Guess: " + guess + " is too low."; }

        }
    }
}
