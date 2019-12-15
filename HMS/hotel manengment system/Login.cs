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
    public partial class Login : Form
    {
        public Login()
        {           
            BackgroundImage = Properties.Resources.hotel3;
            BackgroundImageLayout = ImageLayout.Stretch;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Timer time = new Timer();
            time.Interval = 10000/2;
            time.Tick += new EventHandler(time_Tick);
            time.Start();
        }
        public int imagenumber = 1;
        private void time_Tick(object sender,EventArgs e)
        {
            
            if (imagenumber==10)
            {
                imagenumber = 1;
            } 
            List<Bitmap> back = new List<Bitmap>();
            back.Add(Properties.Resources.wallpaper1);
            back.Add(Properties.Resources.HOSHINOYA_Kyoto_Horizontal_1800x1200);
            back.Add(Properties.Resources.hotel2);
            back.Add(Properties.Resources.room2);
            back.Add(Properties.Resources.hotel3);
            back.Add(Properties.Resources.room3);
            back.Add(Properties.Resources.hotel4);
            back.Add(Properties.Resources.room4);
            back.Add(Properties.Resources.hotel5);
            back.Add(Properties.Resources.room5);
            BackgroundImage = back[imagenumber];
            imagenumber++;

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(username.Text=="admin" && password.Text=="hotel" )
            {
                this.Hide();
                admin menu = new admin();
                menu.Show();
            }
            else if(username.Text == "kitchen" && password.Text == "hotel")
            {
                this.Hide();
                room_service rs = new room_service();
                rs.Show();
            }

            else
            {
                string warning="You have entered an invalid username or password",error="Warning";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show(warning,error,button,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
