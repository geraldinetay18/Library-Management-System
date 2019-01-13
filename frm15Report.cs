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
    public partial class frm15Report : frmTemplate
    {
        public frm15Report()
        {
            InitializeComponent();
        }

        private void btnBookList_Click(object sender, EventArgs e)
        {
            frm16Viewer1 f = new frm16Viewer1();
            f.Show();
        }

        private void btnManagerReport_Click(object sender, EventArgs e)
        {
            frm17Viewer2 f = new frm17Viewer2();
            f.Show();
        }

        private void btnBorrowingReceipts_Click(object sender, EventArgs e)
        {
            frm18Viewer3 f = new frm18Viewer3();
            f.Show();
        }
    }
}
