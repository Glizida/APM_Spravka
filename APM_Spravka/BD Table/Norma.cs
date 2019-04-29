using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APM_Spravka_Admin.BD_Table
{
    public class Norma
    {
        private int id { get; set; }
        private int code { get; set; }
        private string content { get; set; }

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
