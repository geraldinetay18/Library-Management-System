namespace SA47Team10a_GalaxyLibrary
{
    partial class frmBookAdd
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
            this.mbtnUpdate = new System.Windows.Forms.Button();
            this.mbtnAdd = new System.Windows.Forms.Button();
            this.lbErrorMessage = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txShelf = new System.Windows.Forms.MaskedTextBox();
            this.txPrice = new System.Windows.Forms.MaskedTextBox();
            this.cbxFloor = new System.Windows.Forms.ComboBox();
            this.txStock = new System.Windows.Forms.NumericUpDown();
            this.lbLocationL = new System.Windows.Forms.Label();
            this.lbLocationF = new System.Windows.Forms.Label();
            this.lbLocation = new System.Windows.Forms.Label();
            this.txTitle = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.lbStock = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbPublisher = new System.Windows.Forms.Label();
            this.txPublisher = new System.Windows.Forms.TextBox();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.txAuthor = new System.Windows.Forms.TextBox();
            this.lbCategory = new System.Windows.Forms.Label();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.txBookID = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txStock)).BeginInit();
            this.SuspendLayout();
            // 
            // mbtnBookInformation
            // 
            this.mbtnBookInformation.BackColor = System.Drawing.Color.OliveDrab;
            this.mbtnBookInformation.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.mbtnBookInformation.FlatAppearance.BorderSize = 5;
            this.mbtnBookInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mbtnBookInformation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            // 
            // mbtnUpdate
            // 
            this.mbtnUpdate.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.mbtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbtnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mbtnUpdate.Location = new System.Drawing.Point(535, 209);
            this.mbtnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mbtnUpdate.Name = "mbtnUpdate";
            this.mbtnUpdate.Size = new System.Drawing.Size(406, 40);
            this.mbtnUpdate.TabIndex = 12;
            this.mbtnUpdate.Text = "Update";
            this.mbtnUpdate.UseVisualStyleBackColor = false;
            this.mbtnUpdate.Click += new System.EventHandler(this.mbtnUpdate_Click);
            // 
            // mbtnAdd
            // 
            this.mbtnAdd.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.mbtnAdd.Enabled = false;
            this.mbtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbtnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mbtnAdd.Location = new System.Drawing.Point(160, 209);
            this.mbtnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mbtnAdd.Name = "mbtnAdd";
            this.mbtnAdd.Size = new System.Drawing.Size(373, 40);
            this.mbtnAdd.TabIndex = 11;
            this.mbtnAdd.Text = "Add New";
            this.mbtnAdd.UseVisualStyleBackColor = false;
            // 
            // lbErrorMessage
            // 
            this.lbErrorMessage.AutoSize = true;
            this.lbErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lbErrorMessage.Location = new System.Drawing.Point(439, 354);
            this.lbErrorMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbErrorMessage.Name = "lbErrorMessage";
            this.lbErrorMessage.Size = new System.Drawing.Size(0, 17);
            this.lbErrorMessage.TabIndex = 85;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnConfirm);
            this.groupBox1.Controls.Add(this.txShelf);
            this.groupBox1.Controls.Add(this.txPrice);
            this.groupBox1.Controls.Add(this.cbxFloor);
            this.groupBox1.Controls.Add(this.txStock);
            this.groupBox1.Controls.Add(this.lbLocationL);
            this.groupBox1.Controls.Add(this.lbLocationF);
            this.groupBox1.Controls.Add(this.lbLocation);
            this.groupBox1.Controls.Add(this.txTitle);
            this.groupBox1.Controls.Add(this.lbPrice);
            this.groupBox1.Controls.Add(this.lbID);
            this.groupBox1.Controls.Add(this.lbStock);
            this.groupBox1.Controls.Add(this.lbTitle);
            this.groupBox1.Controls.Add(this.lbPublisher);
            this.groupBox1.Controls.Add(this.txPublisher);
            this.groupBox1.Controls.Add(this.lbAuthor);
            this.groupBox1.Controls.Add(this.txAuthor);
            this.groupBox1.Controls.Add(this.lbCategory);
            this.groupBox1.Controls.Add(this.cbxCategory);
            this.groupBox1.Controls.Add(this.txBookID);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(160, 250);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(780, 370);
            this.groupBox1.TabIndex = 86;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Book";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.Location = new System.Drawing.Point(550, 290);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(158, 47);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear Values";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfirm.Location = new System.Drawing.Point(373, 290);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(157, 47);
            this.btnConfirm.TabIndex = 9;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txShelf
            // 
            this.txShelf.Location = new System.Drawing.Point(648, 109);
            this.txShelf.Margin = new System.Windows.Forms.Padding(4);
            this.txShelf.Mask = "000";
            this.txShelf.Name = "txShelf";
            this.txShelf.Size = new System.Drawing.Size(58, 30);
            this.txShelf.TabIndex = 6;
            this.txShelf.ValidatingType = typeof(int);
            // 
            // txPrice
            // 
            this.txPrice.Location = new System.Drawing.Point(530, 160);
            this.txPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txPrice.Mask = "00.00";
            this.txPrice.Name = "txPrice";
            this.txPrice.Size = new System.Drawing.Size(69, 30);
            this.txPrice.TabIndex = 7;
            this.txPrice.ValidatingType = typeof(int);
            // 
            // cbxFloor
            // 
            this.cbxFloor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFloor.FormattingEnabled = true;
            this.cbxFloor.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbxFloor.Location = new System.Drawing.Point(550, 106);
            this.cbxFloor.Margin = new System.Windows.Forms.Padding(4);
            this.cbxFloor.Name = "cbxFloor";
            this.cbxFloor.Size = new System.Drawing.Size(47, 33);
            this.cbxFloor.TabIndex = 5;
            // 
            // txStock
            // 
            this.txStock.Location = new System.Drawing.Point(534, 214);
            this.txStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txStock.Name = "txStock";
            this.txStock.Size = new System.Drawing.Size(69, 30);
            this.txStock.TabIndex = 8;
            // 
            // lbLocationL
            // 
            this.lbLocationL.AutoSize = true;
            this.lbLocationL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocationL.Location = new System.Drawing.Point(605, 114);
            this.lbLocationL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLocationL.Name = "lbLocationL";
            this.lbLocationL.Size = new System.Drawing.Size(35, 25);
            this.lbLocationL.TabIndex = 59;
            this.lbLocationL.Text = "- L";
            // 
            // lbLocationF
            // 
            this.lbLocationF.AutoSize = true;
            this.lbLocationF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocationF.Location = new System.Drawing.Point(523, 114);
            this.lbLocationF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLocationF.Name = "lbLocationF";
            this.lbLocationF.Size = new System.Drawing.Size(24, 25);
            this.lbLocationF.TabIndex = 58;
            this.lbLocationF.Text = "F";
            // 
            // lbLocation
            // 
            this.lbLocation.AutoSize = true;
            this.lbLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocation.Location = new System.Drawing.Point(405, 114);
            this.lbLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(99, 25);
            this.lbLocation.TabIndex = 53;
            this.lbLocation.Text = "Location *";
            // 
            // txTitle
            // 
            this.txTitle.Location = new System.Drawing.Point(139, 109);
            this.txTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txTitle.Name = "txTitle";
            this.txTitle.Size = new System.Drawing.Size(234, 30);
            this.txTitle.TabIndex = 1;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(405, 165);
            this.lbPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(99, 25);
            this.lbPrice.TabIndex = 54;
            this.lbPrice.Text = "Price ($) *";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(29, 61);
            this.lbID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(81, 25);
            this.lbID.TabIndex = 45;
            this.lbID.Text = "Book ID";
            // 
            // lbStock
            // 
            this.lbStock.AutoSize = true;
            this.lbStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStock.Location = new System.Drawing.Point(405, 216);
            this.lbStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStock.Name = "lbStock";
            this.lbStock.Size = new System.Drawing.Size(124, 25);
            this.lbStock.TabIndex = 55;
            this.lbStock.Text = "Total Stock *";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(29, 116);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(62, 25);
            this.lbTitle.TabIndex = 46;
            this.lbTitle.Text = "Title *";
            // 
            // lbPublisher
            // 
            this.lbPublisher.AutoSize = true;
            this.lbPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPublisher.Location = new System.Drawing.Point(29, 163);
            this.lbPublisher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPublisher.Name = "lbPublisher";
            this.lbPublisher.Size = new System.Drawing.Size(106, 25);
            this.lbPublisher.TabIndex = 48;
            this.lbPublisher.Text = "Publisher *";
            // 
            // txPublisher
            // 
            this.txPublisher.Location = new System.Drawing.Point(139, 160);
            this.txPublisher.Margin = new System.Windows.Forms.Padding(4);
            this.txPublisher.Name = "txPublisher";
            this.txPublisher.Size = new System.Drawing.Size(234, 30);
            this.txPublisher.TabIndex = 2;
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAuthor.Location = new System.Drawing.Point(29, 216);
            this.lbAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(83, 25);
            this.lbAuthor.TabIndex = 50;
            this.lbAuthor.Text = "Author *";
            // 
            // txAuthor
            // 
            this.txAuthor.Location = new System.Drawing.Point(139, 211);
            this.txAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.txAuthor.Name = "txAuthor";
            this.txAuthor.Size = new System.Drawing.Size(234, 30);
            this.txAuthor.TabIndex = 3;
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategory.Location = new System.Drawing.Point(405, 63);
            this.lbCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(105, 25);
            this.lbCategory.TabIndex = 52;
            this.lbCategory.Text = "Category *";
            // 
            // cbxCategory
            // 
            this.cbxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Items.AddRange(new object[] {
            "Action",
            "Adventure",
            "Animated",
            "Animation",
            "Comedy",
            "Drama",
            "Horror",
            "Martial Ar",
            "Sci-fi",
            "War"});
            this.cbxCategory.Location = new System.Drawing.Point(528, 60);
            this.cbxCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(178, 33);
            this.cbxCategory.TabIndex = 4;
            // 
            // txBookID
            // 
            this.txBookID.Location = new System.Drawing.Point(139, 58);
            this.txBookID.Margin = new System.Windows.Forms.Padding(4);
            this.txBookID.Name = "txBookID";
            this.txBookID.ReadOnly = true;
            this.txBookID.Size = new System.Drawing.Size(234, 30);
            this.txBookID.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Location = new System.Drawing.Point(160, 646);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(110, 47);
            this.btnBack.TabIndex = 60;
            this.btnBack.Text = "< Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmBookAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 753);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbErrorMessage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mbtnUpdate);
            this.Controls.Add(this.mbtnAdd);
            this.Name = "frmBookAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Galaxy Libray | Book Information | Add New Book";
            this.Load += new System.EventHandler(this.frmBookAdd_Load);
            this.Controls.SetChildIndex(this.mbtnAdd, 0);
            this.Controls.SetChildIndex(this.mbtnUpdate, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.lbErrorMessage, 0);
            this.Controls.SetChildIndex(this.mbtnReport, 0);
            this.Controls.SetChildIndex(this.mbtnBorrow, 0);
            this.Controls.SetChildIndex(this.mbtnReturn, 0);
            this.Controls.SetChildIndex(this.mbtnBookInformation, 0);
            this.Controls.SetChildIndex(this.mbtnMemberInfomation, 0);
            this.Controls.SetChildIndex(this.btnAdmin, 0);
            this.Controls.SetChildIndex(this.btnBack, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button mbtnUpdate;
        private System.Windows.Forms.Button mbtnAdd;
        private System.Windows.Forms.Label lbErrorMessage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.MaskedTextBox txShelf;
        private System.Windows.Forms.MaskedTextBox txPrice;
        private System.Windows.Forms.ComboBox cbxFloor;
        private System.Windows.Forms.NumericUpDown txStock;
        private System.Windows.Forms.Label lbLocationL;
        private System.Windows.Forms.Label lbLocationF;
        private System.Windows.Forms.Label lbLocation;
        private System.Windows.Forms.TextBox txTitle;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbStock;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbPublisher;
        private System.Windows.Forms.TextBox txPublisher;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.TextBox txAuthor;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.TextBox txBookID;
        private System.Windows.Forms.Button btnBack;
    }
}