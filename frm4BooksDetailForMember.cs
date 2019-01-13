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
    public partial class frm4BooksDetailForMember : Form
    {
        GalaxyEntities context;
        Form f;
        Book b;

        public frm4BooksDetailForMember()
        {
            InitializeComponent();
            context = new GalaxyEntities();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frm5BookSearchForMember f = new frm5BookSearchForMember();
            DialogResult r = f.ShowDialog(this);
            f.Location = this.Location;

            if (r == DialogResult.OK)
            {
                b = context.Books.Where(x => x.BookID == f.SelectedID).First();
                PopulateFields(b);
            }
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            
            if (txBookID.Text.Length==5 && txBookID.Text.Substring(0, 1).ToUpper() == "G" && Convert.ToDouble(txBookID.Text.Substring(1, 4)) >= 1 && Convert.ToDouble(txBookID.Text.Substring(1, 4)) <= context.Books.Count())
            {
                var q = from x in context.Books where x.BookID == txBookID.Text select x;
                Book b = q.First();
                PopulateFields(b);
            }
            else
            {
                MessageBox.Show("This book is not existing! You may input the wrong BookID, please check and input again!");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            f = new frm1Welcome();
            f.Location = this.Location;
            f.ShowDialog();
            this.Close();
        }

        private void txBookID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                btnRetrieve_Click(sender, e);
            }
        }

        private void PopulateFields(Book b)
        {
            txBookID.Text = "";
            txID.Text = b.BookID;
            txTitle.Text = b.Title;
            txAuthor.Text = b.Author;
            txPublisher.Text = b.Publisher;
            txCategory.Text = b.BookCategory;
            txLocation.Text = b.Location;
            txPrice.Text = b.Price.ToString();
            txTotalStock.Text = b.TotalStock.ToString();
            txNumber.Text = (b.TotalStock - b.NumberBorrowed).ToString();

            var q = from x in context.Transactions
                    where (x.BookID == b.BookID && x.ReturnDate == null)
                    select new { x.BookID, x.IssueDate, x.DueDate, x.LoanStatus };

            gvBorrowedList.DataSource = q.ToList();
        }
    }
}
