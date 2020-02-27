using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace hotel_manengment_system
{
    public partial class over : UserControl
    {
        MySqlConnection connect = new MySqlConnection("datasource= localhost; port=3306;Initial Catalog='hote ms';username = root; password=");

        public over()
        {            
            InitializeComponent();
            
        }
        public void dataupload()
        {

            string select = "SELECT * FROM kitchen";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(select, connect);
            //adapter.Fill(table);
           dataGridView1.DataSource = table;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void over_Load(object sender, EventArgs e)
        {
            dataupload();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void updateBN_Click(object sender, EventArgs e)
        {
            dataupload();

        }

        private void update_Click(object sender, EventArgs e)
        {
            dataupload();
        }

        private void updateBN_Click_1(object sender, EventArgs e)
        {
            dataupload();
        }
    }
}
