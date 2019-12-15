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
    public partial class search_data : UserControl
    {
        MySqlConnection connect = new MySqlConnection("datasource= localhost; port=3306;Initial Catalog='hote ms';username = root; password=");

        public search_data()
        {
            InitializeComponent();
            
        }
        private void search_data_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = "SELECT *FROM reservation WHERE Id =" +int.Parse( cTextBox1.Text);
            MySqlCommand command = new MySqlCommand(a,connect);
            MySqlDataAdapter dpt = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            dpt.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
