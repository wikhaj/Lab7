namespace Lab7
{
    partial class Form1
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
            this.button_bookadd = new System.Windows.Forms.Button();
            this.button_bookdelete = new System.Windows.Forms.Button();
            this.button_userdelete = new System.Windows.Forms.Button();
            this.button_useradd = new System.Windows.Forms.Button();
            this.button_borrow = new System.Windows.Forms.Button();
            this.button_bookread = new System.Windows.Forms.Button();
            this.button_userread = new System.Windows.Forms.Button();
            this.button_usersave = new System.Windows.Forms.Button();
            this.button_booksave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_book = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tytuł = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_return = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_bookadd
            // 
            this.button_bookadd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_bookadd.Location = new System.Drawing.Point(676, 698);
            this.button_bookadd.Name = "button_bookadd";
            this.button_bookadd.Size = new System.Drawing.Size(77, 46);
            this.button_bookadd.TabIndex = 26;
            this.button_bookadd.Text = "+";
            this.button_bookadd.UseVisualStyleBackColor = true;
            this.button_bookadd.Click += new System.EventHandler(this.button_bookadd_Click);
            // 
            // button_bookdelete
            // 
            this.button_bookdelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_bookdelete.Location = new System.Drawing.Point(770, 698);
            this.button_bookdelete.Name = "button_bookdelete";
            this.button_bookdelete.Size = new System.Drawing.Size(77, 46);
            this.button_bookdelete.TabIndex = 25;
            this.button_bookdelete.Text = "-";
            this.button_bookdelete.UseVisualStyleBackColor = true;
            this.button_bookdelete.Click += new System.EventHandler(this.button_bookdelete_Click);
            // 
            // button_userdelete
            // 
            this.button_userdelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_userdelete.Location = new System.Drawing.Point(200, 698);
            this.button_userdelete.Name = "button_userdelete";
            this.button_userdelete.Size = new System.Drawing.Size(77, 46);
            this.button_userdelete.TabIndex = 24;
            this.button_userdelete.Text = "-";
            this.button_userdelete.UseVisualStyleBackColor = true;
            this.button_userdelete.Click += new System.EventHandler(this.button_userdelete_Click);
            // 
            // button_useradd
            // 
            this.button_useradd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_useradd.Location = new System.Drawing.Point(99, 698);
            this.button_useradd.Name = "button_useradd";
            this.button_useradd.Size = new System.Drawing.Size(77, 46);
            this.button_useradd.TabIndex = 23;
            this.button_useradd.Text = "+";
            this.button_useradd.UseVisualStyleBackColor = true;
            this.button_useradd.Click += new System.EventHandler(this.button_useradd_Click);
            // 
            // button_borrow
            // 
            this.button_borrow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_borrow.Location = new System.Drawing.Point(787, 839);
            this.button_borrow.Name = "button_borrow";
            this.button_borrow.Size = new System.Drawing.Size(290, 46);
            this.button_borrow.TabIndex = 22;
            this.button_borrow.Text = "wypożycz";
            this.button_borrow.UseVisualStyleBackColor = true;
            this.button_borrow.Click += new System.EventHandler(this.button_borrow_Click);
            // 
            // button_bookread
            // 
            this.button_bookread.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_bookread.Location = new System.Drawing.Point(676, 632);
            this.button_bookread.Name = "button_bookread";
            this.button_bookread.Size = new System.Drawing.Size(320, 46);
            this.button_bookread.TabIndex = 21;
            this.button_bookread.Text = "Odczyt";
            this.button_bookread.UseVisualStyleBackColor = true;
            this.button_bookread.Click += new System.EventHandler(this.button_bookread_Click);
            // 
            // button_userread
            // 
            this.button_userread.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_userread.Location = new System.Drawing.Point(99, 632);
            this.button_userread.Name = "button_userread";
            this.button_userread.Size = new System.Drawing.Size(315, 46);
            this.button_userread.TabIndex = 20;
            this.button_userread.Text = "Odczyt";
            this.button_userread.UseVisualStyleBackColor = true;
            this.button_userread.Click += new System.EventHandler(this.button_userread_Click);
            // 
            // button_usersave
            // 
            this.button_usersave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_usersave.Location = new System.Drawing.Point(99, 564);
            this.button_usersave.Name = "button_usersave";
            this.button_usersave.Size = new System.Drawing.Size(315, 46);
            this.button_usersave.TabIndex = 19;
            this.button_usersave.Text = "Zapis";
            this.button_usersave.UseVisualStyleBackColor = true;
            this.button_usersave.Click += new System.EventHandler(this.button_usersave_Click);
            // 
            // button_booksave
            // 
            this.button_booksave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_booksave.Location = new System.Drawing.Point(676, 564);
            this.button_booksave.Name = "button_booksave";
            this.button_booksave.Size = new System.Drawing.Size(320, 46);
            this.button_booksave.TabIndex = 18;
            this.button_booksave.Text = "Zapis";
            this.button_booksave.UseVisualStyleBackColor = true;
            this.button_booksave.Click += new System.EventHandler(this.button_booksave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 45);
            this.label1.TabIndex = 17;
            this.label1.Text = "Użytkownik";
            // 
            // label_book
            // 
            this.label_book.AutoSize = true;
            this.label_book.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_book.Location = new System.Drawing.Point(600, 118);
            this.label_book.Name = "label_book";
            this.label_book.Size = new System.Drawing.Size(128, 45);
            this.label_book.TabIndex = 16;
            this.label_book.Text = "Książka";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Stan,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView2.Location = new System.Drawing.Point(600, 203);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.Size = new System.Drawing.Size(499, 299);
            this.dataGridView2.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Tytuł,
            this.Autor});
            this.dataGridView1.Location = new System.Drawing.Point(23, 203);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(494, 299);
            this.dataGridView1.TabIndex = 14;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            // 
            // Tytuł
            // 
            this.Tytuł.HeaderText = "Imię";
            this.Tytuł.MinimumWidth = 8;
            this.Tytuł.Name = "Tytuł";
            // 
            // Autor
            // 
            this.Autor.HeaderText = "Nazwisko";
            this.Autor.MinimumWidth = 8;
            this.Autor.Name = "Autor";
            // 
            // button_return
            // 
            this.button_return.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_return.Location = new System.Drawing.Point(787, 900);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(290, 46);
            this.button_return.TabIndex = 27;
            this.button_return.Text = "zwróć";
            this.button_return.UseVisualStyleBackColor = true;
            this.button_return.Click += new System.EventHandler(this.button_return_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 113.6364F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Stan
            // 
            this.Stan.FillWeight = 95.45454F;
            this.Stan.HeaderText = "Stan";
            this.Stan.MinimumWidth = 8;
            this.Stan.Name = "Stan";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 95.45454F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Tytuł";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 95.45454F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Autor";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 1010);
            this.Controls.Add(this.button_return);
            this.Controls.Add(this.button_bookadd);
            this.Controls.Add(this.button_bookdelete);
            this.Controls.Add(this.button_userdelete);
            this.Controls.Add(this.button_useradd);
            this.Controls.Add(this.button_borrow);
            this.Controls.Add(this.button_bookread);
            this.Controls.Add(this.button_userread);
            this.Controls.Add(this.button_usersave);
            this.Controls.Add(this.button_booksave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_book);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_bookadd;
        private Button button_bookdelete;
        private Button button_userdelete;
        private Button button_useradd;
        private Button button_borrow;
        private Button button_bookread;
        private Button button_userread;
        private Button button_usersave;
        private Button button_booksave;
        private Label label1;
        private Label label_book;
        public DataGridView dataGridView2;
        public DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Tytuł;
        private DataGridViewTextBoxColumn Autor;
        private Button button_return;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Stan;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}