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
    public partial class frmBookSearchForStaff : Form,Interface1
    {
        GalaxyEntities context;
        string selectedBookID;
        double amount;

        public string SelectedBookID
        {
            get { return selectedBookID;  }
        }
        
        public frmBookSearchForStaff()
        {
            InitializeComponent();
        }

        private void frmBookSearchForStaff_Load(object sender, EventArgs e)
        {
            context = new GalaxyEntities();
            gv.DataSource = context.Books.Select(x => new { x.BookID, x.Title, x.Publisher, x.Author, x.BookCategory, x.Location, x.Price,
                                          x.TotalStock, x.NumberBorrowed, x.Availability}).ToList();
            cbxSearchBy.SelectedIndex = 0;
            txInput.Text = "";
            selectedBookID = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            search();
        }

        public void search()
        {
            try
            {
                // Perform SQL query with condition indicated by user has input search text
                if (txInput.Text != "")
                {
                    switch (cbxSearchBy.SelectedItem.ToString())
                    {
                        case "Book ID":
                            gv.DataSource = context.Books.Where(x => x.BookID.Contains(txInput.Text)).
                                        Select(x => new {
                                            x.BookID,
                                            x.Title,
                                            x.Publisher,
                                            x.Author,
                                            x.BookCategory,
                                            x.Location,
                                            x.Price,
                                            x.TotalStock,
                                            x.NumberBorrowed,
                                            x.Availability
                                        }).ToList(); break;
                        case "Title":
                            gv.DataSource = context.Books.Where(x => x.Title.Contains(txInput.Text)).
                                          Select(x => new {
                                              x.BookID,
                                              x.Title,
                                              x.Publisher,
                                              x.Author,
                                              x.BookCategory,
                                              x.Location,
                                              x.Price,
                                              x.TotalStock,
                                              x.NumberBorrowed,
                                              x.Availability
                                          }).ToList(); break;
                        case "Publisher":
                            gv.DataSource = context.Books.Where(x => x.Publisher.Contains(txInput.Text)).
                                      Select(x => new {
                                          x.BookID,
                                          x.Title,
                                          x.Publisher,
                                          x.Author,
                                          x.BookCategory,
                                          x.Location,
                                          x.Price,
                                          x.TotalStock,
                                          x.NumberBorrowed,
                                          x.Availability
                                      }).ToList(); break;
                        case "Author":
                            gv.DataSource = context.Books.Where(x => x.Author.Contains(txInput.Text)).
                                         Select(x => new {
                                             x.BookID,
                                             x.Title,
                                             x.Publisher,
                                             x.Author,
                                             x.BookCategory,
                                             x.Location,
                                             x.Price,
                                             x.TotalStock,
                                             x.NumberBorrowed,
                                             x.Availability
                                         }).ToList(); break;
                        case "Book Category":
                            gv.DataSource = context.Books.Where(x => x.BookCategory.Contains(txInput.Text)).
                                  Select(x => new {
                                      x.BookID,
                                      x.Title,
                                      x.Publisher,
                                      x.Author,
                                      x.BookCategory,
                                      x.Location,
                                      x.Price,
                                      x.TotalStock,
                                      x.NumberBorrowed,
                                      x.Availability
                                  }).ToList(); break;
                        case "Location":
                            gv.DataSource = context.Books.Where(x => x.Location.Contains(txInput.Text)).
                                       Select(x => new {
                                           x.BookID,
                                           x.Title,
                                           x.Publisher,
                                           x.Author,
                                           x.BookCategory,
                                           x.Location,
                                           x.Price,
                                           x.TotalStock,
                                           x.NumberBorrowed,
                                           x.Availability
                                       }).ToList(); break;
                        case "Price":
                            amount = double.Parse(txInput.Text);
                            gv.DataSource = context.Books.Where(x => x.Price == amount).
                            Select(x => new {
                                x.BookID,
                                x.Title,
                                x.Publisher,
                                x.Author,
                                x.BookCategory,
                                x.Location,
                                x.Price,
                                x.TotalStock,
                                x.NumberBorrowed,
                                x.Availability
                            }).ToList(); break;
                        case "Total Stock":
                            amount = int.Parse(txInput.Text);
                            gv.DataSource = context.Books.Where(x => x.TotalStock == amount).
                            Select(x => new {
                                x.BookID,
                                x.Title,
                                x.Publisher,
                                x.Author,
                                x.BookCategory,
                                x.Location,
                                x.Price,
                                x.TotalStock,
                                x.NumberBorrowed,
                                x.Availability
                            }).ToList(); break;
                        case "Number Borrowed":
                            amount = int.Parse(txInput.Text);
                            gv.DataSource = context.Books.Where(x => x.NumberBorrowed == amount).
                            Select(x => new {
                                x.BookID,
                                x.Title,
                                x.Publisher,
                                x.Author,
                                x.BookCategory,
                                x.Location,
                                x.Price,
                                x.TotalStock,
                                x.NumberBorrowed,
                                x.Availability
                            }).ToList(); break;
                        case "Availability":
                            gv.DataSource = context.Books.Where(x => x.Availability == txInput.Text).
                                   Select(x => new {
                                       x.BookID,
                                       x.Title,
                                       x.Publisher,
                                       x.Author,
                                       x.BookCategory,
                                       x.Location,
                                       x.Price,
                                       x.TotalStock,
                                       x.NumberBorrowed,
                                       x.Availability
                                   }).ToList(); break;
                    }
                }
            }
            catch (Exception a)
            {
                a = new InvalidInputException("Invalid number.");
                MessageBox.Show(a.Message);
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Capture Book ID of selected book record
            DataGridViewRow selectedRow = gv.Rows[e.RowIndex];
            selectedBookID = selectedRow.Cells["BookID"].Value.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (selectedBookID != "")
                this.DialogResult = DialogResult.OK;
            else
                MessageBox.Show("Please click on the record to confirm your selection.");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }

    class InvalidInputException : ApplicationException
    {
        public InvalidInputException() : base()
        {
        }
        public InvalidInputException(string message) : base(message)
        {
        }
    }
}
