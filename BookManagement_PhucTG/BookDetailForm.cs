using Repositories.Entities;
using Services;

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
            cboBookCategoryID.DataSource = bookCategoryDAO.GetBookCategories();
            cboBookCategoryID.DisplayMember = "BookGenreType";
            cboBookCategoryID.ValueMember = "BookCategoryId";

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
                cboBookCategoryID.SelectedValue = SelectedBook.BookCategoryId;

                //!important
                //assign value BookCategoryID to combo box and convert it into BookGenreType; 
                cboBookCategoryID.SelectedValue = SelectedBook.BookCategoryId;
            }
            else
            {
                lblAddUpdate.Text = "Add a new book";
            }
        }




        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            //we new a Book() with information taken from textbox
            // for update 

            //Nếu là sách Update, thì cuốn sách new đã có ID của Book Selected
            //Nếu là sách Add(), thì Id là null nên sẽ lấy ID từ txtID
            Book b = new Book()
            {
                BookId = int.Parse(txtBookID.Text),
                BookName = txtBookName.Text,
                Description = txtBookDescription.Text,
                PublicationDate = dtpPublicatioDate.Value,
                Quantity = int.Parse(txtQuantity.Text),
                Author = txtAuthor.Text,
                Price = double.Parse(txtPrice.Text),
                BookCategoryId = int.Parse(cboBookCategoryID.SelectedValue.ToString()),
            };



            //gửi xuống DB thông qua service

            if (SelectedBook == null)
            {
                bookDAO.AddABookForUI(b);

                MessageBox.Show("Add successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);                
            }
            else
            {

                bookDAO.UpdateABook(b);
                MessageBox.Show("Update successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }

            //cho dù new/edit thì xong phỉa tắt màn hình detail
            Close();

            //đóng màn hình detail thì phải F5 cái lưới grid
            //Bên main form phải refresh lưới ở ngay sau chỗ gọi detail




        }
    }
}
