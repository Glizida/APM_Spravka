using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APM_Spravka
{
    public class RecordCSIndex
    {
        private string mounth;
        private decimal doxod;
        private Int32 index;

        public RecordCSIndex(string mounth, decimal doxod, int index)
        {
            this.mounth = mounth;
            this.doxod = doxod;
            this.index = index;
        }

        public RecordCSIndex()
        {
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

        public int Index
        {
            get => index;
            set => index = value;
        }
    }


}
