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
    public partial class frm13MemberSearch : frmTemplateSearch
    {
        public frm13MemberSearch()
        {
            InitializeComponent();

            // Set search filters
            cbxSearchBy.DataSource = new List<string> { "Member ID", "Name", "Phone Number", "Email Address" };

            // Display all books
            gvSearchResult.DataSource = context.Members.Select(x => new
            {
                x.MemberID,
                x.Name,
                x.MemberCategory,
                x.DateOfBirth,
                x.Address,
                x.PhoneNumber,
                x.EmailAddress,
                x.CurrentBorrowing,
                x.FineAmount,
                x.Status
            }).ToList();
        }


        public override void btnSearch_Click(object sender, EventArgs e)
        {
            // Perform SQL query with condition indicated by user has input search text
            if (txSearchDetail.Text != "")
            {
                switch (cbxSearchBy.SelectedItem.ToString())
                {
                    case "Member ID":
                        gvSearchResult.DataSource = context.Members.Where(x => x.MemberID.Contains(txSearchDetail.Text)).
              OrderBy(y => y.MemberID).Select(x => new {
                  x.MemberID,
                  x.Name,
                  x.MemberCategory,
                  x.DateOfBirth,
                  x.Address,
                  x.PhoneNumber,
                  x.EmailAddress,
                  x.CurrentBorrowing,
                  x.FineAmount,
                  x.Status
              }).ToList(); break;

                    case "Name":
                        gvSearchResult.DataSource = context.Members.Where(x => x.Name.Contains(txSearchDetail.Text)).
                   OrderBy(y => y.Name).Select(x => new {
                       x.MemberID,
                       x.Name,
                       x.MemberCategory,
                       x.DateOfBirth,
                       x.Address,
                       x.PhoneNumber,
                       x.EmailAddress,
                       x.CurrentBorrowing,
                       x.FineAmount,
                       x.Status
                   }).ToList(); break;

                    case "Phone Number":
                        gvSearchResult.DataSource = context.Members.Where(x => x.PhoneNumber.Contains(txSearchDetail.Text)).
          OrderBy(y => y.PhoneNumber).Select(x => new {
              x.MemberID,
              x.Name,
              x.MemberCategory,
              x.DateOfBirth,
              x.Address,
              x.PhoneNumber,
              x.EmailAddress,
              x.CurrentBorrowing,
              x.FineAmount,
              x.Status
          }).ToList(); break;

                    case "Email Address":
                        gvSearchResult.DataSource = context.Members.Where(x => x.EmailAddress.Contains(txSearchDetail.Text)).
        OrderBy(y => y.EmailAddress).Select(x => new {
            x.MemberID,
            x.Name,
            x.MemberCategory,
            x.DateOfBirth,
            x.Address,
            x.PhoneNumber,
            x.EmailAddress,
            x.CurrentBorrowing,
            x.FineAmount,
            x.Status
        }).ToList(); break;
                }
            }
        }
    }
}
