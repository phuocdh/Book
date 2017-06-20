namespace Books
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.linkLogout = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnManageBooks = new System.Windows.Forms.Button();
            this.btnManageAuthors = new System.Windows.Forms.Button();
            this.btnManageCategories = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgManaAuth = new System.Windows.Forms.DataGridView();
            this.dgManaCate = new System.Windows.Forms.DataGridView();
            this.CateID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CateTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CateDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CateCreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CateLastUpdateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgManaBooks = new System.Windows.Forms.DataGridView();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CategoryId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cover = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastUpdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AuID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuCreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuLastUpdateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spGetAuthorResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spGetCategoryResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgManaAuth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgManaCate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgManaBooks)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spGetAuthorResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCategoryResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLogout
            // 
            this.linkLogout.AutoSize = true;
            this.linkLogout.Dock = System.Windows.Forms.DockStyle.Right;
            this.linkLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLogout.Location = new System.Drawing.Point(800, 0);
            this.linkLogout.Name = "linkLogout";
            this.linkLogout.Size = new System.Drawing.Size(59, 20);
            this.linkLogout.TabIndex = 0;
            this.linkLogout.TabStop = true;
            this.linkLogout.Text = "Logout";
            this.linkLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLogout_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnManageBooks);
            this.panel1.Controls.Add(this.btnManageAuthors);
            this.panel1.Controls.Add(this.btnManageCategories);
            this.panel1.Location = new System.Drawing.Point(13, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 278);
            this.panel1.TabIndex = 1;
            // 
            // btnManageBooks
            // 
            this.btnManageBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnManageBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageBooks.ForeColor = System.Drawing.Color.Red;
            this.btnManageBooks.Location = new System.Drawing.Point(6, 17);
            this.btnManageBooks.Name = "btnManageBooks";
            this.btnManageBooks.Size = new System.Drawing.Size(161, 58);
            this.btnManageBooks.TabIndex = 0;
            this.btnManageBooks.Text = "Manage books";
            this.btnManageBooks.UseVisualStyleBackColor = false;
            this.btnManageBooks.Click += new System.EventHandler(this.btnManageBooks_Click);
            // 
            // btnManageAuthors
            // 
            this.btnManageAuthors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageAuthors.ForeColor = System.Drawing.Color.Red;
            this.btnManageAuthors.Location = new System.Drawing.Point(6, 199);
            this.btnManageAuthors.Name = "btnManageAuthors";
            this.btnManageAuthors.Size = new System.Drawing.Size(161, 58);
            this.btnManageAuthors.TabIndex = 0;
            this.btnManageAuthors.Text = "Manage authors";
            this.btnManageAuthors.UseVisualStyleBackColor = true;
            this.btnManageAuthors.Click += new System.EventHandler(this.btnManageAuthors_Click);
            // 
            // btnManageCategories
            // 
            this.btnManageCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCategories.ForeColor = System.Drawing.Color.Red;
            this.btnManageCategories.Location = new System.Drawing.Point(6, 108);
            this.btnManageCategories.Name = "btnManageCategories";
            this.btnManageCategories.Size = new System.Drawing.Size(161, 58);
            this.btnManageCategories.TabIndex = 0;
            this.btnManageCategories.Text = "Manage categories";
            this.btnManageCategories.UseVisualStyleBackColor = true;
            this.btnManageCategories.Click += new System.EventHandler(this.btnManageCategories_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.dgManaAuth);
            this.panel2.Controls.Add(this.dgManaCate);
            this.panel2.Controls.Add(this.dgManaBooks);
            this.panel2.Location = new System.Drawing.Point(193, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(664, 234);
            this.panel2.TabIndex = 2;
            // 
            // dgManaAuth
            // 
            this.dgManaAuth.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgManaAuth.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgManaAuth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgManaAuth.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AuID,
            this.AuTitle,
            this.AuDescription,
            this.AuCreateTime,
            this.AuLastUpdateTime});
            this.dgManaAuth.Location = new System.Drawing.Point(310, 126);
            this.dgManaAuth.Name = "dgManaAuth";
            this.dgManaAuth.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgManaAuth.Size = new System.Drawing.Size(320, 83);
            this.dgManaAuth.TabIndex = 0;
            this.dgManaAuth.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgManaAuth_CellClick);
            this.dgManaAuth.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgManaAuth_RowsAdded);
            this.dgManaAuth.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgManaAuth_UserDeletingRow);
            // 
            // dgManaCate
            // 
            this.dgManaCate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgManaCate.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgManaCate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgManaCate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CateID,
            this.CateTitle,
            this.CateDescription,
            this.CateCreateTime,
            this.CateLastUpdateTime});
            this.dgManaCate.Location = new System.Drawing.Point(13, 126);
            this.dgManaCate.Name = "dgManaCate";
            this.dgManaCate.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgManaCate.Size = new System.Drawing.Size(291, 83);
            this.dgManaCate.TabIndex = 0;
            this.dgManaCate.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgManaCate_CellClick);
            this.dgManaCate.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgManaCate_RowsAdded);
            this.dgManaCate.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgManaCate_UserDeletingRow);
            // 
            // CateID
            // 
            this.CateID.DataPropertyName = "Id";
            this.CateID.HeaderText = "ID";
            this.CateID.Name = "CateID";
            // 
            // CateTitle
            // 
            this.CateTitle.DataPropertyName = "Title";
            this.CateTitle.HeaderText = "Title";
            this.CateTitle.Name = "CateTitle";
            // 
            // CateDescription
            // 
            this.CateDescription.DataPropertyName = "Description";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CateDescription.DefaultCellStyle = dataGridViewCellStyle1;
            this.CateDescription.FillWeight = 200F;
            this.CateDescription.HeaderText = "Description";
            this.CateDescription.Name = "CateDescription";
            // 
            // CateCreateTime
            // 
            this.CateCreateTime.DataPropertyName = "CreateTime";
            this.CateCreateTime.FillWeight = 200F;
            this.CateCreateTime.HeaderText = "CreateTime";
            this.CateCreateTime.Name = "CateCreateTime";
            // 
            // CateLastUpdateTime
            // 
            this.CateLastUpdateTime.DataPropertyName = "LastUpdateTime";
            this.CateLastUpdateTime.FillWeight = 200F;
            this.CateLastUpdateTime.HeaderText = "LastUpdateTime";
            this.CateLastUpdateTime.Name = "CateLastUpdateTime";
            // 
            // dgManaBooks
            // 
            this.dgManaBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgManaBooks.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgManaBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgManaBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookID,
            this.BookTitle,
            this.Author,
            this.CategoryId,
            this.Description,
            this.Cover,
            this.Year,
            this.CreateTime,
            this.LastUpdate});
            this.dgManaBooks.Location = new System.Drawing.Point(13, 17);
            this.dgManaBooks.Name = "dgManaBooks";
            this.dgManaBooks.RowHeadersWidth = 25;
            this.dgManaBooks.Size = new System.Drawing.Size(551, 192);
            this.dgManaBooks.TabIndex = 0;
            this.dgManaBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgManaBooks_CellClick);
            this.dgManaBooks.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgManaBooks_DataError);
            this.dgManaBooks.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgManaBooks_EditingControlShowing);
            this.dgManaBooks.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgManaBooks_RowsAdded);
            this.dgManaBooks.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgManaBooks_UserDeletingRow);
            // 
            // BookID
            // 
            this.BookID.DataPropertyName = "Id";
            this.BookID.HeaderText = "BookID";
            this.BookID.Name = "BookID";
            this.BookID.ReadOnly = true;
            // 
            // BookTitle
            // 
            this.BookTitle.DataPropertyName = "Title";
            this.BookTitle.HeaderText = "BookTitle";
            this.BookTitle.Name = "BookTitle";
            // 
            // Author
            // 
            this.Author.DataPropertyName = "Author";
            this.Author.DataSource = this.spGetAuthorResultBindingSource;
            this.Author.DisplayMember = "Title";
            this.Author.HeaderText = "Author";
            this.Author.Name = "Author";
            this.Author.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Author.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Author.ValueMember = "Id";
            // 
            // CategoryId
            // 
            this.CategoryId.DataPropertyName = "CategoryId";
            this.CategoryId.DataSource = this.spGetCategoryResultBindingSource;
            this.CategoryId.DisplayMember = "Title";
            this.CategoryId.HeaderText = "Category";
            this.CategoryId.Name = "CategoryId";
            this.CategoryId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CategoryId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CategoryId.ValueMember = "Id";
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // Cover
            // 
            this.Cover.DataPropertyName = "Cover";
            this.Cover.HeaderText = "Cover";
            this.Cover.Name = "Cover";
            // 
            // Year
            // 
            this.Year.DataPropertyName = "Year";
            this.Year.HeaderText = "Year";
            this.Year.Name = "Year";
            // 
            // CreateTime
            // 
            this.CreateTime.DataPropertyName = "CreateTime";
            this.CreateTime.HeaderText = "CreateTime";
            this.CreateTime.Name = "CreateTime";
            // 
            // LastUpdate
            // 
            this.LastUpdate.DataPropertyName = "LastUpdateTime";
            this.LastUpdate.HeaderText = "LastUpdate";
            this.LastUpdate.Name = "LastUpdate";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(237, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(557, 65);
            this.label1.TabIndex = 3;
            this.label1.Text = "Books Management";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Red;
            this.btnAdd.Location = new System.Drawing.Point(394, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 31);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Red;
            this.btnUpdate.Location = new System.Drawing.Point(482, 8);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 31);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(570, 8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 31);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Location = new System.Drawing.Point(193, 300);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(664, 46);
            this.panel3.TabIndex = 4;
            // 
            // AuID
            // 
            this.AuID.DataPropertyName = "Id";
            this.AuID.HeaderText = "ID";
            this.AuID.Name = "AuID";
            // 
            // AuTitle
            // 
            this.AuTitle.DataPropertyName = "Title";
            this.AuTitle.HeaderText = "Title";
            this.AuTitle.Name = "AuTitle";
            // 
            // AuDescription
            // 
            this.AuDescription.DataPropertyName = "Description";
            this.AuDescription.HeaderText = "Description";
            this.AuDescription.Name = "AuDescription";
            // 
            // AuCreateTime
            // 
            this.AuCreateTime.DataPropertyName = "CreateTime";
            this.AuCreateTime.HeaderText = "CreateTime";
            this.AuCreateTime.Name = "AuCreateTime";
            // 
            // AuLastUpdateTime
            // 
            this.AuLastUpdateTime.DataPropertyName = "LastUpdateTime";
            this.AuLastUpdateTime.HeaderText = "LastUpdateTime";
            this.AuLastUpdateTime.Name = "AuLastUpdateTime";
            // 
            // spGetAuthorResultBindingSource
            // 
            this.spGetAuthorResultBindingSource.DataSource = typeof(Books.spGetAuthor_Result);
            // 
            // spGetCategoryResultBindingSource
            // 
            this.spGetCategoryResultBindingSource.DataSource = typeof(Books.spGetCategory_Result);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 355);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkLogout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgManaAuth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgManaCate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgManaBooks)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spGetAuthorResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCategoryResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnManageBooks;
        private System.Windows.Forms.Button btnManageAuthors;
        private System.Windows.Forms.Button btnManageCategories;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgManaBooks;
        private System.Windows.Forms.DataGridView dgManaAuth;
        private System.Windows.Forms.DataGridView dgManaCate;
        private System.Windows.Forms.BindingSource spGetAuthorResultBindingSource;
        private System.Windows.Forms.BindingSource spGetCategoryResultBindingSource;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookTitle;
        private System.Windows.Forms.DataGridViewComboBoxColumn Author;
        private System.Windows.Forms.DataGridViewComboBoxColumn CategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cover;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CateID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CateTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn CateDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn CateCreateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn CateLastUpdateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuCreateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuLastUpdateTime;
    }
}

