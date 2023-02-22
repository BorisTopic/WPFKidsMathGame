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
    public partial class MainMenuWindow : Form
    {
        /// <summary>
        /// Class where the game is played.
        /// </summary>
        frmGameForm frmGameForm;
        /// <summary>
        /// Class where final scores are displayed.
        /// </summary>
        frmFinalScore frmFinalScore;
        /// <summary>
        /// Handles the "business" logic of the game.
        /// </summary>
        clsGame clsGame;
        /// <summary>
        /// Stores the user's information.
        /// </summary>
        clsUser clsUser;
        
        public MainMenuWindow()
        {
            InitializeComponent();

            frmGameForm = new frmGameForm();
            clsUser = new clsUser();
            //frmFinalScore = new frmFinalScore(clsUser);

            clsGame = new clsGame();
            frmGameForm.clsGame = this.clsGame;

            //frmGameForm.frmFinalScore = this.frmFinalScore;

            beginGameButton.Enabled = false;
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
        /// Validate user's name.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (userNameTextBox.Text == " " || userNameTextBox.Text == "")
                {
                    userNameErrorLabel.Text = "Please enter a valid name.";
                    beginGameButton.Enabled = false;
                }
                else
                {
                    userNameErrorLabel.Text = "";
                    if (userAgeTextBox.Text != "" && userAgeErrorLabel.Text == "")
                    {
                        beginGameButton.Enabled = true;
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
        /// Validate user's age.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userAgeTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var userAgeString = userAgeTextBox.Text;
                int userAge;
                if (int.TryParse(userAgeString, out userAge) && (userAge <= 10 && userAge > 2))
                {
                    userAgeErrorLabel.Text = "";
                    if (userNameErrorLabel.Text == "" && userNameTextBox.Text != "")
                    {
                        beginGameButton.Enabled = true;
                    }
                }
                else
                {
                    userAgeErrorLabel.Text = "Please enter a valid age.";
                    beginGameButton.Enabled = false;
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
        /// Allows the user to begin the game. This will also pass data to the user class to be used and reset the text boxes in preparation for the next game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void beginGameButton_Click(object sender, EventArgs e)
        {
            try
            {
                frmGameForm = new frmGameForm();
                frmGameForm.clsGame = this.clsGame;

                if (addRadioButton.Checked != true || subtractRadioButton.Checked != true || multiplyRadioButton.Checked != true || divideRadioButton.Checked != true)
                {
                    gameTypeErrorLabel.Text = "You need to pick a game!";
                }
                if (addRadioButton.Checked == true)
                {
                    gameTypeErrorLabel.Text = "";
                    clsGame.gameType = "add";
                    uploadUserData();
                    resetMenuForm();
                    this.Hide();
                    frmGameForm.ShowDialog();
                    this.Show();
                }
                if (subtractRadioButton.Checked == true)
                {
                    gameTypeErrorLabel.Text = "";
                    clsGame.gameType = "subtract";
                    uploadUserData();
                    resetMenuForm();
                    this.Hide();
                    frmGameForm.ShowDialog();
                    this.Show();
                }
                if (multiplyRadioButton.Checked == true)
                {
                    gameTypeErrorLabel.Text = "";
                    clsGame.gameType = "multiply";
                    uploadUserData();
                    resetMenuForm();
                    this.Hide();
                    frmGameForm.ShowDialog();
                    this.Show();
                }
                if (divideRadioButton.Checked == true)
                {
                    gameTypeErrorLabel.Text = "";
                    clsGame.gameType = "divide";
                    uploadUserData();
                    resetMenuForm();
                    this.Hide();
                    frmGameForm.ShowDialog();
                    this.Show();
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
        /// Passes the user's data to be stored in clsUser.
        /// </summary>
        private void uploadUserData()
        {
            try
            {
                clsUser.UserName = userNameTextBox.Text;
                clsUser.UserAge = int.Parse(userAgeTextBox.Text);
                frmFinalScore = new frmFinalScore(clsUser);
                frmGameForm.frmFinalScore = this.frmFinalScore;
            }
            catch (Exception ex)
            {
                //Just throw the exception
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }
        /// <summary>
        /// Resets the Main Menu Form.
        /// </summary>
        private void resetMenuForm()
        {
            try
            {
                userNameTextBox.Text = "";
                userAgeTextBox.Text = "";
                userNameErrorLabel.Text = "";
                userAgeErrorLabel.Text = "";
                addRadioButton.Checked = false;
                subtractRadioButton.Checked = false;
                multiplyRadioButton.Checked = false;
                divideRadioButton.Checked = false;
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
