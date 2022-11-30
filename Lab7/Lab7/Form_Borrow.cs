using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab7
{
    public partial class Form_Borrow : Form
    {
        Form1 form1;

        public Form_Borrow(Form1 f)
        {
            InitializeComponent();
            form1 = f;

            Program.user_list.ForEach(
                x => {
                    string person = x.ID + " " + x.Name + " " + x.Surname;
                    comboBox1.Items.Add(person);
                }
                );
            Program.book_list.ForEach(
                x => {
                    if(x.Status == "dostępna")
                    {
                        string book = x.ID + " " + x.Title + " " + x.Author;
                        comboBox2.Items.Add(book);
                    }
                }
                );
        }

        private void button_borrow_Click(object sender, EventArgs e)
        {
            User usr = get_user();
            Book bk = get_book();

            bk.User = (usr.Name + usr.Surname).ToLower();
            bk.Status = "wypożyczona";

            foreach (DataGridViewRow row in form1.dataGridView2.Rows)
            {
                if (row.Cells[0].Value.Equals(bk.ID))
                {
                    row.Selected = true;
                    row.Cells[1].Value = "wypożyczona";
                    break;
                }
            }
            form1.dataGridView2.Update();

            this.Close();
        }

        Book get_book()
        {
            string selected_book = this.comboBox2.SelectedItem.ToString();
            string[] sel_book = selected_book.Split(' ');
            int book_id = Int32.Parse(sel_book[0]);

            Book bk = Program.book_list.Find(e => e.ID == book_id);

            return bk;
        }

        User get_user()
        {
            string selected_person = this.comboBox1.SelectedItem.ToString();
            string[] sel_pers = selected_person.Split(' ');
            int person_id = Int32.Parse(sel_pers[0]);

            User usr = Program.user_list.Find(e => e.ID == person_id);

            return usr;
        }
    }
}
