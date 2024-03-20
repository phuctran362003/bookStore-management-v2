

using Repositories.Entities;
using Services;

namespace BookManagement_PhucTG
{
    public partial class BookManagerMainUI : Form
    {
        BookDAO bookDAO = new BookDAO();
        private Book selected = null; //chờ ai đó ấn nút grid table
        // gán xuống cuốn sách đang chọn

        public BookManagerMainUI()
        {
            InitializeComponent();
        }
        private void BookManagerMainUI_Load(object sender, EventArgs e)
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
            if (string.IsNullOrEmpty(txtKeyword.Text))
            {
                MessageBox.Show("Input must not be empty!!", "Input required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var result = bookDAO.Search(txtKeyword.Text);
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = result;
        }




        private void btnCreate_Click(object sender, EventArgs e)
        {
            BookDetailForm f1 = new BookDetailForm();
            f1.ShowDialog();
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


    }
}
