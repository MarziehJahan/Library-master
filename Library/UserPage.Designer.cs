using System.Drawing;

namespace Library
{
    partial class UserPage
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.کتابهاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchStorageByAuthor = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchStorageBySubject = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchStorageByPublishYear = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchStorageByTitle = new System.Windows.Forms.ToolStripMenuItem();
            this.ReservedBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.Fines = new System.Windows.Forms.ToolStripMenuItem();
            this.BorrowedBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridOfBooks = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReserve = new System.Windows.Forms.Button();
            this.btnExtendReserve = new System.Windows.Forms.Button();
            this.btnAllFines = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOfBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.کتابهاToolStripMenuItem,
            this.ReservedBooks,
            this.Fines,
            this.BorrowedBooks});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip2.Size = new System.Drawing.Size(691, 28);
            this.menuStrip2.TabIndex = 7;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // کتابهاToolStripMenuItem
            // 
            this.کتابهاToolStripMenuItem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.کتابهاToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchStorageByAuthor,
            this.SearchStorageBySubject,
            this.SearchStorageByPublishYear,
            this.SearchStorageByTitle});
            this.کتابهاToolStripMenuItem.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.کتابهاToolStripMenuItem.Name = "کتابهاToolStripMenuItem";
            this.کتابهاToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.کتابهاToolStripMenuItem.Text = "کتاب ها";
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
            // SearchStorageByTitle
            // 
            this.SearchStorageByTitle.Name = "SearchStorageByTitle";
            this.SearchStorageByTitle.Size = new System.Drawing.Size(174, 24);
            this.SearchStorageByTitle.Text = "بر اساس عنوان کتاب";
            this.SearchStorageByTitle.Click += new System.EventHandler(this.SearchStorageByTitle_Click);
            // 
            // ReservedBooks
            // 
            this.ReservedBooks.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ReservedBooks.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ReservedBooks.Name = "ReservedBooks";
            this.ReservedBooks.Size = new System.Drawing.Size(143, 24);
            this.ReservedBooks.Text = "لیست کتاب های رزرو شده";
            this.ReservedBooks.Click += new System.EventHandler(this.ReservedBooks_Click);
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
            // dataGridOfBooks
            // 
            this.dataGridOfBooks.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridOfBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOfBooks.Font = new System.Drawing.Font("B Nazanin", 10F);
            this.dataGridOfBooks.Location = new System.Drawing.Point(16, 155);
            this.dataGridOfBooks.Name = "dataGridOfBooks";
            this.dataGridOfBooks.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridOfBooks.Size = new System.Drawing.Size(653, 192);
            this.dataGridOfBooks.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSearch.Location = new System.Drawing.Point(16, 104);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(97, 29);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSearch.Location = new System.Drawing.Point(119, 105);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSearch.Size = new System.Drawing.Size(550, 29);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblUser.Location = new System.Drawing.Point(32, 40);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(45, 19);
            this.lblUser.TabIndex = 12;
            this.lblUser.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(83, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "خوش آمدید";
            // 
            // btnReserve
            // 
            this.btnReserve.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnReserve.Location = new System.Drawing.Point(216, 368);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(97, 29);
            this.btnReserve.TabIndex = 14;
            this.btnReserve.Text = "تایید رزرو";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // btnExtendReserve
            // 
            this.btnExtendReserve.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnExtendReserve.Location = new System.Drawing.Point(113, 368);
            this.btnExtendReserve.Name = "btnExtendReserve";
            this.btnExtendReserve.Size = new System.Drawing.Size(97, 29);
            this.btnExtendReserve.TabIndex = 15;
            this.btnExtendReserve.Text = "تمدید امانت";
            this.btnExtendReserve.UseVisualStyleBackColor = true;
            this.btnExtendReserve.Click += new System.EventHandler(this.btnExtendReserve_Click);
            // 
            // btnAllFines
            // 
            this.btnAllFines.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAllFines.Location = new System.Drawing.Point(10, 368);
            this.btnAllFines.Name = "btnAllFines";
            this.btnAllFines.Size = new System.Drawing.Size(97, 29);
            this.btnAllFines.TabIndex = 16;
            this.btnAllFines.Text = "نمایش کل جریمه";
            this.btnAllFines.UseVisualStyleBackColor = true;
            this.btnAllFines.Click += new System.EventHandler(this.btnAllFines_Click);
            // 
            // UserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 450);
            this.Controls.Add(this.btnAllFines);
            this.Controls.Add(this.btnExtendReserve);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataGridOfBooks);
            this.Controls.Add(this.menuStrip2);
            this.Name = "UserPage";
            this.Text = "صفحه کاربری";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOfBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem کتابهاToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SearchStorageByAuthor;
        private System.Windows.Forms.ToolStripMenuItem SearchStorageBySubject;
        private System.Windows.Forms.ToolStripMenuItem SearchStorageByPublishYear;
        private System.Windows.Forms.ToolStripMenuItem SearchStorageByTitle;
        private System.Windows.Forms.ToolStripMenuItem ReservedBooks;
        private System.Windows.Forms.ToolStripMenuItem BorrowedBooks;
        private System.Windows.Forms.DataGridView dataGridOfBooks;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.ToolStripMenuItem Fines;
        private System.Windows.Forms.Button btnExtendReserve;
        private System.Windows.Forms.Button btnAllFines;
    }
}