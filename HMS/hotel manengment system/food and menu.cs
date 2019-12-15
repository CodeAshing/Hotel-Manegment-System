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
    public partial class food_and_menu : Form
    {
        reservation ree;
        public food_and_menu(reservation re)
        {
            this.ree = re;
            InitializeComponent();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void food_and_menu_Load(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
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

        private void cTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            loop:
            if (checkBox4.CheckState == CheckState.Checked)
            {
                if (breakfasttext.Text == "")
                {
                    string Discricption = "Fill the quantity of Breakfast";
                    MessageBox.Show(Discricption, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    goto loop;
                }

            }

            else if(checkBox4.CheckState == CheckState.Unchecked)
            {
                breakfasttext.Text = 0.ToString();
            }
            if (checkBox5.CheckState == CheckState.Checked)
            {
                if (luchtext.Text == "")
                {
                    string Discricption = "Fill the quantity of Lunch";
                    MessageBox.Show(Discricption, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    goto loop;
                }
            }
            else if(checkBox5.CheckState == CheckState.Unchecked)
            {
                luchtext.Text = 0.ToString();
            }

            if (checkBox6.CheckState == CheckState.Checked)
            {
                if (dinnertext.Text == "")
                {
                    string Discricption = "Fill the quantity of Dinner";
                    MessageBox.Show(Discricption, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    goto loop;
                }
            }
            else if(checkBox6.CheckState == CheckState.Unchecked)
            {
                dinnertext.Text = 0.ToString();
            }
            ree.foodp = (int.Parse(breakfasttext.Text) + int.Parse(luchtext.Text) + int.Parse(dinnertext.Text)) * 4;
            if (cleancb.CheckState==CheckState.Checked)
            {
                ree.clean = "YES";
            } 
            else if (cleancb.CheckState== CheckState.Unchecked)
            {
                ree.clean = "NO";
            }
            if (towelcb.CheckState == CheckState.Checked)
            {
                ree.towel = "YES";
            }
            else if (towelcb.CheckState == CheckState.Unchecked)
            {
                ree.towel = "NO";
            }
            if (sweetcb.CheckState == CheckState.Checked)
            {
                ree.sweet = "YES";
            }
            else if (sweetcb.CheckState == CheckState.Unchecked)
            {
                ree.sweet = "NO";
            }
            ree.dinner = dinnertext.Text;
            ree.breakfast = breakfasttext.Text;
            ree.lunch = luchtext.Text;
            this.Hide();
        }

    }
}
