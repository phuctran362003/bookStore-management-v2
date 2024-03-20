namespace BookManagement_PhucTG
{
    partial class BookManagerMainUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookManagerMainUI));
            lblHeader = new Label();
            lblBookName = new Label();
            grbSearchCriteria = new GroupBox();
            btnSearch = new Button();
            txtKeyword = new TextBox();
            txtBookName = new TextBox();
            lblBookDescription = new Label();
            btnCreate = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnExit = new Button();
            dgvBookList = new DataGridView();
            lblBookList = new Label();
            lblCopyright = new Label();
            grbActionCriteria = new GroupBox();
            grbSearchCriteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).BeginInit();
            grbActionCriteria.SuspendLayout();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI Black", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.ForeColor = Color.Snow;
            lblHeader.Location = new Point(12, 9);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(363, 62);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Book Manager";
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.BackColor = SystemColors.ActiveBorder;
            lblBookName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblBookName.ForeColor = SystemColors.MenuHighlight;
            lblBookName.Location = new Point(6, 36);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(139, 31);
            lblBookName.TabIndex = 1;
            lblBookName.Text = "Book Name";
            // 
            // grbSearchCriteria
            // 
            grbSearchCriteria.BackColor = SystemColors.ActiveBorder;
            grbSearchCriteria.Controls.Add(btnSearch);
            grbSearchCriteria.Controls.Add(txtKeyword);
            grbSearchCriteria.Controls.Add(txtBookName);
            grbSearchCriteria.Controls.Add(lblBookDescription);
            grbSearchCriteria.Controls.Add(lblBookName);
            grbSearchCriteria.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grbSearchCriteria.ForeColor = SystemColors.HotTrack;
            grbSearchCriteria.Location = new Point(12, 86);
            grbSearchCriteria.Name = "grbSearchCriteria";
            grbSearchCriteria.Size = new Size(974, 75);
            grbSearchCriteria.TabIndex = 2;
            grbSearchCriteria.TabStop = false;
            grbSearchCriteria.Text = " Search Criteria ";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Fuchsia;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = SystemColors.Control;
            btnSearch.Location = new Point(819, 36);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(128, 29);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtKeyword
            // 
            txtKeyword.Location = new Point(537, 38);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.Size = new Size(218, 27);
            txtKeyword.TabIndex = 4;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(155, 38);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(218, 27);
            txtBookName.TabIndex = 3;
            // 
            // lblBookDescription
            // 
            lblBookDescription.AutoSize = true;
            lblBookDescription.BackColor = SystemColors.ActiveBorder;
            lblBookDescription.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblBookDescription.ForeColor = SystemColors.MenuHighlight;
            lblBookDescription.Location = new Point(384, 36);
            lblBookDescription.Name = "lblBookDescription";
            lblBookDescription.Size = new Size(147, 31);
            lblBookDescription.TabIndex = 2;
            lblBookDescription.Text = "Book Search";
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.LightSeaGreen;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreate.ForeColor = SystemColors.Control;
            btnCreate.Location = new Point(34, 49);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(128, 29);
            btnCreate.TabIndex = 6;
            btnCreate.Text = "Create a book";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.Control;
            btnDelete.Location = new Point(34, 177);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(128, 29);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete a book";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.LimeGreen;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(34, 113);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(128, 29);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update a book";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(255, 128, 0);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = SystemColors.Control;
            btnExit.Location = new Point(34, 255);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(128, 29);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // dgvBookList
            // 
            dgvBookList.BackgroundColor = SystemColors.ButtonFace;
            dgvBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookList.Location = new Point(12, 189);
            dgvBookList.Name = "dgvBookList";
            dgvBookList.RowHeadersWidth = 51;
            dgvBookList.RowTemplate.Height = 29;
            dgvBookList.Size = new Size(778, 293);
            dgvBookList.TabIndex = 10;
            dgvBookList.CellContentClick += dgvBookList_CellContentClick;
            dgvBookList.SelectionChanged += dgvBookList_SelectionChanged;
            // 
            // lblBookList
            // 
            lblBookList.AutoSize = true;
            lblBookList.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblBookList.ForeColor = Color.Snow;
            lblBookList.Location = new Point(18, 164);
            lblBookList.Name = "lblBookList";
            lblBookList.Size = new Size(76, 22);
            lblBookList.TabIndex = 11;
            lblBookList.Text = "Book List";
            // 
            // lblCopyright
            // 
            lblCopyright.AutoSize = true;
            lblCopyright.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblCopyright.ForeColor = Color.Snow;
            lblCopyright.Location = new Point(12, 487);
            lblCopyright.Name = "lblCopyright";
            lblCopyright.Size = new Size(73, 16);
            lblCopyright.TabIndex = 12;
            lblCopyright.Text = "© phuctrann";
            // 
            // grbActionCriteria
            // 
            grbActionCriteria.BackColor = SystemColors.ActiveBorder;
            grbActionCriteria.Controls.Add(btnExit);
            grbActionCriteria.Controls.Add(btnUpdate);
            grbActionCriteria.Controls.Add(btnDelete);
            grbActionCriteria.Controls.Add(btnCreate);
            grbActionCriteria.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grbActionCriteria.ForeColor = SystemColors.HotTrack;
            grbActionCriteria.Location = new Point(797, 189);
            grbActionCriteria.Name = "grbActionCriteria";
            grbActionCriteria.Size = new Size(191, 293);
            grbActionCriteria.TabIndex = 13;
            grbActionCriteria.TabStop = false;
            grbActionCriteria.Text = "Action";
            // 
            // BookManagerMainUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(998, 512);
            Controls.Add(grbActionCriteria);
            Controls.Add(lblCopyright);
            Controls.Add(lblBookList);
            Controls.Add(dgvBookList);
            Controls.Add(grbSearchCriteria);
            Controls.Add(lblHeader);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BookManagerMainUI";
            Text = "Book Manager";
            Load += BookManagerMainUI_Load;
            grbSearchCriteria.ResumeLayout(false);
            grbSearchCriteria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).EndInit();
            grbActionCriteria.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private Label lblBookName;
        private GroupBox grbSearchCriteria;
        private Label lblBookDescription;
        private Button btnSearch;
        private TextBox txtKeyword;
        private TextBox txtBookName;
        private Button btnCreate;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnExit;
        private DataGridView dgvBookList;
        private Label lblBookList;
        private Label lblCopyright;
        private GroupBox grbActionCriteria;
    }
}
