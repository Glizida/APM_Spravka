using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APM_Spravka
{
    public class Spravka
    {
        public int Key { get; set; }
        public string Name { get; set; }

        public Spravka()
        {
        }

        public Spravka(int key, string name)
        {
            this.Key = key;
            this.Name = name;
        }
    }
}
