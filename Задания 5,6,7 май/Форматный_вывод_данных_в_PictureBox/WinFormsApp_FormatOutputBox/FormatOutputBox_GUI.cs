using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static WinFormsApp_FormatOutputBox.FormatOutputBox_Handling;

namespace WinFormsApp_FormatOutputBox
{
    interface IFormatOutputBox
    {
        bool Load_Invoking(ref RichTextBox lbox, ref PictureBox picbox);
        bool Run_Executing(int? a, int? b, ref RichTextBox lbox);
    }
    public class FormatOutputBox_GUI
    {
        public enum operations
        {
            None = 0,
            SimpleSum,
            SimpleMult, 
            InLine,
            InColumnSum,
            InColumnMult
        };
        private int _sel_operation = (int)operations.None;
        private PictureBox _picturePreview = null;
        private RichTextBox _consoleExample = null;
        private List<IFormatOutputBox> _operations = new List<IFormatOutputBox>();
        public FormatOutputBox_GUI()
        {
            foreach (operations i in Enum.GetValues(typeof(operations)))
            {
                switch (i)
                {
                    case operations.None:
                        _operations.Add(new FormatOutputBox_Handling.Operation_None());
                        break;
                    case operations.SimpleSum:
                        _operations.Add(new FormatOutputBox_Handling.Operation_SimpleSum());
                        break;
                    case operations.SimpleMult:
                        _operations.Add(new FormatOutputBox_Handling.Operation_SimpleMult());
                        break;
                    case operations.InLine:
                        _operations.Add(new FormatOutputBox_Handling.Operation_InLine());
                        break;
                    case operations.InColumnSum:
                        _operations.Add(new FormatOutputBox_Handling.Operation_InColumnSum());
                        break;
                    case operations.InColumnMult:
                        _operations.Add(new FormatOutputBox_Handling.Operation_InColumnMult());
                        break;
                }
            }
        }
        public bool Invoke_Data(int sel_operation, ref PictureBox picturePreview, ref RichTextBox
        consoleExample)
        {
            _sel_operation = sel_operation;
            _picturePreview = picturePreview;
            _consoleExample = consoleExample;
            Clear_Data();
            _operations[_sel_operation].Load_Invoking(ref _consoleExample, ref _picturePreview);
            return true;
        }
        public bool Execute_Data(int? a, int? b)
        {
            _operations[_sel_operation].Run_Executing(a, b, ref _consoleExample);
            return true;
        }
        public void Clear_Data()
        {
            _consoleExample.Clear();
        }
    }
}
