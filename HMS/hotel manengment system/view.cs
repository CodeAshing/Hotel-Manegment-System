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
    public partial class view : UserControl
    {
        public view()
        {
            InitializeComponent();
        }
        MySqlConnection connect = new MySqlConnection("datasource= localhost; port=3306;Initial Catalog='hote ms';username = root; password=");

        public void dataupload()
        {

            string select = "SELECT * FROM reservation";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(select, connect);
            //adapter.Fill(table);
            viewr.DataSource = table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataupload();
        }

        private void view_Load(object sender, EventArgs e)
        {
            dataupload();
            
        }

        private void update_Click(object sender, EventArgs e)
        {
            dataupload();
        }
    }
}
