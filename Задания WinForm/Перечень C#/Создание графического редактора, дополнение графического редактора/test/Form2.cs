﻿using System;
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
    public partial class Form2: Form
    {
        Color colorResult;
        public Form2(Color color)
        {
            InitializeComponent();
            hScrollBar1.Tag = numericUpDown1;
            hScrollBar2.Tag = numericUpDown2;
            hScrollBar3.Tag = numericUpDown3;

            numericUpDown1.Tag = hScrollBar1;
            numericUpDown2.Tag = hScrollBar2;
            numericUpDown3.Tag = hScrollBar3;

            numericUpDown1.Value = color.R;
            numericUpDown2.Value = color.G;
            numericUpDown1.Value = color.B;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
        private void UpdateColor()
        {
            colorResult = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
            pictureBox1.BackColor = colorResult;
        }
        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ScrollBar scrollBar = (System.Windows.Forms.ScrollBar)sender;
            NumericUpDown numericUpDown = (NumericUpDown)scrollBar.Tag;
            numericUpDown.Value = scrollBar.Value;
        }

        private void hScrollBar2_ValueChanged_1(object sender, EventArgs e)
        {
            System.Windows.Forms.ScrollBar scrollBar = (System.Windows.Forms.ScrollBar)sender;
            NumericUpDown numericUpDown = (NumericUpDown)scrollBar.Tag;
            numericUpDown.Value = scrollBar.Value;
        }

        private void hScrollBar3_ValueChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ScrollBar scrollBar = (System.Windows.Forms.ScrollBar)sender;
            NumericUpDown numericUpDown = (NumericUpDown)scrollBar.Tag;
            numericUpDown.Value = scrollBar.Value;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            System.Windows.Forms.ScrollBar scrollBar = (System.Windows.Forms.ScrollBar)numericUpDown.Tag;
            scrollBar.Value = (int)numericUpDown.Value;
            UpdateColor();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            System.Windows.Forms.ScrollBar scrollBar = (System.Windows.Forms.ScrollBar)numericUpDown.Tag;
            scrollBar.Value = (int)numericUpDown.Value;
            UpdateColor();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            System.Windows.Forms.ScrollBar scrollBar = (System.Windows.Forms.ScrollBar)numericUpDown.Tag;
            scrollBar.Value = (int)numericUpDown.Value;
            UpdateColor();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                hScrollBar1.Value = colorDialog.Color.R;
                hScrollBar2.Value = colorDialog.Color.G;
                hScrollBar3.Value = colorDialog.Color.B;
                colorResult = colorDialog.Color;
                UpdateColor();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            UpdateColor();
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                main.currentPen.Color = colorResult;
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
