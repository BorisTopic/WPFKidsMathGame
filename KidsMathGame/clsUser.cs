using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program5
{
    public class clsUser
    {
        /// <summary>
        /// Stores user name.
        /// </summary>
        private string userName;
        /// <summary>
        /// Stores user age.
        /// </summary>
        private int userAge;
        /// <summary>
        /// Get and Set for userName.
        /// </summary>
        public string UserName { get => userName; set => userName = value; }
        /// <summary>
        /// Get and Set for userAge.
        /// </summary>
        public int UserAge { get => userAge; set => userAge = value; }
    }
}
