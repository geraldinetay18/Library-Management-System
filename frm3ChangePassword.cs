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
    public partial class frm3ChangePassword : Form
    {
        GalaxyEntities context = new GalaxyEntities();
        Form f;
        public frm3ChangePassword()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Staff s = context.Staffs.Where(x => x.Username == txtUserName.Text && x.EmailAddress == txtEmailId.Text).First();
                if (txtNewPassword.Text != txtRetypePassword.Text)
                {
                    MessageBox.Show("Password does'nt match");
                }
                else
                {
                        s = context.Staffs.Where(x => x.Username == txtUserName.Text).First();
                        s.Password = txtNewPassword.Text;
                        context.SaveChanges();
                        MessageBox.Show("Password Changed");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Invalid Details. Please check the details entered                       " +ex.Message);
            }
            //this.Hide();
            //f = new frm2Login();
            //f.Location = this.Location;
            //f.ShowDialog();
            //this.Close();
            btnBack_Click(sender, e);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            f = new frm2Login();
            f.Location = this.Location;
            f.ShowDialog();
            this.Close();
        }
    }
}
