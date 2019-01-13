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
    public partial class frmTemplate : Form
    {
        private string name;
        GalaxyEntities context = new GalaxyEntities();

        Form f;

        public frmTemplate()
        {
            InitializeComponent();

            name = "";
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private void btnChangeColor(Button btn, Color c)
        {
            btn.BackColor = c;
            if (c == Color.Black) {
                btn.ForeColor = Color.White;
                btn.Font = new Font(btn.Font, FontStyle.Bold);
            }
            else {
                btn.ForeColor = Color.White;
                btn.Font = new Font(btn.Font, FontStyle.Regular);
            }
        }

        private void frmTemplate_Load(object sender, EventArgs e)
        {
            lbUserName.Text = "Welcome, "+ Name;
            if (Name.ToLower() == "venkat") {
                btnAdmin.Visible = true;
            }
            else {
                btnAdmin.Visible = false;
            }
        }

        public void mbtnBorrow_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm6BorrowBook f = new frm6BorrowBook();
            f.Name = this.Name;
            f.Location = this.Location;
            f.ShowDialog();
            this.Close();
        }

        public void mbtnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm7Return f = new frm7Return();
            f.Name = this.Name;
            f.Location = this.Location;
            f.ShowDialog();
            this.Close();
        }

        public void mbtnBookInformation_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm8BookInformation f = new frm8BookInformation();
            f.Name = this.Name;
            f.Location = this.Location;
            f.ShowDialog();
            this.Close();
        }

        public void mbtnMemberInfomation_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCustomerInformation f = new frmCustomerInformation();
            f.Name = this.Name;
            f.Location = this.Location;
            f.ShowDialog();
            this.Close();
        }

        public void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            f = new frm1Welcome();
            f.Location = this.Location;
            f.ShowDialog();
            this.Close();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBossVenkat f = new frmBossVenkat();
            f.Name = this.Name;
            f.Location = this.Location;
            f.ShowDialog();
            this.Close();
        }

        private void mbtnReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm15Report f = new frm15Report();
            f.Name = this.Name;
            f.Location = this.Location;
            f.ShowDialog();
            this.Close();
        }
        private void menustripHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry No content... any help contact team10a@gmail.com (even this may not work .. will let u know if this gmail is created)");
        }
    }
}
