using System;
using System.Collections;
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
    public partial class Form_removeuser : Form
    {
        Form1 form1;
        public Form_removeuser(Form1 f)
        {
            InitializeComponent();
            form1 = f;
            for (int i = 1; i < 3000; i++)
            {
                comboBox1.Items.Add(i);
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public int getID()
        {
            return comboBox1.SelectedIndex;
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
/*            string selected_person = this.comboBox1.SelectedItem.ToString();
            string[] sel_pers = selected_person.Split(' ');
            int person_id = Int32.Parse(sel_pers[0]);

            User usr = Program.user_list.Find(e => e.ID == person_id);


            int id = getID();
            int index = Program.user_list.FindIndex(a => id == usr.ID);*/

            Program.user_list.RemoveAt(index); //i+1
            form1.dataGridView1.Rows.RemoveAt(index); //i+1*/

            form1.dataGridView1.Update();
            this.Close();
        }
    }
}
