using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Lab7
{
    public partial class Form_removebook : Form
    {
        Form1 form1 = new Form1();

        public Form_removebook(Form1 f)
        {
            form1 = f;
            InitializeComponent();
            for (int i = 1; i < 6000; i++)
            {
                comboBox1.Items.Add(i);
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            int id = getID();

            Program.book_list.RemoveAt(id); //i+1
            form1.dataGridView2.Rows.RemoveAt(id); //i+1*/

            form1.dataGridView2.Update();
            this.Close();

        }
        public int getID()
        {
            return comboBox1.SelectedIndex;
        }
    }
}
