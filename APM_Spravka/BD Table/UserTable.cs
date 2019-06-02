namespace APM_Spravka.BD_Table
{
    public class UserTable
    {
        private int idSviazi;
        private int idUser;
        private string unp;
        private string fio;
        private string namee;
        private string otch;
        private string doxod;
        private string nalog;

        public UserTable()
        {
        }

        public UserTable(int idSviazi, int idUser, string unp, string fio, string namee, string otch, string doxod, string nalog)
        {
            this.idSviazi = idSviazi;
            this.idUser = idUser;
            this.unp = unp;
            this.fio = fio;
            this.namee = namee;
            this.otch = otch;
            this.doxod = doxod;
            this.nalog = nalog;
        }

        public int IdSviazi
        {
            get => idSviazi;
            set => idSviazi = value;
        }

        public int IdUser
        {
            get => idUser;
            set => idUser = value;
        }

        public string Unp
        {
            get => unp;
            set => unp = value;
        }

        public string Fio
        {
            get => fio;
            set => fio = value;
        }

        public string Namee
        {
            get => namee;
            set => namee = value;
        }

        public string Otch
        {
            get => otch;
            set => otch = value;
        }

        public string Doxod
        {
            get => doxod;
            set => doxod = value;
        }

        public string Nalog
        {
            get => nalog;
            set => nalog = value;
        }
    }
}