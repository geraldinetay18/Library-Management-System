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
    public partial class frmBossVenkatCustomer : frmTemplate
    {
        public frmBossVenkatCustomer()
        {
            InitializeComponent();
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            GalaxyEntities ctx = new GalaxyEntities();
            if (txmemberID.Text.Length == 5 && txmemberID.Text.Substring(0, 1) == "M")
            {
                if (Convert.ToInt32(txmemberID.Text.Substring(1, 4)) >= 1000 && Convert.ToInt32(txmemberID.Text.Substring(1, 4)) <= ctx.Members.Count() + 999)
                {
                    Member c = ctx.Members.Where(x => x.MemberID == txmemberID.Text).First();
                    txmemberID.Text = c.MemberID.ToString();
                    txName.Text = c.Name.ToString();
                    txCategory.Text = c.MemberCategory.ToString();
                    txFine.Text = c.FineAmount.ToString();
                }
                else
                {
                    MessageBox.Show("This format of input is right but this member is not existing!");
                }
            }
            else
            {
                MessageBox.Show("You input the wrong format! You can check the notice and input again!");
            }
        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            txmemberID.Text = "";
            txName.Text = "";
            txCategory.Text = "";
            txFine.Text = "";
        }

        private void btnUpfM_Click(object sender, EventArgs e)
        {
            GalaxyEntities ctx = new GalaxyEntities();
            Member c = new Member();
            try
            {
                // Validate ID to be existing
                if (txmemberID.Text.Length == 5 && txmemberID.Text.Substring(0, 1) == "M")
                {
                    if (Convert.ToInt32(txmemberID.Text.Substring(1, 4)) >= 1000 && Convert.ToInt32(txmemberID.Text.Substring(1, 4)) <= ctx.Members.Count() + 999)
                    {
                        // Identify member record
                        c = ctx.Members.Where(x => x.MemberID == txmemberID.Text).First();
                        c.FineAmount = Convert.ToDouble(txFine.Text);
                        ctx.SaveChanges();
                        MessageBox.Show("Successful update!");
                        btnclr_Click(sender, e);
                    }
                }
                else
                    MessageBox.Show("Not an existing MemberID!");
            }
            catch (Exception a)
            {
                a = new InvalidInputException("Please ensure that details of member is correct.");
                MessageBox.Show(a.Message);
            }
           
        }

        private void txmemberID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnRetrieve_Click(sender, e);
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBossVenkat f = new frmBossVenkat();
            f.Location = this.Location;
            f.ShowDialog();
            this.Close();
        }
    }
}
