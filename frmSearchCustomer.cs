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
    public partial class frmSearchCustomer : Form
    {
        GalaxyEntities context;
        string searchDetail;
        string getID;
        DataGridViewRow selectRow;
        protected List<string> searchByList = new List<string> { "Name", "Phone Number", "Email Address" };

        public frmSearchCustomer()
        {
            InitializeComponent();
            context = new GalaxyEntities();
            cbxSearchBy.DataSource = searchByList;
            btnRetrieve.Enabled = false;
            btnSearch.Enabled = false;
            txSearchDetail.ReadOnly = true;
        }

        public string GetID
        {
            get
            {
                return getID;
            }
        }

        private void cbxSearchBy_TextChanged(object sender, EventArgs e)
        {
            txSearchDetail.ReadOnly = false;
        }

        private void txSearchDetail_TextChanged(object sender, EventArgs e)
        {
            btnSearch.Enabled = true;
            btnSearch_Click(sender, e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchDetail = txSearchDetail.Text;
            string by = cbxSearchBy.Text;
            switch (by) {
                case "Name":
                    gvSearchResult.DataSource = context.Members.Where(x => x.Name.Contains(searchDetail)).OrderBy(y => y.Name).ToList();
                    break;
                case "Phone Number":
                    gvSearchResult.DataSource = context.Members.Where(x => x.PhoneNumber.ToString().Contains(searchDetail)).OrderBy(y => y.PhoneNumber).ToList();
                    break;
                case "Email Address":
                    gvSearchResult.DataSource = context.Members.Where(x => x.EmailAddress.Contains(searchDetail)).OrderBy(y => y.EmailAddress).ToList();
                    break;
            }
        }

        private void gvSearchResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnRetrieve.Enabled = true;

            selectRow = gvSearchResult.Rows[e.RowIndex];
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            getID = selectRow.Cells[0].Value.ToString();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
