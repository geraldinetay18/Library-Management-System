namespace SA47Team10a_GalaxyLibrary
{
    partial class frm15Report
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
            this.btnBookList = new System.Windows.Forms.Button();
            this.btnManagerReport = new System.Windows.Forms.Button();
            this.btnBorrowingReceipts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mbtnReport
            // 
            this.mbtnReport.BackColor = System.Drawing.Color.OliveDrab;
            this.mbtnReport.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.mbtnReport.FlatAppearance.BorderSize = 5;
            this.mbtnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mbtnReport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            // 
            // btnBookList
            // 
            this.btnBookList.BackColor = System.Drawing.Color.Goldenrod;
            this.btnBookList.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBookList.FlatAppearance.BorderSize = 5;
            this.btnBookList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookList.Location = new System.Drawing.Point(83, 348);
            this.btnBookList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBookList.Name = "btnBookList";
            this.btnBookList.Size = new System.Drawing.Size(285, 152);
            this.btnBookList.TabIndex = 27;
            this.btnBookList.Text = "Book List";
            this.btnBookList.UseVisualStyleBackColor = false;
            this.btnBookList.Click += new System.EventHandler(this.btnBookList_Click);
            // 
            // btnManagerReport
            // 
            this.btnManagerReport.BackColor = System.Drawing.Color.Goldenrod;
            this.btnManagerReport.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnManagerReport.FlatAppearance.BorderSize = 5;
            this.btnManagerReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagerReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagerReport.Location = new System.Drawing.Point(399, 348);
            this.btnManagerReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnManagerReport.Name = "btnManagerReport";
            this.btnManagerReport.Size = new System.Drawing.Size(285, 152);
            this.btnManagerReport.TabIndex = 28;
            this.btnManagerReport.Text = "Manager Report";
            this.btnManagerReport.UseVisualStyleBackColor = false;
            this.btnManagerReport.Click += new System.EventHandler(this.btnManagerReport_Click);
            // 
            // btnBorrowingReceipts
            // 
            this.btnBorrowingReceipts.BackColor = System.Drawing.Color.Goldenrod;
            this.btnBorrowingReceipts.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBorrowingReceipts.FlatAppearance.BorderSize = 5;
            this.btnBorrowingReceipts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrowingReceipts.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrowingReceipts.Location = new System.Drawing.Point(720, 348);
            this.btnBorrowingReceipts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBorrowingReceipts.Name = "btnBorrowingReceipts";
            this.btnBorrowingReceipts.Size = new System.Drawing.Size(285, 152);
            this.btnBorrowingReceipts.TabIndex = 29;
            this.btnBorrowingReceipts.Text = "Borrowing Receipts";
            this.btnBorrowingReceipts.UseVisualStyleBackColor = false;
            this.btnBorrowingReceipts.Click += new System.EventHandler(this.btnBorrowingReceipts_Click);
            // 
            // frm15Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 753);
            this.Controls.Add(this.btnBorrowingReceipts);
            this.Controls.Add(this.btnManagerReport);
            this.Controls.Add(this.btnBookList);
            this.Name = "frm15Report";
            this.Text = "Galaxy Library | Report";
            this.Controls.SetChildIndex(this.mbtnReport, 0);
            this.Controls.SetChildIndex(this.mbtnBorrow, 0);
            this.Controls.SetChildIndex(this.mbtnReturn, 0);
            this.Controls.SetChildIndex(this.mbtnBookInformation, 0);
            this.Controls.SetChildIndex(this.mbtnMemberInfomation, 0);
            this.Controls.SetChildIndex(this.btnAdmin, 0);
            this.Controls.SetChildIndex(this.btnBookList, 0);
            this.Controls.SetChildIndex(this.btnManagerReport, 0);
            this.Controls.SetChildIndex(this.btnBorrowingReceipts, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBookList;
        private System.Windows.Forms.Button btnManagerReport;
        private System.Windows.Forms.Button btnBorrowingReceipts;
    }
}