namespace WindowsFormsApp1
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ToolStripContainerMain = new System.Windows.Forms.ToolStripContainer();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ButtonSayHello = new System.Windows.Forms.Button();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileAboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileLanguageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileLanguageRUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileLanguageBEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileLanguageDEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileLanguageENToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileLanguageZHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileLanguageESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileLanguagePTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripContainerMain.ContentPanel.SuspendLayout();
            this.ToolStripContainerMain.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStripContainerMain
            // 
            resources.ApplyResources(this.ToolStripContainerMain, "ToolStripContainerMain");
            // 
            // ToolStripContainerMain.BottomToolStripPanel
            // 
            resources.ApplyResources(this.ToolStripContainerMain.BottomToolStripPanel, "ToolStripContainerMain.BottomToolStripPanel");
            // 
            // ToolStripContainerMain.ContentPanel
            // 
            resources.ApplyResources(this.ToolStripContainerMain.ContentPanel, "ToolStripContainerMain.ContentPanel");
            this.ToolStripContainerMain.ContentPanel.Controls.Add(this.ButtonExit);
            this.ToolStripContainerMain.ContentPanel.Controls.Add(this.ButtonSayHello);
            this.ToolStripContainerMain.ContentPanel.Controls.Add(this.TextBoxName);
            this.ToolStripContainerMain.ContentPanel.Controls.Add(this.LabelName);
            this.ToolStripContainerMain.ContentPanel.Controls.Add(this.menuStrip1);
            // 
            // ToolStripContainerMain.LeftToolStripPanel
            // 
            resources.ApplyResources(this.ToolStripContainerMain.LeftToolStripPanel, "ToolStripContainerMain.LeftToolStripPanel");
            this.ToolStripContainerMain.Name = "ToolStripContainerMain";
            // 
            // ToolStripContainerMain.RightToolStripPanel
            // 
            resources.ApplyResources(this.ToolStripContainerMain.RightToolStripPanel, "ToolStripContainerMain.RightToolStripPanel");
            // 
            // ToolStripContainerMain.TopToolStripPanel
            // 
            resources.ApplyResources(this.ToolStripContainerMain.TopToolStripPanel, "ToolStripContainerMain.TopToolStripPanel");
            // 
            // ButtonExit
            // 
            resources.ApplyResources(this.ButtonExit, "ButtonExit");
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // ButtonSayHello
            // 
            resources.ApplyResources(this.ButtonSayHello, "ButtonSayHello");
            this.ButtonSayHello.Name = "ButtonSayHello";
            this.ButtonSayHello.UseVisualStyleBackColor = true;
            this.ButtonSayHello.Click += new System.EventHandler(this.ButtonSayHello_Click);
            // 
            // TextBoxName
            // 
            resources.ApplyResources(this.TextBoxName, "TextBoxName");
            this.TextBoxName.Name = "TextBoxName";
            // 
            // LabelName
            // 
            resources.ApplyResources(this.LabelName, "LabelName");
            this.LabelName.Name = "LabelName";
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            resources.ApplyResources(this.FileToolStripMenuItem, "FileToolStripMenuItem");
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileAboutToolStripMenuItem,
            this.FileLanguageToolStripMenuItem,
            this.FileExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            // 
            // FileAboutToolStripMenuItem
            // 
            resources.ApplyResources(this.FileAboutToolStripMenuItem, "FileAboutToolStripMenuItem");
            this.FileAboutToolStripMenuItem.Name = "FileAboutToolStripMenuItem";
            // 
            // FileLanguageToolStripMenuItem
            // 
            resources.ApplyResources(this.FileLanguageToolStripMenuItem, "FileLanguageToolStripMenuItem");
            this.FileLanguageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileLanguageRUToolStripMenuItem,
            this.FileLanguageBEToolStripMenuItem,
            this.FileLanguageDEToolStripMenuItem,
            this.FileLanguageENToolStripMenuItem,
            this.FileLanguageZHToolStripMenuItem,
            this.FileLanguageESToolStripMenuItem,
            this.FileLanguagePTToolStripMenuItem});
            this.FileLanguageToolStripMenuItem.Name = "FileLanguageToolStripMenuItem";
            // 
            // FileLanguageRUToolStripMenuItem
            // 
            resources.ApplyResources(this.FileLanguageRUToolStripMenuItem, "FileLanguageRUToolStripMenuItem");
            this.FileLanguageRUToolStripMenuItem.Name = "FileLanguageRUToolStripMenuItem";
            this.FileLanguageRUToolStripMenuItem.Tag = "ru";
            this.FileLanguageRUToolStripMenuItem.Click += new System.EventHandler(this.FileLanguageRUToolStripMenuItem_Click);
            // 
            // FileLanguageBEToolStripMenuItem
            // 
            resources.ApplyResources(this.FileLanguageBEToolStripMenuItem, "FileLanguageBEToolStripMenuItem");
            this.FileLanguageBEToolStripMenuItem.Name = "FileLanguageBEToolStripMenuItem";
            this.FileLanguageBEToolStripMenuItem.Tag = "be";
            this.FileLanguageBEToolStripMenuItem.Click += new System.EventHandler(this.FileLanguageBEToolStripMenuItem_Click);
            // 
            // FileLanguageDEToolStripMenuItem
            // 
            resources.ApplyResources(this.FileLanguageDEToolStripMenuItem, "FileLanguageDEToolStripMenuItem");
            this.FileLanguageDEToolStripMenuItem.Name = "FileLanguageDEToolStripMenuItem";
            this.FileLanguageDEToolStripMenuItem.Tag = "de";
            this.FileLanguageDEToolStripMenuItem.Click += new System.EventHandler(this.FileLanguageDEToolStripMenuItem_Click);
            // 
            // FileLanguageENToolStripMenuItem
            // 
            resources.ApplyResources(this.FileLanguageENToolStripMenuItem, "FileLanguageENToolStripMenuItem");
            this.FileLanguageENToolStripMenuItem.Name = "FileLanguageENToolStripMenuItem";
            this.FileLanguageENToolStripMenuItem.Tag = "en";
            this.FileLanguageENToolStripMenuItem.Click += new System.EventHandler(this.FileLanguageENToolStripMenuItem_Click);
            // 
            // FileLanguageZHToolStripMenuItem
            // 
            resources.ApplyResources(this.FileLanguageZHToolStripMenuItem, "FileLanguageZHToolStripMenuItem");
            this.FileLanguageZHToolStripMenuItem.Name = "FileLanguageZHToolStripMenuItem";
            this.FileLanguageZHToolStripMenuItem.Tag = "zh";
            this.FileLanguageZHToolStripMenuItem.Click += new System.EventHandler(this.FileLanguageZHToolStripMenuItem_Click);
            // 
            // FileLanguageESToolStripMenuItem
            // 
            resources.ApplyResources(this.FileLanguageESToolStripMenuItem, "FileLanguageESToolStripMenuItem");
            this.FileLanguageESToolStripMenuItem.Name = "FileLanguageESToolStripMenuItem";
            this.FileLanguageESToolStripMenuItem.Tag = "es";
            this.FileLanguageESToolStripMenuItem.Click += new System.EventHandler(this.FileLanguageESToolStripMenuItem_Click);
            // 
            // FileLanguagePTToolStripMenuItem
            // 
            resources.ApplyResources(this.FileLanguagePTToolStripMenuItem, "FileLanguagePTToolStripMenuItem");
            this.FileLanguagePTToolStripMenuItem.Name = "FileLanguagePTToolStripMenuItem";
            this.FileLanguagePTToolStripMenuItem.Tag = "pt";
            this.FileLanguagePTToolStripMenuItem.Click += new System.EventHandler(this.FileLanguagePTToolStripMenuItem_Click);
            // 
            // FileExitToolStripMenuItem
            // 
            resources.ApplyResources(this.FileExitToolStripMenuItem, "FileExitToolStripMenuItem");
            this.FileExitToolStripMenuItem.Name = "FileExitToolStripMenuItem";
            // 
            // FrmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ToolStripContainerMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ToolStripContainerMain.ContentPanel.ResumeLayout(false);
            this.ToolStripContainerMain.ContentPanel.PerformLayout();
            this.ToolStripContainerMain.ResumeLayout(false);
            this.ToolStripContainerMain.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer ToolStripContainerMain;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Button ButtonSayHello;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileAboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileLanguageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileLanguageRUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileLanguageBEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileLanguageDEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileLanguageENToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileLanguageZHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileLanguageESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileLanguagePTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileExitToolStripMenuItem;
    }
}

