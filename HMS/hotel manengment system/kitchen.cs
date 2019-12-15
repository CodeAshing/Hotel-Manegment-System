using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_manengment_system
{
    public partial class room_service : Form
    {
        public room_service()
        {
            InitializeComponent();

            hpanel.Height = reservationb.Height;
            hpanel.Top = reservationb.Top;
            too1.BringToFront();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void reservationb_Click(object sender, EventArgs e)
        {
            hpanel.Height = reservationb.Height;
            hpanel.Top = reservationb.Top;
            too1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hpanel.Height = button3.Height;
            hpanel.Top = button3.Top;
            over1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login ff = new Login();
            ff.Show();
        }

        private void too1_Load(object sender, EventArgs e)
        {
        }

        private void too1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
