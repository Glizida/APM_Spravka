namespace APM_Spravka.BD_Table
{
    public class UserData
    {
        private int idUserData;
        private int idUser;
        private string FullName;
        private int UNP;
        private int KeyOrgana;
        private string Telefon;
        private string God;

        public UserData()
        {
            
        }

        public UserData(int idUserData, int idUser, string fullName, int unp, int keyOrgana, string telefon, string god)
        {
            this.idUserData = idUserData;
            this.idUser = idUser;
            FullName = fullName;
            UNP = unp;
            KeyOrgana = keyOrgana;
            Telefon = telefon;
            God = god;
        }

        public int IdUserData
        {
            get => idUserData;
            set => idUserData = value;
        }

        public int IdUser
        {
            get => idUser;
            set => idUser = value;
        }

        public string fullName
        {
            get => FullName;
            set => FullName = value;
        }

        public int unp
        {
            get => UNP;
            set => UNP = value;
        }

        public int keyOrgana
        {
            get => KeyOrgana;
            set => KeyOrgana = value;
        }

        public string telefon
        {
            get => Telefon;
            set => Telefon = value;
        }

        public string god
        {
            get => God;
            set => God = value;
        }
    }
}