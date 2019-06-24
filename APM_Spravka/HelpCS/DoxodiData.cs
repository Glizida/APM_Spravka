using System;

namespace APM_Spravka
{
    public class DoxodiData
    {
        private int cod;
        private string meciac;
        private int summa;
        private int index;

        public DoxodiData(int cod, string meciac, int summa, int index)
        {
            this.cod = cod;
            this.meciac = meciac;
            this.summa = summa;
            this.index = index;
        }

        public DoxodiData()
        {
        }

        public int Cod
        {
            get => cod;
            set => cod = value;
        }

        public string Meciac
        {
            get => meciac;
            set => meciac = value;
        }

        public int Summa
        {
            get => summa;
            set => summa = value;
        }

        public int Index
        {
            get => index;
            set => index = value;
        }

        public override string ToString()
        {
            string temp = Cod.ToString() + Meciac.ToString() + Summa.ToString() + Index.ToString();
            return temp;
        }

        public static DoxodiData splitData(string stroka)
        {
            var mass = stroka.Split('|');
            return new DoxodiData(Convert.ToInt32(mass[0]),mass[1],Convert.ToInt32(mass[2]),Convert.ToInt32(mass[3]));
        }
    }
}