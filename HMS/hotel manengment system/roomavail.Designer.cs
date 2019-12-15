namespace hotel_manengment_system
{
    partial class roomavail
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.occupiedd = new System.Windows.Forms.DataGridView();
            this.reservedd = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.occupiedd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservedd)).BeginInit();
            this.SuspendLayout();
            // 
            // occupiedd
            // 
            this.occupiedd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.occupiedd.Location = new System.Drawing.Point(3, 28);
            this.occupiedd.Name = "occupiedd";
            this.occupiedd.Size = new System.Drawing.Size(358, 450);
            this.occupiedd.TabIndex = 0;
            this.occupiedd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // reservedd
            // 
            this.reservedd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservedd.Location = new System.Drawing.Point(367, 28);
            this.reservedd.Name = "reservedd";
            this.reservedd.Size = new System.Drawing.Size(360, 450);
            this.reservedd.TabIndex = 1;
            this.reservedd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reservedd_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Occupied";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(363, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Reserved";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(69)))));
            this.update.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.update.FlatAppearance.BorderSize = 0;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.Location = new System.Drawing.Point(264, 484);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(206, 23);
            this.update.TabIndex = 48;
            this.update.Text = "Update\r\n";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // roomavail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.update);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reservedd);
            this.Controls.Add(this.occupiedd);
            this.Name = "roomavail";
            this.Size = new System.Drawing.Size(730, 521);
            this.Load += new System.EventHandler(this.roomavail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.occupiedd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservedd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView occupiedd;
        private System.Windows.Forms.DataGridView reservedd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button update;
    }
}
