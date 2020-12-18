/*
 * 
 * Rhona Filgueras
 * Trivia Game GUI using buttons
 * 
 * December 17, 2020;
 * Trivia game code derived from Moo ICT youtube video
 * https://www.youtube.com/watch?v=hQDjz2ISklw&t=114s
 * 
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

namespace TriviaGameGUI
{
    public partial class Form1 : Form
    {

        // quiz game variables

        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;

        public Form1()
        {
            InitializeComponent();
            askQuestion(questionNumber);
            totalQuestions = 5;
        }

        private void checkAnswer(object sender, EventArgs e)
        {
            Button senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);
            if (buttonTag == correctAnswer)
            {
                score++;
            }

            // if all the questions have been asked we start calculating the player's score.
            if(questionNumber == totalQuestions)
            {
                // Work out the percentage
                // Since percentage was set as an int we are converting it with Math.Round() and
                // using the double() since it allows decimals (will help get a more accurate percentage).
                percentage = (int)Math.Round((double)(score * 100 / totalQuestions));

                MessageBox.Show(
                    "Quiz Ended" + Environment.NewLine +
                    "You have answered " + score + " questions correctly" + Environment.NewLine +
                    "Your total percentage is " + percentage + " %" + Environment.NewLine +
                    "Click OK to play again"                    
                    );

                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);
            }

            questionNumber++;
            askQuestion(questionNumber);
        }

        private void askQuestion(int qnum)
        {
            // Switch statement to show all the questions one at a time
            switch (qnum)
            {
                case 1:
                    QuestionLabel.Text = "1. When was the idea of the atom first introduced?";
                    button1.Text = "A) 400 B.C";
                    button2.Text = "B) 545 B.C.";
                    button3.Text = "C) 450 B.C.";
                    button4.Text = "D) 2020";

                    correctAnswer = 3;                    
                    break;
                case 2:
                    QuestionLabel.Text = "2. Which astronomer first discovered the sunspots on the sun?";
                    button1.Text = "A) Johannes Kepler";
                    button2.Text = "B) Galileo Galilei";
                    button3.Text = "C) Nicolaus Copernicus";
                    button4.Text = "D) Hugh Jackman";

                    correctAnswer = 2;                    
                    break;
                case 3:
                    QuestionLabel.Text = "3. It is a data type in C# that stores a true or false value.";
                    button1.Text = "Boolean";
                    button2.Text = "String";
                    button3.Text = "Double";
                    button4.Text = "Integers";

                    correctAnswer = 1;                    
                    break;
                case 4:
                    QuestionLabel.Text = "4. It is a data type in C# that stores a string of characters.";
                    button1.Text = "Boolean";
                    button2.Text = "String";
                    button3.Text = "Double";
                    button4.Text = "Integers";

                    correctAnswer = 2;
                    break;
                case 5:
                    QuestionLabel.Text = "5. It is a data type in C# that stores a whole number.";
                    button1.Text = "Boolean";
                    button2.Text = "String";
                    button3.Text = "Double";
                    button4.Text = "Integers";

                    correctAnswer = 4;
                    break;               
                default:
                    break;
            }
        }
    }
}
