namespace hotel_manengment_system
{
    partial class over
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.updateBN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(724, 467);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // updateBN
            // 
            this.updateBN.BackColor = System.Drawing.Color.DarkCyan;
            this.updateBN.FlatAppearance.BorderSize = 0;
            this.updateBN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBN.ForeColor = System.Drawing.Color.White;
            this.updateBN.Location = new System.Drawing.Point(499, 476);
            this.updateBN.Name = "updateBN";
            this.updateBN.Size = new System.Drawing.Size(219, 23);
            this.updateBN.TabIndex = 28;
            this.updateBN.Text = "Update ";
            this.updateBN.UseVisualStyleBackColor = false;
            this.updateBN.Click += new System.EventHandler(this.updateBN_Click_1);
            // 
            // over
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.updateBN);
            this.Controls.Add(this.dataGridView1);
            this.Name = "over";
            this.Size = new System.Drawing.Size(730, 521);
            this.Load += new System.EventHandler(this.over_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button updateBN;
    }
}
