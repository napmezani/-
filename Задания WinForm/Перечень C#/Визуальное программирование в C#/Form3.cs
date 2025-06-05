using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            Form1 Main = this.Owner as Form1;

            if (textBox.Text != "")
            {
                if (this.first_section_radioButton.Checked == true)
                    DeleteSelectedStrings(Main.listBox1);
                else 
                    DeleteSelectedStrings(Main.listBox2);

                this.Close();
            }


            void DeleteSelectedStrings(ListBox listBox)
            {
                for (int i = listBox.Items.Count - 1; i >= 0; i--)
                {
                    if (listBox.Items[i].ToString().Contains(textBox.Text)) listBox.Items.RemoveAt(i);
                }
            } 
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
