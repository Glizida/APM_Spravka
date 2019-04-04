using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APM_Spravka
{
    public class RecordCS
    {
        private string mounth;
        private decimal doxod;

        public RecordCS()
        {
        }

        public RecordCS(string mounth, decimal doxod)
        {
            this.mounth = mounth;
            this.doxod = doxod;
        }

        public string Mounth
        {
            get => mounth;
            set => mounth = value;
        }

        public decimal Doxod
        {
            get => doxod;
            set => doxod = value;
        }
    }
}
