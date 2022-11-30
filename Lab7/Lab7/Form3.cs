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
    public partial class Form3 : Form
    {
        public Form1 for1;
        public User user = new User();
        public Form3(Form1 for1)
        {
            InitializeComponent();
            this.for1 = for1;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            user.Name = textBox1.Text;
            textBox1.Clear();
            user.Surname = textBox2.Text;
            textBox2.Clear();
            int tmp_id = Program.UserId + 1;

            Program.UserId = tmp_id;

            user.ID = tmp_id;

            Program.user_list.Add(user);

            for1.dataGridView1.Rows.Add(user.ID, user.Name, user.Surname);

            for1.dataGridView1.Update();
            this.Close();
        }
    }
}
