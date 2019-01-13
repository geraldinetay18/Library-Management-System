using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SA47Team10a_GalaxyLibrary
{
    public partial class frm17Viewer2 : Form
    {
        public frm17Viewer2()
        {
            InitializeComponent();
        }

        private void frm17Viewer2_Load(object sender, EventArgs e)
        {
            //GalaxyEntities context = new GalaxyEntities();
            //CrystalReport1 cr = new CrystalReport1();
            //cr.SetDataSource(context.Books);
            //crystalReportViewer1.ReportSource = cr;
            String cnS = "data source=(local);initial catalog=Galaxy;integrated security=SSPI;";
            SqlConnection cn = new SqlConnection(cnS);
            SqlCommand cm = new SqlCommand("Select * from Books", cn);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            SqlCommandBuilder cmb = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds, "Books");
            CrystalReport2 cr = new CrystalReport2();
            //int c = 0;
            //c = ds.Tables["Transactions"].Rows.Count;
            //SqlCommand cm1 = new SqlCommand("select Transactions.TransactionID, Transactions.MemberID, Transactions.BookID, Transactions.IssueDate, Transactions.DueDate from Transactions where Transactions.TransactionID ='" + c + "'",cn);
            //SqlDataAdapter da1 = new SqlDataAdapter(cm1);
            //SqlCommandBuilder cmb1 = new SqlCommandBuilder(da1);
            //DataSet ds1 = new DataSet();
            //da1.Fill(ds1, "Transactions");
            cr.SetDataSource(ds.Tables["Books"]);
            crystalReportViewer1.ReportSource = cr;
        }
    }
}
