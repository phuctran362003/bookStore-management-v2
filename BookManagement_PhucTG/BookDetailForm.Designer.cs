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
            groupBox1 = new GroupBox();
            btnCancel = new Button();
            btnSaveChanges = new Button();
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
            txtBookDescription = new TextBox();
            txtBookID = new TextBox();
            lblBookID = new Label();
            lblHeader = new Label();
            lblAddUpdate = new Label();
            grbBookInfo.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // grbBookInfo
            // 
            grbBookInfo.BackColor = SystemColors.ButtonFace;
            grbBookInfo.Controls.Add(groupBox1);
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
            grbBookInfo.Controls.Add(txtBookDescription);
            grbBookInfo.Controls.Add(txtBookID);
            grbBookInfo.Controls.Add(lblBookID);
            grbBookInfo.Font = new Font("SF Mono", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grbBookInfo.ForeColor = SystemColors.HotTrack;
            grbBookInfo.Location = new Point(12, 84);
            grbBookInfo.Name = "grbBookInfo";
            grbBookInfo.Size = new Size(986, 543);
            grbBookInfo.TabIndex = 12;
            grbBookInfo.TabStop = false;
            grbBookInfo.Text = " Book Info ";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(btnSaveChanges);
            groupBox1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.MenuHighlight;
            groupBox1.Location = new Point(797, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(180, 499);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = " Action ";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(255, 128, 0);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = SystemColors.Control;
            btnCancel.Location = new Point(33, 189);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(128, 34);
            btnCancel.TabIndex = 19;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.BackColor = Color.LimeGreen;
            btnSaveChanges.FlatStyle = FlatStyle.Flat;
            btnSaveChanges.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveChanges.ForeColor = SystemColors.Control;
            btnSaveChanges.Location = new Point(33, 41);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(128, 46);
            btnSaveChanges.TabIndex = 5;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = false;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // cboBookCategory
            // 
            cboBookCategory.BackColor = Color.FromArgb(224, 224, 224);
            cboBookCategory.FormattingEnabled = true;
            cboBookCategory.Location = new Point(195, 458);
            cboBookCategory.Name = "cboBookCategory";
            cboBookCategory.Size = new Size(248, 26);
            cboBookCategory.TabIndex = 6;
            // 
            // dtpPublicatioDate
            // 
            dtpPublicatioDate.CalendarForeColor = SystemColors.MenuHighlight;
            dtpPublicatioDate.CalendarMonthBackground = Color.FromArgb(224, 224, 224);
            dtpPublicatioDate.CalendarTitleForeColor = SystemColors.MenuHighlight;
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
            lblBookCategory.BackColor = SystemColors.ButtonFace;
            lblBookCategory.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblBookCategory.ForeColor = SystemColors.MenuHighlight;
            lblBookCategory.Location = new Point(0, 458);
            lblBookCategory.Name = "lblBookCategory";
            lblBookCategory.Size = new Size(173, 31);
            lblBookCategory.TabIndex = 17;
            lblBookCategory.Text = "Book Category";
            // 
            // txtAuthor
            // 
            txtAuthor.BackColor = Color.FromArgb(224, 224, 224);
            txtAuthor.Location = new Point(195, 407);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(248, 25);
            txtAuthor.TabIndex = 5;
            // 
            // txtPrice
            // 
            txtPrice.BackColor = Color.FromArgb(224, 224, 224);
            txtPrice.Location = new Point(600, 289);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(183, 25);
            txtPrice.TabIndex = 7;
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = Color.FromArgb(224, 224, 224);
            txtQuantity.Location = new Point(195, 350);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(248, 25);
            txtQuantity.TabIndex = 4;
            // 
            // txtBookName
            // 
            txtBookName.BackColor = Color.FromArgb(224, 224, 224);
            txtBookName.Location = new Point(193, 91);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(590, 25);
            txtBookName.TabIndex = 1;
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.BackColor = SystemColors.ButtonFace;
            lblBookName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblBookName.ForeColor = SystemColors.MenuHighlight;
            lblBookName.Location = new Point(6, 91);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(139, 31);
            lblBookName.TabIndex = 11;
            lblBookName.Text = "Book Name";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.BackColor = SystemColors.ButtonFace;
            lblDescription.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescription.ForeColor = SystemColors.MenuHighlight;
            lblDescription.Location = new Point(6, 145);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(138, 31);
            lblDescription.TabIndex = 10;
            lblDescription.Text = "Description";
            // 
            // lblPublicationDate
            // 
            lblPublicationDate.AutoSize = true;
            lblPublicationDate.BackColor = SystemColors.ButtonFace;
            lblPublicationDate.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblPublicationDate.ForeColor = SystemColors.MenuHighlight;
            lblPublicationDate.Location = new Point(0, 289);
            lblPublicationDate.Name = "lblPublicationDate";
            lblPublicationDate.Size = new Size(187, 31);
            lblPublicationDate.TabIndex = 9;
            lblPublicationDate.Text = "PublicationDate";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.BackColor = SystemColors.ButtonFace;
            lblQuantity.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuantity.ForeColor = SystemColors.MenuHighlight;
            lblQuantity.Location = new Point(0, 350);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(108, 31);
            lblQuantity.TabIndex = 8;
            lblQuantity.Text = "Quantity";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.BackColor = SystemColors.ButtonFace;
            lblAuthor.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblAuthor.ForeColor = SystemColors.MenuHighlight;
            lblAuthor.Location = new Point(0, 407);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(90, 31);
            lblAuthor.TabIndex = 7;
            lblAuthor.Text = "Author";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.BackColor = SystemColors.ButtonFace;
            lblPrice.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrice.ForeColor = SystemColors.MenuHighlight;
            lblPrice.Location = new Point(525, 289);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(67, 31);
            lblPrice.TabIndex = 6;
            lblPrice.Text = "Price";
            // 
            // txtBookDescription
            // 
            txtBookDescription.BackColor = Color.FromArgb(224, 224, 224);
            txtBookDescription.Location = new Point(193, 145);
            txtBookDescription.Multiline = true;
            txtBookDescription.Name = "txtBookDescription";
            txtBookDescription.ScrollBars = ScrollBars.Vertical;
            txtBookDescription.Size = new Size(590, 116);
            txtBookDescription.TabIndex = 2;
            // 
            // txtBookID
            // 
            txtBookID.BackColor = Color.FromArgb(224, 224, 224);
            txtBookID.Location = new Point(193, 38);
            txtBookID.Name = "txtBookID";
            txtBookID.RightToLeft = RightToLeft.Yes;
            txtBookID.Size = new Size(250, 25);
            txtBookID.TabIndex = 0;
            txtBookID.TextAlign = HorizontalAlignment.Center;
            txtBookID.Click += txtBookID_Click;
            // 
            // lblBookID
            // 
            lblBookID.AutoSize = true;
            lblBookID.BackColor = SystemColors.ButtonFace;
            lblBookID.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblBookID.ForeColor = SystemColors.MenuHighlight;
            lblBookID.Location = new Point(6, 38);
            lblBookID.Name = "lblBookID";
            lblBookID.Size = new Size(100, 31);
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
            // lblAddUpdate
            // 
            lblAddUpdate.AutoSize = true;
            lblAddUpdate.Font = new Font("Segoe UI Black", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddUpdate.ForeColor = SystemColors.ButtonFace;
            lblAddUpdate.Location = new Point(12, 9);
            lblAddUpdate.Name = "lblAddUpdate";
            lblAddUpdate.Size = new Size(506, 62);
            lblAddUpdate.TabIndex = 13;
            lblAddUpdate.Text = "Add | Update a Book";
            // 
            // BookDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(1032, 639);
            Controls.Add(lblAddUpdate);
            Controls.Add(grbBookInfo);
            Controls.Add(lblHeader);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BookDetailForm";
            Text = "BookDetailForm";
            Load += BookDetailForm_Load;
            grbBookInfo.ResumeLayout(false);
            grbBookInfo.PerformLayout();
            groupBox1.ResumeLayout(false);
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
        private Button btnSaveChanges;
        private TextBox txtBookDescription;
        private TextBox txtBookID;
        private Label lblBookID;
        private Label lblHeader;
        private Label lblAddUpdate;
        private GroupBox groupBox1;
        private Button btnCancel;
    }
}