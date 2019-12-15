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
    public partial class reservation : UserControl
    {
        MySqlConnection connect = new MySqlConnection("datasource= localhost; port=3306;Initial Catalog='hote ms';username = root; password=");
        public int foodp, totalp;
        public int currentp;
        public string towel, clean, sweet, breakfast,lunch,dinner;
        public reservation()
        {
            view v = new view();
            v.dataupload();
            InitializeComponent();
            fillcombo();               
            int i;
            for (i = 1988; i < DateTime.Now.Year; i++)
            {
                yearcb.Items.Add(i);
            }
            for (i = 1; i <= 31; i++)
            {
                daycb.Items.Add(i);
            }
        }
        void fillcombo()
        {
            reservsearchcb.Items.Clear();
            MySqlCommand combocommand = new MySqlCommand("select * from reservation", connect);
            MySqlDataReader myreader;
            try
            {
                connect.Open();;

                myreader = combocommand.ExecuteReader();
                while(myreader.Read())
                {
                    string id = myreader.GetString("Id");
                    string name = myreader.GetString("Firstname");
                    string phone = myreader.GetString("Phonenumber");
                    reservsearchcb.Items.Add(string.Concat(id," | ",name," | ",phone));
                    
                }
            }
            finally
            {
                connect.Close();
            }
           
        }
        public MySqlCommand command;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void nul()
        {
            firsttb.Text = null;
            lasttb.Text = null;
            daycb.Text = "Day";
            monthcb.Text = "Month";
            yearcb.Text = "Year";
            gendercb.Text = "____";
            phonetb.Text = null;
            emailcb.Text = null;
            streettb.Text = null;
            apttb.Text = null;
            statetb.Text = null;
            ziptb.Text =null;
            nofguestcb.Text = "# of guest";
            roomcb.Text ="Capacity";
            floorcb.Text ="Floor#";
            roomnucb.Text = "Room#";
            reserveCB.Checked = false;
            checkinCB.Checked = false;
            smsCB.Checked = false;
            reservsearchcb.Text = "Select Reservation to edit";
        } 


        private void button3_Click(object sender, EventArgs e)
        {
            string advreservation,sms,checkin,birth = (""+daycb.Text+" "+monthcb.Text+" "+yearcb.Text);
            if (smsCB.CheckState==CheckState.Checked)
            {
                sms = "YES";
            }
            else
            {
                sms = "NO";
            }
            if (checkinCB.CheckState == CheckState.Checked)
            {
                checkin = "YES";
            }
            else
            {
                checkin = "NO";
            }

            if (reserveCB.CheckState == CheckState.Checked)
            {
                advreservation = "YES";
            }
            else
            {
                advreservation = "NO";
            }

           string insert = "INSERT INTO reservation(Firstname, Lastname, Birthday, Gender, Phonenumber, Email, Address, AptorSuite, State, Zipcode, Noofguest, Roomtype, Floor, Roomnumber, Entrydate, Departuredate, checkin, sms, advancereservation, TotalPrice) VALUES('" + firsttb.Text + "','" + lasttb.Text + "','" + birth + "','" + gendercb.Text + "','" + phonetb.Text + "','" + emailcb.Text + "','" + streettb.Text + "','" + apttb.Text + "','" + statetb.Text + "','" + ziptb.Text + "','" + nofguestcb.Text + "','" + roomcb.Text + "','" + floorcb.Text + "','" + roomnucb.Text + "','" + dateTimeentry.Text + "','" + dateTimedeparture.Text + "','" + checkin + "','" + sms + "','" + advreservation + "','" + totalp + "')";
            execute(insert);
            if (foodp > 0 || clean=="YES" || towel == "YES" || sweet == "YES")
            {
                string kitchen = "INSERT INTO kitchen(Firstname, Lastname, Phonenumber, Roomnumber, Roomtype, Floor, Breakfast, Lunch, Dinner, Towel, Cleaning, SpecialSurprise, Foodbill) VALUES('" + firsttb.Text + "','" + lasttb.Text + "','" + phonetb.Text + "','" + roomnucb.Text + "','" + roomcb.Text + "','" + floorcb.Text + "','" + breakfast + "','" + lunch + "','" + dinner + "','" + towel + "','" + clean + "','" + sweet + "','" + foodp + "') ";
                execute(kitchen);
            }

            if (reserveCB.CheckState ==  CheckState.Checked)
            {
                string reservatDB= "INSERT INTO reserved(Roomnumber, Roomtype, Firstname, Lastname, Phonenumber, Entry, Departure) VALUES('"+roomnucb.Text+"','"+roomcb.Text+"','"+firsttb.Text+"','"+lasttb.Text+"','"+phonetb.Text+"','"+dateTimeentry.Text+"','"+dateTimedeparture.Text+"')";
                execute(reservatDB);

            }
            else if (reserveCB.CheckState == CheckState.Unchecked)
            {
                string occupiedDB = "INSERT INTO occupied(Roomnumber, Roomtype, Firstname, Lastname, Phone) VALUES('" + roomnucb.Text + "','" + roomcb.Text + "','" + firsttb.Text + "','" + lasttb.Text + "','" + phonetb.Text + "')";
                execute(occupiedDB);
            }
            breakfast = "0";
            lunch = "0";
            dinner = "0";
            towel = "NO";
            sweet = "NO";
            clean = "NO";
            totalp = 0;
            foodp = 0;
            currentp = 0;

            
                    string report = "Report", message = "Entry succcessfully inserted into database\n\nProvide the unique ID to the customer\n\nUSER UNIQUE ID: " ;
                    MessageBoxButtons button = MessageBoxButtons.OK;
                    MessageBox.Show(message, report, button, MessageBoxIcon.Information);
            
            nul();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            food_and_menu food = new food_and_menu(this);
            food.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            currentp = int.Parse(nofguestcb.Text)*20;
            if (clean == "YES")
            {
                currentp = currentp + 10;
            }
            if (sweet == "YES")
            {
                currentp = currentp +10;
            }
            if (towel == "YES")
            {
                currentp = currentp + 10;
            }
            totalp = currentp + foodp + 20;
            var billl = new bill(this);
            billl.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fillcombo();
            foodandmenubt.Hide();
            searchbutton.Show();
            update.Show();
            delete.Show();
            reservsearchcb.Show();
            button3.Hide();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foodandmenubt.Show();
            searchbutton.Hide(); 
            update.Hide();
            delete.Hide();
            reservsearchcb.Hide();
            button3.Show();
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        { 
            
        }

        private void reservation_Load(object sender, EventArgs e)
        {

        }

        public void openconnect()
        {
            if(connect.State==ConnectionState.Closed)
            {
                connect.Open();
            }
        }
        public void closeconnect()
        {
            if(connect.State==ConnectionState.Open)
            {
                connect.Close();
            }
        }
        public void execute(string insertion)
        {
            try
            {
                openconnect();
                command = new MySqlCommand(insertion,connect);

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
        public int chr;
        private void button6_Click(object sender, EventArgs e)
        {
            string[] value = reservsearchcb.Text.Split(' ');
            MySqlDataReader sear;
            MySqlCommand command = new MySqlCommand("SELECT *FROM reservation WHERE Id =" + int.Parse(value[0]) ,connect);

            try
            {
                openconnect();
                sear = command.ExecuteReader();
                while (sear.Read())
                {
                    string birth = sear.GetString("Birthday");
                    string[] birthadapter = birth.Split();
                    firsttb.Text = sear.GetString("Firstname");
                    lasttb.Text = sear.GetString("Lastname");
                    daycb.Text = birthadapter[0];
                    monthcb.Text = birthadapter[1];
                    yearcb.Text = birthadapter[2];
                    gendercb.Text = sear.GetString("Gender");
                    phonetb.Text = sear.GetString("Phonenumber");
                    emailcb.Text = sear.GetString("Email");
                    streettb.Text = sear.GetString("Address");
                    apttb.Text = sear.GetString("AptorSuite");
                    statetb.Text = sear.GetString("State");
                    ziptb.Text = sear.GetString("Zipcode");
                    nofguestcb.Text = sear.GetString("Noofguest");
                    roomcb.Text = sear.GetString("Roomtype");
                    floorcb.Text = sear.GetString("Floor");
                    roomnucb.Text = sear.GetString("Roomnumber");
                    String sms, check, advance;
                    sms = sear.GetString("sms");
                    check = sear.GetString("checkin");
                    advance = sear.GetString("advancereservation");

                    if (sms=="YES")
                    {
                        smsCB.Checked = true;
                    }
                    else
                    {
                        smsCB.Checked = false;
                    }
                    if(check=="YES")
                    {
                        checkinCB.Checked = true;
                    }
                    else
                    {
                        checkinCB.Checked = false;
                    }
                    if (advance == "YES")
                    {
                        chr++;                        
                        reserveCB.Checked = true;
                    }else
                    {
                        reserveCB.Checked = false;
                    }

                }
            }
            finally
            {
                closeconnect();
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            string[] value = reservsearchcb.Text.Split(' ');
            string advreservation, sms, checkin, birth = (" " + daycb.Text + " " + monthcb.Text + " " + yearcb.Text);
            if (smsCB.CheckState == CheckState.Checked)
            {
                sms = "YES";
            }
            else
            {
                sms = "NO";
            }
            if (checkinCB.CheckState == CheckState.Checked)
            {
                checkin = "YES";
            }
            else
            {
                checkin = "NO";
            }

            if (reserveCB.CheckState == CheckState.Checked)
            {
                advreservation = "YES";
            }
            else
            {
                advreservation = "NO";
            }
            string updateDb = "UPDATE reservation SET Firstname='" +firsttb.Text+ "',Lastname='" + lasttb.Text + "',Birthday='" + birth + "',Gender='" + gendercb.Text + "',Phonenumber='" + phonetb.Text + "',Email='" + emailcb.Text + "',Address='" + streettb.Text + "',AptorSuite='" + apttb.Text + "',State='" + statetb.Text + "',Zipcode='" + ziptb.Text + "',Noofguest='" + nofguestcb.Text + "',Roomtype='" + roomcb.Text + "',Floor='" + floorcb.Text + "',Roomnumber='" + roomnucb.Text + "',Entrydate='" + dateTimeentry.Text + "',Departuredate='" + dateTimedeparture.Text + "',checkin='"+checkin+"',sms='"+sms+"',advancereservation='"+advreservation+"' WHERE Id="+int.Parse(value[0]);
            execute(updateDb);
            if (reserveCB.CheckState == CheckState.Checked)
            {
                string reservatDB = "UPDATE reserved SET Roomnumber='" + roomnucb.Text + "', Roomtype='" + roomcb.Text + "', Firstname='" + firsttb.Text + "', Lastname='" + lasttb.Text + "', Phonenumber='" + phonetb.Text + "', Entry='" + dateTimeentry.Text + "', Departure='" + dateTimedeparture.Text + "' WHERE Phonenumber=" + int.Parse(value[4]);
                execute(reservatDB);

            }
            else if(reserveCB.CheckState == CheckState.Unchecked) 
            {                
                string convet="SELECT *FROM reserved WHERE Phonenumber="+int.Parse(value[4]), occupiedDB = "UPDATE occupied SET Roomnumber='" + roomnucb.Text + "', Roomtype='" + roomcb.Text + "', Firstname='" + firsttb.Text + "', Lastname='" + lasttb.Text + "', Phone='" + phonetb.Text + "' WHERE Phone=" + int.Parse(value[4]);

                if (chr >0)
                {
                    string del = "DELETE FROM reserved WHERE phonenumber=" + int.Parse(value[4]);
                    execute(del);
                    string inser = "INSERT INTO occupied(Roomnumber, Roomtype,ID, Firstname, Lastname, Phone) VALUES('" + roomnucb.Text + "','" + roomcb.Text + "','" + int.Parse(value[0]) + "','" + firsttb.Text + "','" + lasttb.Text + "','" + phonetb.Text + "')";
                    execute(inser);
                    chr--;
                }
                else
                {
                    execute(occupiedDB);
                }               
                                  
            }
            string report = "Report", message = "Entry successfully updated into database for the UNIQUE ID:\n\n " +value[0];
            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBox.Show(message, report, button, MessageBoxIcon.Information);
            fillcombo();
            nul();

        }

        private void delete_Click(object sender, EventArgs e)
        {

            string[] value = reservsearchcb.Text.Split(' ');
            string birth = ("" + daycb.Text + "" + monthcb.Text + "" + yearcb.Text);
            string deletDB = "DELETE FROM reservation WHERE id="+int.Parse(value[0]);
                execute(deletDB);
            if (reserveCB.CheckState == CheckState.Checked)
            {
                string reservatDB = "DELETE FROM reserved WHERE Phonenumber=" + int.Parse(value[4]);
                execute(reservatDB);

            }
            else
            {
                string occupiedDB = "DELETE FROM occupied WHERE Phone=" + int.Parse(value[4]);
                execute(occupiedDB);
            }
            string report = "Report", message = "Entry successfully deleted from database of the UNIQUE ID:\n\n " + value[0];
            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBox.Show(message, report, button, MessageBoxIcon.Information);
            fillcombo();
            nul();
        }

        private void reserveCB_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
