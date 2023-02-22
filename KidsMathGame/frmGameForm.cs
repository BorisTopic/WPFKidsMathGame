using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Program5
{
    public partial class frmGameForm : Form
    {
        /// <summary>
        /// Handles the "business" logic of the game.
        /// </summary>
        public clsGame clsGame;
        /// <summary>
        /// Class where final scores are displayed.
        /// </summary>
        public frmFinalScore frmFinalScore;
        /// <summary>
        /// A timer.
        /// </summary>
        Timer MyTimer;
        /// <summary>
        /// Seconds for the timer.
        /// </summary>
        private int seconds = 0;
        /// <summary>
        /// Minutes for the timer.
        /// </summary>
        private int minutes = 0;
        /// <summary>
        /// Tells us if the game has begun.
        /// </summary>
        private bool isGameStarted = false;
        /// <summary>
        /// Keeps track of which question the user is on.
        /// </summary>
        private int questionNum = 0;
        /// <summary>
        /// Number of correct answers user guesess.
        /// </summary>
        private int numOfCorrectAnswers = 0;
        /// <summary>
        /// Number of incorrect answers user guesses.
        /// </summary>
        private int numOfIncorrectAnswers = 0;

        public frmGameForm()
        {
            InitializeComponent();


            MyTimer = new Timer();
            MyTimer.Interval = 1000;
            MyTimer.Tick += MyTimer_Tick;
        }

        /// <summary>
        /// Displays correct time for the timer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                seconds++;
                timerLabel.Text = TimeSpan.FromSeconds(seconds).ToString("mm\\:ss");
            }
            catch (Exception ex)
            {
                //Just throw the exception
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Handle the error.
        /// </summary>
        /// <param name="sClass">The class in which the error occurred in.</param>
        /// <param name="sMethod">The method in which the error occurred in.</param>
        private void HandleError(string sClass, string sMethod, string sMessage)
        {
            try
            {
                //Would write to a file or database here.
                MessageBox.Show(sClass + "." + sMethod + " -> " + sMessage);
            }
            catch (Exception ex)
            {
                System.IO.File.AppendAllText("C:\\Error.txt", Environment.NewLine +
                                             "HandleError Exception: " + ex.Message);
            }
        }

        /// <summary>
        /// Starts game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startButton_Click(object sender, EventArgs e)
        {
            try
            {
                isGameStarted = true;
                answerTextBox.Focus();
                MyTimer.Start();
                if (clsGame.gameType == "add")
                {
                    runAdditionGame();
                }
                if (clsGame.gameType == "subtract")
                {
                    runSubtractionGame();
                }
                if (clsGame.gameType == "multiply")
                {
                    runMiltiplicatonGame();
                }
                if (clsGame.gameType == "divide")
                {
                    runDivisionGame();
                }
            }
            catch (Exception ex)
            {
                //This is the top level method so we want to handle the exception
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// Cancels game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            try
            {
                MyTimer.Stop();
                seconds = 0;
                minutes = 0;
                timerLabel.Text = "Timer";
                numberOneLabel.Text = "-";
                numberTwoLabel.Text = "-";
                mathSignLabel.Text = "-";
                correctOrIncorrectLabel.Text = "";
                answerTextBox.Text = "";
                clsGame.gameType = null;
                questionNum = 0;
                this.Hide();
            }
            catch (Exception ex)
            {
                //This is the top level method so we want to handle the exception
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// Allows user to click the submit button to submit their answer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                answerTextBox.Focus();
                if (isGameStarted == true)
                {
                    //Tell the user if they are right or wrong.
                    if (clsGame.Answer.ToString() == answerTextBox.Text)
                    {
                        correctOrIncorrectLabel.Text = "Correct!";
                        correctOrIncorrectLabel.ForeColor = Color.Green;
                        numOfCorrectAnswers++;
                    }
                    else
                    {
                        correctOrIncorrectLabel.Text = "Incorrect!";
                        correctOrIncorrectLabel.ForeColor = Color.Red;
                        numOfIncorrectAnswers++;
                    }
                    //Clear away answer.
                    answerTextBox.Text = "";
                    //Add to questionNum to keep track of how many questions they've answered.
                    questionNum++;
                    //If they have not answered ten questions yet, display then next question.
                    if (questionNum <= 9 && clsGame.gameType == "add")
                    {
                        runAdditionGame();
                    }
                    else if (questionNum <= 9 && clsGame.gameType == "subtract")
                    {
                        runSubtractionGame();
                    }
                    else if (questionNum <= 9 && clsGame.gameType == "multiply")
                    {
                        runMiltiplicatonGame();
                    }
                    else if (questionNum <= 9 && clsGame.gameType == "divide")
                    {
                        runDivisionGame();
                    }
                    else
                    {
                        MyTimer.Stop();
                        frmFinalScore.CorrectAnswers = numOfCorrectAnswers;
                        frmFinalScore.IncorrectAnswers = numOfIncorrectAnswers;
                        frmFinalScore.Time = seconds;
                        this.Hide();
                        frmFinalScore.ShowDialog();
                    }


                }
            }
            catch (Exception ex)
            {
                //This is the top level method so we want to handle the exception
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// Allows user to hit enter to submit their answer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void answerTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (isGameStarted == true)
                {
                    //Only numbers and backspace
                    if (!(Char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)8))
                    {
                        if (e.KeyChar == (char)13)
                        {
                            if (clsGame.Answer.ToString() == answerTextBox.Text)
                            {
                                correctOrIncorrectLabel.Text = "Correct!";
                                correctOrIncorrectLabel.ForeColor = Color.Green;
                                numOfCorrectAnswers++;
                                //Clear away answer.
                                answerTextBox.Text = "";
                                //Add to questionNum to keep track of how many questions they've answered.
                                questionNum++;
                            }
                            else
                            {
                                correctOrIncorrectLabel.Text = "Incorrect!";
                                correctOrIncorrectLabel.ForeColor = Color.Red;
                                numOfIncorrectAnswers++;
                                //Clear away answer.
                                answerTextBox.Text = "";
                                //Add to questionNum to keep track of how many questions they've answered.
                                questionNum++;
                            }
                        }
                        else
                        {
                            // the pressed key is not a number or backspace
                            //prevent the character from being displayed in the textbox
                            e.Handled = true;
                        }

                        //If they have not answered ten questions yet, display then next question.
                        if (questionNum <= 9 && clsGame.gameType == "add")
                        {
                            runAdditionGame();
                        }
                        else if (questionNum <= 9 && clsGame.gameType == "subtract")
                        {
                            runSubtractionGame();
                        }
                        else if (questionNum <= 9 && clsGame.gameType == "multiply")
                        {
                            runMiltiplicatonGame();
                        }
                        else if (questionNum <= 9 && clsGame.gameType == "divide")
                        {
                            runDivisionGame();
                        }
                        else
                        {
                            MyTimer.Stop();
                            frmFinalScore.CorrectAnswers = numOfCorrectAnswers;
                            frmFinalScore.IncorrectAnswers = numOfIncorrectAnswers;
                            frmFinalScore.Time = seconds;
                            this.Hide();
                            frmFinalScore.ShowDialog();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //This is the top level method so we want to handle the exception
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }
 

        /// <summary>
        /// Plays addition game.
        /// </summary>
        private void runAdditionGame()
        {
            try
            {
                clsGame.additionGameType();
                numberOneLabel.Text = clsGame.NumberOne.ToString();
                numberTwoLabel.Text = clsGame.NumberTwo.ToString();
                mathSignLabel.Text = clsGame.MathSign;
            }
            catch (Exception ex)
            {
                //Just throw the exception
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }
        /// <summary>
        /// Plays subtraction game.
        /// </summary>
        private void runSubtractionGame()
        {
            try
            {
                clsGame.subtractionGameType();
                numberOneLabel.Text = clsGame.NumberOne.ToString();
                numberTwoLabel.Text = clsGame.NumberTwo.ToString();
                mathSignLabel.Text = clsGame.MathSign;
            }
            catch (Exception ex)
            {
                //Just throw the exception
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }
        /// <summary>
        /// Plays multiplicaton game.
        /// </summary>
        private void runMiltiplicatonGame()
        {
            try
            {
                clsGame.multiplicationGameType();
                numberOneLabel.Text = clsGame.NumberOne.ToString();
                numberTwoLabel.Text = clsGame.NumberTwo.ToString();
                mathSignLabel.Text = clsGame.MathSign;
            }
            catch (Exception ex)
            {
                //Just throw the exception
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }
        /// <summary>
        /// Plays division game.
        /// </summary>
        private void runDivisionGame()
        {
            try
            {
                clsGame.divisionGameType();
                numberOneLabel.Text = clsGame.NumberOne.ToString();
                numberTwoLabel.Text = clsGame.NumberTwo.ToString();
                mathSignLabel.Text = clsGame.MathSign;
            }
            catch (Exception ex)
            {
                //Just throw the exception
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }



    }
}
