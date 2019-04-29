﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APM_Spravka_Admin.BD_Table
{
    class Stock
    {
        private int id;
        private int code;
        private string content;

        public Stock(int id, int code, string content)
        {
            this.id = id;
            this.code = code;
            this.content = content;
        }

        public Stock()
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
