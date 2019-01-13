namespace SA47Team10a_GalaxyLibrary
{
    partial class frmTemplateSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTemplateSearch));
            this.label14 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRetrieve = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbxSearchBy = new System.Windows.Forms.ComboBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.txSearchDetail = new System.Windows.Forms.TextBox();
            this.gvSearchResult = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvSearchResult)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Font = new System.Drawing.Font("Trebuchet MS", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(496, 129);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(400, 61);
            this.label14.TabIndex = 41;
            this.label14.Text = "GALAXY LIBRARY";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnCancel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Location = new System.Drawing.Point(534, 766);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 46);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnRetrieve.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetrieve.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRetrieve.Location = new System.Drawing.Point(694, 766);
            this.btnRetrieve.Margin = new System.Windows.Forms.Padding(2);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.Size = new System.Drawing.Size(165, 46);
            this.btnRetrieve.TabIndex = 4;
            this.btnRetrieve.Text = "Retrieve";
            this.btnRetrieve.UseVisualStyleBackColor = false;
            this.btnRetrieve.Click += new System.EventHandler(this.btnRetrieve_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Indigo;
            this.btnSearch.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearch.Location = new System.Drawing.Point(1104, 236);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(138, 46);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbxSearchBy
            // 
            this.cbxSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSearchBy.FormattingEnabled = true;
            this.cbxSearchBy.Items.AddRange(new object[] {
            "temp"});
            this.cbxSearchBy.Location = new System.Drawing.Point(260, 239);
            this.cbxSearchBy.Margin = new System.Windows.Forms.Padding(2);
            this.cbxSearchBy.Name = "cbxSearchBy";
            this.cbxSearchBy.Size = new System.Drawing.Size(274, 38);
            this.cbxSearchBy.TabIndex = 1;
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbSearch.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbSearch.Location = new System.Drawing.Point(111, 241);
            this.lbSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(148, 33);
            this.lbSearch.TabIndex = 37;
            this.lbSearch.Text = "SEARCH BY";
            // 
            // txSearchDetail
            // 
            this.txSearchDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txSearchDetail.Location = new System.Drawing.Point(562, 240);
            this.txSearchDetail.Margin = new System.Windows.Forms.Padding(2);
            this.txSearchDetail.Name = "txSearchDetail";
            this.txSearchDetail.Size = new System.Drawing.Size(523, 37);
            this.txSearchDetail.TabIndex = 0;
            this.txSearchDetail.TextChanged += new System.EventHandler(this.txSearchDetail_TextChanged);
            this.txSearchDetail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txSearchDetail_KeyDown);
            // 
            // gvSearchResult
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvSearchResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSearchResult.Location = new System.Drawing.Point(118, 299);
            this.gvSearchResult.Margin = new System.Windows.Forms.Padding(2);
            this.gvSearchResult.MultiSelect = false;
            this.gvSearchResult.Name = "gvSearchResult";
            this.gvSearchResult.ReadOnly = true;
            this.gvSearchResult.RowTemplate.Height = 33;
            this.gvSearchResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvSearchResult.Size = new System.Drawing.Size(1125, 429);
            this.gvSearchResult.TabIndex = 3;
            this.gvSearchResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvSearchResult_CellClick);
            this.gvSearchResult.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvSearchResult_CellDoubleClick);
            this.gvSearchResult.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvSearchResult_KeyDown);
            // 
            // frmTemplateSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1352, 941);
            this.ControlBox = false;
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRetrieve);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbxSearchBy);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.txSearchDetail);
            this.Controls.Add(this.gvSearchResult);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmTemplateSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmTemplateSearch";
            ((System.ComponentModel.ISupportInitialize)(this.gvSearchResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label label14;
        protected System.Windows.Forms.Button btnCancel;
        protected System.Windows.Forms.Button btnRetrieve;
        protected System.Windows.Forms.Button btnSearch;
        protected System.Windows.Forms.ComboBox cbxSearchBy;
        protected System.Windows.Forms.Label lbSearch;
        protected System.Windows.Forms.TextBox txSearchDetail;
        protected System.Windows.Forms.DataGridView gvSearchResult;
    }
}