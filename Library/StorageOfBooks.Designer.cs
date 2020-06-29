using System.Drawing;

namespace Library
{
    partial class StorageOfBooks
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.کتابهاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchStorageByAuthor = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchStorageBySubject = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchStorageByPublishYear = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchByTitle = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveNewBook = new System.Windows.Forms.ToolStripMenuItem();
            this.MissedBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.MatteredBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.Fines = new System.Windows.Forms.ToolStripMenuItem();
            this.BorrowedBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.ReservedBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridStorageOfBooks = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rdBtnMissedBooks = new System.Windows.Forms.RadioButton();
            this.rdBtnTornBooks = new System.Windows.Forms.RadioButton();
            this.rdBtnOldBooks = new System.Windows.Forms.RadioButton();
            this.rdBtnGoodBooks = new System.Windows.Forms.RadioButton();
            this.btnSubmitBookCondition = new System.Windows.Forms.Button();
            this.txtExplanation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.lblExplanations = new System.Windows.Forms.Label();
            this.btnDeliverToLib = new System.Windows.Forms.Button();
            this.txtNationalCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEditbook = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStorageOfBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.کتابهاToolStripMenuItem,
            this.SaveNewBook,
            this.MissedBooks,
            this.MatteredBooks,
            this.Fines,
            this.BorrowedBooks,
            this.ReservedBooks});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(692, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // کتابهاToolStripMenuItem
            // 
            this.کتابهاToolStripMenuItem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.کتابهاToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchStorageByAuthor,
            this.SearchStorageBySubject,
            this.SearchStorageByPublishYear,
            this.SearchByTitle});
            this.کتابهاToolStripMenuItem.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.کتابهاToolStripMenuItem.Name = "کتابهاToolStripMenuItem";
            this.کتابهاToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.کتابهاToolStripMenuItem.Text = "جستجوی کتاب ها";
            // 
            // SearchStorageByAuthor
            // 
            this.SearchStorageByAuthor.Name = "SearchStorageByAuthor";
            this.SearchStorageByAuthor.Size = new System.Drawing.Size(174, 24);
            this.SearchStorageByAuthor.Text = "بر اساس پدید آور";
            this.SearchStorageByAuthor.Click += new System.EventHandler(this.SearchStorageByAuthor_Click);
            // 
            // SearchStorageBySubject
            // 
            this.SearchStorageBySubject.Name = "SearchStorageBySubject";
            this.SearchStorageBySubject.Size = new System.Drawing.Size(174, 24);
            this.SearchStorageBySubject.Text = "بر اساس موضوع";
            this.SearchStorageBySubject.Click += new System.EventHandler(this.SearchStorageBySubject_Click);
            // 
            // SearchStorageByPublishYear
            // 
            this.SearchStorageByPublishYear.Name = "SearchStorageByPublishYear";
            this.SearchStorageByPublishYear.Size = new System.Drawing.Size(174, 24);
            this.SearchStorageByPublishYear.Text = "بر اساس سال انتشار";
            this.SearchStorageByPublishYear.Click += new System.EventHandler(this.SearchStorageByPublishYear_Click);
            // 
            // SearchByTitle
            // 
            this.SearchByTitle.Name = "SearchByTitle";
            this.SearchByTitle.Size = new System.Drawing.Size(174, 24);
            this.SearchByTitle.Text = "بر اساس عنوان کتاب";
            this.SearchByTitle.Click += new System.EventHandler(this.SearchByTitle_Click);
            // 
            // SaveNewBook
            // 
            this.SaveNewBook.BackColor = System.Drawing.Color.LightSteelBlue;
            this.SaveNewBook.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SaveNewBook.Name = "SaveNewBook";
            this.SaveNewBook.Size = new System.Drawing.Size(126, 24);
            this.SaveNewBook.Text = "ذخیره کتاب های جدید";
            this.SaveNewBook.Click += new System.EventHandler(this.SaveNewBook_Click);
            // 
            // MissedBooks
            // 
            this.MissedBooks.BackColor = System.Drawing.Color.LightSteelBlue;
            this.MissedBooks.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MissedBooks.Name = "MissedBooks";
            this.MissedBooks.Size = new System.Drawing.Size(105, 24);
            this.MissedBooks.Text = "کتاب های مفقودی";
            this.MissedBooks.Click += new System.EventHandler(this.MissedBooks_Click);
            // 
            // MatteredBooks
            // 
            this.MatteredBooks.BackColor = System.Drawing.Color.LightSteelBlue;
            this.MatteredBooks.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MatteredBooks.Name = "MatteredBooks";
            this.MatteredBooks.Size = new System.Drawing.Size(111, 24);
            this.MatteredBooks.Text = "کتاب های مستهلک";
            this.MatteredBooks.Click += new System.EventHandler(this.MatteredBooks_Click);
            // 
            // Fines
            // 
            this.Fines.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Fines.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Fines.Name = "Fines";
            this.Fines.Size = new System.Drawing.Size(62, 24);
            this.Fines.Text = "جریمه ها";
            this.Fines.Click += new System.EventHandler(this.Fines_Click);
            // 
            // BorrowedBooks
            // 
            this.BorrowedBooks.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BorrowedBooks.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BorrowedBooks.Name = "BorrowedBooks";
            this.BorrowedBooks.Size = new System.Drawing.Size(48, 24);
            this.BorrowedBooks.Text = "امانات";
            this.BorrowedBooks.Click += new System.EventHandler(this.BorrowedBooks_Click);
            // 
            // ReservedBooks
            // 
            this.ReservedBooks.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ReservedBooks.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ReservedBooks.Name = "ReservedBooks";
            this.ReservedBooks.Size = new System.Drawing.Size(113, 24);
            this.ReservedBooks.Text = "کتاب های رزرو شده";
            this.ReservedBooks.Click += new System.EventHandler(this.ReservedBooks_Click);
            // 
            // dataGridStorageOfBooks
            // 
            this.dataGridStorageOfBooks.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridStorageOfBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStorageOfBooks.Font = new System.Drawing.Font("B Nazanin", 10F);
            this.dataGridStorageOfBooks.Location = new System.Drawing.Point(12, 88);
            this.dataGridStorageOfBooks.Name = "dataGridStorageOfBooks";
            this.dataGridStorageOfBooks.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridStorageOfBooks.Size = new System.Drawing.Size(653, 185);
            this.dataGridStorageOfBooks.TabIndex = 7;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSearch.Location = new System.Drawing.Point(115, 42);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSearch.Size = new System.Drawing.Size(550, 29);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSearch.Location = new System.Drawing.Point(12, 42);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(97, 29);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(559, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = ": ثبت کتاب به عنوان";
            // 
            // rdBtnMissedBooks
            // 
            this.rdBtnMissedBooks.AutoSize = true;
            this.rdBtnMissedBooks.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdBtnMissedBooks.Location = new System.Drawing.Point(478, 399);
            this.rdBtnMissedBooks.Name = "rdBtnMissedBooks";
            this.rdBtnMissedBooks.Size = new System.Drawing.Size(69, 24);
            this.rdBtnMissedBooks.TabIndex = 11;
            this.rdBtnMissedBooks.TabStop = true;
            this.rdBtnMissedBooks.Text = "مفقود شده";
            this.rdBtnMissedBooks.UseVisualStyleBackColor = true;
            // 
            // rdBtnTornBooks
            // 
            this.rdBtnTornBooks.AutoSize = true;
            this.rdBtnTornBooks.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdBtnTornBooks.Location = new System.Drawing.Point(478, 429);
            this.rdBtnTornBooks.Name = "rdBtnTornBooks";
            this.rdBtnTornBooks.Size = new System.Drawing.Size(74, 24);
            this.rdBtnTornBooks.TabIndex = 12;
            this.rdBtnTornBooks.TabStop = true;
            this.rdBtnTornBooks.Text = "دارای پارگی";
            this.rdBtnTornBooks.UseVisualStyleBackColor = true;
            // 
            // rdBtnOldBooks
            // 
            this.rdBtnOldBooks.AutoSize = true;
            this.rdBtnOldBooks.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdBtnOldBooks.Location = new System.Drawing.Point(478, 459);
            this.rdBtnOldBooks.Name = "rdBtnOldBooks";
            this.rdBtnOldBooks.Size = new System.Drawing.Size(46, 24);
            this.rdBtnOldBooks.TabIndex = 13;
            this.rdBtnOldBooks.TabStop = true;
            this.rdBtnOldBooks.Text = "کهنه";
            this.rdBtnOldBooks.UseVisualStyleBackColor = true;
            // 
            // rdBtnGoodBooks
            // 
            this.rdBtnGoodBooks.AutoSize = true;
            this.rdBtnGoodBooks.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdBtnGoodBooks.Location = new System.Drawing.Point(478, 489);
            this.rdBtnGoodBooks.Name = "rdBtnGoodBooks";
            this.rdBtnGoodBooks.Size = new System.Drawing.Size(46, 24);
            this.rdBtnGoodBooks.TabIndex = 14;
            this.rdBtnGoodBooks.TabStop = true;
            this.rdBtnGoodBooks.Text = "سالم";
            this.rdBtnGoodBooks.UseVisualStyleBackColor = true;
            // 
            // btnSubmitBookCondition
            // 
            this.btnSubmitBookCondition.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSubmitBookCondition.Location = new System.Drawing.Point(129, 441);
            this.btnSubmitBookCondition.Name = "btnSubmitBookCondition";
            this.btnSubmitBookCondition.Size = new System.Drawing.Size(47, 30);
            this.btnSubmitBookCondition.TabIndex = 15;
            this.btnSubmitBookCondition.Text = "ثبت";
            this.btnSubmitBookCondition.UseVisualStyleBackColor = true;
            this.btnSubmitBookCondition.Click += new System.EventHandler(this.btnSubmitBookCondition_Click);
            // 
            // txtExplanation
            // 
            this.txtExplanation.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtExplanation.Location = new System.Drawing.Point(206, 428);
            this.txtExplanation.Multiline = true;
            this.txtExplanation.Name = "txtExplanation";
            this.txtExplanation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtExplanation.Size = new System.Drawing.Size(236, 55);
            this.txtExplanation.TabIndex = 16;
            this.txtExplanation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(367, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "درج توضیحات";
            // 
            // btnBorrow
            // 
            this.btnBorrow.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnBorrow.Location = new System.Drawing.Point(243, 302);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(97, 29);
            this.btnBorrow.TabIndex = 18;
            this.btnBorrow.Text = "ثبت امانت";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // lblExplanations
            // 
            this.lblExplanations.AutoSize = true;
            this.lblExplanations.Font = new System.Drawing.Font("B Nazanin", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblExplanations.ForeColor = System.Drawing.Color.Red;
            this.lblExplanations.Location = new System.Drawing.Point(329, 489);
            this.lblExplanations.Name = "lblExplanations";
            this.lblExplanations.Size = new System.Drawing.Size(113, 17);
            this.lblExplanations.TabIndex = 21;
            this.lblExplanations.Text = "لطفا توضیحات را درج نمایید";
            this.lblExplanations.Visible = false;
            // 
            // btnDeliverToLib
            // 
            this.btnDeliverToLib.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDeliverToLib.Location = new System.Drawing.Point(12, 279);
            this.btnDeliverToLib.Name = "btnDeliverToLib";
            this.btnDeliverToLib.Size = new System.Drawing.Size(97, 29);
            this.btnDeliverToLib.TabIndex = 22;
            this.btnDeliverToLib.Text = "ثبت تحویل کتاب";
            this.btnDeliverToLib.UseVisualStyleBackColor = true;
            this.btnDeliverToLib.Click += new System.EventHandler(this.btnDeliverToLib_Click);
            // 
            // txtNationalCode
            // 
            this.txtNationalCode.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtNationalCode.Location = new System.Drawing.Point(371, 310);
            this.txtNationalCode.Multiline = true;
            this.txtNationalCode.Name = "txtNationalCode";
            this.txtNationalCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNationalCode.Size = new System.Drawing.Size(220, 21);
            this.txtNationalCode.TabIndex = 23;
            this.txtNationalCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(597, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "کد ملی کاربر";
            // 
            // btnEditbook
            // 
            this.btnEditbook.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnEditbook.Location = new System.Drawing.Point(12, 314);
            this.btnEditbook.Name = "btnEditbook";
            this.btnEditbook.Size = new System.Drawing.Size(119, 30);
            this.btnEditbook.TabIndex = 25;
            this.btnEditbook.Text = "ویرایش اطلاعات کتاب";
            this.btnEditbook.UseVisualStyleBackColor = true;
            this.btnEditbook.Click += new System.EventHandler(this.btnEditbook_Click);
            // 
            // StorageOfBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 536);
            this.Controls.Add(this.btnEditbook);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNationalCode);
            this.Controls.Add(this.btnDeliverToLib);
            this.Controls.Add(this.lblExplanations);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtExplanation);
            this.Controls.Add(this.btnSubmitBookCondition);
            this.Controls.Add(this.rdBtnGoodBooks);
            this.Controls.Add(this.rdBtnOldBooks);
            this.Controls.Add(this.rdBtnTornBooks);
            this.Controls.Add(this.rdBtnMissedBooks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataGridStorageOfBooks);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StorageOfBooks";
            this.Text = "مدیریت انبار";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStorageOfBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem کتابهاToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SearchStorageByAuthor;
        private System.Windows.Forms.ToolStripMenuItem SearchStorageBySubject;
        private System.Windows.Forms.ToolStripMenuItem SearchStorageByPublishYear;
        private System.Windows.Forms.ToolStripMenuItem SaveNewBook;
        private System.Windows.Forms.DataGridView dataGridStorageOfBooks;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ToolStripMenuItem MissedBooks;
        private System.Windows.Forms.ToolStripMenuItem MatteredBooks;
        private System.Windows.Forms.ToolStripMenuItem BorrowedBooks;
        private System.Windows.Forms.ToolStripMenuItem ReservedBooks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdBtnMissedBooks;
        private System.Windows.Forms.RadioButton rdBtnTornBooks;
        private System.Windows.Forms.RadioButton rdBtnOldBooks;
        private System.Windows.Forms.RadioButton rdBtnGoodBooks;
        private System.Windows.Forms.Button btnSubmitBookCondition;
        private System.Windows.Forms.ToolStripMenuItem SearchByTitle;
        private System.Windows.Forms.TextBox txtExplanation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Label lblExplanations;
        private System.Windows.Forms.Button btnDeliverToLib;
        private System.Windows.Forms.TextBox txtNationalCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem Fines;
        private System.Windows.Forms.Button btnEditbook;
    }
}