using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace SA47Team10a_GalaxyLibrary
{
    public partial class frm6BorrowBook : frmTemplate
    {
        GalaxyEntities context = new GalaxyEntities();

        public frm6BorrowBook()
        {
            InitializeComponent();
        }

        //for linking with Customer information
        public void SetMemberID(string s)
        {
            txMemberID.Text = s;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            using (GalaxyEntities context = new GalaxyEntities()) {
                txMemberID.Text.Trim();
                txBookID.Text.Trim();

                if (txMemberID.Text.Length == 5 && txMemberID.Text.Substring(0, 1) == "M" &&
                        Convert.ToDouble(txMemberID.Text.Substring(1, 4)) >= 1000 && Convert.ToDouble(txMemberID.Text.Substring(1, 4)) <= context.Members.Count() + 999) {
                    if (txBookID.Text.Length == 5 && txBookID.Text.Substring(0, 1) == "G" && Convert.ToDouble(txBookID.Text.Substring(1, 4)) >= 1 && Convert.ToDouble(txBookID.Text.Substring(1, 4)) <= context.Books.Count()) {
                        int i = TotalBookStockValidation(context);

                        if (i > 0) {
                            var count = context.Transactions.Where(x => x.MemberID == txMemberID.Text && x.LoanStatus == "Borrowed").Count();
                            var Lecturer = context.Members.Where(x => x.MemberID == txMemberID.Text && x.MemberCategory == "Lecturer");

                            if (count <= 3) {
                                Transaction t = new Transaction();
                                t.TransactionID = (context.Transactions.Count() + 1);
                                t.BookID = txBookID.Text;
                                t.MemberID = txMemberID.Text;
                                t.IssueDate = DateTime.Today.Date;
                                t.DueDate = DateTime.Now.AddDays(10);
                                t.LoanStatus = "";
                                context.Transactions.Add(t);
                                context.SaveChanges();

                                DateTime r = DateTime.Today;

                                Transaction t1 = context.Transactions.Where
                                (x => x.MemberID == txMemberID.Text && x.BookID == txBookID.Text).First();
                                if (Lecturer != null) //Lecturers loan duration is 20 compared to 10
                                {
                                    t1.DueDate = DateTime.Today.Date.AddDays(20);
                                }
                                else {
                                    t1.DueDate = DateTime.Now.AddDays(10);
                                }
                                Book b1 = new Book();
                                b1 = context.Books.Where(x => x.BookID == txBookID.Text).First();
                                b1.NumberBorrowed += 1;
                                b1.TotalStock -= 1;
                                Member a = new Member();
                                a = context.Members.Where(x => x.MemberID == txMemberID.Text).First();
                                a.CurrentBorrowing += 1;
                                t.LoanStatus = "Borrowed";
                                context.SaveChanges();
                                GV.DataSource = context.Transactions.Where(x => x.LoanStatus == "Borrowed" && x.MemberID == txMemberID.Text).
                                                                Select(x => new { x.TransactionID, x.BookID, x.MemberID, x.ReturnDate, x.IssueDate, x.DueDate, x.ExtensionCount, x.LoanStatus, x.Remarks }).
                                                                ToList();
                            }
                            else {
                                txSuccess.Text = "Borrowing Limit Reached";
                            }
                        }
                        else {
                            txSuccess.Text = "Book Currently Unavailable!";
                        }
                    }
                    else {
                        txSuccess.Text = "Wrong input!";
                    }
                }
                else {
                    txSuccess.Text = "Wrong Input!";
                }

            }
        }

        private void btnExtension_Click(object sender, EventArgs e)
        {
            using (GalaxyEntities context = new GalaxyEntities())
            {
                txMemberID.Text.Trim();
                txBookID.Text.Trim();

                if (UsernamePasswordisValid(context))
                {
                    if (TotalBorrowCount(context))
                    {
                        int i = ExtensionCount(context);
                        var Lecturer = LecturerValidation(context);

                        if (i < 3)
                        {
                            Extension(context);
                            var Display = context.Transactions.Where
                                (x => x.BookID == txBookID.Text && x.MemberID == txMemberID.Text).Select(x => new { x.TransactionID, x.BookID, x.MemberID, x.ReturnDate, x.IssueDate, x.DueDate, x.ExtensionCount, x.LoanStatus, x.Remarks });

                            GV.DataSource = Display.ToList(); // DataGridView
                        }
                        else
                        {
                            txSuccess.Text = "Extension Limit Reached";
                        }
                    }
                    else
                    {
                        txSuccess.Text = "Wrong Input!";
                    }
                }
                else
                {
                    txSuccess.Text = "Wrong Input!";
                }
            }
        }

        //methods 
        private IQueryable<Member> LecturerValidation(GalaxyEntities context)
        {
            return context.Members.Where(x => x.MemberID == txMemberID.Text && x.MemberCategory == "Lecturer");
        }

        private void Extension(GalaxyEntities context)
        {
            Transaction t = context.Transactions.Where(x => x.BookID == txBookID.Text && x.MemberID == txMemberID.Text).FirstOrDefault();
            t.IssueDate = DateTime.Today.Date;
            t.DueDate = DateTime.Now.AddDays(10);
            t.ExtensionCount += 1;
            context.SaveChanges();
        }

        private int ExtensionCount(GalaxyEntities context)
        {
            var count = from x in context.Transactions where x.MemberID == txMemberID.Text && x.BookID == txBookID.Text select x;
            Transaction c = count.First();
            int i = c.ExtensionCount;
            return i;
        }

        private bool UsernamePasswordisValid(GalaxyEntities context)
        {
            return txMemberID.Text.Length == 5 && txMemberID.Text.Substring(0, 1) == "M" &&
                                  Convert.ToInt32(txMemberID.Text.Substring(1, 4)) >= 1000 && Convert.ToInt32(txMemberID.Text.Substring(1, 4)) <= context.Members.Count() + 999;
        }

        private bool TotalBorrowCount(GalaxyEntities context)
        {
            return txBookID.Text.Length == 5 && txBookID.Text.Substring(0, 1) == "G" && Convert.ToDouble(txBookID.Text.Substring(1, 4)) >= 1 && Convert.ToDouble(txBookID.Text.Substring(1, 4)) <= context.Books.Count();
        }

        private void txBookID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                btnConfirm_Click(sender, e);
            }
        }

        private int TotalBookStockValidation(GalaxyEntities context)
        {
            var TotalStockCount = from x in context.Books.Where(x => x.BookID == txBookID.Text) select x.TotalStock;
            int i = TotalStockCount.Single();
            return i;
        }
    }
}
