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
    public partial class roomavail : UserControl
    {
        MySqlConnection connect = new MySqlConnection("datasource= localhost; port=3306;Initial Catalog='hote ms';username = root; password=");

        public roomavail()
        {

            
            InitializeComponent();

            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            adapter();
        }
        public void adapter()
        {
            string selectt = "SELECT * FROM reserved";
            DataTable tablee = new DataTable();
            MySqlDataAdapter adapterr = new MySqlDataAdapter(selectt, connect);
            //adapterr.Fill(tablee);
            reservedd.DataSource = tablee;

            string select = "SELECT * FROM Occupied";
            DataTable tabl = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(select, connect);
            //adapter.Fill(tabl);
            occupiedd.DataSource = tabl;
        }
        private void roomavail_Load(object sender, EventArgs e)
        {
            adapter();
        }

        private void reservedd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void update_Click(object sender, EventArgs e)
        {
            adapter();
        }
    }
}
