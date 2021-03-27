using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gibdd_drivers
{
    public partial class Drivers : Form
    {
        public Drivers()
        {
            InitializeComponent();
        }

        private void driverBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.driverBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_DriversDataSet);

        }

        private void Drivers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_DriversDataSet.Driver". При необходимости она может быть перемещена или удалена.
            this.driverTableAdapter.Fill(this.dB_DriversDataSet.Driver);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Authorization f = new Authorization();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            License f = new License();
            f.Show();
        }
    }
}
