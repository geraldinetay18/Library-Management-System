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
    public partial class frmBookModify : frmTemplate
    {
        GalaxyEntities context;
        Book b;
        Form f;
        public frmBookModify()
        {
            InitializeComponent();
        }

        private void frmBookModify_Load(object sender, EventArgs e)
        {
            context = new GalaxyEntities();
            readOnlyFields();
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            // Dialog form
            frm11BookSearchForStaff f = new frm11BookSearchForStaff();
            DialogResult r = f.ShowDialog(this);

            // Display all fields of selected record if 'OK' was chosen in dialog
            if (r == DialogResult.OK)
            {

                b = context.Books.Where(x => x.BookID == f.SelectedID).First();
                txBookID.Text = b.BookID;
                txTitle.Text = b.Title;
                txAuthor.Text = b.Author;
                txPublisher.Text = b.Publisher;
                cbxCategory.Text = b.BookCategory;
                cbxFloor.Text = b.Location.Substring(1, 1);
                txShelf.Text = b.Location.Substring(4, 3);
                txPrice.Text = b.Price.ToString();
                txStock.Text = b.TotalStock.ToString();
                txNumBorrowed.Text = b.NumberBorrowed.ToString();
                if (b.Availability.ToString() == "yes")
                    rbtnYes.Checked = true;
                else
                    rbtnNo.Checked = true;

                enableUpdateFields();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetValues();
            readOnlyFields();
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (txTitle.Text == "" || txPublisher.Text == "" || txAuthor.Text == "" || txShelf.Text == "" || txPrice.Text == "" || txStock.Text == "")
                    throw new InvalidInputException();

                // Update book details in database
                b.Title = txTitle.Text;
                b.Publisher = txPublisher.Text;
                b.Author = txAuthor.Text;
                b.BookCategory = cbxCategory.SelectedItem.ToString();
                b.Location = "F" + cbxFloor.SelectedItem.ToString() + "-L" + txShelf.Text;
                b.Price = Convert.ToDouble(txPrice.Text);
                b.TotalStock = Convert.ToInt32(txStock.Text);
                if (rbtnYes.Checked)
                    b.Availability = "yes";
                else
                    b.Availability = "no";

                context.SaveChanges();
                MessageBox.Show("Book information successfully updated!");
                ResetValues();
                readOnlyFields();
            }
            catch (Exception a)
            {
                a = new InvalidInputException("Please fill in all fields.");
                MessageBox.Show(a.Message);
            }
        }

        private void ResetValues()
        {
            txBookID.Text = "";
            txTitle.Text = "";
            txPublisher.Text = "";
            txAuthor.Text = "";
            cbxCategory.Text = "";
            cbxFloor.Text = "";
            txShelf.Text = "";
            txPrice.Text = "";
            txStock.Text = "";
            rbtnYes.Checked = false;
            rbtnNo.Checked = false;
        }

        public void readOnlyFields()
        {
            txTitle.ReadOnly = true;
            txPublisher.ReadOnly = true;
            txAuthor.ReadOnly = true;
            cbxCategory.Enabled = false;
            cbxFloor.Enabled = false;
            txShelf.ReadOnly = true;
            txPrice.ReadOnly = true;
            txStock.ReadOnly = true;
            rbtnYes.Enabled = false;
            rbtnNo.Enabled = false;
        }

        public void enableUpdateFields()
        {
            txTitle.ReadOnly = false;
            txPublisher.ReadOnly = false;
            txAuthor.ReadOnly = false;
            cbxCategory.Enabled = true;
            cbxFloor.Enabled = true;
            txShelf.ReadOnly = false;
            txPrice.ReadOnly = false;
            txStock.ReadOnly = false;
            rbtnYes.Enabled = true;
            rbtnNo.Enabled = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            f = new frm8BookInformation();
            f.Location = this.Location;
            f.ShowDialog();
            this.Close();
        }

        private void mbtnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            f = new frmBookAdd();
            f.Location = this.Location;
            f.ShowDialog();
            this.Close();
        }
    }
}
