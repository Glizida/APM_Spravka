using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APM_Spravka
{
    public partial class Othet : Form
    {
        public Othet()
        {
            InitializeComponent();
        }

        private void Othet_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "nzzGtRxVKLDataSet.Rasdel2". При необходимости она может быть перемещена или удалена.
            this.Rasdel2TableAdapter.Fill(this.nzzGtRxVKLDataSet.Rasdel2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "nzzGtRxVKLDataSet.DoxodTable". При необходимости она может быть перемещена или удалена.
            this.DoxodTableTableAdapter.Fill(this.nzzGtRxVKLDataSet.DoxodTable);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "nzzGtRxVKLDataSet.Doxod". При необходимости она может быть перемещена или удалена.
            this.DoxodTableAdapter.Fill(this.nzzGtRxVKLDataSet.Doxod);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "nzzGtRxVKLDataSet.VznosiTabl1". При необходимости она может быть перемещена или удалена.
            this.VznosiTabl1TableAdapter.Fill(this.nzzGtRxVKLDataSet.VznosiTabl1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "nzzGtRxVKLDataSet.VznosiTabl2". При необходимости она может быть перемещена или удалена.
            this.VznosiTabl2TableAdapter.Fill(this.nzzGtRxVKLDataSet.VznosiTabl2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "nzzGtRxVKLDataSet.VznosiTabl3". При необходимости она может быть перемещена или удалена.
            this.VznosiTabl3TableAdapter.Fill(this.nzzGtRxVKLDataSet.VznosiTabl3);

            this.reportViewer1.RefreshReport();
        }
    }
}
