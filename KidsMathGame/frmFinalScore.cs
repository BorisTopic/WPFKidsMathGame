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
using System.Media;

namespace Program5
{
    public partial class frmFinalScore : Form
    {
        /// <summary>
        /// Stores user's data.
        /// </summary>
        public clsUser clsUser;
        /// <summary>
        /// Stores the number of correct answers the user got.
        /// </summary>
        private int correctAnswers;
        /// <summary>
        /// Stores the number of incorrect answers the user got.
        /// </summary>
        private int incorrectAnswers;
        /// <summary>
        /// Stores the amount of time it took the user to answer all ten questions.
        /// </summary>
        private int time;
        /// <summary>
        /// Sounds of people clapping.
        /// </summary>
        SoundPlayer clappingSound = new SoundPlayer("clapping.wav");
        /// <summary>
        /// Sounds of a crowd cheering.
        /// </summary>
        SoundPlayer cheeringSound = new SoundPlayer("cheering.wav"); 
        /// <summary>
        /// Sounds of a crowd booing and yelling.
        /// </summary>
        SoundPlayer booingSound = new SoundPlayer("booing1.wav");

        public frmFinalScore()
        {
            InitializeComponent();

        }

        public frmFinalScore(clsUser user)
        {
            InitializeComponent();
            userNameDisplayLabel.Text = user.UserName;
            userAgeDisplayLabel.Text = user.UserAge.ToString();
        }

        /// <summary>
        /// Get and Set for correctAnswers.
        /// </summary>
        public int CorrectAnswers { get => correctAnswers; set => correctAnswers = value; }
        /// <summary>
        /// Get and Set for incorrectAnswers.
        /// </summary>
        public int IncorrectAnswers { get => incorrectAnswers; set => incorrectAnswers = value; }
        /// <summary>
        /// Get and Set for time.
        /// </summary>
        public int Time { get => time; set => time = value; }

        /// <summary>
        /// Displays the the correct answers, incorrect answers, and time it took the user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmFinalScore_Activated(object sender, EventArgs e)
        {
            try
            {
                correctAnswersDisplayLabel.Text = correctAnswers.ToString();
                incorrectAnswersDisplayLabel.Text = incorrectAnswers.ToString();
                timeToCompleteDisplayLabel.Text = TimeSpan.FromSeconds(time).ToString("mm\\:ss");

                
                if (correctAnswers <= 4)
                {
                    booingSound.Play();
                }
                else if (correctAnswers >= 5 && correctAnswers <= 7)
                {
                    clappingSound.Play();
                }
                else if (correctAnswers >= 8)
                {
                    cheeringSound.Play();
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
        /// Allows the user to close the Final Score Form and be sent back to the beginning.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                resetGame();
            }
            catch (Exception ex)
            {
                //This is the top level method so we want to handle the exception
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// Resets the scores of the previous game.
        /// </summary>
        private void resetGame()
        {
            try
            {
                correctAnswers = 0;
                incorrectAnswers = 0;
                time = 0;
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

    }
}
