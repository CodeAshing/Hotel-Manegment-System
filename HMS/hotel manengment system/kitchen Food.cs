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
    public partial class food_kitchen : Form
    {
        
        too to;
        public food_kitchen(too to)
        {
            this.to = to;           
            
            InitializeComponent();
        }
        public void init()
        {
            dinner.Text = to.dinner;
            lun.Text = to.lunch;
            brea.Text = to.breakfast;
            if (to.breakfast != "0")
            {
                 breakfastCB.Checked= true;
            }
            else
            {
                breakfastCB.Checked = false;
            }
            if ( to.lunch != "0")
            {
                lunchCB.Checked = true;
            }
            else
            {
                lunchCB.Checked = false;
            }
            if (to.dinner != "0")
            {
                DinnerCB.Checked = true;
            }
            else
            {
                DinnerCB.Checked = false;
            }
        }

        private void food_kitchen_Load(object sender, EventArgs e)
        {
            init();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (breakfastCB.CheckState == CheckState.Checked)
            {
                if (brea.Text == "")
                {
                    string Discricption = "Fill the quantity of Breakfast";
                    MessageBox.Show(Discricption, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

            else if (breakfastCB.CheckState == CheckState.Unchecked)
            {
                brea.Text = 0.ToString();
            }
            if (lunchCB.CheckState == CheckState.Checked)
            {
                if (lun.Text == "")
                {
                    string Discricption = "Fill the quantity of Lunch";
                    MessageBox.Show(Discricption, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (lunchCB.CheckState == CheckState.Unchecked)
            {
                lun.Text = 0.ToString();
            }

            if (DinnerCB.CheckState == CheckState.Checked)
            {
                if (dinner.Text == "")
                {
                    string Discricption = "Fill the quantity of Dinner";
                    MessageBox.Show(Discricption, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (DinnerCB.CheckState == CheckState.Unchecked)
            {
                dinner.Text = 0.ToString();
            }
            to.dinner = dinner.Text;
            to.lunch = lun.Text;
            to.breakfast = brea.Text;
            this.Hide();
        }
    }
}
