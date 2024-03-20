

using Repositories.Entities;
using Services;

namespace BookManagement_PhucTG
{
    public partial class BookManagerMainUI : Form
    {
        BookDAO bookDAO = new BookDAO();
        public Book selected = null; //chờ ai đó ấn nút grid table
        // gán xuống cuốn sách đang chọn

        public BookManagerMainUI()
        {
            InitializeComponent();
        }
        public void BookManagerMainUI_Load(object sender, EventArgs e)
        {
            var result = bookDAO.GetAllBooks();
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = result;

            //giấu cột Category ID

            dgvBookList.Columns["BookCategory"].Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }





        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKeyword.Text) && (string.IsNullOrEmpty(txtBookName.Text)))
            {
                MessageBox.Show("Search keyword is required", "Field text is required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var result = bookDAO.Search(txtKeyword.Text.Trim());
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
            BookDetailForm f1 = new BookDetailForm();
            f1.Show();
            //no book is passed, show empty form
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


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBookList.SelectedRows.Count > 0)
            {
                selected = (Book)dgvBookList.SelectedRows[0].DataBoundItem;
                bookDAO.Delete(selected.BookId);
                MessageBox.Show("Delete successfully! ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //delete thành công thì refresh lại lưới
            var result = bookDAO.GetAllBooks();
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = result;
        }

        private void dgvBookList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var result = bookDAO.GetAllBooks();
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = result;
        }
    }
}
