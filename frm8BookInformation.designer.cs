namespace SA47Team10a_GalaxyLibrary
{
    partial class frm8BookInformation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbMenu = new System.Windows.Forms.Label();
            this.txBookID = new System.Windows.Forms.TextBox();
            this.txTitle = new System.Windows.Forms.TextBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.gv = new System.Windows.Forms.DataGridView();
            this.btnMore = new System.Windows.Forms.Button();
            this.mbtnUpdate = new System.Windows.Forms.Button();
            this.mbtnAdd = new System.Windows.Forms.Button();
            this.lbNumBorrowed = new System.Windows.Forms.Label();
            this.lbAvailability = new System.Windows.Forms.Label();
            this.lbStock = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbLocation = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.txAuthor = new System.Windows.Forms.TextBox();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.txPublisher = new System.Windows.Forms.TextBox();
            this.lbPublisher = new System.Windows.Forms.Label();
            this.txLocation = new System.Windows.Forms.TextBox();
            this.txAvailability = new System.Windows.Forms.TextBox();
            this.txPrice = new System.Windows.Forms.TextBox();
            this.txStock = new System.Windows.Forms.TextBox();
            this.txNumBorrowed = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.txCategory = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mbtnBookInformation
            // 
            this.mbtnBookInformation.BackColor = System.Drawing.Color.OliveDrab;
            this.mbtnBookInformation.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.mbtnBookInformation.FlatAppearance.BorderSize = 5;
            this.mbtnBookInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mbtnBookInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbtnBookInformation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            // 
            // lbMenu
            // 
            this.lbMenu.AutoSize = true;
            this.lbMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbMenu.Location = new System.Drawing.Point(25, 516);
            this.lbMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.Size = new System.Drawing.Size(221, 29);
            this.lbMenu.TabIndex = 39;
            this.lbMenu.Text = "Borrowing History";
            // 
            // txBookID
            // 
            this.txBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBookID.Location = new System.Drawing.Point(130, 51);
            this.txBookID.Margin = new System.Windows.Forms.Padding(4);
            this.txBookID.Name = "txBookID";
            this.txBookID.ReadOnly = true;
            this.txBookID.Size = new System.Drawing.Size(211, 30);
            this.txBookID.TabIndex = 0;
            // 
            // txTitle
            // 
            this.txTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txTitle.Location = new System.Drawing.Point(130, 113);
            this.txTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txTitle.Name = "txTitle";
            this.txTitle.ReadOnly = true;
            this.txTitle.Size = new System.Drawing.Size(211, 30);
            this.txTitle.TabIndex = 1;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(30, 116);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(49, 25);
            this.lbTitle.TabIndex = 63;
            this.lbTitle.Text = "Title";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(30, 56);
            this.lbID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(81, 25);
            this.lbID.TabIndex = 62;
            this.lbID.Text = "Book ID";
            // 
            // gv
            // 
            this.gv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv.DefaultCellStyle = dataGridViewCellStyle4;
            this.gv.Location = new System.Drawing.Point(30, 549);
            this.gv.Margin = new System.Windows.Forms.Padding(4);
            this.gv.Name = "gv";
            this.gv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv.Size = new System.Drawing.Size(1007, 156);
            this.gv.TabIndex = 66;
            // 
            // btnMore
            // 
            this.btnMore.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnMore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMore.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMore.Location = new System.Drawing.Point(697, 226);
            this.btnMore.Margin = new System.Windows.Forms.Padding(4);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(266, 46);
            this.btnMore.TabIndex = 10;
            this.btnMore.Text = "Search for more books";
            this.btnMore.UseVisualStyleBackColor = false;
            this.btnMore.Click += new System.EventHandler(this.btnMore_Click);
            // 
            // mbtnUpdate
            // 
            this.mbtnUpdate.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.mbtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbtnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mbtnUpdate.Location = new System.Drawing.Point(918, 161);
            this.mbtnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mbtnUpdate.Name = "mbtnUpdate";
            this.mbtnUpdate.Size = new System.Drawing.Size(132, 40);
            this.mbtnUpdate.TabIndex = 14;
            this.mbtnUpdate.Text = "Update";
            this.mbtnUpdate.UseVisualStyleBackColor = false;
            this.mbtnUpdate.Click += new System.EventHandler(this.mbtnUpdate_Click);
            // 
            // mbtnAdd
            // 
            this.mbtnAdd.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.mbtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbtnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mbtnAdd.Location = new System.Drawing.Point(775, 161);
            this.mbtnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mbtnAdd.Name = "mbtnAdd";
            this.mbtnAdd.Size = new System.Drawing.Size(132, 40);
            this.mbtnAdd.TabIndex = 13;
            this.mbtnAdd.Text = "Add New";
            this.mbtnAdd.UseVisualStyleBackColor = false;
            this.mbtnAdd.Click += new System.EventHandler(this.mbtnAdd_Click);
            // 
            // lbNumBorrowed
            // 
            this.lbNumBorrowed.AutoSize = true;
            this.lbNumBorrowed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumBorrowed.Location = new System.Drawing.Point(740, 116);
            this.lbNumBorrowed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNumBorrowed.Name = "lbNumBorrowed";
            this.lbNumBorrowed.Size = new System.Drawing.Size(95, 25);
            this.lbNumBorrowed.TabIndex = 101;
            this.lbNumBorrowed.Text = "Borrowed";
            // 
            // lbAvailability
            // 
            this.lbAvailability.AutoSize = true;
            this.lbAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAvailability.Location = new System.Drawing.Point(740, 178);
            this.lbAvailability.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAvailability.Name = "lbAvailability";
            this.lbAvailability.Size = new System.Drawing.Size(104, 25);
            this.lbAvailability.TabIndex = 97;
            this.lbAvailability.Text = "Availability";
            // 
            // lbStock
            // 
            this.lbStock.AutoSize = true;
            this.lbStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStock.Location = new System.Drawing.Point(740, 54);
            this.lbStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStock.Name = "lbStock";
            this.lbStock.Size = new System.Drawing.Size(111, 25);
            this.lbStock.TabIndex = 90;
            this.lbStock.Text = "Total Stock";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(390, 178);
            this.lbPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(86, 25);
            this.lbPrice.TabIndex = 89;
            this.lbPrice.Text = "Price ($)";
            this.lbPrice.Click += new System.EventHandler(this.lbPrice_Click);
            // 
            // lbLocation
            // 
            this.lbLocation.AutoSize = true;
            this.lbLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocation.Location = new System.Drawing.Point(390, 116);
            this.lbLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(86, 25);
            this.lbLocation.TabIndex = 88;
            this.lbLocation.Text = "Location";
            this.lbLocation.Click += new System.EventHandler(this.lbLocation_Click);
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategory.Location = new System.Drawing.Point(390, 56);
            this.lbCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(92, 25);
            this.lbCategory.TabIndex = 87;
            this.lbCategory.Text = "Category";
            // 
            // txAuthor
            // 
            this.txAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txAuthor.Location = new System.Drawing.Point(130, 240);
            this.txAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.txAuthor.Name = "txAuthor";
            this.txAuthor.ReadOnly = true;
            this.txAuthor.Size = new System.Drawing.Size(211, 30);
            this.txAuthor.TabIndex = 3;
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAuthor.Location = new System.Drawing.Point(30, 240);
            this.lbAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(70, 25);
            this.lbAuthor.TabIndex = 85;
            this.lbAuthor.Text = "Author";
            // 
            // txPublisher
            // 
            this.txPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPublisher.Location = new System.Drawing.Point(130, 175);
            this.txPublisher.Margin = new System.Windows.Forms.Padding(4);
            this.txPublisher.Name = "txPublisher";
            this.txPublisher.ReadOnly = true;
            this.txPublisher.Size = new System.Drawing.Size(211, 30);
            this.txPublisher.TabIndex = 2;
            // 
            // lbPublisher
            // 
            this.lbPublisher.AutoSize = true;
            this.lbPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPublisher.Location = new System.Drawing.Point(30, 178);
            this.lbPublisher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPublisher.Name = "lbPublisher";
            this.lbPublisher.Size = new System.Drawing.Size(93, 25);
            this.lbPublisher.TabIndex = 83;
            this.lbPublisher.Text = "Publisher";
            // 
            // txLocation
            // 
            this.txLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txLocation.Location = new System.Drawing.Point(484, 113);
            this.txLocation.Margin = new System.Windows.Forms.Padding(4);
            this.txLocation.Name = "txLocation";
            this.txLocation.ReadOnly = true;
            this.txLocation.Size = new System.Drawing.Size(191, 30);
            this.txLocation.TabIndex = 6;
            // 
            // txAvailability
            // 
            this.txAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txAvailability.Location = new System.Drawing.Point(859, 175);
            this.txAvailability.Margin = new System.Windows.Forms.Padding(4);
            this.txAvailability.Name = "txAvailability";
            this.txAvailability.ReadOnly = true;
            this.txAvailability.Size = new System.Drawing.Size(104, 30);
            this.txAvailability.TabIndex = 7;
            // 
            // txPrice
            // 
            this.txPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPrice.Location = new System.Drawing.Point(484, 175);
            this.txPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txPrice.Name = "txPrice";
            this.txPrice.ReadOnly = true;
            this.txPrice.Size = new System.Drawing.Size(191, 30);
            this.txPrice.TabIndex = 8;
            // 
            // txStock
            // 
            this.txStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txStock.Location = new System.Drawing.Point(856, 53);
            this.txStock.Margin = new System.Windows.Forms.Padding(4);
            this.txStock.Name = "txStock";
            this.txStock.ReadOnly = true;
            this.txStock.Size = new System.Drawing.Size(104, 30);
            this.txStock.TabIndex = 9;
            // 
            // txNumBorrowed
            // 
            this.txNumBorrowed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNumBorrowed.Location = new System.Drawing.Point(859, 113);
            this.txNumBorrowed.Margin = new System.Windows.Forms.Padding(4);
            this.txNumBorrowed.Name = "txNumBorrowed";
            this.txNumBorrowed.ReadOnly = true;
            this.txNumBorrowed.Size = new System.Drawing.Size(104, 30);
            this.txNumBorrowed.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNext);
            this.groupBox1.Controls.Add(this.btnPrev);
            this.groupBox1.Controls.Add(this.txCategory);
            this.groupBox1.Controls.Add(this.txNumBorrowed);
            this.groupBox1.Controls.Add(this.txBookID);
            this.groupBox1.Controls.Add(this.btnMore);
            this.groupBox1.Controls.Add(this.txStock);
            this.groupBox1.Controls.Add(this.lbID);
            this.groupBox1.Controls.Add(this.txPrice);
            this.groupBox1.Controls.Add(this.lbTitle);
            this.groupBox1.Controls.Add(this.txAvailability);
            this.groupBox1.Controls.Add(this.txTitle);
            this.groupBox1.Controls.Add(this.txLocation);
            this.groupBox1.Controls.Add(this.lbPublisher);
            this.groupBox1.Controls.Add(this.txPublisher);
            this.groupBox1.Controls.Add(this.lbNumBorrowed);
            this.groupBox1.Controls.Add(this.lbAuthor);
            this.groupBox1.Controls.Add(this.lbAvailability);
            this.groupBox1.Controls.Add(this.txAuthor);
            this.groupBox1.Controls.Add(this.lbCategory);
            this.groupBox1.Controls.Add(this.lbStock);
            this.groupBox1.Controls.Add(this.lbLocation);
            this.groupBox1.Controls.Add(this.lbPrice);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 205);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1020, 291);
            this.groupBox1.TabIndex = 109;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book Details";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNext.Location = new System.Drawing.Point(586, 226);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(89, 48);
            this.btnNext.TabIndex = 12;
            this.btnNext.Text = "Next >";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPrev.Location = new System.Drawing.Point(484, 226);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(89, 48);
            this.btnPrev.TabIndex = 11;
            this.btnPrev.Text = "< Prev";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // txCategory
            // 
            this.txCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCategory.Location = new System.Drawing.Point(484, 53);
            this.txCategory.Margin = new System.Windows.Forms.Padding(4);
            this.txCategory.Name = "txCategory";
            this.txCategory.ReadOnly = true;
            this.txCategory.Size = new System.Drawing.Size(191, 30);
            this.txCategory.TabIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 731);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1082, 22);
            this.statusStrip1.TabIndex = 110;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // frm8BookInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 753);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mbtnUpdate);
            this.Controls.Add(this.mbtnAdd);
            this.Controls.Add(this.gv);
            this.Controls.Add(this.lbMenu);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm8BookInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Galaxy Libray | Book Information";
            this.Load += new System.EventHandler(this.frm8BookInformation_Load);
            this.Controls.SetChildIndex(this.mbtnReport, 0);
            this.Controls.SetChildIndex(this.mbtnBorrow, 0);
            this.Controls.SetChildIndex(this.mbtnReturn, 0);
            this.Controls.SetChildIndex(this.mbtnBookInformation, 0);
            this.Controls.SetChildIndex(this.mbtnMemberInfomation, 0);
            this.Controls.SetChildIndex(this.btnAdmin, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.lbMenu, 0);
            this.Controls.SetChildIndex(this.gv, 0);
            this.Controls.SetChildIndex(this.mbtnAdd, 0);
            this.Controls.SetChildIndex(this.mbtnUpdate, 0);
            this.Controls.SetChildIndex(this.statusStrip1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbMenu;
        private System.Windows.Forms.TextBox txBookID;
        private System.Windows.Forms.TextBox txTitle;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.DataGridView gv;
        private System.Windows.Forms.Button btnMore;
        private System.Windows.Forms.Button mbtnUpdate;
        private System.Windows.Forms.Button mbtnAdd;
        private System.Windows.Forms.Label lbNumBorrowed;
        private System.Windows.Forms.Label lbAvailability;
        private System.Windows.Forms.Label lbStock;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbLocation;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.TextBox txAuthor;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.TextBox txPublisher;
        private System.Windows.Forms.Label lbPublisher;
        private System.Windows.Forms.TextBox txLocation;
        private System.Windows.Forms.TextBox txAvailability;
        private System.Windows.Forms.TextBox txPrice;
        private System.Windows.Forms.TextBox txStock;
        private System.Windows.Forms.TextBox txNumBorrowed;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txCategory;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}