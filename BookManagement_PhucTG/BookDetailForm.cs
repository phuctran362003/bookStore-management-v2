using Repositories.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagement_PhucTG
{
    public partial class BookDetailForm : Form
    {
        private BookCategoryDAO bookCategoryDAO = new BookCategoryDAO();
        private BookDAO bookDAO = new BookDAO();
        public Book? SelectedBook { get; set; } = null;
        //default

        public BookDetailForm()
        {
            InitializeComponent();
        }

        private void BookDetailForm_Load(object sender, EventArgs e)
        {
            //fill comboBox
            cboBookCategory.DataSource = bookCategoryDAO.GetBookCategories();
            cboBookCategory.DisplayMember = "BookGenreType";
            cboBookCategory.ValueMember = "BookCategoryId";

            //vi diệu
            //cboBookCategory.SelectedValue = 5; //default display

            //check if user clicks update
            //if yes, fill data into Text boxes

            if (SelectedBook != null)
            {
                //check if user clicks update
                //if yes, fill data into Text boxes
                lblAddUpdate.Text = "Update a new book";

                txtBookID.BackColor = Color.LightGray;                
                txtBookID.Text = SelectedBook.BookId.ToString();

                txtBookName.Text = SelectedBook.BookName.ToString();
                txtBookDescription.Text = SelectedBook.Description.ToString();
                dtpPublicatioDate.Value = SelectedBook.PublicationDate;
                txtQuantity.Text = SelectedBook.Quantity.ToString();
                txtAuthor.Text = SelectedBook.Author.ToString();
                txtPrice.Text = SelectedBook.Price.ToString();

                //!important
                //assign value BookCategoryID to combo box and convert it into BookGenreType; 
                cboBookCategory.SelectedValue = SelectedBook.BookCategoryId;
            }
            else
            {
                lblAddUpdate.Text = " Add a new book";
            }
        }


        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            Book b = new Book();

            if (SelectedBook == null)
            {
                b.BookName = txtBookName.Text;
                b.Description = txtBookDescription.Text;
                b.Quantity = Convert.ToInt32(txtQuantity.Text);
                b.Author = txtAuthor.Text;
                b.Price = Convert.ToDouble(txtPrice.Text);
                b.BookCategoryId = (int)cboBookCategory.SelectedValue;

                bookDAO.AddABook(b);                

            } else
            {               
                bookDAO.UpdateABook(b);
            }



        }
    }
}
