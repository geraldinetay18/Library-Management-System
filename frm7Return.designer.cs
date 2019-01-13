namespace SA47Team10a_GalaxyLibrary
{
    partial class frm7Return
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
            this.components = new System.ComponentModel.Container();
            this.btnReturn = new System.Windows.Forms.Button();
            this.txMemberID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gvReturn = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txBookID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txFineAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txRemarks = new System.Windows.Forms.TextBox();
            this.btnPrice = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSearchMember = new System.Windows.Forms.Button();
            this.btnSearchBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // mbtnReturn
            // 
            this.mbtnReturn.BackColor = System.Drawing.Color.OliveDrab;
            this.mbtnReturn.Enabled = false;
            this.mbtnReturn.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.mbtnReturn.FlatAppearance.BorderSize = 5;
            this.mbtnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mbtnReturn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReturn.Location = new System.Drawing.Point(254, 718);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(5);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(259, 58);
            this.btnReturn.TabIndex = 16;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txMemberID
            // 
            this.txMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txMemberID.Location = new System.Drawing.Point(254, 310);
            this.txMemberID.Margin = new System.Windows.Forms.Padding(5);
            this.txMemberID.Name = "txMemberID";
            this.txMemberID.Size = new System.Drawing.Size(168, 37);
            this.txMemberID.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(62, 310);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 30);
            this.label2.TabIndex = 18;
            this.label2.Text = "Member Id";
            // 
            // gvReturn
            // 
            this.gvReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvReturn.Location = new System.Drawing.Point(566, 306);
            this.gvReturn.Margin = new System.Windows.Forms.Padding(5);
            this.gvReturn.Name = "gvReturn";
            this.gvReturn.ReadOnly = true;
            this.gvReturn.Size = new System.Drawing.Size(749, 470);
            this.gvReturn.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(62, 401);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 30);
            this.label3.TabIndex = 21;
            this.label3.Text = "Book Id";
            // 
            // txBookID
            // 
            this.txBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBookID.Location = new System.Drawing.Point(254, 401);
            this.txBookID.Margin = new System.Windows.Forms.Padding(5);
            this.txBookID.Name = "txBookID";
            this.txBookID.Size = new System.Drawing.Size(168, 37);
            this.txBookID.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(62, 489);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 30);
            this.label4.TabIndex = 23;
            this.label4.Text = "Fine Amount";
            // 
            // txFineAmount
            // 
            this.txFineAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txFineAmount.Location = new System.Drawing.Point(254, 494);
            this.txFineAmount.Margin = new System.Windows.Forms.Padding(5);
            this.txFineAmount.Name = "txFineAmount";
            this.txFineAmount.ReadOnly = true;
            this.txFineAmount.Size = new System.Drawing.Size(168, 37);
            this.txFineAmount.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(62, 577);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 30);
            this.label5.TabIndex = 25;
            this.label5.Text = "Remarks";
            // 
            // txRemarks
            // 
            this.txRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txRemarks.Location = new System.Drawing.Point(254, 582);
            this.txRemarks.Margin = new System.Windows.Forms.Padding(5);
            this.txRemarks.Multiline = true;
            this.txRemarks.Name = "txRemarks";
            this.txRemarks.Size = new System.Drawing.Size(252, 103);
            this.txRemarks.TabIndex = 24;
            // 
            // btnPrice
            // 
            this.btnPrice.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrice.Location = new System.Drawing.Point(981, 229);
            this.btnPrice.Margin = new System.Windows.Forms.Padding(5);
            this.btnPrice.Name = "btnPrice";
            this.btnPrice.Size = new System.Drawing.Size(334, 58);
            this.btnPrice.TabIndex = 26;
            this.btnPrice.Text = "Damaged Book Price";
            this.toolTip1.SetToolTip(this.btnPrice, "Click only when the book is damaged");
            this.btnPrice.UseVisualStyleBackColor = false;
            this.btnPrice.Click += new System.EventHandler(this.btnPrice_Click);
            // 
            // btnSearchMember
            // 
            this.btnSearchMember.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnSearchMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMember.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearchMember.Location = new System.Drawing.Point(440, 310);
            this.btnSearchMember.Margin = new System.Windows.Forms.Padding(5);
            this.btnSearchMember.Name = "btnSearchMember";
            this.btnSearchMember.Size = new System.Drawing.Size(66, 43);
            this.btnSearchMember.TabIndex = 27;
            this.btnSearchMember.Text = "...";
            this.btnSearchMember.UseVisualStyleBackColor = false;
            this.btnSearchMember.Click += new System.EventHandler(this.btnSearchMember_Click);
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnSearchBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBook.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearchBook.Location = new System.Drawing.Point(440, 400);
            this.btnSearchBook.Margin = new System.Windows.Forms.Padding(5);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(66, 43);
            this.btnSearchBook.TabIndex = 28;
            this.btnSearchBook.Text = "...";
            this.btnSearchBook.UseVisualStyleBackColor = false;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // frm7Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 941);
            this.Controls.Add(this.btnSearchBook);
            this.Controls.Add(this.btnSearchMember);
            this.Controls.Add(this.btnPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txRemarks);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txFineAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txBookID);
            this.Controls.Add(this.gvReturn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txMemberID);
            this.Controls.Add(this.btnReturn);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm7Return";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Galaxy Libray | Book Return";
            this.Controls.SetChildIndex(this.btnReturn, 0);
            this.Controls.SetChildIndex(this.txMemberID, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.gvReturn, 0);
            this.Controls.SetChildIndex(this.txBookID, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txFineAmount, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txRemarks, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.btnPrice, 0);
            this.Controls.SetChildIndex(this.btnSearchMember, 0);
            this.Controls.SetChildIndex(this.mbtnReport, 0);
            this.Controls.SetChildIndex(this.mbtnBorrow, 0);
            this.Controls.SetChildIndex(this.mbtnReturn, 0);
            this.Controls.SetChildIndex(this.mbtnBookInformation, 0);
            this.Controls.SetChildIndex(this.mbtnMemberInfomation, 0);
            this.Controls.SetChildIndex(this.btnAdmin, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.btnSearchBook, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gvReturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox txMemberID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gvReturn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txBookID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txFineAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txRemarks;
        private System.Windows.Forms.Button btnPrice;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnSearchMember;
        private System.Windows.Forms.Button btnSearchBook;
    }
}