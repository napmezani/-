using System;
using System.Globalization;
using System.Resources;
using System.Threading;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;
using MultiLangSupportResources.Resources;

namespace WindowsFormsApp1
{
    public partial class FrmMain: Form
    {
        private ResourceManager resourceManager;
        public FrmMain()
        {
            InitializeComponent();
            resourceManager = new ResourceManager(typeof(FrmMain));
        }
        private void SelectLanguageMenuItem(string selectedCulture)
        {
            foreach (ToolStripMenuItem dropDownItem in
            FileLanguageToolStripMenuItem.DropDownItems)
            {
                if (dropDownItem.Tag is string str && str.Equals(selectedCulture))
                {
                    dropDownItem.Checked = true;
                }
            }
        }
        private void ReloadFormControlsTranslation()
        {
            this.Text = resourceManager.GetString("$this.Text");
            LabelName.Text = resourceManager.GetString("LabelName.Text");
            FileToolStripMenuItem.Text = resourceManager.GetString("FileToolStripMenuItem.Text");
            FileAboutToolStripMenuItem.Text = resourceManager.GetString("FileAboutToolStripMenuItem.Text");
            FileLanguageToolStripMenuItem.Text = resourceManager.GetString("FileLanguageToolStripMenuItem.Text");
            FileLanguageRUToolStripMenuItem.Text = resourceManager.GetString("FileLanguageRUToolStripMenuItem.Text");
            FileLanguageBEToolStripMenuItem.Text = resourceManager.GetString("FileLanguageBEToolStripMenuItem.Text");
            FileLanguageDEToolStripMenuItem.Text = resourceManager.GetString("FileLanguageDEToolStripMenuItem.Text");
            FileLanguageENToolStripMenuItem.Text = resourceManager.GetString("FileLanguageENToolStripMenuItem.Text");
            FileLanguageZHToolStripMenuItem.Text = resourceManager.GetString("FileLanguageZHToolStripMenuItem.Text");
            FileLanguageESToolStripMenuItem.Text = resourceManager.GetString("FileLanguageESToolStripMenuItem.Text");
            FileLanguagePTToolStripMenuItem.Text = resourceManager.GetString("FileLanguagePTToolStripMenuItem.Text");
            FileExitToolStripMenuItem.Text = resourceManager.GetString("FileExitToolStripMenuItem.Text");
            ButtonSayHello.Text = resourceManager.GetString("ButtonSayHello.Text");
            ButtonExit.Text = resourceManager.GetString("ButtonExit.Text");
        }
        public void ChangeCurrentCulture(string selectedCulture, bool saveSettings)
        {
            CultureInfo selectedCultureInfo = CultureInfo.GetCultureInfo(selectedCulture);
            Thread.CurrentThread.CurrentUICulture = selectedCultureInfo;
            Thread.CurrentThread.CurrentCulture = selectedCultureInfo;
            if (saveSettings)
            {
                Settings.Default.LastUsedLanguage = selectedCulture;
                Settings.Default.Save();
            }
            SelectLanguageMenuItem(selectedCulture);
            ReloadFormControlsTranslation();
        }
        private void LoadLastUsedLanguage()
        {
            string lastLanguage = Settings.Default.LastUsedLanguage;
            if (!string.IsNullOrEmpty(lastLanguage))
            {
                if (lastLanguage.StartsWith("ru"))
                    ChangeCurrentCulture("ru", false);
                else if (lastLanguage.StartsWith("be"))
                    ChangeCurrentCulture("be", false);
                else if (lastLanguage.StartsWith("de"))
                    ChangeCurrentCulture("de", false);
                else if (lastLanguage.StartsWith("en"))
                    ChangeCurrentCulture("en", false);
                else if (lastLanguage.StartsWith("zh"))
                    ChangeCurrentCulture("zh", false);
                else if (lastLanguage.StartsWith("es"))
                    ChangeCurrentCulture("es", false);
                else if (lastLanguage.StartsWith("pt"))
                    ChangeCurrentCulture("pt", false);
                else
                    ChangeCurrentCulture("ru", false);
            }
            else
                ChangeCurrentCulture("ru", false);
        }
        private void SwitchLanguage(object sender)
        {
            foreach (ToolStripMenuItem dropDownItem in FileLanguageToolStripMenuItem.DropDownItems)
            {
                dropDownItem.Checked = false;
            }
            if (sender is ToolStripMenuItem clickedMenuItem)
            {
                clickedMenuItem.Checked = true;
                ChangeCurrentCulture(clickedMenuItem.Tag.ToString(), true);
            }
        }
        private void ExitApp()
        {
            DialogResult dlgResult = MessageBox.Show(
            MultiLangSupportExampleI18N.AreYouSureYouWantToExit,
            MultiLangSupportExampleI18N.ExitAppTitle,
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question
            );
            if (dlgResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadLastUsedLanguage();
        }

        private void ButtonSayHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show( MultiLangSupportExampleI18N.Greeting + " " + TextBoxName.Text, MultiLangSupportExampleI18N.Greeting + " " + TextBoxName.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            ExitApp();
        }

        private void FileLanguageRUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchLanguage(sender);
        }

        private void FileLanguageBEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchLanguage(sender);
        }

        private void FileLanguageDEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchLanguage(sender);
        }

        private void FileLanguageENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchLanguage(sender);
        }

        private void FileLanguageZHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchLanguage(sender);
        }

        private void FileLanguageESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchLanguage(sender);
        }

        private void FileLanguagePTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchLanguage(sender);
        }
    }
}
