namespace SA47Team10a_GalaxyLibrary
{
    partial class frmTemplate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTemplate));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GALAXY = new System.Windows.Forms.Label();
            this.mbtnBorrow = new System.Windows.Forms.Button();
            this.mbtnReturn = new System.Windows.Forms.Button();
            this.mbtnBookInformation = new System.Windows.Forms.Button();
            this.mbtnMemberInfomation = new System.Windows.Forms.Button();
            this.mbtnReport = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menustripHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.lbUserName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1083, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // GALAXY
            // 
            this.GALAXY.AutoSize = true;
            this.GALAXY.BackColor = System.Drawing.Color.Transparent;
            this.GALAXY.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GALAXY.ForeColor = System.Drawing.Color.White;
            this.GALAXY.Location = new System.Drawing.Point(8, 35);
            this.GALAXY.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.GALAXY.Name = "GALAXY";
            this.GALAXY.Size = new System.Drawing.Size(262, 38);
            this.GALAXY.TabIndex = 1;
            this.GALAXY.Text = " GALAXY LIBRARY";
            // 
            // mbtnBorrow
            // 
            this.mbtnBorrow.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.mbtnBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbtnBorrow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mbtnBorrow.Location = new System.Drawing.Point(177, 81);
            this.mbtnBorrow.Margin = new System.Windows.Forms.Padding(1);
            this.mbtnBorrow.Name = "mbtnBorrow";
            this.mbtnBorrow.Size = new System.Drawing.Size(173, 52);
            this.mbtnBorrow.TabIndex = 2;
            this.mbtnBorrow.Text = "Borrow";
            this.mbtnBorrow.UseVisualStyleBackColor = false;
            this.mbtnBorrow.Click += new System.EventHandler(this.mbtnBorrow_Click);
            // 
            // mbtnReturn
            // 
            this.mbtnReturn.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.mbtnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbtnReturn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mbtnReturn.Location = new System.Drawing.Point(352, 81);
            this.mbtnReturn.Margin = new System.Windows.Forms.Padding(1);
            this.mbtnReturn.Name = "mbtnReturn";
            this.mbtnReturn.Size = new System.Drawing.Size(173, 52);
            this.mbtnReturn.TabIndex = 3;
            this.mbtnReturn.Text = "Return";
            this.mbtnReturn.UseVisualStyleBackColor = false;
            this.mbtnReturn.Click += new System.EventHandler(this.mbtnReturn_Click);
            // 
            // mbtnBookInformation
            // 
            this.mbtnBookInformation.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.mbtnBookInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbtnBookInformation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mbtnBookInformation.Location = new System.Drawing.Point(527, 81);
            this.mbtnBookInformation.Margin = new System.Windows.Forms.Padding(1);
            this.mbtnBookInformation.Name = "mbtnBookInformation";
            this.mbtnBookInformation.Size = new System.Drawing.Size(173, 52);
            this.mbtnBookInformation.TabIndex = 4;
            this.mbtnBookInformation.Text = "Book Information";
            this.mbtnBookInformation.UseVisualStyleBackColor = false;
            this.mbtnBookInformation.Click += new System.EventHandler(this.mbtnBookInformation_Click);
            // 
            // mbtnMemberInfomation
            // 
            this.mbtnMemberInfomation.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.mbtnMemberInfomation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbtnMemberInfomation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mbtnMemberInfomation.Location = new System.Drawing.Point(702, 81);
            this.mbtnMemberInfomation.Margin = new System.Windows.Forms.Padding(1);
            this.mbtnMemberInfomation.Name = "mbtnMemberInfomation";
            this.mbtnMemberInfomation.Size = new System.Drawing.Size(205, 52);
            this.mbtnMemberInfomation.TabIndex = 5;
            this.mbtnMemberInfomation.Text = "Member Information";
            this.mbtnMemberInfomation.UseVisualStyleBackColor = false;
            this.mbtnMemberInfomation.Click += new System.EventHandler(this.mbtnMemberInfomation_Click);
            // 
            // mbtnReport
            // 
            this.mbtnReport.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.mbtnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbtnReport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mbtnReport.Location = new System.Drawing.Point(909, 81);
            this.mbtnReport.Margin = new System.Windows.Forms.Padding(1);
            this.mbtnReport.Name = "mbtnReport";
            this.mbtnReport.Size = new System.Drawing.Size(173, 52);
            this.mbtnReport.TabIndex = 6;
            this.mbtnReport.Text = "Report";
            this.mbtnReport.UseVisualStyleBackColor = false;
            this.mbtnReport.Click += new System.EventHandler(this.mbtnReport_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menustripHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1082, 26);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menustripHelp
            // 
            this.menustripHelp.Name = "menustripHelp";
            this.menustripHelp.Size = new System.Drawing.Size(53, 24);
            this.menustripHelp.Text = "Help";
            this.menustripHelp.Click += new System.EventHandler(this.menustripHelp_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogout.Location = new System.Drawing.Point(949, 32);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(1);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(127, 44);
            this.btnLogout.TabIndex = 23;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdmin.Location = new System.Drawing.Point(2, 81);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(1);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(173, 52);
            this.btnAdmin.TabIndex = 24;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.ForeColor = System.Drawing.Color.White;
            this.lbUserName.Location = new System.Drawing.Point(639, 42);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(61, 25);
            this.lbUserName.TabIndex = 25;
            this.lbUserName.Text = "Hello";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel1.Location = new System.Drawing.Point(0, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1093, 10);
            this.panel1.TabIndex = 26;
            // 
            // frmTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 753);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.mbtnMemberInfomation);
            this.Controls.Add(this.mbtnBookInformation);
            this.Controls.Add(this.mbtnReturn);
            this.Controls.Add(this.mbtnBorrow);
            this.Controls.Add(this.GALAXY);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.mbtnReport);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "frmTemplate";
            this.Text = "Template";
            this.Load += new System.EventHandler(this.frmTemplate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label GALAXY;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menustripHelp;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lbUserName;
        protected System.Windows.Forms.Button mbtnBorrow;
        protected System.Windows.Forms.Button mbtnReturn;
        protected System.Windows.Forms.Button mbtnBookInformation;
        protected System.Windows.Forms.Button mbtnMemberInfomation;
        protected System.Windows.Forms.Button mbtnReport;
        protected System.Windows.Forms.Button btnAdmin;
        protected System.Windows.Forms.Panel panel1;
    }
}

