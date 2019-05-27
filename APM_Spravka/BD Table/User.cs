using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace APM_Spravka.BD_Table
{
    public class User
    {
        private int idUser;
        private string loginUser;
        private string passwordUser;
        private int levelAccess;
        private int idCreator;

        public User()
        {
        }

        public User(int idUser, string loginUser, string passwordUser, int levelAccess, int idCreator)
        {
            this.idUser = idUser;
            this.loginUser = loginUser;
            this.passwordUser = passwordUser;
            this.levelAccess = levelAccess;
            this.idCreator = idCreator;
        }

        public int IdUser
        {
            get => idUser;
            set => idUser = value;
        }

        public string LoginUser
        {
            get => loginUser;
            set => loginUser = value;
        }

        public string PasswordUser
        {
            get => passwordUser;
            set => passwordUser = value;
        }

        public int LevelAccess
        {
            get => levelAccess;
            set => levelAccess = value;
        }

        public int IdCreator
        {
            get => idCreator;
            set
            {
                if (value != null)
                {
                    idCreator = value;
                }
                else
                {
                    idCreator = 0;
                }
            }
        }

        //public override string ToString()
        //{
        //    return this.IdUser + "      " + this.LoginUser + "      " + this.PasswordUser + "       " +
        //           this.LevelAccess + "        " + this.IdCreator;
        //}
    }
}
