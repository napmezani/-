using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp_FormatOutputBox
{
    class FormatOutputBox_Handling
    {
        public class Operation_None : IFormatOutputBox
        {
            public bool Load_Invoking(ref RichTextBox consoleOut, ref PictureBox pic)
            {
                string str_class_name = this.GetType().Name;
                byte[] imageBytes = (byte[])Properties.Resources.ResourceManager.GetObject(str_class_name);
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    pic.Image = Image.FromStream(ms);
                }
                consoleOut.AppendText("Инициализировано действие \"0\".");
                return true;
            }
            public bool Run_Executing(int? a, int? b, ref RichTextBox consoleOut)
            {
                string str = String.Format("\nВыполнение действия \"0\"");
                return true;
            }
        }
        public class Operation_SimpleSum : IFormatOutputBox
        {
            public bool Load_Invoking(ref RichTextBox consoleOut, ref PictureBox pic)
            {
                string str_class_name = this.GetType().Name;
                byte[] imageBytes = (byte[])Properties.Resources.ResourceManager.GetObject(str_class_name);
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    pic.Image = Image.FromStream(ms);
                }
                consoleOut.AppendText("Инициализировано действие \"1\"!");
                return true;
            }
            public bool Run_Executing(int? a, int? b, ref RichTextBox consoleOut)
            {
                string str = String.Format("\nВыполнение действия \"1\":\n{0} + {1} = {2}", a, b, a + b);
                consoleOut.AppendText(str);
                return true;
            }
        }
        public class Operation_SimpleMult : IFormatOutputBox
        {
            public bool Load_Invoking(ref RichTextBox consoleOut, ref PictureBox pic)
            {
                string str_class_name = this.GetType().Name;
                byte[] imageBytes = (byte[])Properties.Resources.ResourceManager.GetObject(str_class_name);
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    pic.Image = Image.FromStream(ms);
                }
                consoleOut.AppendText("Инициализировано действие \"2\"!");
                return true;
            }
            public bool Run_Executing(int? a, int? b, ref RichTextBox consoleOut)
            {
                string str = String.Format("\nВыполнение действия \"2\":\n{0} * {1} = {2}", a, b, a * b);
                consoleOut.AppendText(str);
                return true;
            }
        }
        public class Operation_InLine : IFormatOutputBox
        {
            public bool Load_Invoking(ref RichTextBox consoleOut, ref PictureBox pic)
            {
                string str_class_name = this.GetType().Name;
                byte[] imageBytes = (byte[])Properties.Resources.ResourceManager.GetObject(str_class_name);
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    pic.Image = Image.FromStream(ms);
                }
                consoleOut.AppendText("Инициализировано действие \"3\"!");
                return true;
            }
            public bool Run_Executing(int? a, int? b, ref RichTextBox consoleOut)
            {
                string str = String.Format("\nВыполнение действия \"3\":\n{0}^2 + {1}^2 = {2}", a, b, -(a * a * a * a) - (b * b * b));
                consoleOut.AppendText(str);
                return true;
            }
        }
        public class Operation_InColumnSum : IFormatOutputBox
        {
            public bool Load_Invoking(ref RichTextBox consoleOut, ref PictureBox pic)
            {
                string str_class_name = this.GetType().Name;
                byte[] imageBytes = (byte[])Properties.Resources.ResourceManager.GetObject(str_class_name);
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    pic.Image = Image.FromStream(ms);
                }
                consoleOut.AppendText("Инициализировано действие \"4\"!\n");
                consoleOut.AppendText("Выберите a в промежутке от 0 до 12 и b от -14 (вкл.) до 0 (вкл.)!");
                return true;
            }
            public bool Run_Executing(int? a, int? b, ref RichTextBox consoleOut)
            {
                string str = String.Format("\nВыполнение действия \"4\":\n {0, 4}\n+{1, 4}\n {2, 4}", a, b, a + b);
                consoleOut.AppendText(str);
                return true;
            }
        }
        public class Operation_InColumnMult : IFormatOutputBox
        {
            public bool Load_Invoking(ref RichTextBox consoleOut, ref PictureBox pic)
            {
                string str_class_name = this.GetType().Name;
                byte[] imageBytes = (byte[])Properties.Resources.ResourceManager.GetObject(str_class_name);
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    pic.Image = Image.FromStream(ms);
                }
                consoleOut.AppendText("Инициализировано действие \"5\"!\n");
                consoleOut.AppendText("Выберите a в промежутке от 0 до 12 и b от -14 (вкл.) до 0 (вкл.)!");
                return true;
            }
            public bool Run_Executing(int? a, int? b, ref RichTextBox consoleOut)
            {
                string str = String.Format("\nВыполнение действия \"5\":\n{0,4}\n*{1,4}\n{2,4}", a, b, a * b);
                consoleOut.AppendText(str);
                return true;
            }
        }
    }
}
