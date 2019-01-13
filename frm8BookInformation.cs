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
    public partial class frm8BookInformation : frmTemplate
    {

        GalaxyEntities context;
        List<Book> bookList;
        Book b;
        int position;
        string tempID;
        Form f;

        public frm8BookInformation()
        {
            InitializeComponent();
        }

        private void frm8BookInformation_Load(object sender, EventArgs e)
        {
            context = new GalaxyEntities();
            tempID = "";

            // View first book
            position = 0;
            bookList = context.Books.ToList();
            b = bookList[position];
            displayDetails();
            displayHistory();
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            // Dialog form
            frm11BookSearchForStaff f = new frm11BookSearchForStaff();
            DialogResult r = f.ShowDialog(this);
            f.Location = this.Location;

            // Display all fields of selected record if 'OK' was chosen in dialog
            if (r == DialogResult.OK)
            {
                b = context.Books.Where(x => x.BookID == f.SelectedID).First();
                position = bookList.IndexOf(b);
                displayDetails();
                displayHistory();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (position < (context.Books.Count()-1))
            {
                position++;
                b = bookList[position];
                displayDetails();
                displayHistory();
            }
            else
                MessageBox.Show("Last record in the list. No more records.");
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (position > 0)
            {
                position--;
                b = bookList[position];
                displayDetails();
                displayHistory();
            }
            else
                MessageBox.Show("First record in the list. No previous records.");           
        }

        private void displayDetails()
        {
            txBookID.Text = b.BookID;
            txTitle.Text = b.Title;
            txAuthor.Text = b.Author;
            txPublisher.Text = b.Publisher;
            txCategory.Text = b.BookCategory;
            txLocation.Text = b.Location;
            txPrice.Text = b.Price.ToString();
            txStock.Text = b.TotalStock.ToString();
            txNumBorrowed.Text = b.NumberBorrowed.ToString();
            txAvailability.Text = b.Availability;

            toolStripStatusLabel1.Text = "Record: " + (position + 1);
        }

        private void displayHistory()
        {
            gv.DataSource = context.Transactions.Where(x => x.BookID == b.BookID).
                                              Select(x => new { x.BookID, x.IssueDate, x.DueDate, x.ReturnDate, x.LoanStatus }).ToList();
        }

        private string PopulateZeroes(int digits)
        {
            string zeroes = "";

            if (digits < 10)
                zeroes = "000";
            else if (digits < 100)
                zeroes = "00";
            else if (digits < 1000)
                zeroes = "0";

            return zeroes;
        }

        private void lbPrice_Click(object sender, EventArgs e)
        {

        }

        private void lbLocation_Click(object sender, EventArgs e)
        {

        }

        private void mbtnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            f = new frmBookAdd();
            f.Location = this.Location;
            f.ShowDialog();
            this.Close();
        }

        private void mbtnUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            f = new frmBookModify();
            f.Location = this.Location;
            f.ShowDialog();
            this.Close();
        }
    }
}
