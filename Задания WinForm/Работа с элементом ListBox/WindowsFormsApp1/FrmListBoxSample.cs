using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmListBoxSample: Form
    {
        public FrmListBoxSample()
        {
            InitializeComponent();
        }

        private void FrmListBoxSample_Load(object sender, EventArgs e)
        {
            ListBoxElements.Items.Add("Первый элемент списка");
            ListBoxElements.Items.Add("Второй элемент списка");
            ListBoxElements.Items.Add("Третий элемент списка");
            ListBoxElements.Items.Add("Другой элемент списка");
            ListBoxElements.Items.Add("Какой-то ещё элемент списка");
            UpdateSelectedElementInfo();
            ClearTextBox();
            EnableDisableButtonAddElement();
        }
        private void UpdateSelectedElementInfo()
        {
            if (ListBoxElements.SelectedIndex == -1)
            {
                LabelInfoSelectedElementContents.Text = "Не выбран ни один элемент списка";
            return;
            }
            string selectedItem = (string)ListBoxElements.SelectedItem;
            LabelInfoSelectedElementContents.Text = "Выбран элемент списка: " + selectedItem;
        }

        private void ListBoxElements_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSelectedElementInfo();
            EnableDisableButtonRemoveSelectedElement();
        }
        private void EnableDisableButtonAddElement()
        {
            ButtonAddElement.Enabled = TextBoxNewElement.Text != "" &&
            TextBoxNewElement.ForeColor != Color.LightGray;
        }
        private void EnableDisableButtonRemoveSelectedElement()
        {
            ButtonRemoveSelectedElement.Enabled = ListBoxElements.Items.Count >
            0 && ListBoxElements.SelectedItem != null;
        }
        private void EnableDisableButtonClearList()
        {
            ButtonClearList.Enabled = ListBoxElements.Items.Count > 0;
        }
        private void AddLogRecord(string logMessage)
        {
            TextBoxEvents.Text += logMessage + "\r\n";
        }
        private void ClearTextBox()
        {
            TextBoxNewElement.ForeColor = Color.LightGray;
            TextBoxNewElement.Text = "< Введите текст для элемента списка... >";
        }

        private void TextBoxNewElement_Enter(object sender, EventArgs e)
        {
            if (TextBoxNewElement.ForeColor == Color.LightGray)
            {
                TextBoxNewElement.Text = "";
                TextBoxNewElement.ForeColor = SystemColors.WindowText;
            }
        }

        private void TextBoxNewElement_Leave(object sender, EventArgs e)
        {
            if (TextBoxNewElement.Text == "")
                ClearTextBox();
        }

        private void TextBoxNewElement_TextChanged(object sender, EventArgs e)
        {
            EnableDisableButtonAddElement();
        }

        private void ButtonAddElement_Click(object sender, EventArgs e)
        {
            string newListElement = TextBoxNewElement.Text;
            AddLogRecord("Добавлен новый элемент в список: " + newListElement);
            ListBoxElements.Items.Add(newListElement);
            ClearTextBox();
            EnableDisableButtonRemoveSelectedElement();
            EnableDisableButtonClearList();
        }

        private void ButtonRemoveSelectedElement_Click(object sender, EventArgs e)
        {
            if (ListBoxElements.SelectedItem != null)
            {
                AddLogRecord("Удалён элемент списка: " + ListBoxElements.SelectedItem);
                ListBoxElements.Items.Remove(ListBoxElements.SelectedItem);
            }
            EnableDisableButtonRemoveSelectedElement();
            EnableDisableButtonClearList();
        }

        private void ButtonClearList_Click(object sender, EventArgs e)
        {
            ListBoxElements.Items.Clear();
            EnableDisableButtonClearList();
            EnableDisableButtonRemoveSelectedElement();
            AddLogRecord("Список полностью очищен");
        }

        private void ListBoxElements_MouseClick(object sender, MouseEventArgs e)
        {
            AddLogRecord("[MouseClick] Клик мышью: Кнопка = " + e.Button + ", Кликов = " + e.Clicks + ", Положение = " + e.Location);
        }

        private void ButtonClearLog_Click(object sender, EventArgs e)
        {
            TextBoxEvents.Text = "";
        }
    }
}
