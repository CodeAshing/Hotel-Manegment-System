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
    public partial class bill : Form
    {
        public reservation ree;
        public bill(reservation ree)
        {
            this.ree = ree;            
            InitializeComponent();             
            int i;
            foodlabel.Text = Convert.ToString(ree.foodp);
            currentL.Text = Convert.ToString(ree.currentp);
            totalL.Text = Convert.ToString(ree.totalp);
            for (i = 1988; i < DateTime.Now.Year; i++)
            {
                comboBox3.Items.Add(i);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bill_Load(object sender, EventArgs e)
        {
        }

        private void foodlabel_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
