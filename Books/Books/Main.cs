using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Books.Process;

namespace Books
{
    public partial class Main : Form
    {
        DateTimePicker mDatePicker;
        int mRow;
        int mColumn;
        int mTag = 1;
        int mRowSelect = 0;

        public Main()
        {
            InitializeComponent();
            loadDataManageBooks();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void linkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void btnManageBooks_Click(object sender, EventArgs e)
        {
            mTag = 1;
            this.btnManageBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnManageAuthors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnManageCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            loadDataManageBooks();
        }

        private void loadDataManageBooks()
        {
            mRowSelect = 0;
            this.dgManaBooks.Visible = true;
            this.dgManaAuth.Visible = false;
            this.dgManaCate.Visible = false;
            this.dgManaBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            loadCategoryCombo();
            loadAuthorCombo();
            dgManaBooks.DataSource = BookProcess.SelectBooks();
        }

        private void btnManageCategories_Click(object sender, EventArgs e)
        {
            mTag = 2;
            mRowSelect = 0;
            this.dgManaCate.Visible = true;
            this.dgManaBooks.Visible = false;
            this.dgManaAuth.Visible = false;
            this.dgManaCate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnManageCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnManageBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnManageAuthors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dgManaCate.DataSource = CategoryProcess.SelectCategory();
        }

        private void btnManageAuthors_Click(object sender, EventArgs e)
        {
            mTag = 3;
            mRowSelect = 0;
            this.dgManaAuth.Visible = true;
            this.dgManaBooks.Visible = false;
            this.dgManaCate.Visible = false;
            this.dgManaAuth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnManageAuthors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnManageBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnManageCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dgManaAuth.DataSource = AuthorProcess.SelectAuthor();
        }

        private void loadCategoryCombo()
        {
            DataGridViewComboBoxColumn categoryColumn = (DataGridViewComboBoxColumn)dgManaBooks.Columns["CategoryId"];
            categoryColumn.DataSource = CategoryProcess.SelectCategory();
        }

        private void loadAuthorCombo()
        {
            DataGridViewComboBoxColumn authorColumn = (DataGridViewComboBoxColumn)dgManaBooks.Columns["Author"];
            authorColumn.DataSource = AuthorProcess.SelectAuthor();
        }

        private void dgManaBooks_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            return;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (mTag == 1)
            {
                string id = dgManaBooks.Rows[mRowSelect - 1].Cells["BookID"].Value.ToString();
                if (!String.IsNullOrEmpty(id))
                {
                    Book book = new Book();
                    book.Id = id;
                    book.Title = dgManaBooks.Rows[mRowSelect - 1].Cells["BookTitle"].Value.ToString();
                    book.Author = dgManaBooks.Rows[mRowSelect - 1].Cells["Author"].Value.ToString();
                    book.CategoryId = dgManaBooks.Rows[mRowSelect - 1].Cells["CategoryId"].Value.ToString();
                    book.Cover = dgManaBooks.Rows[mRowSelect - 1].Cells["Cover"].Value.ToString();
                    book.Description = dgManaBooks.Rows[mRowSelect - 1].Cells["Description"].Value.ToString();
                    book.Year = (int)dgManaBooks.Rows[mRowSelect - 1].Cells["Year"].Value;
                    book.CreateTime = (DateTime)dgManaBooks.Rows[mRowSelect - 1].Cells["CreateTime"].Value;
                    book.LastUpdateTime = (DateTime)dgManaBooks.Rows[mRowSelect - 1].Cells["LastUpdate"].Value;
                    if (BookProcess.AddBooks(book))
                    {
                        MessageBox.Show(Constant.MSG_ADD_SUCCESS);
                    }
                    else
                    {
                        MessageBox.Show(Constant.MSG_ADD_FAIL);
                    }
                    loadDataManageBooks();
                }
            }
            else if (mTag == 2)
            {
                string id = dgManaCate.Rows[mRowSelect - 1].Cells["CateID"].Value.ToString();
                if (!String.IsNullOrEmpty(id))
                {
                    Category category = new Category();
                    category.Id = id;
                    category.Title = dgManaCate.Rows[mRowSelect - 1].Cells["CateTitle"].Value.ToString();
                    category.Description = dgManaCate.Rows[mRowSelect - 1].Cells["CateDescription"].Value.ToString();
                    category.CreateTime = (DateTime)dgManaCate.Rows[mRowSelect - 1].Cells["CateCreateTime"].Value;
                    category.LastUpdateTime = (DateTime)dgManaCate.Rows[mRowSelect - 1].Cells["CateLastUpdateTime"].Value;
                    if (CategoryProcess.AddCategory(category))
                    {
                        MessageBox.Show(Constant.MSG_ADD_SUCCESS);
                    }
                    else
                    {
                        MessageBox.Show(Constant.MSG_ADD_FAIL);
                    }
                    dgManaCate.DataSource = CategoryProcess.SelectCategory();
                }
            }
            else
            {
                string id = dgManaAuth.Rows[mRowSelect - 1].Cells["AuID"].Value.ToString();
                if (!String.IsNullOrEmpty(id))
                {
                    Author author = new Author();
                    author.Id = id;
                    author.Title = dgManaAuth.Rows[mRowSelect - 1].Cells["AuTitle"].Value.ToString();
                    author.Description = dgManaAuth.Rows[mRowSelect - 1].Cells["AuDescription"].Value.ToString();
                    author.CreateTime = (DateTime)dgManaAuth.Rows[mRowSelect - 1].Cells["AuCreateTime"].Value;
                    author.LastUpdateTime = (DateTime)dgManaAuth.Rows[mRowSelect - 1].Cells["AuLastUpdateTime"].Value;
                    if (AuthorProcess.AddAuthor(author))
                    {
                        MessageBox.Show(Constant.MSG_ADD_SUCCESS);
                    }
                    else
                    {
                        MessageBox.Show(Constant.MSG_ADD_FAIL);
                    }
                    dgManaAuth.DataSource = AuthorProcess.SelectAuthor();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int dialog = 0;
            if (mTag == 1)
            {
                foreach (DataGridViewRow row in dgManaBooks.Rows)
                {
                    if (row.Cells["BookID"].Value != null)
                    {
                        string id = row.Cells["BookID"].Value.ToString();
                        if (!String.IsNullOrEmpty(id))
                        {
                            Book book = new Book();
                            book.Id = id;
                            book.Title = row.Cells["BookTitle"].Value.ToString();
                            book.Author = row.Cells["Author"].Value.ToString();
                            book.CategoryId = row.Cells["CategoryId"].Value.ToString();
                            book.Cover = row.Cells["Cover"].Value.ToString();
                            book.Description = row.Cells["Description"].Value.ToString();
                            book.Year = (int)row.Cells["Year"].Value;
                            book.CreateTime = (DateTime)row.Cells["CreateTime"].Value;
                            book.LastUpdateTime = (DateTime)row.Cells["LastUpdate"].Value;
                            if (BookProcess.UpdateBooks(book))
                            {
                                dialog++;
                            }
                            else
                            {
                                dialog--;
                            }
                        }
                    }
                }
                if (dialog > 0)
                {
                    MessageBox.Show(Constant.MSG_UPDATE_SUCCESS);
                }
                else if (dialog < 0)
                {
                    MessageBox.Show(Constant.MSG_UPDATE_FAIL);
                }
                loadDataManageBooks();
            }
            else if (mTag == 2)
            {
                foreach (DataGridViewRow row in dgManaCate.Rows)
                {
                    if (row.Cells["CateID"].Value != null)
                    {
                        string id = row.Cells["CateID"].Value.ToString();
                        if (!String.IsNullOrEmpty(id))
                        {
                            Category category = new Category();
                            category.Id = id;
                            category.Title = row.Cells["CateTitle"].Value.ToString();
                            category.Description = row.Cells["CateDescription"].Value.ToString();
                            category.CreateTime = (DateTime)row.Cells["CateCreateTime"].Value;
                            category.LastUpdateTime = (DateTime)row.Cells["CateLastUpdateTime"].Value;
                            if (CategoryProcess.UpdateCategory(category))
                            {
                                dialog++;
                            }
                            else
                            {
                                dialog--;
                            }
                        }
                    }
                }
                if (dialog > 0)
                {
                    MessageBox.Show(Constant.MSG_UPDATE_SUCCESS);
                }
                else if (dialog < 0)
                {
                    MessageBox.Show(Constant.MSG_UPDATE_FAIL);
                }
                dgManaCate.DataSource = CategoryProcess.SelectCategory();
                mRowSelect = 0;
            }
            else
            {
                foreach (DataGridViewRow row in dgManaAuth.Rows)
                {
                    if (row.Cells["AuID"].Value != null)
                    {
                        string id = row.Cells["AuID"].Value.ToString();
                        if (!String.IsNullOrEmpty(id))
                        {
                            Author author = new Author();
                            author.Id = id;
                            author.Title = row.Cells["AuTitle"].Value.ToString();
                            author.Description = row.Cells["AuDescription"].Value.ToString();
                            author.CreateTime = (DateTime)row.Cells["AuCreateTime"].Value;
                            author.LastUpdateTime = (DateTime)row.Cells["AuLastUpdateTime"].Value;
                            if (AuthorProcess.UpdateAuthor(author))
                            {
                                dialog++;
                            }
                            else
                            {
                                dialog--;
                            }
                        }
                    }
                }
                if (dialog > 0)
                {
                    MessageBox.Show(Constant.MSG_UPDATE_SUCCESS);
                }
                else if (dialog < 0)
                {
                    MessageBox.Show(Constant.MSG_UPDATE_FAIL);
                }
                dgManaAuth.DataSource = AuthorProcess.SelectAuthor();
                mRowSelect = 0;
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int row = 0;
            if (mTag == 1)
            {
                row = dgManaBooks.SelectedRows[0].Index;
                deleteData(mTag, row);
                loadDataManageBooks();
            }
            else if (mTag == 2)
            {
                row = dgManaCate.SelectedRows[0].Index;
                deleteData(mTag, row);
                dgManaCate.DataSource = CategoryProcess.SelectCategory();
                mRowSelect = 0;
            }
            else
            {
                row = dgManaAuth.SelectedRows[0].Index;
                deleteData(mTag, row);
                dgManaAuth.DataSource = AuthorProcess.SelectAuthor();
                mRowSelect = 0;
            }

        }

        private void dgManaBooks_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            var itemID = e.Control as TextBox;
            if (dgManaBooks.CurrentCell.ColumnIndex == 6)
            {
                if (itemID != null)
                {
                    itemID.KeyPress += new KeyPressEventHandler(itemID_KeyPress);
                    itemID.KeyPress -= new KeyPressEventHandler(itemID_KeyPress);
                }
            }
        }

        private void itemID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void deleteData(int tag, int row)
        {
            int role = Properties.Settings.Default.Role;
            if (mTag == 1)
            {
                if (row > 0)
                {
                    if (role == 1)
                    {
                        object Id = dgManaBooks.Rows[row].Cells["BookID"].Value;
                        if (Id != null)
                            if (BookProcess.DeleteBooks(Id.ToString()))
                            {
                                MessageBox.Show(Constant.MSG_DELETE_SUCCESS);
                            }
                            else
                            {
                                MessageBox.Show(Constant.MSG_DELETE_FAIL);
                            }
                    }
                    else
                    {
                        MessageBox.Show(Constant.MSG_NOT_PERMISSTION);
                    }
                }
            }
            else if (mTag == 2)
            {
                if (row > 0)
                {
                    if (role == 1)
                    {
                        object Id = dgManaCate.Rows[row].Cells["CateID"].Value;
                        if (Id != null)
                            if (CategoryProcess.DeleteCategory(Id.ToString()))
                            {
                                MessageBox.Show(Constant.MSG_DELETE_SUCCESS);
                            }
                            else
                            {
                                MessageBox.Show(Constant.MSG_DELETE_FAIL);
                            }
                    }
                    else
                    {
                        MessageBox.Show(Constant.MSG_NOT_PERMISSTION);
                    }
                }
            }
            else
            {
                if (row > 0)
                {
                    if (role == 1)
                    {
                        object Id = dgManaAuth.Rows[row].Cells["AuID"].Value;
                        if (Id != null)
                            if (AuthorProcess.DeleteAuthor(Id.ToString()))
                            {
                                MessageBox.Show(Constant.MSG_DELETE_SUCCESS);
                            }
                            else
                            {
                                MessageBox.Show(Constant.MSG_DELETE_FAIL);
                            }
                    }
                    else
                    {
                        MessageBox.Show(Constant.MSG_NOT_PERMISSTION);
                    }
                }
            }

        }

        private void dgManaBooks_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (e.RowCount >= 1 && mRowSelect < e.RowIndex)
            {
                int row = e.RowIndex;
                if (row > 1)
                {
                    if (ValidateManaBooks(row - 2))
                    {
                        if (dgManaBooks.Rows[row - 1].Cells["BookID"].Value != null)
                        {
                            dgManaBooks.Rows[row - 1].Cells["BookID"].Value = Common.GetNextID(dgManaBooks.Rows[row - 2].Cells["BookID"].Value.ToString());
                            mRowSelect = e.RowIndex;
                        }
                    }
                }
                else
                {
                    dgManaBooks.Rows[row - 1].Cells["BookID"].Value = "BO001";
                    mRowSelect = e.RowIndex;
                }
            }
        }

        private void dgManaCate_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (e.RowCount >= 1 && mRowSelect < e.RowIndex)
            {
                int row = e.RowIndex;
                if (row > 1)
                {
                    if (ValidateManaCategory(row - 2))
                    {
                        if (dgManaCate.Rows[row - 1].Cells["CateID"].Value != null)
                        {
                            dgManaCate.Rows[row - 1].Cells["CateID"].Value = Common.GetNextID(dgManaCate.Rows[row - 2].Cells["CateID"].Value.ToString());
                            mRowSelect = e.RowIndex;
                        }
                    }
                }
                else
                {
                    dgManaCate.Rows[row - 1].Cells["CateID"].Value = "CA001";
                    mRowSelect = e.RowIndex;
                }
            }
        }

        private void dgManaAuth_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (e.RowCount >= 1 && mRowSelect < e.RowIndex)
            {
                int row = e.RowIndex;
                if (row > 1)
                {
                    if (ValidateManaBooks(row - 2))
                    {
                        if (dgManaAuth.Rows[row - 1].Cells["AuID"].Value != null)
                        {
                            dgManaAuth.Rows[row - 1].Cells["AuID"].Value = Common.GetNextID(dgManaAuth.Rows[row - 2].Cells["AuID"].Value.ToString());
                            mRowSelect = e.RowIndex;
                        }
                    }
                }
                else
                {
                    dgManaAuth.Rows[row - 1].Cells["AuID"].Value = "AU001";
                    mRowSelect = e.RowIndex;
                }
            }
        }

        private void dgManaBooks_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            deleteData(1, e.Row.Index);
        }

        private void dgManaCate_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            deleteData(2, e.Row.Index);
        }

        private void dgManaAuth_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            deleteData(3, e.Row.Index);
        }

        private bool ValidateManaBooks(int row)
        {
            if (row < 0)
            {
                return false;
            }
            if (String.IsNullOrEmpty(dgManaBooks.Rows[row].Cells["BookTitle"].Value.ToString()))
            {
                dgManaBooks.Rows[row].Cells["BookTitle"].Style.BackColor = Color.Red;
                return false;
            }

            if (String.IsNullOrEmpty(dgManaBooks.Rows[row].Cells["Author"].Value.ToString()))
            {
                dgManaBooks.Rows[row].Cells["Author"].Style.BackColor = Color.Red;
                return false;
            }

            if (String.IsNullOrEmpty(dgManaBooks.Rows[row].Cells["Year"].Value.ToString()))
            {
                dgManaBooks.Rows[row].Cells["Year"].Style.BackColor = Color.Red;
                return false;
            }

            if (String.IsNullOrEmpty(dgManaBooks.Rows[row].Cells["CreateTime"].Value.ToString()))
            {
                dgManaBooks.Rows[row].Cells["CreateTime"].Style.BackColor = Color.Red;
                return false;
            }

            return true;
        }

        private bool ValidateManaCategory(int row)
        {
            if (row < 0)
            {
                return false;
            }
            if (String.IsNullOrEmpty(dgManaCate.Rows[row].Cells["CateTitle"].Value.ToString()))
            {
                dgManaCate.Rows[row].Cells["CateTitle"].Style.BackColor = Color.Red;
                return false;
            }

            if (String.IsNullOrEmpty(dgManaCate.Rows[row].Cells["CateCreateTime"].Value.ToString()))
            {
                dgManaCate.Rows[row].Cells["CateCreateTime"].Style.BackColor = Color.Red;
                return false;
            }
            return true;
        }

        private bool ValidateManaAuthor(int row)
        {
            if (row < 0)
            {
                return false;
            }
            if (String.IsNullOrEmpty(dgManaAuth.Rows[row].Cells["AuTitle"].Value.ToString()))
            {
                dgManaAuth.Rows[row].Cells["AuTitle"].Style.BackColor = Color.Red;
                return false;
            }

            if (String.IsNullOrEmpty(dgManaAuth.Rows[row].Cells["AuCreateTime"].Value.ToString()))
            {
                dgManaAuth.Rows[row].Cells["AuCreateTime"].Style.BackColor = Color.Red;
                return false;
            }
            return true;
        }

        private void dgManaBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1 || e.RowIndex == -1)
            {
                return;
            }
            if (dgManaBooks.Columns[e.ColumnIndex].Name.Equals("CreateTime")
                || dgManaBooks.Columns[e.ColumnIndex].Name.Equals("LastUpdate"))
            {
                if (String.IsNullOrEmpty(dgManaBooks.CurrentCell.Value.ToString()))
                {
                    mDatePicker = new DateTimePicker();
                }
                dgManaBooks.Controls.Add(mDatePicker);
                mDatePicker.Format = DateTimePickerFormat.Short;
                Rectangle Rectangle = dgManaBooks.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                mDatePicker.Size = new Size(Rectangle.Width, Rectangle.Height);
                mDatePicker.Location = new Point(Rectangle.X, Rectangle.Y);
                mDatePicker.CloseUp += new EventHandler(dtp_CloseUp);
                mDatePicker.TextChanged += new EventHandler(dtp_OnTextChange);
                mDatePicker.Visible = true;
                mRow = e.RowIndex;
                mColumn = e.ColumnIndex;
            }
            else
            {
                if (mDatePicker != null)
                {
                    mDatePicker.Visible = false;
                }
            }
        }

        private void dtp_OnTextChange(object sender, EventArgs e)
        {
            if (mTag == 1)
            {
                dgManaBooks.Rows[mRow].Cells[mColumn].Value = mDatePicker.Text.ToString();
            }
            else if (mTag == 2)
            {
                dgManaCate.Rows[mRow].Cells[mColumn].Value = mDatePicker.Text.ToString();
            }
            else
            {
                dgManaAuth.Rows[mRow].Cells[mColumn].Value = mDatePicker.Text.ToString();
            }
            mDatePicker.Visible = false;
        }

        void dtp_CloseUp(object sender, EventArgs e)
        {
            mDatePicker.Visible = false;
        }

        private void dgManaCate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1 || e.RowIndex == -1)
            {
                return;
            }
            if (dgManaCate.Columns[e.ColumnIndex].Name.Equals("CateCreateTime")
                || dgManaCate.Columns[e.ColumnIndex].Name.Equals("CateLastUpdateTime"))
            {
                if (String.IsNullOrEmpty(dgManaCate.CurrentCell.Value.ToString()))
                {
                    mDatePicker = new DateTimePicker();
                }
                dgManaCate.Controls.Add(mDatePicker);
                mDatePicker.Format = DateTimePickerFormat.Short;
                Rectangle Rectangle = dgManaCate.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                mDatePicker.Size = new Size(Rectangle.Width, Rectangle.Height);
                mDatePicker.Location = new Point(Rectangle.X, Rectangle.Y);
                mDatePicker.CloseUp += new EventHandler(dtp_CloseUp);
                mDatePicker.TextChanged += new EventHandler(dtp_OnTextChange);
                mDatePicker.Visible = true;
                mRow = e.RowIndex;
                mColumn = e.ColumnIndex;
            }
            else
            {
                if (mDatePicker != null)
                {
                    mDatePicker.Visible = false;
                }
            }
        }

        private void dgManaAuth_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1 || e.RowIndex == -1)
            {
                return;
            }
            if (dgManaAuth.Columns[e.ColumnIndex].Name.Equals("AuCreateTime")
                || dgManaAuth.Columns[e.ColumnIndex].Name.Equals("AuLastUpdateTime"))
            {
                if (String.IsNullOrEmpty(dgManaAuth.CurrentCell.Value.ToString()))
                {
                    mDatePicker = new DateTimePicker();
                }
                dgManaAuth.Controls.Add(mDatePicker);
                mDatePicker.Format = DateTimePickerFormat.Short;
                Rectangle Rectangle = dgManaAuth.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                mDatePicker.Size = new Size(Rectangle.Width, Rectangle.Height);
                mDatePicker.Location = new Point(Rectangle.X, Rectangle.Y);
                mDatePicker.CloseUp += new EventHandler(dtp_CloseUp);
                mDatePicker.TextChanged += new EventHandler(dtp_OnTextChange);
                mDatePicker.Visible = true;
                mRow = e.RowIndex;
                mColumn = e.ColumnIndex;
            }
            else
            {
                if (mDatePicker != null)
                {
                    mDatePicker.Visible = false;
                }
            }
        }
    }
}
