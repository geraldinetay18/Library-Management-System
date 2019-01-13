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
    public partial class frmBossVenkat : frmTemplate
    {

        public frmBossVenkat()
        {
            InitializeComponent();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            GalaxyEntities ctx = new GalaxyEntities();
            Staff c = ctx.Staffs.Where(x => x.StaffID == txID.Text).First();
            c.Name = txName.Text;
            c.Password = txPassword.Text;
            c.PhoneNumber = txPhoneNo.Text;
            c.Position = txPosition.Text;
            c.Username = txUserName.Text;
            c.Address = txAddress.Text;
            c.EmailAddress = txEmail.Text;
            ctx.SaveChanges();

            MessageBox.Show("Information successfully updated!");
        }

        private void btnSure_Click(object sender, EventArgs e)
        {
            GalaxyEntities ctx = new GalaxyEntities();
            if (txID.Text.Length == 3 && txID.Text.Substring(0, 1) == "S")
            {
                if (Convert.ToInt32(txID.Text.Substring(1, 2)) >= 1 && Convert.ToInt32(txID.Text.Substring(1, 2)) <= ctx.Staffs.Count())
                {
                    Staff c = ctx.Staffs.Where(x => x.StaffID == txID.Text).First();
                    txName.Text = c.Name;
                    txPassword.Text = c.Password;
                    txPhoneNo.Text = c.PhoneNumber.ToString();
                    txPosition.Text = c.Position;
                    txUserName.Text = c.Username;
                    txAddress.Text = c.Address;
                    txEmail.Text = c.EmailAddress;
                }
                else
                {
                    MessageBox.Show("This format of input is right but this staff is not existing! You can add a new one!");
                }
            }
            else
            {
                MessageBox.Show("You input the wrong format! You can check the notice and input again!");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GalaxyEntities ctx = new GalaxyEntities();
            
                
            if (txID.Text.Length == 3 && txID.Text.Substring(0, 1) == "S" && Convert.ToInt32(txID.Text.Substring(1, 2)) >= 1 && Convert.ToInt32(txID.Text.Substring(1, 2)) <= ctx.Staffs.Count())
            {
                bool check = false;
                foreach (Staff x in ctx.Staffs.ToList()) {
                    if (txID.Text == x.StaffID) {
                        check = true;
                        break;
                    }
                }
                if (check == false) {
                    Staff c = new Staff();
                    c.StaffID = txID.Text;
                    c.Name = txName.Text;
                    c.Password = txPassword.Text;
                    c.PhoneNumber = txPhoneNo.Text;
                    c.Position = txPosition.Text;
                    c.Username = txUserName.Text;
                    c.Address = txAddress.Text;
                    c.EmailAddress = txEmail.Text;
                    ctx.Staffs.Add(c);
                    ctx.SaveChanges();

                    MessageBox.Show("Staff successfully added!");
                } else {
                    MessageBox.Show("Existed Member ID, please set other ID!!");
                }
            }
            else
            {
                MessageBox.Show("You may input the wrong StaffID, please check and input again!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            GalaxyEntities ctx = new GalaxyEntities();
            if (txID.Text.Length == 3 && txID.Text.Substring(0, 1) == "S" && Convert.ToInt32(txID.Text.Substring(1, 2)) >= 1 && Convert.ToInt32(txID.Text.Substring(1, 2)) <= ctx.Staffs.Count())
            {
                Staff c = ctx.Staffs.Where(x => x.StaffID == txID.Text).First();
                ctx.Staffs.Remove(c);
                ctx.SaveChanges();

                MessageBox.Show("Staff successfully deleted!");
            }
            else
            {
                MessageBox.Show("This staff is not existing! You may input the wrong StaffID, please check and input again!");
            }
        }
        
        private void btnclr_Click(object sender, EventArgs e)
        {
            txName.Text = "";
            txPassword.Text = "";
            txPhoneNo.Text = "";
            txPosition.Text = "";
            txUserName.Text = "";
            txAddress.Text = "";
            txEmail.Text = "";
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBossVenkatCustomer f = new frmBossVenkatCustomer();
            f.Location = this.Location;
            f.ShowDialog();
            this.Close();
        }
    }
}
