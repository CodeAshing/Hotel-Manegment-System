namespace hotel_manengment_system
{
    partial class food_and_menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(food_and_menu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dinnertext = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.breakfasttext = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.luchtext = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.sweetcb = new System.Windows.Forms.CheckBox();
            this.towelcb = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cleancb = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 22);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(416, -4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(17, 26);
            this.button2.TabIndex = 2;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(439, -4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(17, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.dinnertext);
            this.panel2.Controls.Add(this.breakfasttext);
            this.panel2.Controls.Add(this.luchtext);
            this.panel2.Controls.Add(this.checkBox6);
            this.panel2.Controls.Add(this.checkBox5);
            this.panel2.Controls.Add(this.checkBox4);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(287, 307);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dinnertext
            // 
            this.dinnertext.Location = new System.Drawing.Point(15, 273);
            this.dinnertext.Name = "dinnertext";
            this.dinnertext.Size = new System.Drawing.Size(100, 20);
            this.dinnertext.TabIndex = 12;
            this.dinnertext.WaterMark = "Quantity?";
            this.dinnertext.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.dinnertext.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dinnertext.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // breakfasttext
            // 
            this.breakfasttext.Location = new System.Drawing.Point(15, 143);
            this.breakfasttext.Name = "breakfasttext";
            this.breakfasttext.Size = new System.Drawing.Size(100, 20);
            this.breakfasttext.TabIndex = 11;
            this.breakfasttext.WaterMark = "Quantity?";
            this.breakfasttext.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.breakfasttext.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakfasttext.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // luchtext
            // 
            this.luchtext.Location = new System.Drawing.Point(149, 143);
            this.luchtext.Name = "luchtext";
            this.luchtext.Size = new System.Drawing.Size(100, 20);
            this.luchtext.TabIndex = 10;
            this.luchtext.WaterMark = "Quantity?";
            this.luchtext.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.luchtext.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luchtext.WaterMarkForeColor = System.Drawing.Color.LightGray;
            this.luchtext.TextChanged += new System.EventHandler(this.cTextBox1_TextChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(15, 250);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(84, 17);
            this.checkBox6.TabIndex = 7;
            this.checkBox6.Text = "Dinner ($15)";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkBox5.Location = new System.Drawing.Point(149, 121);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(83, 17);
            this.checkBox5.TabIndex = 6;
            this.checkBox5.Text = "Lunch ($15)";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(15, 121);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(95, 17);
            this.checkBox4.TabIndex = 5;
            this.checkBox4.Text = "Break fast ($7)";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Location = new System.Drawing.Point(149, 51);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(100, 64);
            this.panel6.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Location = new System.Drawing.Point(15, 169);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(100, 69);
            this.panel5.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(15, 51);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(100, 64);
            this.panel4.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Food Selection";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Food and Menu";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Controls.Add(this.sweetcb);
            this.panel3.Controls.Add(this.towelcb);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.cleancb);
            this.panel3.Location = new System.Drawing.Point(305, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(139, 267);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // sweetcb
            // 
            this.sweetcb.AutoSize = true;
            this.sweetcb.Location = new System.Drawing.Point(6, 115);
            this.sweetcb.Name = "sweetcb";
            this.sweetcb.Size = new System.Drawing.Size(109, 17);
            this.sweetcb.TabIndex = 2;
            this.sweetcb.Text = "Sweetest surprise";
            this.sweetcb.UseVisualStyleBackColor = true;
            // 
            // towelcb
            // 
            this.towelcb.AutoSize = true;
            this.towelcb.Location = new System.Drawing.Point(6, 83);
            this.towelcb.Name = "towelcb";
            this.towelcb.Size = new System.Drawing.Size(55, 17);
            this.towelcb.TabIndex = 1;
            this.towelcb.Text = "Towel";
            this.towelcb.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Special needs";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cleancb
            // 
            this.cleancb.AutoSize = true;
            this.cleancb.Location = new System.Drawing.Point(6, 51);
            this.cleancb.Name = "cleancb";
            this.cleancb.Size = new System.Drawing.Size(67, 17);
            this.cleancb.TabIndex = 0;
            this.cleancb.Text = "Cleaning";
            this.cleancb.UseVisualStyleBackColor = true;
            this.cleancb.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkCyan;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(305, 334);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 34);
            this.button3.TabIndex = 3;
            this.button3.Text = "Next";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // food_and_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(456, 380);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "food_and_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " nn n";
            this.Load += new System.EventHandler(this.food_and_menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox sweetcb;
        private System.Windows.Forms.CheckBox towelcb;
        private System.Windows.Forms.CheckBox cleancb;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private ChreneLib.Controls.TextBoxes.CTextBox dinnertext;
        private ChreneLib.Controls.TextBoxes.CTextBox breakfasttext;
        private ChreneLib.Controls.TextBoxes.CTextBox luchtext;
    }
}