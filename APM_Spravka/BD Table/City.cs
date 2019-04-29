using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APM_Spravka_Admin.BD_Table
{
    class City
    {
        private int id;
        private int code;
        private string namee;
        private string obl;
        private string raion;
        private string sovet;
        private string derevnia;

        public City(int id, int code, string namee, string obl, string raion, string sovet, string derevnia)
        {
            this.id = id;
            this.code = code;
            this.namee = namee;
            this.obl = obl;
            this.raion = raion;
            this.sovet = sovet;
            this.derevnia = derevnia;
        }

        public City()
        {
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public int Code
        {
            get => code;
            set => code = value;
        }

        public string Namee
        {
            get => namee;
            set => namee = value;
        }

        public string Obl
        {
            get => obl;
            set => obl = value;
        }

        public string Raion
        {
            get => raion;
            set => raion = value;
        }

        public string Sovet
        {
            get => sovet;
            set => sovet = value;
        }

        public string Derevnia
        {
            get => derevnia;
            set => derevnia = value;
        }
    }
}
