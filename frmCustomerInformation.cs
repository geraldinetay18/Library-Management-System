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
    
    public partial class frmCustomerInformation : frmTemplate
    {
        GalaxyEntities context;
        List<Member> membersList;
        Member m;
        string choose;
        int position;
        Form f;

        public frmCustomerInformation()
        {
            InitializeComponent();

            context = new GalaxyEntities();

            btnBorrow.Enabled = false;
            btnPay.Enabled = false;
            btnRetrieve.Enabled = false;
            btnUpdate.Enabled = false;
            btnReturn.Enabled = false;
            btnConfirm.Enabled = false;
            btnCancel.Enabled = false;
            btnAdd.Enabled = true;

            groupBoxReadOnly(true);

            // Display first customer by default
            position = 0;
            membersList = context.Members.ToList();
            m = membersList[position];
            display(m);
        }

        //methods
        public void groupBoxReadOnly (bool x)
        {
            bool y=false;
            if (x == false) { y = true; }
            txCustomerName.ReadOnly = x;
            txAddress.ReadOnly = x;
            txEmailAddress.ReadOnly = x;
            txPhoneNumber.ReadOnly = x;
            cbxMemberCategory.Enabled = y;
            dtpDateOfBirth.Enabled = y;
            cbxStatus.Enabled = y;
        }
        private void display (Member m)
        {
            txCustomerID.Text = m.MemberID;
            txCustomerName.Text = m.Name;
            cbxMemberCategory.Text = m.MemberCategory;
            dtpDateOfBirth.Value = m.DateOfBirth.Date;
            txAddress.Text = m.Address;
            txEmailAddress.Text = m.EmailAddress;
            txPhoneNumber.Text = m.PhoneNumber.ToString();
            cbxStatus.Text = m.Status;
            txFineAmount.Text = m.FineAmount.ToString();
            toolStripStatusLabel1.Text = "Record: " + position;

            //grid
            var q = from x in context.Transactions
                    where (x.MemberID==m.MemberID && x.DueDate==null)
                    select new { x.BookID, x.Book.Title, x.DueDate };
            gridCurrentBorrwing.DataSource = q.ToList();
        }

        private void updateMember (Member m)
        {
            m.Name = txCustomerName.Text;
            m.MemberCategory = cbxMemberCategory.SelectedItem.ToString();
            m.DateOfBirth = dtpDateOfBirth.Value;
            m.Address = txAddress.Text;
            //m.PhoneNumber = Convert.ToInt32(txPhoneNumber.Text);
            m.PhoneNumber = txPhoneNumber.Text;
            m.EmailAddress = txEmailAddress.Text;
            m.Status = cbxStatus.SelectedItem.ToString();
        }

        private void resetCustomerDetails()
        {
            txCustomerName.Text = "";
            cbxMemberCategory.Text = cbxMemberCategory.ValueMember;
            dtpDateOfBirth.Value = DateTime.Today;
            txAddress.Text = "";
            txEmailAddress.Text = "";
            txPhoneNumber.Text = "";
            txCustomerID.Text = "";
        }

        private void btnChangeColor(Button btn, bool b)
        {
            if (b == true) {
                btn.BackColor = Color.WhiteSmoke;
                btn.ForeColor = Color.Black;
                btn.Font = new Font(btn.Font, FontStyle.Bold);
            }
            else {
                btn.BackColor = Color.DarkGoldenrod;
                btn.ForeColor = Color.White;
                btn.Font = new Font(btn.Font, FontStyle.Regular);
            }

        }



        //button event
        private void btnCustomerInformation_MouseMove(object sender, MouseEventArgs e)
        {
            //btnCustomerInformation.BackColor = Color.ForestGreen;
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            
            try {
                m = context.Members.Where(x => x.MemberID == txCustomerID.Text.ToUpper()).First();
                position = membersList.IndexOf(m);
                display(m);
                groupBoxReadOnly(true);
                if (txFineAmount.Text != "0") {
                    btnPay.Enabled = true;
                }
                else {
                    btnPay.Enabled = false;
                    btnBorrow.Enabled = true;
                    btnReturn.Enabled = true;
                }
                btnRetrieve.Enabled = false;
                btnAdd.Enabled = true;
            } catch (Exception a) {
                a = new ErrorException("ID Number is incorrect!!");
                MessageBox.Show(a.Message);
            }
        }

        private void txCustomerID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnRetrieve_Click(sender, e);
        }
        private void txCustomerID_TextChanged(object sender, EventArgs e)
        {
            btnRetrieve.Enabled = true;
            //btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void txCustomerName_TextChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
        }

        
        //update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            choose = "Update";
            btnConfirm.Enabled = true;
            btnCancel.Enabled = true;
            btnChangeColor(btnAdd, false);
            btnChangeColor(btnUpdate, true);
            btnAdd.Enabled = false;
            btnRetrieve.Enabled = false;
            
            //groupBox1.Enabled = true;

            groupBoxReadOnly(false);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try {
                if (choose == "Update") {
                    groupBoxReadOnly(true);
                    m = context.Members.Where(x => x.MemberID == txCustomerID.Text.ToUpper()).First();
                    updateMember(m);
                    m.Status = cbxStatus.Text;


                    context.SaveChanges();
                    MessageBox.Show("Customer information successfully updated!");

                    btnAdd.Enabled = true;
                    btnConfirm.Enabled = false;
                    resetCustomerDetails();
                }
                if (choose == "Add") {
                    if (txCustomerName.Text == "" || txPhoneNumber.Text == "" || txEmailAddress.Text == "") {
                        throw new ErrorException("Please ensure fill in all the necessary details.");
                    }
                    updateMember(m);
                    m.CurrentBorrowing = 0;
                    m.FineAmount = 0;
                    context.Members.Add(m);

                    context.SaveChanges();
                    MessageBox.Show("Customer successfully added!");

                    resetCustomerDetails();
                }
            }
            catch (Exception a) {
                a = new ErrorException("Please ensure valid format for all the details.");
                MessageBox.Show(a.Message);
            }
            
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            m.FineAmount = 0;
            
            context.SaveChanges();
            MessageBox.Show("Payment successful!");
            txFineAmount.Text = m.FineAmount.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            choose = "Add";
            btnChangeColor(btnAdd, true);
            btnChangeColor(btnUpdate, false);
            resetCustomerDetails();

            btnCancel.Enabled = true;
            btnConfirm.Enabled = true;
            btnUpdate.Enabled = false;
            groupBoxReadOnly(false);
            txCustomerID.ReadOnly = true;

            m = new Member();
            m.MemberID = "M" + (context.Members.Count() + 1000);
            txCustomerID.Text = m.MemberID;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frm13MemberSearch f = new frm13MemberSearch();
            DialogResult r = f.ShowDialog(this);
            f.Location = this.Location;

            if (r == DialogResult.OK) {
                txCustomerID.Text = f.SelectedID;
                m = context.Members.Where(x => x.MemberID == f.SelectedID).First();
                position = membersList.IndexOf(m);
                display(m);
                btnUpdate.Enabled = true;
                btnAdd.Enabled = true;
                btnBorrow.Enabled = true;
                btnReturn.Enabled = true;
                btnRetrieve.Enabled = false;
                btnConfirm.Enabled = false;

                btnChangeColor(btnAdd, false);
                btnChangeColor(btnUpdate, false);
            }
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            //launch form Borrow
            //fill all required the customer informations
            
            this.Hide();
            frm6BorrowBook f = new frm6BorrowBook();
            f.Location = this.Location;
            f.SetMemberID(m.MemberID.ToString());

            f.ShowDialog();
            this.Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //launch form Return
            //fill all required the customer informations
            this.Hide();
            frm7Return f = new frm7Return();
            f.Location = this.Location;
            f.SetMemberID(m.MemberID.ToString());

            f.ShowDialog();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //frmCustomerInformation newForm = new frmCustomerInformation();
            //newForm.Location = this.Location;
            //newForm.Show();

            //this.Dispose(false);

            resetCustomerDetails();
            groupBoxReadOnly(true);
            txCustomerID.ReadOnly = false;
            btnChangeColor(btnAdd, false);
            btnChangeColor(btnUpdate, false);
            btnBorrow.Enabled = false;
            btnPay.Enabled = false;
            btnRetrieve.Enabled = false;
            btnUpdate.Enabled = false;
            btnAdd.Enabled = true;
            btnReturn.Enabled = false;
            btnConfirm.Enabled = false;
            btnCancel.Enabled = false;

            groupBoxReadOnly(true);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (position > 0)
            {
                position--;
                m = membersList[position];
                display(m);
            }
            else
                MessageBox.Show("First record already. No previous records.");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (position < (context.Members.Count() - 1))
            {
                position++;
                m = membersList[position];
                display(m);
            }
            else
                MessageBox.Show("Last record already. No further records.");
        }
    }
}
