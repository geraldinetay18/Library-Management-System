namespace SA47Team10a_GalaxyLibrary
{
    partial class frm6BorrowBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm6BorrowBook));
            this.txMemberID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txBookID = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txSuccess = new System.Windows.Forms.Label();
            this.GV = new System.Windows.Forms.DataGridView();
            this.btnExtension = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GV)).BeginInit();
            this.SuspendLayout();
            // 
            // mbtnBorrow
            // 
            this.mbtnBorrow.BackColor = System.Drawing.Color.OliveDrab;
            this.mbtnBorrow.Enabled = false;
            this.mbtnBorrow.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.mbtnBorrow.FlatAppearance.BorderSize = 5;
            this.mbtnBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mbtnBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbtnBorrow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mbtnBorrow.Size = new System.Drawing.Size(173, 57);
            // 
            // txMemberID
            // 
            this.txMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txMemberID.Location = new System.Drawing.Point(150, 303);
            this.txMemberID.Margin = new System.Windows.Forms.Padding(2);
            this.txMemberID.Name = "txMemberID";
            this.txMemberID.Size = new System.Drawing.Size(268, 30);
            this.txMemberID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(145, 275);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "MemberID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(473, 275);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(380, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Information of Member \'s Transactions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(145, 367);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "BookID";
            // 
            // txBookID
            // 
            this.txBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBookID.Location = new System.Drawing.Point(150, 394);
            this.txBookID.Margin = new System.Windows.Forms.Padding(2);
            this.txBookID.Name = "txBookID";
            this.txBookID.Size = new System.Drawing.Size(268, 30);
            this.txBookID.TabIndex = 2;
            this.txBookID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txBookID_KeyDown);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfirm.Location = new System.Drawing.Point(277, 484);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(150, 71);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Confirm Loan";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txSuccess
            // 
            this.txSuccess.AutoSize = true;
            this.txSuccess.Location = new System.Drawing.Point(174, 572);
            this.txSuccess.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txSuccess.Name = "txSuccess";
            this.txSuccess.Size = new System.Drawing.Size(0, 17);
            this.txSuccess.TabIndex = 22;
            // 
            // GV
            // 
            this.GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV.Location = new System.Drawing.Point(478, 303);
            this.GV.Margin = new System.Windows.Forms.Padding(2);
            this.GV.Name = "GV";
            this.GV.RowTemplate.Height = 33;
            this.GV.Size = new System.Drawing.Size(480, 252);
            this.GV.TabIndex = 24;
            // 
            // btnExtension
            // 
            this.btnExtension.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtension.Location = new System.Drawing.Point(150, 484);
            this.btnExtension.Margin = new System.Windows.Forms.Padding(2);
            this.btnExtension.Name = "btnExtension";
            this.btnExtension.Size = new System.Drawing.Size(120, 71);
            this.btnExtension.TabIndex = 3;
            this.btnExtension.Text = "Extension";
            this.btnExtension.UseVisualStyleBackColor = true;
            this.btnExtension.Click += new System.EventHandler(this.btnExtension_Click);
            // 
            // frm6BorrowBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1082, 753);
            this.Controls.Add(this.btnExtension);
            this.Controls.Add(this.GV);
            this.Controls.Add(this.txSuccess);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txBookID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txMemberID);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm6BorrowBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "GalaxyLibrary | Book Borrow";
            this.Controls.SetChildIndex(this.txMemberID, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txBookID, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.btnConfirm, 0);
            this.Controls.SetChildIndex(this.txSuccess, 0);
            this.Controls.SetChildIndex(this.GV, 0);
            this.Controls.SetChildIndex(this.btnExtension, 0);
            this.Controls.SetChildIndex(this.mbtnReport, 0);
            this.Controls.SetChildIndex(this.mbtnReturn, 0);
            this.Controls.SetChildIndex(this.mbtnBookInformation, 0);
            this.Controls.SetChildIndex(this.mbtnMemberInfomation, 0);
            this.Controls.SetChildIndex(this.btnAdmin, 0);
            this.Controls.SetChildIndex(this.mbtnBorrow, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.GV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txMemberID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txBookID;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label txSuccess;
        private System.Windows.Forms.DataGridView GV;
        private System.Windows.Forms.Button btnExtension;
    }
}

