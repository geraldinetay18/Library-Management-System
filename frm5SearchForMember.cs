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
    public partial class frm5SearchForMember : Form,Interface1
    {
        GalaxyEntities context;
        Book selectedBook;
        protected List<string> searchByList = new List<string> { "BookID", "Title", "Author", "Publisher", "BookCategory", "TotalStock", "Availability" };

        public Book SelectedBook
        {
            get { return selectedBook; }
        }

        public frm5SearchForMember():base()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            search();
        }
        public void search()
        {
            int amount;

            switch (comboBox1.SelectedItem.ToString())
            {
                case "BookID": gvsearch.DataSource = context.Books.Where(x => x.BookID.Contains(txInput.Text)).ToList(); break;
                case "Title": gvsearch.DataSource = context.Books.Where(x => x.Title.Contains(txInput.Text)).ToList(); break;
                case "Publisher": gvsearch.DataSource = context.Books.Where(x => x.Publisher.Contains(txInput.Text)).ToList(); break;
                case "Author": gvsearch.DataSource = context.Books.Where(x => x.Author.Contains(txInput.Text)).ToList(); break;
                case "BookCategory": gvsearch.DataSource = context.Books.Where(x => x.BookCategory.Contains(txInput.Text)).ToList(); break;
                case "TotalStock":
                    amount = Convert.ToInt16(txInput.Text);
                    gvsearch.DataSource = context.Books.Where(x => x.TotalStock == amount).ToList(); break;
                case "Availability": gvsearch.DataSource = context.Books.Where(x => x.Availability.Contains(txInput.Text)).ToList(); break;
            }
        }

        private void gvsearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewRow selectedRow = gvsearch.Rows[e.RowIndex];
            //selectedBook.BookID = selectedRow.Cells["BookID"].Value.ToString();
            //selectedBook.Title = selectedRow.Cells["Title"].Value.ToString();
            //selectedBook.Author = selectedRow.Cells["Author"].Value.ToString();
            //selectedBook.Publisher = selectedRow.Cells["Publisher"].Value.ToString();
            //selectedBook.BookCategory = selectedRow.Cells["BookCategory"].Value.ToString();
            //selectedBook.Location = selectedRow.Cells["Location"].Value.ToString();
            //selectedBook.Price = Convert.ToDouble(selectedRow.Cells["Price"].Value.ToString());
            //selectedBook.TotalStock = Convert.ToInt32(selectedRow.Cells["TotalStock"].Value.ToString());
            //selectedBook.NumberBorrowed = Convert.ToInt32(selectedRow.Cells["NumberBorrowed"].Value.ToString());
        }

        private void frmRetrieve_Load(object sender, EventArgs e)
        {
            context = new GalaxyEntities();
            selectedBook = new Book();
        }

        private void gvsearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = gvsearch.Rows[e.RowIndex];
            selectedBook.BookID = selectedRow.Cells["BookID"].Value.ToString();
            selectedBook.Title = selectedRow.Cells["Title"].Value.ToString();
            selectedBook.Author = selectedRow.Cells["Author"].Value.ToString();
            selectedBook.Publisher = selectedRow.Cells["Publisher"].Value.ToString();
            selectedBook.BookCategory = selectedRow.Cells["BookCategory"].Value.ToString();
            selectedBook.Location = selectedRow.Cells["Location"].Value.ToString();
            selectedBook.Price = Convert.ToDouble(selectedRow.Cells["Price"].Value.ToString());
            selectedBook.TotalStock = Convert.ToInt32(selectedRow.Cells["TotalStock"].Value.ToString());
            selectedBook.NumberBorrowed = Convert.ToInt32(selectedRow.Cells["NumberBorrowed"].Value.ToString());
            selectedBook.Availability = selectedRow.Cells["Availability"].Value.ToString();
        }
    }
}
