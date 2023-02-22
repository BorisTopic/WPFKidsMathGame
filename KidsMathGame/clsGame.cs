using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Program5
{
    public class clsGame
    {
        /// <summary>
        /// Tells us which game type the user chose.
        /// </summary>
        public string gameType;
        /// <summary>
        /// First number presented in game.
        /// </summary>
        private int numberOne;
        /// <summary>
        /// Second number presented in game.
        /// </summary>
        private int numberTwo;
        /// <summary>
        /// Operator presented in game.
        /// </summary>
        private string mathSign;
        /// <summary>
        /// Correct for problem presented in game.
        /// </summary>
        private int answer;
        /// <summary>
        /// Generates a random number
        /// </summary>
        Random rand = new Random();
        /// <summary>
        /// Get and Set for numberOne.
        /// </summary>
        public int NumberOne { get => numberOne; set => numberOne = value; }
        /// <summary>
        /// Get and Set for numberTwo.
        /// </summary>
        public int NumberTwo { get => numberTwo; set => numberTwo = value; }
        /// <summary>
        /// Get and Set for mathSign.
        /// </summary>
        public string MathSign { get => mathSign; set => mathSign = value; }
        /// <summary>
        /// Get and Set for answer.
        /// </summary>
        public int Answer { get => answer; set => answer = value; }
        /// <summary>
        /// Creates the question for the addition game.
        /// </summary>
        public void additionGameType()
        {
            try
            {
                numberOne = rand.Next(1, 11);
                numberTwo = rand.Next(1, 11);
                mathSign = "+";
                answer = numberOne + numberTwo;
            }
            catch (Exception ex)
            {
                //Just throw the exception
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }
        /// <summary>
        /// Creates the question for the subtraction game.
        /// </summary>
        public void subtractionGameType()
        {
            try
            {
                int tempOne = rand.Next(1, 11);
                int tempTwo = rand.Next(1, 11);

                if (tempOne > tempTwo)
                {
                    numberOne = tempOne;
                    numberTwo = tempTwo;
                }
                else
                {
                    numberOne = tempTwo;
                    numberTwo = tempOne;
                }

                answer = numberOne - numberTwo;
                mathSign = "-";


            }
            catch (Exception ex)
            {
                //Just throw the exception
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }
        /// <summary>
        /// Creates the question for the multiplication game.
        /// </summary>
        public void multiplicationGameType()
        {
            try
            {
                numberOne = rand.Next(1, 11);
                numberTwo = rand.Next(1, 11);
                mathSign = "*";
                answer = numberOne * numberTwo;
            }
            catch (Exception ex)
            {
                //Just throw the exception
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }
        /// <summary>
        /// Creates the question for the division game.
        /// </summary>
        public void divisionGameType()
        {
            try
            {
                int temp;
                
                numberOne = rand.Next(1, 11);
                numberTwo = rand.Next(1, 11);
                answer = numberOne * numberTwo;
                temp = numberOne;
                numberOne = answer;
                answer = temp;
                mathSign = "/";
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
