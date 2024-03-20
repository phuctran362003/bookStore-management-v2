namespace BookManagement_PhucTG
{
    partial class BookDetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookDetailForm));
            grbBookInfo = new GroupBox();
            btnCreate = new Button();
            cboBookCategory = new ComboBox();
            dtpPublicatioDate = new DateTimePicker();
            lblBookCategory = new Label();
            txtAuthor = new TextBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            txtBookName = new TextBox();
            lblBookName = new Label();
            lblDescription = new Label();
            lblPublicationDate = new Label();
            lblQuantity = new Label();
            lblAuthor = new Label();
            lblPrice = new Label();
            btnSearch = new Button();
            txtBookDescription = new TextBox();
            txtBookID = new TextBox();
            lblBookID = new Label();
            lblHeader = new Label();
            label1 = new Label();
            grbBookInfo.SuspendLayout();
            SuspendLayout();
            // 
            // grbBookInfo
            // 
            grbBookInfo.BackColor = SystemColors.ActiveBorder;
            grbBookInfo.Controls.Add(btnCreate);
            grbBookInfo.Controls.Add(cboBookCategory);
            grbBookInfo.Controls.Add(dtpPublicatioDate);
            grbBookInfo.Controls.Add(lblBookCategory);
            grbBookInfo.Controls.Add(txtAuthor);
            grbBookInfo.Controls.Add(txtPrice);
            grbBookInfo.Controls.Add(txtQuantity);
            grbBookInfo.Controls.Add(txtBookName);
            grbBookInfo.Controls.Add(lblBookName);
            grbBookInfo.Controls.Add(lblDescription);
            grbBookInfo.Controls.Add(lblPublicationDate);
            grbBookInfo.Controls.Add(lblQuantity);
            grbBookInfo.Controls.Add(lblAuthor);
            grbBookInfo.Controls.Add(lblPrice);
            grbBookInfo.Controls.Add(btnSearch);
            grbBookInfo.Controls.Add(txtBookDescription);
            grbBookInfo.Controls.Add(txtBookID);
            grbBookInfo.Controls.Add(lblBookID);
            grbBookInfo.Font = new Font("SF Mono", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grbBookInfo.ForeColor = SystemColors.HotTrack;
            grbBookInfo.Location = new Point(12, 71);
            grbBookInfo.Name = "grbBookInfo";
            grbBookInfo.Size = new Size(986, 543);
            grbBookInfo.TabIndex = 12;
            grbBookInfo.TabStop = false;
            grbBookInfo.Text = " Book Info ";
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.LimeGreen;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreate.ForeColor = SystemColors.Control;
            btnCreate.Location = new Point(832, 141);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(128, 46);
            btnCreate.TabIndex = 18;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            // 
            // cboBookCategory
            // 
            cboBookCategory.FormattingEnabled = true;
            cboBookCategory.Location = new Point(195, 458);
            cboBookCategory.Name = "cboBookCategory";
            cboBookCategory.Size = new Size(248, 26);
            cboBookCategory.TabIndex = 6;
            // 
            // dtpPublicatioDate
            // 
            dtpPublicatioDate.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dtpPublicatioDate.Format = DateTimePickerFormat.Short;
            dtpPublicatioDate.Location = new Point(195, 289);
            dtpPublicatioDate.Name = "dtpPublicatioDate";
            dtpPublicatioDate.Size = new Size(248, 28);
            dtpPublicatioDate.TabIndex = 3;
            // 
            // lblBookCategory
            // 
            lblBookCategory.AutoSize = true;
            lblBookCategory.BackColor = SystemColors.ActiveBorder;
            lblBookCategory.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblBookCategory.ForeColor = Color.Black;
            lblBookCategory.Location = new Point(0, 453);
            lblBookCategory.Name = "lblBookCategory";
            lblBookCategory.Size = new Size(180, 31);
            lblBookCategory.TabIndex = 17;
            lblBookCategory.Text = "Book Category";
            // 
            // txtAuthor
            // 
            txtAuthor.BackColor = Color.White;
            txtAuthor.Location = new Point(195, 407);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(248, 25);
            txtAuthor.TabIndex = 5;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(600, 289);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(183, 25);
            txtPrice.TabIndex = 7;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(195, 350);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(248, 25);
            txtQuantity.TabIndex = 4;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(193, 91);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(590, 25);
            txtBookName.TabIndex = 1;
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.BackColor = SystemColors.ActiveBorder;
            lblBookName.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblBookName.ForeColor = Color.Black;
            lblBookName.Location = new Point(6, 91);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(146, 31);
            lblBookName.TabIndex = 11;
            lblBookName.Text = "Book Name";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.BackColor = SystemColors.ActiveBorder;
            lblDescription.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblDescription.ForeColor = Color.Black;
            lblDescription.Location = new Point(6, 145);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(142, 31);
            lblDescription.TabIndex = 10;
            lblDescription.Text = "Description";
            // 
            // lblPublicationDate
            // 
            lblPublicationDate.AutoSize = true;
            lblPublicationDate.BackColor = SystemColors.ActiveBorder;
            lblPublicationDate.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblPublicationDate.ForeColor = Color.Black;
            lblPublicationDate.Location = new Point(0, 283);
            lblPublicationDate.Name = "lblPublicationDate";
            lblPublicationDate.Size = new Size(196, 31);
            lblPublicationDate.TabIndex = 9;
            lblPublicationDate.Text = "PublicationDate";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.BackColor = SystemColors.ActiveBorder;
            lblQuantity.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblQuantity.ForeColor = Color.Black;
            lblQuantity.Location = new Point(0, 342);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(113, 31);
            lblQuantity.TabIndex = 8;
            lblQuantity.Text = "Quantity";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.BackColor = SystemColors.ActiveBorder;
            lblAuthor.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblAuthor.ForeColor = Color.Black;
            lblAuthor.Location = new Point(6, 401);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(92, 31);
            lblAuthor.TabIndex = 7;
            lblAuthor.Text = "Author";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.BackColor = SystemColors.ActiveBorder;
            lblPrice.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblPrice.ForeColor = Color.Black;
            lblPrice.Location = new Point(527, 283);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(69, 31);
            lblPrice.TabIndex = 6;
            lblPrice.Text = "Price";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.LimeGreen;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = SystemColors.Control;
            btnSearch.Location = new Point(832, 32);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(128, 46);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtBookDescription
            // 
            txtBookDescription.Location = new Point(193, 145);
            txtBookDescription.Multiline = true;
            txtBookDescription.Name = "txtBookDescription";
            txtBookDescription.ScrollBars = ScrollBars.Vertical;
            txtBookDescription.Size = new Size(590, 116);
            txtBookDescription.TabIndex = 2;
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(193, 38);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(250, 25);
            txtBookID.TabIndex = 0;
            // 
            // lblBookID
            // 
            lblBookID.AutoSize = true;
            lblBookID.BackColor = SystemColors.ActiveBorder;
            lblBookID.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblBookID.ForeColor = Color.Black;
            lblBookID.Location = new Point(6, 36);
            lblBookID.Name = "lblBookID";
            lblBookID.Size = new Size(104, 31);
            lblBookID.TabIndex = 1;
            lblBookID.Text = "Book ID";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("SF Mono", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.ForeColor = Color.Snow;
            lblHeader.Location = new Point(-93, -76);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(372, 56);
            lblHeader.TabIndex = 11;
            lblHeader.Text = "Book Manager";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(12, 6);
            label1.Name = "label1";
            label1.Size = new Size(506, 62);
            label1.TabIndex = 13;
            label1.Text = "Add | Update a Book";
            // 
            // BookDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(1032, 639);
            Controls.Add(label1);
            Controls.Add(grbBookInfo);
            Controls.Add(lblHeader);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BookDetailForm";
            Text = "BookDetailForm";
            Load += BookDetailForm_Load;
            grbBookInfo.ResumeLayout(false);
            grbBookInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbBookInfo;
        private ComboBox cboBookCategory;
        private DateTimePicker dtpPublicatioDate;
        private Label lblBookCategory;
        private TextBox txtAuthor;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private TextBox txtBookName;
        private Label lblBookName;
        private Label lblDescription;
        private Label lblPublicationDate;
        private Label lblQuantity;
        private Label lblAuthor;
        private Label lblPrice;
        private Button btnSearch;
        private TextBox txtBookDescription;
        private TextBox txtBookID;
        private Label lblBookID;
        private Label lblHeader;
        private Button btnCreate;
        private Label label1;
    }
}