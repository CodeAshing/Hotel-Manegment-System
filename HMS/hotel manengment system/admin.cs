using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace hotel_manengment_system
{
    
    public partial class admin : Form
    {
        MySqlConnection connect = new MySqlConnection("datasource= localhost; port=3306;Initial Catalog='hote ms';username = root; password=");
        
         public admin()
        {
            InitializeComponent();
            hpanel.Height = reservationb.Height;
            hpanel.Top = reservationb.Top;
            reservation1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hpanel.Height = reservationb.Height;
            hpanel.Top = reservationb.Top;
            reservation1.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            hpanel.Height= button2.Height;
            hpanel.Top = button2.Top;
            view1.BringToFront();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reservation1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            hpanel.Height = button1.Height;
            hpanel.Top = button1.Top;
            search_data1.BringToFront();
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            hpanel.Height = button3.Height;
            hpanel.Top = button3.Top;
            roomavail1.BringToFront();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login fo = new Login();
            fo.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void search_data1_Load(object sender, EventArgs e)
        {

        }

        private void view1_Load(object sender, EventArgs e)
        {

        }
    }
}
