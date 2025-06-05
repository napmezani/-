using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using WinFormsApp_SaveLoadFragments.WinForms_SaveLoadFragments;


namespace WinFormsApp_SaveLoadFragments
{
    public partial class Form_Main: Form
    {
        private ArrayPictures _arr_pictures;
        public Form_Main()
        {
            InitializeComponent();
            int ind_image = 0;
            Image im_pic;
            byte[] imageBytes = (byte[])Properties.Resources.ResourceManager.GetObject("Task_" + (ind_image + 1).ToString());
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                im_pic = Image.FromStream(ms);
            }
            Bitmap bmp_pic = new Bitmap(im_pic);
            Size size_pic = new Size(pictureBox.Width, pictureBox.Height);
            _arr_pictures = new ArrayPictures(pictureBox, bmp_pic, size_pic, 3, 4);
            AssignPictures();
        }

            private void AssignPictures()
        {
            foreach (PictureBox pic in _arr_pictures.Get_Pictures())
            {
                int index = (int)pic.Tag;
                pic.Click += new EventHandler(fragment_Click);
                pic.Visible = true;
            }
        }
        ///
        private PictureBox firstSelected = null;
        void fragment_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            int index = (int)pic.Tag;
            if (radioButton_Load.Checked)
            {
                Load_Fragment(index);
            }
            else if (radioButton_SaveAs.Checked)
            {
                Save_Fragment(index);
            }
            ///
            else if (radioButton_Swap.Checked)
            {
                Swap_Fragment(ref firstSelected, ref pic);
            }
            else
            {
                Load_New_Picture();
            }
        }
        private void Load_Fragment(int index)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "файлы картинок (*.bmp;*.jpg;*.jpeg;)|*.bmp;*.jpg;.jpeg|All files(*.*) | *.* ";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap pic_show = new Bitmap(openFileDialog.FileName);
                _arr_pictures.Change_Bmp(index, pic_show);
            }
        }
        private void Save_Fragment(int index)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "файлы картинок (*.bmp;*.jpg;*.jpeg;)|*.bmp;*.jpg;.jpeg|All files(*.*) | *.* ";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string str_file = saveFileDialog.FileName;
                PictureBox pic = _arr_pictures[index];
                pic.Image.Save(str_file);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        private void Swap_Fragment(ref PictureBox first, ref PictureBox second)
        {
            if (first == null)
            {
                first = second;
            }
            else
            {
                _arr_pictures.Swap_Bmp((int)first.Tag, (int)second.Tag);
                first = null;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private void Load_New_Picture()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "файлы картинок (*.bmp;*.jpg;*.jpeg;)|*.bmp;*.jpg;.jpeg|All files(*.*) | *.* ";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _arr_pictures.Clean();
                Image pic = new Bitmap(openFileDialog.FileName);
                Bitmap bmp_pic = new Bitmap(pic);
                Size size_pic = new Size(pictureBox.Width, pictureBox.Height);
                _arr_pictures = new ArrayPictures(pictureBox, bmp_pic, size_pic, 3, 4);
                AssignPictures();
            }
        }
        private void Form_Main_SizeChanged(object sender, EventArgs e)
        {
            Size pic_size = new Size(this.Size.Width - 40, this.Size.Height - 100);
            pictureBox.Size = pic_size;
            _arr_pictures.Set_Sizes(pic_size);
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
