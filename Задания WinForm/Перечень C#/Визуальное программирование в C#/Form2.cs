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

namespace test
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            Form1 Main = this.Owner as Form1;
            if (textBox.Text != "")
            {
                if (this.first_section_radioButton.Checked == true)
                    Main.listBox1.Items.Add(this.textBox.Text);
                else Main.listBox2.Items.Add(this.textBox.Text);
                this.Close();
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
