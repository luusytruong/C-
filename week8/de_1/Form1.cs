namespace de_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            using (var context = new BookDbContext())
            {
                var books = context.Books.ToList();
                dgvTable.DataSource = books;
            }
        }
        public void Clear()
        {
            txtMaSach.Clear();
            txtTenSach.Clear();
            txtGia.Clear();
            txtSoLuong.Clear();
            txtMota.Clear();
        }
        private void dgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTable.Rows[e.RowIndex];

                txtMaSach.Text = row.Cells["Id"].Value.ToString();
                txtTenSach.Text = row.Cells["TenSach"].Value.ToString();
                txtGia.Text = row.Cells["Price"].Value.ToString();
                txtSoLuong.Text = row.Cells["SoLuong"].Value.ToString();
                txtMota.Text = row.Cells["MoTa"].Value.ToString();
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            using (var context = new BookDbContext())
            {
                var newBook = new Book()
                {

                    TenSach = txtTenSach.Text,
                    Price = Convert.ToDecimal(txtGia.Text),
                    SoLuong = Convert.ToInt32(txtSoLuong.Text),
                    MoTa = txtMota.Text,
                };
                context.Books.Add(newBook);
                if (context.SaveChanges() != 0)
                {
                    Clear();
                    LoadData();
                    MessageBox.Show("added successfull");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var context = new BookDbContext())
            {
                var currentBook = context.Books.FirstOrDefault(b => b.Id == Convert.ToInt32(txtMaSach.Text));
                if (currentBook != null)
                {
                    currentBook.TenSach = txtTenSach.Text;
                    currentBook.Price = Convert.ToDecimal(txtGia.Text);
                    currentBook.TenSach = txtTenSach.Text;
                    currentBook.MoTa = txtMota.Text;

                    if (context.SaveChanges() != 0)
                    {
                        Clear();
                        LoadData();
                        MessageBox.Show("update " + currentBook.Id + " successfull");
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var context = new BookDbContext())
            {
                var currentBook = context.Books.FirstOrDefault(b => b.Id == Convert.ToInt32(txtMaSach.Text));

                if (currentBook != null)
                {
                    context.Books.Remove(currentBook);

                    if (context.SaveChanges() != 0)
                    {
                        Clear();
                        LoadData();
                        MessageBox.Show("delete " + currentBook.Id + " successfull");
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (var context = new BookDbContext())
            {
                if (!string.IsNullOrWhiteSpace(txtSearch.Text))
                {

                    var bookTitle = context.Books.Where(b => (b.TenSach).Contains(txtSearch.Text));
                    if (bookTitle != null)
                    {
                       
                        dgvTable.DataSource = bookTitle.ToList();
                    }
                    else
                    {
                    MessageBox.Show("book title not found");
                    }
                }
                else {
                    MessageBox.Show("pls enter book title to search");
                }
            }
        }
    }
}
