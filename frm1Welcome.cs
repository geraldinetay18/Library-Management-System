using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace  SA47Team10a_GalaxyLibrary
{
    public partial class frm1Welcome : Form
    {
        Form f;
        public frm1Welcome()
        {
            InitializeComponent();
        }

        private void btnLibraryUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            f = new frm4BooksDetailForMember();
            f.Location = this.Location;
            f.ShowDialog();
            this.Close();
        }

        private void btnStaffLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            f = new frm2Login();
            f.Location = this.Location;
            f.ShowDialog();
            this.Close();
        }
    }
}
