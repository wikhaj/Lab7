using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form2 : Form
    {
        Book book = new Book();
        public Form1 for1;

        public Form2(Form1 f)
        {
            InitializeComponent();
            for1 = f;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            book.Title = textBox1.Text;
            textBox1.Clear();
            book.Author = textBox2.Text;
            textBox2.Clear();
            int tmp_id = Program.BookId+1;

            string default_status = "dostępna";

            Program.BookId = tmp_id;

            book.ID = tmp_id;
            book.Status = default_status;
            book.User = "";

            Program.book_list.Add(book);

            for1.dataGridView2.Rows.Add(book.ID, book.Status, book.Title, book.Author);

            for1.dataGridView1.Update();
            this.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
