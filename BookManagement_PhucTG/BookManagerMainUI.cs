

using Repositories;
using Repositories.Entities;
using Services;

namespace BookManagement_PhucTG
{
    public partial class BookManagerMainUI : Form
    {
        BookDAO bookDAO = new BookDAO();
        public Book? selected = null; //chờ ai đó ấn nút grid table
        // gán xuống cuốn sách đang chọn

        public BookManagerMainUI()
        {
            InitializeComponent();
        }

        public void RefreshLoad()
        {
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = bookDAO.GetAllBooks();
        }

        public void BookManagerMainUI_Load(object sender, EventArgs e)
        {
            RefreshLoad();
            //giấu cột Category ID
            dgvBookList.Columns["BookCategoryId"].Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKeyword.Text) && (string.IsNullOrWhiteSpace(txtBookName.Text)))
            {
                MessageBox.Show("Search keyword is required", "Field text is required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string temp = txtKeyword.Text;

            //if bookname filled
            if (!string.IsNullOrEmpty(txtBookName.Text))
            {
                temp = txtBookName.Text;
            }

            var result = bookDAO.Search(temp.Trim().ToLower());
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = result;


            //if no resul, notify and return the list
            if (dgvBookList.Rows.Count == 0)
            {
                MessageBox.Show("No book is displayed! Please check again", "Invalid book ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            BookDetailForm f = new BookDetailForm();

            f.ShowDialog();

            //no book is passed, show empty form
            //
            //F5 lưới ở đây
            RefreshLoad();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (selected == null)
            {
                MessageBox.Show("Please select a certain book to edit!", "Select one book! ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            BookDetailForm f = new BookDetailForm();
            f.SelectedBook = selected;
            f.ShowDialog();

            //pass selected book to show in detail form
            //khai báo biến, new, gán prop, show dialog
            // thằng form detail mở lên check selected có null ko, khác null thì data đc gửi sang
            RefreshLoad();
        }

        private void dgvBookList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBookList.SelectedRows.Count > 0)
            {
                selected = (Book)dgvBookList.SelectedRows[0].DataBoundItem;
                //nếu chọn ít nhất 1 dòng, thì cứ dòng đầu tiên đc chọn là bốc nó ra, đẩy sang màn hình detail
                //lấy 1 dòng là kiểu object, là lấy Book từ DataSource = List<Book>
            }
        }

        public void GetABook()
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBookList.SelectedRows.Count > 0)
            {
                selected = (Book)dgvBookList.SelectedRows[0].DataBoundItem;
                bookDAO.DeleteABookFromUI(selected.BookId);
               
            }

            DialogResult answer = MessageBox.Show("Do you want to delete this book", "Delete this book ? ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.No)
                return;


            //delete thành công thì refresh lại lưới
            MessageBox.Show("Delete successfully! ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshLoad();
            selected = null;



        }

        private void dgvBookList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
