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

        public RecordCS(string mounth, decimal doxod)
        {
            Mounth = mounth;
            this.doxod = doxod;
        }

        public RecordCS()
        {
        }

        public string Mounth
        {
            get => Mounth;
            set => Mounth = value;
        }

        public decimal Doxod
        {
            get => doxod;
            set => doxod = value;
        }
    }
}
