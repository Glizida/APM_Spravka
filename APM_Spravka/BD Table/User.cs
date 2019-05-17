using System;
using System.Collections.Generic;
using System.Linq;
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

        public User()
        {
        }

        public User(int idUser, string loginUser, string passwordUser, int levelAccess)
        {
            this.idUser = idUser;
            this.loginUser = loginUser;
            this.passwordUser = passwordUser;
            this.levelAccess = levelAccess;
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
    }
}
