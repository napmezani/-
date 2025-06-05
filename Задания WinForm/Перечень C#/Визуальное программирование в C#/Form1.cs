using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenDlg = new OpenFileDialog();

            if (OpenDlg.ShowDialog() == DialogResult.OK)
            {
                StreamReader Reader = new StreamReader(OpenDlg.FileName, Encoding.Default);
                file_open_richTextBox.Text = Reader.ReadToEnd();
                Reader.Close();
            }
            OpenDlg.Dispose();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveDlg = new SaveFileDialog();
            if (SaveDlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter Writer = new StreamWriter(SaveDlg.FileName);
                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    Writer.WriteLine((string)listBox2.Items[i]);
                }
                Writer.Close();
            }
            SaveDlg.Dispose();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Информация о приложении и разработчике");
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox1.BeginUpdate();
            string[] Strings = file_open_richTextBox.Text.Split(new char[] { '\n', '\t', ' ' },
            StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in Strings)
            {
                string Str = s.Trim();
                if (Str == String.Empty) continue;
                if (all_radioButton.Checked) listBox1.Items.Add(Str);
                if (num_contain_radioButton.Checked)
                {
                    if (Regex.IsMatch(Str, @"\d")) listBox1.Items.Add(Str);
                }
                if (email_contain_radioButton.Checked)
                {
                    if (Regex.IsMatch(Str, @"\w+@\w+\.\w+")) listBox1.Items.Add(Str);
                }
            }
            listBox1.EndUpdate();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            file_open_richTextBox.Clear();

            first_section_checkBox.Checked = true;
            second_section_checkBox.Checked = false;

            all_radioButton.Checked = true;
        }

        private void clean_fist_section_button_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void clean_second_section_button_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            string Find = search_by_word_textBox.Text;
            if (first_section_checkBox.Checked)
            {
                foreach (string String in listBox1.Items)
                {
                    if (String.Contains(Find)) listBox3.Items.Add(String);
                }
            }
            if (second_section_checkBox.Checked)
            {
                foreach (string String in listBox2.Items)
                {
                    if (String.Contains(Find)) listBox3.Items.Add(String);
                }
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            Form2 AddRec = new Form2();
            AddRec.Owner = this;
            AddRec.ShowDialog();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            Form3 DeleteRec = new Form3();
            DeleteRec.Owner = this;
            DeleteRec.ShowDialog();
        }

        private void move_to_right_button_Click(object sender, EventArgs e)
        {
            listBox2.Items.AddRange(listBox1.Items);
            listBox1.Items.Clear();
        }

        private void move_to_left_button_Click(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(listBox2.Items);
            listBox2.Items.Clear();
        }

        private void selected_move_to_right_button_Click(object sender, EventArgs e)
        {
            listBox2.BeginUpdate();
            foreach (object Item in listBox1.SelectedItems)
            {
                listBox2.Items.Add(Item);
            }
            listBox2.EndUpdate();
        }

        private void selected_move_to_left_button_Click(object sender, EventArgs e)
        {
            listBox1.BeginUpdate();
            foreach (object Item in listBox2.SelectedItems)
            {
                listBox1.Items.Add(Item);
            }
            listBox1.EndUpdate();
        }

        private void sort_fist_section_button_Click(object sender, EventArgs e)
        {
            switch (sort_first_section_comboBox.SelectedItem.ToString())
            {
                case "Алфавиту (по возрастанию)":
                    sortByAlphabet(listBox1, true);
                    break;

                case "Алфавиту (по убыванию)":
                    sortByAlphabet(listBox1, false);
                    break;
                case "Длине слова (по возрастанию)":
                    sortByWordLength(listBox1, false);
                    break;
                case "Длине слова (по убыванию)":
                    sortByWordLength(listBox1, true);
                    break;
                default:
                    break;
            }


            void sortByAlphabet(ListBox listBox, bool ascending = true)
            {
                if (listBox == null || listBox.Items.Count == 0)
                    return;

                var items = listBox.Items.Cast<object>().Select(x => x.ToString()).ToList();

                if (ascending)
                {
                    items = items.OrderBy(x => x).ToList();
                }
                else
                {
                    items = items.OrderByDescending(x => x).ToList();
                }

                listBox.BeginUpdate();
                listBox.Items.Clear();
                listBox.Items.AddRange(items.ToArray());
                listBox.EndUpdate();
            }

            void sortByWordLength(ListBox listBox, bool descending = true)
            {
                if (listBox == null || listBox.Items.Count == 0)
                    return;

                var items = listBox.Items.Cast<string>().ToList();

                if (descending)
                {
                    items = items.OrderByDescending(word => word.Length).ToList();
                }
                else
                {
                    items = items.OrderBy(word => word.Length).ToList();
                }

                listBox.BeginUpdate();
                listBox.Items.Clear();
                listBox.Items.AddRange(items.ToArray());
                listBox.EndUpdate();
            }
        }

        private void sort_second_section_button_Click(object sender, EventArgs e)
        {
            switch (sort_second_section_comboBox.SelectedItem.ToString())
            {
                case "Алфавиту (по возрастанию)":
                    sortByAlphabet(listBox2, true);
                    break;
                case "Алфавиту (по убыванию)":
                    sortByAlphabet(listBox2, false);
                    break;
                case "Длине слова (по возрастанию)":
                    sortByWordLength(listBox2, false);
                    break;
                case "Длине слова (по убыванию)":
                    sortByWordLength(listBox2, true);
                    break;
                default:
                    break;
            }    

            void sortByAlphabet(ListBox listBox, bool ascending = true)
            {
                if (listBox == null || listBox.Items.Count == 0)
                    return;

                var items = listBox.Items.Cast<object>().Select(x => x.ToString()).ToList();

                if (ascending)
                {
                    items = items.OrderBy(x => x).ToList();
                }
                else
                {
                    items = items.OrderByDescending(x => x).ToList();
                }

                listBox.BeginUpdate();
                listBox.Items.Clear();
                listBox.Items.AddRange(items.ToArray());
                listBox.EndUpdate();
            }
            void sortByWordLength(ListBox listBox, bool descending = true)
            {
                if (listBox == null || listBox.Items.Count == 0)
                    return;

                var items = listBox.Items.Cast<string>().ToList();

                if (descending)
                {
                    items = items.OrderByDescending(word => word.Length).ToList();
                }
                else
                {
                    items = items.OrderBy(word => word.Length).ToList();
                }

                listBox.BeginUpdate();
                listBox.Items.Clear();
                listBox.Items.AddRange(items.ToArray());
                listBox.EndUpdate();
            }
        }
    }
}
