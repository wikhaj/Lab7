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
    public partial class Form_return : Form
    {
        Form1 form1;
        public Form_return(Form1 f)
        {
            InitializeComponent();
            form1 = f;
            Program.user_list.ForEach(
                x => {
                    string person = x.ID + " " + x.Name + " " + x.Surname;
                    comboBox1.Items.Add(person);
                }
                );

        }



        private void button1_Click(object sender, EventArgs e)
        {
            Book book = get_book();
            book.Status = "dostępna";
            book.User = "";

            foreach (DataGridViewRow row in form1.dataGridView2.Rows)
            {
                if (row.Cells[0].Value.Equals(book.ID))
                {
                    row.Selected = true;
                    row.Cells[1].Value = "dostępna";
                    break;
                }
            }
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            set_books();
        }


        void set_books()
        {
            Program.book_list.ForEach(
                x =>
                {
                    User usr = get_user();
                    if (x.User.ToLower() == (usr.Name + usr.Surname).ToLower())
                    {
                        comboBox2.Items.Add(x.ID + " " + x.Title + " " + x.Author);
                    }

                });
        }
        User get_user()
        {

            string selected_person = comboBox1.SelectedItem.ToString();
            string[] sel_pers = selected_person.Split(' ');
            int person_id = Int32.Parse(sel_pers[0]);

            User usr = Program.user_list.Find(e => e.ID == person_id);

            return usr;
        }

        Book get_book()
        {
            string selected_book = this.comboBox2.SelectedItem.ToString();
            string[] sel_book = selected_book.Split(' ');
            int book_id = Int32.Parse(sel_book[0]);

            Book bk = Program.book_list.Find(e => e.ID == book_id);

            return bk;
        }
    }
}
