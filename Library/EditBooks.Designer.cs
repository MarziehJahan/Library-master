namespace Library
{
    partial class EditBooks
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBook = new System.Windows.Forms.Label();
            this.lblAuthorFname = new System.Windows.Forms.Label();
            this.lblAuthorName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbBoxPublishYear = new System.Windows.Forms.ComboBox();
            this.txtAuthorFname = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCodeBook = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDelete.Location = new System.Drawing.Point(116, 386);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 29);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnClear.Location = new System.Drawing.Point(116, 351);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 29);
            this.btnClear.TabIndex = 39;
            this.btnClear.Text = "پاک کردن";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(91, 260);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPrice.Size = new System.Drawing.Size(168, 20);
            this.txtPrice.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(291, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "قیمت";
            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblBook.ForeColor = System.Drawing.Color.Red;
            this.lblBook.Location = new System.Drawing.Point(122, 54);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(137, 19);
            this.lblBook.TabIndex = 36;
            this.lblBook.Text = "پر کردن این قسمت الزامی است";
            this.lblBook.Visible = false;
            // 
            // lblAuthorFname
            // 
            this.lblAuthorFname.AutoSize = true;
            this.lblAuthorFname.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblAuthorFname.ForeColor = System.Drawing.Color.Red;
            this.lblAuthorFname.Location = new System.Drawing.Point(76, 151);
            this.lblAuthorFname.Name = "lblAuthorFname";
            this.lblAuthorFname.Size = new System.Drawing.Size(137, 19);
            this.lblAuthorFname.TabIndex = 35;
            this.lblAuthorFname.Text = "پر کردن این قسمت الزامی است";
            this.lblAuthorFname.Visible = false;
            // 
            // lblAuthorName
            // 
            this.lblAuthorName.AutoSize = true;
            this.lblAuthorName.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblAuthorName.ForeColor = System.Drawing.Color.Red;
            this.lblAuthorName.Location = new System.Drawing.Point(122, 106);
            this.lblAuthorName.Name = "lblAuthorName";
            this.lblAuthorName.Size = new System.Drawing.Size(137, 19);
            this.lblAuthorName.TabIndex = 34;
            this.lblAuthorName.Text = "پر کردن این قسمت الزامی است";
            this.lblAuthorName.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSave.Location = new System.Drawing.Point(116, 316);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 29);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "ذخیره";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbBoxPublishYear
            // 
            this.cmbBoxPublishYear.FormattingEnabled = true;
            this.cmbBoxPublishYear.Items.AddRange(new object[] {
            "1399",
            "1398",
            "1397",
            "1396",
            "1395",
            "1394",
            "1393",
            "1392",
            "1391",
            "1390",
            "1389",
            "1388",
            "1387",
            "1386",
            "1385",
            "1384",
            "1383",
            "1382",
            "1381",
            "1380"});
            this.cmbBoxPublishYear.Location = new System.Drawing.Point(187, 219);
            this.cmbBoxPublishYear.Name = "cmbBoxPublishYear";
            this.cmbBoxPublishYear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbBoxPublishYear.Size = new System.Drawing.Size(72, 21);
            this.cmbBoxPublishYear.TabIndex = 32;
            // 
            // txtAuthorFname
            // 
            this.txtAuthorFname.Location = new System.Drawing.Point(45, 128);
            this.txtAuthorFname.Name = "txtAuthorFname";
            this.txtAuthorFname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAuthorFname.Size = new System.Drawing.Size(168, 20);
            this.txtAuthorFname.TabIndex = 31;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(45, 177);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSubject.Size = new System.Drawing.Size(214, 20);
            this.txtSubject.TabIndex = 30;
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Location = new System.Drawing.Point(45, 85);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAuthorName.Size = new System.Drawing.Size(214, 20);
            this.txtAuthorName.TabIndex = 29;
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(45, 31);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBookName.Size = new System.Drawing.Size(214, 20);
            this.txtBookName.TabIndex = 28;
            this.txtBookName.TextChanged += new System.EventHandler(this.txtBookName_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(265, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "نام نویسنده";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(220, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "نام خانوادگی نویسنده";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(266, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "سال انتشار";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(258, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "موضوع کتاب";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(278, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "نام کتاب";
            // 
            // lblCodeBook
            // 
            this.lblCodeBook.AutoSize = true;
            this.lblCodeBook.Location = new System.Drawing.Point(1, 0);
            this.lblCodeBook.Name = "lblCodeBook";
            this.lblCodeBook.Size = new System.Drawing.Size(45, 13);
            this.lblCodeBook.TabIndex = 41;
            this.lblCodeBook.Text = "کد کتاب";
            this.lblCodeBook.Visible = false;
            // 
            // EditBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 442);
            this.Controls.Add(this.lblCodeBook);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblBook);
            this.Controls.Add(this.lblAuthorFname);
            this.Controls.Add(this.lblAuthorName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbBoxPublishYear);
            this.Controls.Add(this.txtAuthorFname);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtAuthorName);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditBooks";
            this.Text = "صفحه ویرایش اطلاعات کتاب ها";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.Label lblAuthorFname;
        private System.Windows.Forms.Label lblAuthorName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbBoxPublishYear;
        private System.Windows.Forms.TextBox txtAuthorFname;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCodeBook;
    }
}