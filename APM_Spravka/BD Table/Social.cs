﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APM_Spravka_Admin.BD_Table
{
    class Social
    {
        private int id;
        private int code;
        private string content;

        public Social(int id, int code, string content)
        {
            this.id = id;
            this.code = code;
            this.content = content;
        }

        public Social()
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
