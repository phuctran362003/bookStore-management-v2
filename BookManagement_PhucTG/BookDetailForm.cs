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





        }






    }
}
