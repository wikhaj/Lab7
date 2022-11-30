using System.Xml.Serialization;

namespace Lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_usersave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog xml = new SaveFileDialog())
            {
                xml.Filter = "xml files (*.xml)|*.xml";
                if (xml.ShowDialog() == DialogResult.OK)
                {
                    serializeuser(xml.FileName);
                }
            }
        }

        private void button_userread_Click(object sender, EventArgs e)
        {

            Program.user_list.Clear();
            dataGridView1.Rows.Clear();

            using (OpenFileDialog xml = new OpenFileDialog())
            {
                xml.Filter = "xml files (*.xml)|*.xml";
                if (xml.ShowDialog() == DialogResult.OK)
                {
                    deserializeuser(xml.FileName);
                }
            }
            Program.UserId = dataGridView1.RowCount + 1;
;        }

        private void button_useradd_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.ShowDialog(this);
        }

        private void button_userdelete_Click(object sender, EventArgs e)
        {
            Form_removeuser rmuser = new Form_removeuser(this);
            rmuser.ShowDialog();
        }

        private void button_booksave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog xml = new SaveFileDialog())
            {
                xml.Filter = "xml files (*.xml)|*.xml";
                if (xml.ShowDialog() == DialogResult.OK)
                {
                    serializebook(xml.FileName);
                }
            }
        }

        private void button_bookread_Click(object sender, EventArgs e)
        {
            Program.book_list.Clear();
            dataGridView2.Rows.Clear();

            using (OpenFileDialog xml = new OpenFileDialog())
            {
                xml.Filter = "xml files (*.xml)|*.xml";
                if (xml.ShowDialog() == DialogResult.OK)
                {
                    deserializebook(xml.FileName);
                }
            }
            Program.BookId = dataGridView2.RowCount+1;
        }

        private void button_bookadd_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.ShowDialog();
        }

        private void button_bookdelete_Click(object sender, EventArgs e)
        {
            Form_removebook rmbook = new Form_removebook(this);
            rmbook.ShowDialog();
        }

        private void button_borrow_Click(object sender, EventArgs e)
        {
            Form_Borrow borrow = new Form_Borrow(this);
            borrow.ShowDialog();
        }

        private void button_return_Click(object sender, EventArgs e)
        {
            Form_return rtrn = new Form_return(this);
            rtrn.ShowDialog();
        }
        private void serializeuser(string path)
        {
            var serializer = new XmlSerializer(typeof(List<User>));
            using (var writer = new StreamWriter(path))
            {
                serializer.Serialize(writer, Program.user_list);
            }
        }
        private void serializebook(string path)
        {
            var serializer = new XmlSerializer(typeof(List<Book>));
            using (var writer = new StreamWriter(path))
            {
                serializer.Serialize(writer, Program.book_list);
            }
        }
        private void deserializeuser(string path)
        {
            var deserializer = new XmlSerializer(typeof(List<User>));

            using (var reader = new StreamReader(path))
            {
                try
                {
                    
                    Program.user_list = (List<User>)deserializer.Deserialize(reader);
                    Program.user_list.ForEach(
                        x => {
                        dataGridView1.Rows.Add(x.ID, x.Name, x.Surname); 
                        }
                        );
                }
                catch
                {

                }
            }
        }
        private void deserializebook(string path)
        {
            var deserializer = new XmlSerializer(typeof(List<Book>));

            using (var reader = new StreamReader(path))
            {
                try
                {

                    Program.book_list = (List<Book>)deserializer.Deserialize(reader);
                    Program.book_list.ForEach(
                        x => {
                            dataGridView2.Rows.Add(x.ID, x.Status, x.Title, x.Author);
                        }
                        );
                }
                catch
                {

                }
            }
        }
    }
}