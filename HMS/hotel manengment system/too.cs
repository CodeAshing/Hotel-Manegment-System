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
    public partial class too : UserControl
    {
        MySqlConnection connect = new MySqlConnection("datasource= localhost; port=3306;Initial Catalog='hote ms';username = root; password=");
        MySqlCommand command;
        public string clean, towel, sweet, lunch, breakfast, dinner;
        public too()
        {
            InitializeComponent();
        }
        void fillcombo()
        {

            listcb.Items.Clear();
            MySqlCommand combocommand = new MySqlCommand("select * from kitchen", connect);
            MySqlDataReader myreader;
            try
            {
                connect.Open(); ;

                myreader = combocommand.ExecuteReader();
                while (myreader.Read())
                {
                    string room = myreader.GetString("Roomnumber");
                    string name = myreader.GetString("Firstname");
                    string phone = myreader.GetString("Phonenumber");
                    string floor = myreader.GetString("Floor");
                    listcb.Items.Add(string.Concat(phone, " | ", room, "  |  ", name, "  |  ", floor));
                }
            }
            finally
            {
                connect.Close();
            }

        }
        public void openconnect()
        {
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
        }
        public void closeconnect()
        {
            if (connect.State == ConnectionState.Open)
            {
                connect.Close();
            }
        }
        public void execute(string insertion)
        {
            try
            {
                openconnect();
                command = new MySqlCommand(insertion, connect);

                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeconnect();
            }
        }

        private void updateBN_Click(object sender, EventArgs e)
        {
            string[] value = listcb.Text.Split(' ');

            if (fssCB.CheckState == CheckState.Checked)
            {               
                string deletDB = "DELETE FROM kitchen WHERE Phonenumber=" + double.Parse(value[0]);
                execute(deletDB);
            }
            else if (fssCB.CheckState == CheckState.Unchecked)
            {
                if (cCB.CheckState == CheckState.Checked)
                {
                    clean = "YES";
                }
                else
                {
                    clean = "NO";
                }
                if (ssCB.CheckState == CheckState.Checked)
                {
                    sweet = "YES";
                }
                else
                {
                    sweet = "NO";
                }

                if (tlCB.CheckState == CheckState.Checked)
                {
                    towel = "YES";
                }
                else
                {
                    towel = "NO";
                }
                string update = "UPDATE kitchen SET Breakfast='" + breakfast + "',Lunch='" + lunch + "',Dinner='" + dinner + "',Towel='" +towel+ "',Cleaning='" + clean + "',SpecialSurprise='" + sweet + "' WHERE Phonenumber=" + double.Parse(value[0]);
                execute(update);                
                fillcombo();

            }

            string report = "Report", message = "Entry successfully updated into database of Phone number: \n\n " + value[0];
            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBox.Show(message, report, button, MessageBoxIcon.Information);

            Nul();
            fillcombo();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            food_kitchen fk = new food_kitchen(this);
            fk.Show();
        }

        private void too_Load(object sender, EventArgs e)
        {
            fillcombo();
        }

        public void Nul()
        {

            fttb.Text = null;
            lstb.Text = null;
            rttb.Text = null;
            rmtb.Text = null;
            bttb.Text = null;
            lntb.Text = null;
            drtb.Text = null;
            clean = "NO";
            towel = "NO";
            sweet = "NO";
            breakfast = null;
            lunch = null;
            dinner = null;
            fssCB.Checked = false;
            ssCB.Checked = false;
            cCB.Checked = false;
            tlCB.Checked = false;
            listcb.Text = "                         LIST";
        }
        private void searchbutton_Click(object sender, EventArgs e)
        {
            string[] value = listcb.Text.Split(' ');
            MySqlDataReader sear;
            MySqlCommand command = new MySqlCommand("SELECT *FROM kitchen WHERE Phonenumber=" +Convert.ToDouble(value[0]), connect);

            try
            {
                openconnect();
                sear = command.ExecuteReader();
                while (sear.Read())
                {
                    fltb.Text = sear.GetString("Floor");
                    pntb.Text = value[0];
                    fttb.Text = sear.GetString("Firstname");
                    lstb.Text = sear.GetString("Lastname");
                    rttb.Text = sear.GetString("Roomtype");
                    rmtb.Text = sear.GetString("Roomnumber");
                    bttb.Text = sear.GetString("Breakfast");
                    lntb.Text = sear.GetString("Lunch");
                    drtb.Text = sear.GetString("Dinner");
                    clean = sear.GetString("Cleaning");
                    towel = sear.GetString("Towel");
                    sweet = sear.GetString("SpecialSurprise");
                    breakfast = sear.GetString("Breakfast");
                    lunch = sear.GetString("Lunch");
                    dinner = sear.GetString("Dinner");
                    if (clean == "YES")
                    {
                        cCB.Checked = true;
                    }
                    else
                    {
                        cCB.Checked = false;
                    }
                    if (sweet == "YES")
                    {
                        ssCB.Checked = true;
                    }else
                    {
                        ssCB.Checked = false;
                    }
                    if (towel == "YES")
                    {
                        tlCB.Checked = true;
                    }
                    else
                    {
                        tlCB.Checked = false;
                    }

                }
            }
            finally
            {
                closeconnect();
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    
}