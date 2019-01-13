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
    public partial class frmBookAdd : frmTemplate
    {

        GalaxyEntities context;
        int bookPosition = 0;
        string newBookID;
        Book b;
        Form f;
        public frmBookAdd()
        {
            InitializeComponent();
        }

        private void frmBookAdd_Load(object sender, EventArgs e)
        {
            context = new GalaxyEntities();
            GenerateBookID();
            cbxCategory.SelectedIndex = 0;
            cbxFloor.SelectedIndex = 0;
            
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (txTitle.Text == "" || txPublisher.Text == "" || txAuthor.Text == "" || txShelf.Text == "" || txPrice.Text == "" || txStock.Text == "")
                    throw new InvalidInputException();

                //Create book record
                b = new Book();
                    b.BookID = newBookID;
                    b.Title = txTitle.Text;
                    b.Publisher = txPublisher.Text;
                    b.Author = txAuthor.Text;
                    b.BookCategory = cbxCategory.SelectedItem.ToString();
                    b.Location = "F" + cbxFloor.SelectedItem.ToString() + "-L" + txShelf.Text;
                    b.Price = Convert.ToDouble(txPrice.Text);
                    b.TotalStock = Convert.ToInt32(txStock.Text);
                    b.NumberBorrowed = 0;
                    b.Availability = "yes";

                    //Store book record to database
                    context.Books.Add(b);
                    context.SaveChanges();

                    // Inform user and clear page
                    MessageBox.Show("Book successfully added!");
                    ResetValues();
            }

            catch (Exception a)
            {
                a = new InvalidInputException("Please fill in all fields.");
                MessageBox.Show(a.Message);
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetValues();
        }

        private void GenerateBookID()
        {
            // Auto-generate new Book ID
            bookPosition = context.Books.Count() + 1;
            newBookID = "G" + PopulateZeroes(bookPosition) + bookPosition.ToString();

            // Display
            txBookID.Text = newBookID;
        }

        private string PopulateZeroes(int digits)
        {
            string zeroes = "";

            if (digits < 10)
                zeroes = "000";
            else if (digits < 100)
                zeroes = "00";
            else if (digits < 1000)
                zeroes = "0";

            return zeroes;
        }

        private void ResetValues()
        {
            GenerateBookID();
            txTitle.Text = "";
            txPublisher.Text = "";
            txAuthor.Text = "";
            cbxFloor.SelectedIndex = 0;
            cbxCategory.SelectedIndex = 0;
            cbxFloor.Text = "";
            txShelf.Text = "";
            txPrice.Text = "";
            txStock.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            f = new frm8BookInformation();
            f.Location = this.Location;
            f.ShowDialog();
            this.Close();
        }

        private void mbtnUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            f = new frmBookModify();
            f.Location = this.Location;
            f.ShowDialog();
            this.Close();
        }
    }
}
