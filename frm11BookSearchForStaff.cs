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
    public partial class frm11BookSearchForStaff : frmTemplateSearch
    {
        GalaxyEntities context;
        double amount;

        public frm11BookSearchForStaff(): base()
        {
            InitializeComponent();
            context = new GalaxyEntities();

            // Set search filters
            cbxSearchBy.DataSource = new List<string> { "Book ID", "Title", "Publisher", "Author", "Book Category", "Location",
                                                                                            "Price", "Total Stock","Number Borrowed", "Availability" };

            // Display all books
            gvSearchResult.DataSource = context.Books.Select(x => new {
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
            }).ToList();

        }


        public override void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                // Perform SQL query with condition indicated by user has input search text
                if (txSearchDetail.Text != "")
                {
                    switch (cbxSearchBy.SelectedItem.ToString())
                    {
                        case "Book ID":
                            gvSearchResult.DataSource = context.Books.Where(x => x.BookID.Contains(txSearchDetail.Text)).
                                        OrderBy(x => x.BookID).Select(x => new {
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
                            gvSearchResult.DataSource = context.Books.Where(x => x.Title.Contains(txSearchDetail.Text)).
                                          OrderBy(x => x.Title).Select(x => new {
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
                            gvSearchResult.DataSource = context.Books.Where(x => x.Publisher.Contains(txSearchDetail.Text)).
                                      OrderBy(x => x.Publisher).Select(x => new {
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
                            gvSearchResult.DataSource = context.Books.Where(x => x.Author.Contains(txSearchDetail.Text)).
                                         OrderBy(x => x.Author).Select(x => new {
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
                            gvSearchResult.DataSource = context.Books.Where(x => x.BookCategory.Contains(txSearchDetail.Text)).
                                  OrderBy(x => x.BookCategory).Select(x => new {
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
                            gvSearchResult.DataSource = context.Books.Where(x => x.Location.Contains(txSearchDetail.Text)).
                                       OrderBy(x => x.Location).Select(x => new {
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
                            amount = double.Parse(txSearchDetail.Text);
                            gvSearchResult.DataSource = context.Books.Where(x => x.Price == amount).
                            OrderBy(x => x.Price).Select(x => new {
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
                            amount = int.Parse(txSearchDetail.Text);
                            gvSearchResult.DataSource = context.Books.Where(x => x.TotalStock == amount).
                            OrderBy(x => x.TotalStock).Select(x => new {
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
                            amount = int.Parse(txSearchDetail.Text);
                            gvSearchResult.DataSource = context.Books.Where(x => x.NumberBorrowed == amount).
                            OrderBy(x => x.NumberBorrowed).Select(x => new {
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
                            gvSearchResult.DataSource = context.Books.Where(x => x.Availability == txSearchDetail.Text).
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
    }
}
