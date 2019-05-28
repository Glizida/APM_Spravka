using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APM_Spravka_Admin.BD_Table
{
    public class Norma
    {
        private int id;
        private int code;
        private string content;

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

        public Norma(int id, int code, string content)
        {
            this.id = id;
            this.code = code;
            this.content = content;
        }

        public Norma()
        {
        }
        public override string ToString()
        {
            return this.code + ":   " + this.content;
        }
    }
}
