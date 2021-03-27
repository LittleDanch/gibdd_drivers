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
    public partial class License : Form
    {
        public License()
        {
            InitializeComponent();
        }

        private void driversLicenseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.driversLicenseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_DriversDataSet);

        }

        private void License_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_DriversDataSet.DriversLicense". При необходимости она может быть перемещена или удалена.
            this.driversLicenseTableAdapter.Fill(this.dB_DriversDataSet.DriversLicense);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Drivers f = new Drivers();
            f.Show();
        }
    }
}
