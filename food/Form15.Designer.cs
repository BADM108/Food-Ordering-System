namespace GUI_CW_v1._0
{
    partial class frmadminhome
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
            this.boxgridviewusers = new System.Windows.Forms.DataGridView();
            this.btnbackinsignup = new Guna.UI2.WinForms.Guna2Button();
            this.btnreport = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.boxgridviewusers)).BeginInit();
            this.SuspendLayout();
            // 
            // boxgridviewusers
            // 
            this.boxgridviewusers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.boxgridviewusers.Location = new System.Drawing.Point(474, 10);
            this.boxgridviewusers.Name = "boxgridviewusers";
            this.boxgridviewusers.RowHeadersWidth = 51;
            this.boxgridviewusers.RowTemplate.Height = 24;
            this.boxgridviewusers.Size = new System.Drawing.Size(801, 676);
            this.boxgridviewusers.TabIndex = 1;
            // 
            // btnbackinsignup
            // 
            this.btnbackinsignup.AutoRoundedCorners = true;
            this.btnbackinsignup.BackColor = System.Drawing.Color.Transparent;
            this.btnbackinsignup.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnbackinsignup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnbackinsignup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnbackinsignup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnbackinsignup.FillColor = System.Drawing.Color.Black;
            this.btnbackinsignup.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbackinsignup.ForeColor = System.Drawing.Color.White;
            this.btnbackinsignup.Location = new System.Drawing.Point(95, 455);
            this.btnbackinsignup.Name = "btnbackinsignup";
            this.btnbackinsignup.Size = new System.Drawing.Size(176, 58);
            this.btnbackinsignup.TabIndex = 41;
            this.btnbackinsignup.Text = "Back";
            this.btnbackinsignup.Click += new System.EventHandler(this.btnbackinsignup_Click);
            // 
            // btnreport
            // 
            this.btnreport.AutoRoundedCorners = true;
            this.btnreport.BackColor = System.Drawing.Color.Transparent;
            this.btnreport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnreport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnreport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnreport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnreport.FillColor = System.Drawing.Color.Black;
            this.btnreport.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreport.ForeColor = System.Drawing.Color.White;
            this.btnreport.Location = new System.Drawing.Point(95, 336);
            this.btnreport.Name = "btnreport";
            this.btnreport.Size = new System.Drawing.Size(176, 58);
            this.btnreport.TabIndex = 42;
            this.btnreport.Text = "Report";
            this.btnreport.Click += new System.EventHandler(this.btnreport_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Montserrat", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 92);
            this.label1.TabIndex = 43;
            this.label1.Text = "ADMIN";
            // 
            // frmadminhome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 698);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnreport);
            this.Controls.Add(this.btnbackinsignup);
            this.Controls.Add(this.boxgridviewusers);
            this.Name = "frmadminhome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.frmadminhome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.boxgridviewusers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView boxgridviewusers;
        private Guna.UI2.WinForms.Guna2Button btnbackinsignup;
        private Guna.UI2.WinForms.Guna2Button btnreport;
        private System.Windows.Forms.Label label1;
    }
}