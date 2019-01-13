using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows.Forms;

namespace SA47Team10a_GalaxyLibrary
{
    public partial class frm7Return : frmTemplate, Interface1
    {
        GalaxyEntities context = new GalaxyEntities();
        public frm7Return()
        {
            InitializeComponent();
        }

        //for linking with Customer information
        public void SetMemberID(string s)
        {
            txMemberID.Text = s;
        }


        private void btnReturn_Click(object sender, EventArgs e)
        {

            try
            {
                // Validate Book ID
                if (txBookID.Text.Length == 5 && txBookID.Text.Substring(0, 1) == "G" && Convert.ToInt32(txBookID.Text.Substring(1, 4)) >= 1 && Convert.ToInt32(txBookID.Text.Substring(1, 4)) <= context.Books.Count())
                {
                //Check if member has borrowed this book
                if (context.Transactions.Where(x => (x.BookID == txBookID.Text) && (x.MemberID == txMemberID.Text) && (x.LoanStatus == "Borrowed")).FirstOrDefault() == null)
                        throw new NoTransactionException();

                Transaction r = context.Transactions.Where(x => (x.BookID == txBookID.Text) && (x.MemberID == txMemberID.Text) && (x.LoanStatus == "Borrowed")).FirstOrDefault();
                MessageBox.Show(r.TransactionID.ToString());


                    // Indentify transaction record and update return date, loanstatus and remarks
                    Transaction t = context.Transactions.Where(x => x.MemberID == txMemberID.Text && x.BookID == txBookID.Text && x.LoanStatus == "Borrowed").First();
                    t.ReturnDate = DateTime.Today.Date;
                    t.LoanStatus = "Returned";
                    t.Remarks = txRemarks.Text;
                    gvReturn.DataSource = context.Transactions.Where(x => x.LoanStatus == "Borrowed" && x.MemberID == txMemberID.Text).Select(x => new { x.TransactionID, x.BookID, x.MemberID, x.LoanStatus, x.IssueDate, x.DueDate, }).ToList();

                    // Identify member record 
                    Member m = context.Members.Where(x => x.MemberID == txMemberID.Text).First();
                    CalculateFine(); // Update fine amount in member record 
                    txFineAmount.Text = Convert.ToString(m.FineAmount); // Display fine amount to user

                    // Identify book record
                    Book b = context.Books.Where(x => x.BookID == txBookID.Text).First();
                    b.NumberBorrowed -= 1; // decrease book borrowed
                    context.SaveChanges();

                }
                else
                {
                    MessageBox.Show("This book is not existing! You may input the wrong BookID, please check and input again!");
                }
            }
            catch (NoTransactionException ex)
            {
                ex = new NoTransactionException("Member did not borrow this book.");
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid MemberId" + ex.ToString());
            }
        }

        public void CalculateFine()
        {
            float fine;
            Transaction t = context.Transactions.Where(x => x.MemberID == txMemberID.Text && x.BookID == txBookID.Text && x.LoanStatus == "Borrowed").First();
            TimeSpan? timsp = t.ReturnDate - t.DueDate;
            double xxx = timsp.Value.TotalDays;
            fine = (float)(xxx * 2);
            MessageBox.Show("Fine: " + fine);
            Member m = context.Members.Where(x => x.MemberID == txMemberID.Text).First();
            m.FineAmount = fine;
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            try
            {
                if (txMemberID == null || txBookID == null || txRemarks == null)
                    throw new InvalidInputException();
                Transaction t = context.Transactions.Where(x => x.MemberID == txMemberID.Text && x.BookID == txBookID.Text).First();
                if (t.LoanStatus == "Borrowed")
                {
                    gvReturn.DataSource = context.Books.Select(x => new { x.BookID, x.Title, x.Price }).Where(x => x.BookID == txBookID.Text).ToList();
                    Book b = context.Books.Where(x => x.BookID == txBookID.Text).First();
                    b.TotalStock -= 1;
                    float fine;
                    Member m = context.Members.Where(x => x.MemberID == txMemberID.Text).First();
                    Book b1 = context.Books.Where(x => x.BookID == txBookID.Text).First();
                    fine = (float)Convert.ToDouble(m.FineAmount + b.Price);
                    m.FineAmount = fine;
                    txFineAmount.Text = Convert.ToString(fine);
                    context.SaveChanges();
                    MessageBox.Show("Total stock value is deducted");
                }
                else
                {
                    MessageBox.Show("The book is already returned");
                }

            }
            catch (Exception a)
            {
                a = new InvalidInputException("Please fill in all fields.");
                MessageBox.Show(a.Message);
            }
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            // Dialog form
            frm11BookSearchForStaff f = new frm11BookSearchForStaff();
            DialogResult r = f.ShowDialog(this);
            f.Location = this.Location;

            // Display all fields of selected record if 'OK' was chosen in dialog
            if (r == DialogResult.OK)
            {
                Book b = context.Books.Where(x => x.BookID == f.SelectedID).First();
                txBookID.Text = b.BookID;
            }
        }

        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            frm13MemberSearch f = new frm13MemberSearch();
            DialogResult r = f.ShowDialog(this);
            f.Location = this.Location;

            if (r == DialogResult.OK)
            {
                Member m = context.Members.Where(x => x.MemberID == f.SelectedID).First();
                txMemberID.Text = m.MemberID;
            }
        }
    }

    class NoTransactionException : ApplicationException
    {
        public NoTransactionException() : base() { }
        public NoTransactionException(string message) : base(message) { }

    }

}
