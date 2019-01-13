using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA47Team10a_GalaxyLibrary
{
    public abstract partial class frmTemplateSearch : Form
    {

        protected GalaxyEntities context;
        protected string selectedID;
        protected DataGridViewRow selectedRow;

        public string SelectedID
        {
            get { return selectedID; }
        }

        public frmTemplateSearch()
        {
            InitializeComponent();

            // Display default filter for user to search by
            cbxSearchBy.SelectedIndex = 0;

            // Set viewing preference for grid view
            gvSearchResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;


            txSearchDetail.Text = "";
            selectedID = "";
            context = new GalaxyEntities();
        }


        // Derived forms to determine search criteria
        public abstract void btnSearch_Click(object sender, EventArgs e);


        private void txSearchDetail_TextChanged(object sender, EventArgs e)
        {
            btnSearch_Click(sender, e);
        }


        private void txSearchDetail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                gvSearchResult_KeyDown(sender, e);
        }


        public virtual void gvSearchResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Capture ID of selected book/member record
                selectedRow = gvSearchResult.Rows[e.RowIndex];
                selectedID = selectedRow.Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in selection of record.");
            }
            
        }


        private void gvSearchResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = gvSearchResult.CurrentRow;
            selectedID = selectedRow.Cells[0].Value.ToString();
            btnRetrieve_Click(sender, e);
        }


        private void gvSearchResult_KeyDown(object sender, KeyEventArgs e)
        {
            selectedRow = gvSearchResult.CurrentRow;

            if ((e.KeyCode == Keys.Enter) && (selectedRow != null))
            {
                selectedID = selectedRow.Cells[0].Value.ToString();
                btnRetrieve_Click(sender, e);
            }
        }


        public virtual void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


        public virtual void btnRetrieve_Click(object sender, EventArgs e)
        {
            // Return the first record
            selectedRow = gvSearchResult.CurrentRow;

            if (selectedRow != null)
            {
                selectedID = selectedRow.Cells[0].Value.ToString();
                this.DialogResult = DialogResult.OK;
            }
        }
    }


    class InvalidInputException : ApplicationException
    {
        public InvalidInputException() : base() { }
        public InvalidInputException(string message) : base(message) { }

    }
}
