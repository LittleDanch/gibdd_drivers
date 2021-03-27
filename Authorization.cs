using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gibdd_drivers
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        public int I;
        private int count = 1;

        private void authorizationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.authorizationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_DriversDataSet);

        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_DriversDataSet.Authorization". При необходимости она может быть перемещена или удалена.
            this.authorizationTableAdapter.Fill(this.dB_DriversDataSet.Authorization);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\ADMIN\source\repos\gibdd_drivers\DB_Drivers.mdf; Integrated Security = True");
            I = 0;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [Authorization] WHERE Login ='" + textBox1.Text + "' AND Password ='" + textBox2.Text + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            I = Convert.ToInt32(dt.Rows.Count.ToString());
            if (I == 0)
            {
                MessageBox.Show("Authentication error!");
                if (count++ == 10)
                {
                    this.Close();
                }
            }
            else
            {
                this.Hide();
                Drivers f = new Drivers();
                f.Show();
            }

            con.Close();
        }
    }
}
