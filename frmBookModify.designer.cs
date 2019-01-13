namespace SA47Team10a_GalaxyLibrary
{
    partial class frmBookModify
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
            this.txPrice = new System.Windows.Forms.MaskedTextBox();
            this.txShelf = new System.Windows.Forms.MaskedTextBox();
            this.lbErrorMessage = new System.Windows.Forms.Label();
            this.txBookID = new System.Windows.Forms.TextBox();
            this.cbxFloor = new System.Windows.Forms.ComboBox();
            this.lbLocationL = new System.Windows.Forms.Label();
            this.lbLocationF = new System.Windows.Forms.Label();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lbStock = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbLocation = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.txAuthor = new System.Windows.Forms.TextBox();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.txPublisher = new System.Windows.Forms.TextBox();
            this.lbPublisher = new System.Windows.Forms.Label();
            this.txTitle = new System.Windows.Forms.TextBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.lbAvailability = new System.Windows.Forms.Label();
            this.txStock = new System.Windows.Forms.NumericUpDown();
            this.rbtnYes = new System.Windows.Forms.RadioButton();
            this.rbtnNo = new System.Windows.Forms.RadioButton();
            this.lbNumBorrowed = new System.Windows.Forms.Label();
            this.txNumBorrowed = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMore = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.mbtnUpdate2 = new System.Windows.Forms.Button();
            this.mbtnAdd = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txStock)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mbtnBookInformation
            // 
            this.mbtnBookInformation.BackColor = System.Drawing.Color.OliveDrab;
            this.mbtnBookInformation.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.mbtnBookInformation.FlatAppearance.BorderSize = 5;
            this.mbtnBookInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mbtnBookInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbtnBookInformation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            // 
            // txPrice
            // 
            this.txPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPrice.Location = new System.Drawing.Point(575, 105);
            this.txPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txPrice.Mask = "00.00";
            this.txPrice.Name = "txPrice";
            this.txPrice.ReadOnly = true;
            this.txPrice.Size = new System.Drawing.Size(143, 30);
            this.txPrice.TabIndex = 8;
            this.txPrice.ValidatingType = typeof(int);
            // 
            // txShelf
            // 
            this.txShelf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txShelf.Location = new System.Drawing.Point(669, 53);
            this.txShelf.Margin = new System.Windows.Forms.Padding(4);
            this.txShelf.Mask = "000";
            this.txShelf.Name = "txShelf";
            this.txShelf.ReadOnly = true;
            this.txShelf.Size = new System.Drawing.Size(49, 30);
            this.txShelf.TabIndex = 7;
            this.txShelf.ValidatingType = typeof(int);
            // 
            // lbErrorMessage
            // 
            this.lbErrorMessage.AutoSize = true;
            this.lbErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lbErrorMessage.Location = new System.Drawing.Point(435, 356);
            this.lbErrorMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbErrorMessage.Name = "lbErrorMessage";
            this.lbErrorMessage.Size = new System.Drawing.Size(0, 17);
            this.lbErrorMessage.TabIndex = 62;
            // 
            // txBookID
            // 
            this.txBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBookID.Location = new System.Drawing.Point(127, 56);
            this.txBookID.Margin = new System.Windows.Forms.Padding(4);
            this.txBookID.Name = "txBookID";
            this.txBookID.ReadOnly = true;
            this.txBookID.Size = new System.Drawing.Size(101, 30);
            this.txBookID.TabIndex = 1;
            // 
            // cbxFloor
            // 
            this.cbxFloor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFloor.Enabled = false;
            this.cbxFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFloor.FormattingEnabled = true;
            this.cbxFloor.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbxFloor.Location = new System.Drawing.Point(575, 53);
            this.cbxFloor.Margin = new System.Windows.Forms.Padding(4);
            this.cbxFloor.Name = "cbxFloor";
            this.cbxFloor.Size = new System.Drawing.Size(47, 33);
            this.cbxFloor.TabIndex = 6;
            // 
            // lbLocationL
            // 
            this.lbLocationL.AutoSize = true;
            this.lbLocationL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocationL.Location = new System.Drawing.Point(630, 59);
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
            this.lbLocationF.Location = new System.Drawing.Point(543, 57);
            this.lbLocationF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLocationF.Name = "lbLocationF";
            this.lbLocationF.Size = new System.Drawing.Size(24, 25);
            this.lbLocationF.TabIndex = 58;
            this.lbLocationF.Text = "F";
            // 
            // cbxCategory
            // 
            this.cbxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategory.Enabled = false;
            this.cbxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cbxCategory.Location = new System.Drawing.Point(127, 260);
            this.cbxCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(263, 33);
            this.cbxCategory.TabIndex = 5;
            // 
            // lbStock
            // 
            this.lbStock.AutoSize = true;
            this.lbStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStock.Location = new System.Drawing.Point(428, 161);
            this.lbStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStock.Name = "lbStock";
            this.lbStock.Size = new System.Drawing.Size(111, 25);
            this.lbStock.TabIndex = 55;
            this.lbStock.Text = "Total Stock";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(429, 110);
            this.lbPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(86, 25);
            this.lbPrice.TabIndex = 54;
            this.lbPrice.Text = "Price ($)";
            // 
            // lbLocation
            // 
            this.lbLocation.AutoSize = true;
            this.lbLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocation.Location = new System.Drawing.Point(428, 59);
            this.lbLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(86, 25);
            this.lbLocation.TabIndex = 53;
            this.lbLocation.Text = "Location";
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategory.Location = new System.Drawing.Point(21, 263);
            this.lbCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(92, 25);
            this.lbCategory.TabIndex = 52;
            this.lbCategory.Text = "Category";
            // 
            // txAuthor
            // 
            this.txAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txAuthor.Location = new System.Drawing.Point(127, 209);
            this.txAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.txAuthor.Name = "txAuthor";
            this.txAuthor.ReadOnly = true;
            this.txAuthor.Size = new System.Drawing.Size(263, 30);
            this.txAuthor.TabIndex = 4;
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAuthor.Location = new System.Drawing.Point(21, 212);
            this.lbAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(70, 25);
            this.lbAuthor.TabIndex = 50;
            this.lbAuthor.Text = "Author";
            // 
            // txPublisher
            // 
            this.txPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPublisher.Location = new System.Drawing.Point(127, 158);
            this.txPublisher.Margin = new System.Windows.Forms.Padding(4);
            this.txPublisher.Name = "txPublisher";
            this.txPublisher.ReadOnly = true;
            this.txPublisher.Size = new System.Drawing.Size(263, 30);
            this.txPublisher.TabIndex = 3;
            // 
            // lbPublisher
            // 
            this.lbPublisher.AutoSize = true;
            this.lbPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPublisher.Location = new System.Drawing.Point(21, 161);
            this.lbPublisher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPublisher.Name = "lbPublisher";
            this.lbPublisher.Size = new System.Drawing.Size(93, 25);
            this.lbPublisher.TabIndex = 48;
            this.lbPublisher.Text = "Publisher";
            // 
            // txTitle
            // 
            this.txTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txTitle.Location = new System.Drawing.Point(127, 107);
            this.txTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txTitle.Name = "txTitle";
            this.txTitle.ReadOnly = true;
            this.txTitle.Size = new System.Drawing.Size(263, 30);
            this.txTitle.TabIndex = 2;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(21, 110);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(49, 25);
            this.lbTitle.TabIndex = 46;
            this.lbTitle.Text = "Title";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(21, 62);
            this.lbID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(81, 25);
            this.lbID.TabIndex = 45;
            this.lbID.Text = "Book ID";
            // 
            // lbAvailability
            // 
            this.lbAvailability.AutoSize = true;
            this.lbAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAvailability.Location = new System.Drawing.Point(429, 263);
            this.lbAvailability.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAvailability.Name = "lbAvailability";
            this.lbAvailability.Size = new System.Drawing.Size(104, 25);
            this.lbAvailability.TabIndex = 69;
            this.lbAvailability.Text = "Availability";
            // 
            // txStock
            // 
            this.txStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txStock.Location = new System.Drawing.Point(608, 156);
            this.txStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txStock.Name = "txStock";
            this.txStock.ReadOnly = true;
            this.txStock.Size = new System.Drawing.Size(110, 30);
            this.txStock.TabIndex = 9;
            // 
            // rbtnYes
            // 
            this.rbtnYes.AutoSize = true;
            this.rbtnYes.Enabled = false;
            this.rbtnYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnYes.Location = new System.Drawing.Point(575, 261);
            this.rbtnYes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnYes.Name = "rbtnYes";
            this.rbtnYes.Size = new System.Drawing.Size(70, 29);
            this.rbtnYes.TabIndex = 11;
            this.rbtnYes.TabStop = true;
            this.rbtnYes.Text = "Yes";
            this.rbtnYes.UseVisualStyleBackColor = true;
            // 
            // rbtnNo
            // 
            this.rbtnNo.AutoSize = true;
            this.rbtnNo.Enabled = false;
            this.rbtnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNo.Location = new System.Drawing.Point(667, 263);
            this.rbtnNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnNo.Name = "rbtnNo";
            this.rbtnNo.Size = new System.Drawing.Size(60, 29);
            this.rbtnNo.TabIndex = 12;
            this.rbtnNo.TabStop = true;
            this.rbtnNo.Text = "No";
            this.rbtnNo.UseVisualStyleBackColor = true;
            // 
            // lbNumBorrowed
            // 
            this.lbNumBorrowed.AutoSize = true;
            this.lbNumBorrowed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumBorrowed.Location = new System.Drawing.Point(428, 214);
            this.lbNumBorrowed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNumBorrowed.Name = "lbNumBorrowed";
            this.lbNumBorrowed.Size = new System.Drawing.Size(169, 25);
            this.lbNumBorrowed.TabIndex = 73;
            this.lbNumBorrowed.Text = "Number Borrowed";
            // 
            // txNumBorrowed
            // 
            this.txNumBorrowed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNumBorrowed.Location = new System.Drawing.Point(608, 209);
            this.txNumBorrowed.Margin = new System.Windows.Forms.Padding(4);
            this.txNumBorrowed.Mask = "000";
            this.txNumBorrowed.Name = "txNumBorrowed";
            this.txNumBorrowed.ReadOnly = true;
            this.txNumBorrowed.Size = new System.Drawing.Size(112, 30);
            this.txNumBorrowed.TabIndex = 10;
            this.txNumBorrowed.ValidatingType = typeof(int);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMore);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnConfirm);
            this.groupBox1.Controls.Add(this.txShelf);
            this.groupBox1.Controls.Add(this.txPrice);
            this.groupBox1.Controls.Add(this.cbxFloor);
            this.groupBox1.Controls.Add(this.txStock);
            this.groupBox1.Controls.Add(this.lbLocationL);
            this.groupBox1.Controls.Add(this.txNumBorrowed);
            this.groupBox1.Controls.Add(this.lbLocationF);
            this.groupBox1.Controls.Add(this.lbNumBorrowed);
            this.groupBox1.Controls.Add(this.lbLocation);
            this.groupBox1.Controls.Add(this.txTitle);
            this.groupBox1.Controls.Add(this.lbPrice);
            this.groupBox1.Controls.Add(this.lbID);
            this.groupBox1.Controls.Add(this.rbtnNo);
            this.groupBox1.Controls.Add(this.rbtnYes);
            this.groupBox1.Controls.Add(this.lbStock);
            this.groupBox1.Controls.Add(this.lbTitle);
            this.groupBox1.Controls.Add(this.lbPublisher);
            this.groupBox1.Controls.Add(this.lbAvailability);
            this.groupBox1.Controls.Add(this.txPublisher);
            this.groupBox1.Controls.Add(this.lbAuthor);
            this.groupBox1.Controls.Add(this.txAuthor);
            this.groupBox1.Controls.Add(this.lbCategory);
            this.groupBox1.Controls.Add(this.cbxCategory);
            this.groupBox1.Controls.Add(this.txBookID);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(160, 250);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(780, 386);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update Book Details";
            // 
            // btnMore
            // 
            this.btnMore.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnMore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMore.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMore.Location = new System.Drawing.Point(245, 53);
            this.btnMore.Margin = new System.Windows.Forms.Padding(4);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(145, 38);
            this.btnMore.TabIndex = 0;
            this.btnMore.Text = "Search";
            this.btnMore.UseVisualStyleBackColor = false;
            this.btnMore.Click += new System.EventHandler(this.btnMore_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.Location = new System.Drawing.Point(575, 316);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(145, 46);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear Values";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfirm.Location = new System.Drawing.Point(434, 316);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(133, 46);
            this.btnConfirm.TabIndex = 13;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // mbtnUpdate2
            // 
            this.mbtnUpdate2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.mbtnUpdate2.Enabled = false;
            this.mbtnUpdate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbtnUpdate2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mbtnUpdate2.Location = new System.Drawing.Point(535, 209);
            this.mbtnUpdate2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mbtnUpdate2.Name = "mbtnUpdate2";
            this.mbtnUpdate2.Size = new System.Drawing.Size(405, 40);
            this.mbtnUpdate2.TabIndex = 16;
            this.mbtnUpdate2.Text = "Update";
            this.mbtnUpdate2.UseVisualStyleBackColor = false;
            // 
            // mbtnAdd
            // 
            this.mbtnAdd.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.mbtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbtnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mbtnAdd.Location = new System.Drawing.Point(160, 209);
            this.mbtnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mbtnAdd.Name = "mbtnAdd";
            this.mbtnAdd.Size = new System.Drawing.Size(373, 40);
            this.mbtnAdd.TabIndex = 15;
            this.mbtnAdd.Text = "Add New";
            this.mbtnAdd.UseVisualStyleBackColor = false;
            this.mbtnAdd.Click += new System.EventHandler(this.mbtnAdd_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Location = new System.Drawing.Point(160, 648);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(110, 47);
            this.btnBack.TabIndex = 79;
            this.btnBack.Text = "< Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmBookModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 753);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.mbtnUpdate2);
            this.Controls.Add(this.mbtnAdd);
            this.Controls.Add(this.lbErrorMessage);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBookModify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Galaxy Libray | Book Information | Modify Book";
            this.Load += new System.EventHandler(this.frmBookModify_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.lbErrorMessage, 0);
            this.Controls.SetChildIndex(this.mbtnAdd, 0);
            this.Controls.SetChildIndex(this.mbtnUpdate2, 0);
            this.Controls.SetChildIndex(this.mbtnReport, 0);
            this.Controls.SetChildIndex(this.mbtnBorrow, 0);
            this.Controls.SetChildIndex(this.mbtnReturn, 0);
            this.Controls.SetChildIndex(this.mbtnBookInformation, 0);
            this.Controls.SetChildIndex(this.mbtnMemberInfomation, 0);
            this.Controls.SetChildIndex(this.btnAdmin, 0);
            this.Controls.SetChildIndex(this.btnBack, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.txStock)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox txPrice;
        private System.Windows.Forms.MaskedTextBox txShelf;
        private System.Windows.Forms.Label lbErrorMessage;
        private System.Windows.Forms.TextBox txBookID;
        private System.Windows.Forms.ComboBox cbxFloor;
        private System.Windows.Forms.Label lbLocationL;
        private System.Windows.Forms.Label lbLocationF;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lbStock;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbLocation;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.TextBox txAuthor;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.TextBox txPublisher;
        private System.Windows.Forms.Label lbPublisher;
        private System.Windows.Forms.TextBox txTitle;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbAvailability;
        private System.Windows.Forms.NumericUpDown txStock;
        private System.Windows.Forms.RadioButton rbtnYes;
        private System.Windows.Forms.RadioButton rbtnNo;
        private System.Windows.Forms.Label lbNumBorrowed;
        private System.Windows.Forms.MaskedTextBox txNumBorrowed;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button mbtnUpdate2;
        private System.Windows.Forms.Button mbtnAdd;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnMore;
        private System.Windows.Forms.Button btnBack;
    }
}