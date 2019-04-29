using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APM_Spravka_Admin
{
    class Country
    {
        private int id;
        private int code;
        private string content;

        public Country(int id, int code, string content)
        {
            this.id = id;
            this.code = code;
            this.content = content;
        }

        public Country()
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

        public string Content
        {
            get => content;
            set => content = value;
        }
    }
}
