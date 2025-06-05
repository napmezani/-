namespace test
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_XY = new System.Windows.Forms.Label();
            this.trackBarPen = new System.Windows.Forms.TrackBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picDrawingSurface = new System.Windows.Forms.PictureBox();
            this.newButton = new System.Windows.Forms.ToolStripButton();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.openButton = new System.Windows.Forms.ToolStripButton();
            this.penButton = new System.Windows.Forms.ToolStripButton();
            this.exitButton = new System.Windows.Forms.ToolStripButton();
            this.newMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.undoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.renoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.penMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.styleMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.solidStyleMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.dotStyleMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.dashDotDotStyleMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.colorMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPen)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDrawingSurface)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.helpMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMenu,
            this.openMenu,
            this.saveMenu,
            this.toolStripSeparator1,
            this.exitMenu});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "File";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoMenu,
            this.renoMenu,
            this.penMenu});
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(39, 20);
            this.editMenu.Text = "Edit";
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenu});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(44, 20);
            this.helpMenu.Text = "Help";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newButton,
            this.saveButton,
            this.openButton,
            this.penButton,
            this.toolStripSeparator2,
            this.exitButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(24, 426);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(29, 6);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_XY);
            this.panel1.Controls.Add(this.trackBarPen);
            this.panel1.Location = new System.Drawing.Point(33, 389);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 49);
            this.panel1.TabIndex = 3;
            // 
            // label_XY
            // 
            this.label_XY.AutoSize = true;
            this.label_XY.Location = new System.Drawing.Point(3, 17);
            this.label_XY.Name = "label_XY";
            this.label_XY.Size = new System.Drawing.Size(25, 13);
            this.label_XY.TabIndex = 1;
            this.label_XY.Text = "0, 0";
            // 
            // trackBarPen
            // 
            this.trackBarPen.Location = new System.Drawing.Point(389, 3);
            this.trackBarPen.Maximum = 20;
            this.trackBarPen.Minimum = 1;
            this.trackBarPen.Name = "trackBarPen";
            this.trackBarPen.Size = new System.Drawing.Size(263, 45);
            this.trackBarPen.TabIndex = 0;
            this.trackBarPen.Value = 5;
            this.trackBarPen.Scroll += new System.EventHandler(this.trackBarPen_Scroll);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.picDrawingSurface);
            this.panel2.Location = new System.Drawing.Point(33, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(767, 359);
            this.panel2.TabIndex = 2;
            // 
            // picDrawingSurface
            // 
            this.picDrawingSurface.BackColor = System.Drawing.Color.White;
            this.picDrawingSurface.Location = new System.Drawing.Point(0, 0);
            this.picDrawingSurface.Name = "picDrawingSurface";
            this.picDrawingSurface.Size = new System.Drawing.Size(740, 359);
            this.picDrawingSurface.TabIndex = 1;
            this.picDrawingSurface.TabStop = false;
            this.picDrawingSurface.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picDrawingSurface_MouseDown);
            this.picDrawingSurface.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picDrawingSurface_MouseMove);
            this.picDrawingSurface.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picDrawingSurface_MouseUp);
            // 
            // newButton
            // 
            this.newButton.Image = ((System.Drawing.Image)(resources.GetObject("newButton.Image")));
            this.newButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(21, 20);
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveButton.Image = global::test.Properties.Resources.LaST__Cobalt__Floppy;
            this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(29, 20);
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // openButton
            // 
            this.openButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openButton.Image = ((System.Drawing.Image)(resources.GetObject("openButton.Image")));
            this.openButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(29, 20);
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // penButton
            // 
            this.penButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.penButton.Image = global::test.Properties.Resources.pencil;
            this.penButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.penButton.Name = "penButton";
            this.penButton.Size = new System.Drawing.Size(29, 20);
            this.penButton.Click += new System.EventHandler(this.penButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exitButton.Image = global::test.Properties.Resources.exit;
            this.exitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(29, 20);
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // newMenu
            // 
            this.newMenu.Image = global::test.Properties.Resources.edit_add;
            this.newMenu.Name = "newMenu";
            this.newMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newMenu.Size = new System.Drawing.Size(180, 22);
            this.newMenu.Text = "New";
            this.newMenu.Click += new System.EventHandler(this.newMenu_Click);
            // 
            // openMenu
            // 
            this.openMenu.Image = global::test.Properties.Resources._7;
            this.openMenu.Name = "openMenu";
            this.openMenu.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.openMenu.Size = new System.Drawing.Size(180, 22);
            this.openMenu.Text = "Open";
            this.openMenu.Click += new System.EventHandler(this.openMenu_Click);
            // 
            // saveMenu
            // 
            this.saveMenu.Image = global::test.Properties.Resources.LaST__Cobalt__Floppy;
            this.saveMenu.Name = "saveMenu";
            this.saveMenu.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.saveMenu.Size = new System.Drawing.Size(180, 22);
            this.saveMenu.Text = "Save";
            this.saveMenu.Click += new System.EventHandler(this.saveMenu_Click);
            // 
            // exitMenu
            // 
            this.exitMenu.Image = global::test.Properties.Resources.exit;
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitMenu.Size = new System.Drawing.Size(180, 22);
            this.exitMenu.Text = "Exit";
            this.exitMenu.Click += new System.EventHandler(this.exitMenu_Click);
            // 
            // undoMenu
            // 
            this.undoMenu.Image = global::test.Properties.Resources._1leftarrow;
            this.undoMenu.Name = "undoMenu";
            this.undoMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoMenu.Size = new System.Drawing.Size(174, 22);
            this.undoMenu.Text = "Undo";
            this.undoMenu.Click += new System.EventHandler(this.undoMenu_Click);
            // 
            // renoMenu
            // 
            this.renoMenu.Image = global::test.Properties.Resources._1rightarrow;
            this.renoMenu.Name = "renoMenu";
            this.renoMenu.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.renoMenu.Size = new System.Drawing.Size(174, 22);
            this.renoMenu.Text = "Reno";
            this.renoMenu.Click += new System.EventHandler(this.renoMenu_Click);
            // 
            // penMenu
            // 
            this.penMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.styleMenu,
            this.colorMenu});
            this.penMenu.Image = global::test.Properties.Resources.pencil;
            this.penMenu.Name = "penMenu";
            this.penMenu.Size = new System.Drawing.Size(174, 22);
            this.penMenu.Text = "Pen";
            // 
            // styleMenu
            // 
            this.styleMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solidStyleMenu,
            this.dotStyleMenu,
            this.dashDotDotStyleMenu});
            this.styleMenu.Name = "styleMenu";
            this.styleMenu.Size = new System.Drawing.Size(103, 22);
            this.styleMenu.Text = "Style";
            // 
            // solidStyleMenu
            // 
            this.solidStyleMenu.Checked = true;
            this.solidStyleMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.solidStyleMenu.Name = "solidStyleMenu";
            this.solidStyleMenu.Size = new System.Drawing.Size(138, 22);
            this.solidStyleMenu.Text = "Solid";
            this.solidStyleMenu.Click += new System.EventHandler(this.solidStyleMenu_Click);
            // 
            // dotStyleMenu
            // 
            this.dotStyleMenu.Name = "dotStyleMenu";
            this.dotStyleMenu.Size = new System.Drawing.Size(138, 22);
            this.dotStyleMenu.Text = "Dot";
            this.dotStyleMenu.Click += new System.EventHandler(this.dotStyleMenu_Click);
            // 
            // dashDotDotStyleMenu
            // 
            this.dashDotDotStyleMenu.Name = "dashDotDotStyleMenu";
            this.dashDotDotStyleMenu.Size = new System.Drawing.Size(138, 22);
            this.dashDotDotStyleMenu.Text = "DashDotDot";
            this.dashDotDotStyleMenu.Click += new System.EventHandler(this.dashDotDotStyleMenu_Click);
            // 
            // colorMenu
            // 
            this.colorMenu.Name = "colorMenu";
            this.colorMenu.Size = new System.Drawing.Size(103, 22);
            this.colorMenu.Text = "Color";
            // 
            // aboutMenu
            // 
            this.aboutMenu.Image = global::test.Properties.Resources.SAVED_FILES;
            this.aboutMenu.Name = "aboutMenu";
            this.aboutMenu.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutMenu.Size = new System.Drawing.Size(126, 22);
            this.aboutMenu.Text = "About";
            this.aboutMenu.Click += new System.EventHandler(this.aboutMenu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Paint Lite";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPen)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDrawingSurface)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox picDrawingSurface;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar trackBarPen;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem newMenu;
        private System.Windows.Forms.ToolStripMenuItem openMenu;
        private System.Windows.Forms.ToolStripMenuItem saveMenu;
        private System.Windows.Forms.ToolStripMenuItem exitMenu;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem undoMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem renoMenu;
        private System.Windows.Forms.ToolStripMenuItem penMenu;
        private System.Windows.Forms.ToolStripMenuItem colorMenu;
        private System.Windows.Forms.ToolStripMenuItem styleMenu;
        private System.Windows.Forms.ToolStripMenuItem solidStyleMenu;
        private System.Windows.Forms.ToolStripMenuItem dotStyleMenu;
        private System.Windows.Forms.ToolStripMenuItem dashDotDotStyleMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton newButton;
        private System.Windows.Forms.ToolStripButton saveButton;
        private System.Windows.Forms.ToolStripButton openButton;
        private System.Windows.Forms.ToolStripButton penButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton exitButton;
        private System.Windows.Forms.Label label_XY;
        private System.Windows.Forms.Panel panel2;
    }
}

