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
    public partial class frm5BookSearchForMember : frm11BookSearchForStaff
    {
        GalaxyEntities context;
        public frm5BookSearchForMember()
        {
            InitializeComponent();
            context = new GalaxyEntities();
            // Set search filters
            cbxSearchBy.DataSource = new List<string> { "Book ID", "Title", "Author", "Publisher", "Book Category","Location", "Total Stock", "Availability" };

            // Display all books
            gvSearchResult.DataSource = context.Books.Where(x => x.Availability == "yes").Select(x => new {
                x.BookID,
                x.Title,
                x.Author,
                x.Publisher,
                x.BookCategory,
                x.Location,
                x.TotalStock,
                x.NumberBorrowed
            }).ToList();
        }
    }
}
