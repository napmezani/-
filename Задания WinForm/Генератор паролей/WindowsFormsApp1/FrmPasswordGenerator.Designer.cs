namespace WindowsFormsApp1
{
    partial class FrmPasswordGenerator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPasswordGenerator));
            this.GroupBoxGenerationParams = new System.Windows.Forms.GroupBox();
            this.CheckBoxUseSpecialSymbols = new System.Windows.Forms.CheckBox();
            this.CheckBoxUseDigits = new System.Windows.Forms.CheckBox();
            this.CheckBoxUseLowercaseLetters = new System.Windows.Forms.CheckBox();
            this.CheckBoxUseUppercaseLetters = new System.Windows.Forms.CheckBox();
            this.TrackBarPasswordLength = new System.Windows.Forms.TrackBar();
            this.LabelPasswordLength = new System.Windows.Forms.Label();
            this.LabelPasswordLengthValue = new System.Windows.Forms.Label();
            this.ButtonGeneratePassword = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ButtonClearPassword = new System.Windows.Forms.Button();
            this.LabelGeneratedPassword = new System.Windows.Forms.Label();
            this.LabelPasswordCopiedToClipboard = new System.Windows.Forms.Label();
            this.LabelWarningMessageTitle = new System.Windows.Forms.Label();
            this.LabelWarningMessage = new System.Windows.Forms.Label();
            this.TextBoxGeneratedPassword = new System.Windows.Forms.TextBox();
            this.TimerShowLabelCopiedToClipboard = new System.Windows.Forms.Timer(this.components);
            this.ImageListDefault = new System.Windows.Forms.ImageList(this.components);
            this.ToolTipForControl = new System.Windows.Forms.ToolTip(this.components);
            this.GroupBoxGenerationParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarPasswordLength)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBoxGenerationParams
            // 
            this.GroupBoxGenerationParams.Controls.Add(this.LabelPasswordLengthValue);
            this.GroupBoxGenerationParams.Controls.Add(this.LabelPasswordLength);
            this.GroupBoxGenerationParams.Controls.Add(this.TrackBarPasswordLength);
            this.GroupBoxGenerationParams.Controls.Add(this.CheckBoxUseUppercaseLetters);
            this.GroupBoxGenerationParams.Controls.Add(this.CheckBoxUseLowercaseLetters);
            this.GroupBoxGenerationParams.Controls.Add(this.CheckBoxUseDigits);
            this.GroupBoxGenerationParams.Controls.Add(this.CheckBoxUseSpecialSymbols);
            this.GroupBoxGenerationParams.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxGenerationParams.Name = "GroupBoxGenerationParams";
            this.GroupBoxGenerationParams.Size = new System.Drawing.Size(560, 171);
            this.GroupBoxGenerationParams.TabIndex = 0;
            this.GroupBoxGenerationParams.TabStop = false;
            this.GroupBoxGenerationParams.Text = "Параметры генерации пароля:";
            // 
            // CheckBoxUseSpecialSymbols
            // 
            this.CheckBoxUseSpecialSymbols.AutoSize = true;
            this.CheckBoxUseSpecialSymbols.Location = new System.Drawing.Point(9, 20);
            this.CheckBoxUseSpecialSymbols.Name = "CheckBoxUseSpecialSymbols";
            this.CheckBoxUseSpecialSymbols.Size = new System.Drawing.Size(289, 17);
            this.CheckBoxUseSpecialSymbols.TabIndex = 0;
            this.CheckBoxUseSpecialSymbols.Text = "Использовать специальные символы: # ! $ ; _ ? && ^";
            this.CheckBoxUseSpecialSymbols.UseVisualStyleBackColor = true;
            this.CheckBoxUseSpecialSymbols.CheckedChanged += new System.EventHandler(this.CheckBoxUseSpecialSymbols_CheckedChanged);
            // 
            // CheckBoxUseDigits
            // 
            this.CheckBoxUseDigits.AutoSize = true;
            this.CheckBoxUseDigits.Location = new System.Drawing.Point(9, 43);
            this.CheckBoxUseDigits.Name = "CheckBoxUseDigits";
            this.CheckBoxUseDigits.Size = new System.Drawing.Size(163, 17);
            this.CheckBoxUseDigits.TabIndex = 1;
            this.CheckBoxUseDigits.Text = "Использовать цифры: 0 - 9";
            this.CheckBoxUseDigits.UseVisualStyleBackColor = true;
            this.CheckBoxUseDigits.CheckedChanged += new System.EventHandler(this.CheckBoxUseDigits_CheckedChanged);
            // 
            // CheckBoxUseLowercaseLetters
            // 
            this.CheckBoxUseLowercaseLetters.AutoSize = true;
            this.CheckBoxUseLowercaseLetters.Location = new System.Drawing.Point(9, 66);
            this.CheckBoxUseLowercaseLetters.Name = "CheckBoxUseLowercaseLetters";
            this.CheckBoxUseLowercaseLetters.Size = new System.Drawing.Size(266, 17);
            this.CheckBoxUseLowercaseLetters.TabIndex = 2;
            this.CheckBoxUseLowercaseLetters.Text = "Использовать строчные латинские буквы: a - z";
            this.CheckBoxUseLowercaseLetters.UseVisualStyleBackColor = true;
            this.CheckBoxUseLowercaseLetters.CheckedChanged += new System.EventHandler(this.CheckBoxUseLowercaseLetters_CheckedChanged);
            // 
            // CheckBoxUseUppercaseLetters
            // 
            this.CheckBoxUseUppercaseLetters.AutoSize = true;
            this.CheckBoxUseUppercaseLetters.Location = new System.Drawing.Point(9, 89);
            this.CheckBoxUseUppercaseLetters.Name = "CheckBoxUseUppercaseLetters";
            this.CheckBoxUseUppercaseLetters.Size = new System.Drawing.Size(277, 17);
            this.CheckBoxUseUppercaseLetters.TabIndex = 3;
            this.CheckBoxUseUppercaseLetters.Text = "Использовать прописные латинские буквы: A - Z";
            this.CheckBoxUseUppercaseLetters.UseVisualStyleBackColor = true;
            this.CheckBoxUseUppercaseLetters.CheckedChanged += new System.EventHandler(this.CheckBoxUseUppercaseLetters_CheckedChanged);
            // 
            // TrackBarPasswordLength
            // 
            this.TrackBarPasswordLength.Location = new System.Drawing.Point(184, 112);
            this.TrackBarPasswordLength.Maximum = 30;
            this.TrackBarPasswordLength.Minimum = 5;
            this.TrackBarPasswordLength.Name = "TrackBarPasswordLength";
            this.TrackBarPasswordLength.Size = new System.Drawing.Size(368, 45);
            this.TrackBarPasswordLength.TabIndex = 4;
            this.TrackBarPasswordLength.Value = 5;
            this.TrackBarPasswordLength.ValueChanged += new System.EventHandler(this.TrackBarPasswordLength_ValueChanged);
            // 
            // LabelPasswordLength
            // 
            this.LabelPasswordLength.AutoSize = true;
            this.LabelPasswordLength.Location = new System.Drawing.Point(6, 118);
            this.LabelPasswordLength.Name = "LabelPasswordLength";
            this.LabelPasswordLength.Size = new System.Drawing.Size(141, 13);
            this.LabelPasswordLength.TabIndex = 5;
            this.LabelPasswordLength.Text = "Длина пароля (символов):";
            // 
            // LabelPasswordLengthValue
            // 
            this.LabelPasswordLengthValue.AutoSize = true;
            this.LabelPasswordLengthValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.LabelPasswordLengthValue.Location = new System.Drawing.Point(143, 118);
            this.LabelPasswordLengthValue.Name = "LabelPasswordLengthValue";
            this.LabelPasswordLengthValue.Size = new System.Drawing.Size(23, 13);
            this.LabelPasswordLengthValue.TabIndex = 6;
            this.LabelPasswordLengthValue.Text = "##";
            // 
            // ButtonGeneratePassword
            // 
            this.ButtonGeneratePassword.Location = new System.Drawing.Point(12, 199);
            this.ButtonGeneratePassword.Name = "ButtonGeneratePassword";
            this.ButtonGeneratePassword.Size = new System.Drawing.Size(138, 23);
            this.ButtonGeneratePassword.TabIndex = 7;
            this.ButtonGeneratePassword.Text = "&Сгенерировать пароль";
            this.ToolTipForControl.SetToolTip(this.ButtonGeneratePassword, "Сгенерировать надёжный пароль");
            this.ButtonGeneratePassword.UseVisualStyleBackColor = true;
            this.ButtonGeneratePassword.Click += new System.EventHandler(this.ButtonGeneratePassword_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonExit.Location = new System.Drawing.Point(461, 269);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(111, 23);
            this.ButtonExit.TabIndex = 8;
            this.ButtonExit.Text = "&Выход";
            this.ToolTipForControl.SetToolTip(this.ButtonExit, "Выйти из программы");
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // ButtonClearPassword
            // 
            this.ButtonClearPassword.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ButtonClearPassword.ImageIndex = 0;
            this.ButtonClearPassword.ImageList = this.ImageListDefault;
            this.ButtonClearPassword.Location = new System.Drawing.Point(539, 194);
            this.ButtonClearPassword.Name = "ButtonClearPassword";
            this.ButtonClearPassword.Size = new System.Drawing.Size(33, 33);
            this.ButtonClearPassword.TabIndex = 9;
            this.ToolTipForControl.SetToolTip(this.ButtonClearPassword, "Очистить поле");
            this.ButtonClearPassword.UseVisualStyleBackColor = true;
            this.ButtonClearPassword.Click += new System.EventHandler(this.ButtonClearPassword_Click);
            // 
            // LabelGeneratedPassword
            // 
            this.LabelGeneratedPassword.AutoSize = true;
            this.LabelGeneratedPassword.Location = new System.Drawing.Point(156, 204);
            this.LabelGeneratedPassword.Name = "LabelGeneratedPassword";
            this.LabelGeneratedPassword.Size = new System.Drawing.Size(141, 13);
            this.LabelGeneratedPassword.TabIndex = 10;
            this.LabelGeneratedPassword.Text = "Сгенерированный пароль:";
            // 
            // LabelPasswordCopiedToClipboard
            // 
            this.LabelPasswordCopiedToClipboard.AutoSize = true;
            this.LabelPasswordCopiedToClipboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.LabelPasswordCopiedToClipboard.ForeColor = System.Drawing.Color.Green;
            this.LabelPasswordCopiedToClipboard.Location = new System.Drawing.Point(300, 224);
            this.LabelPasswordCopiedToClipboard.Name = "LabelPasswordCopiedToClipboard";
            this.LabelPasswordCopiedToClipboard.Size = new System.Drawing.Size(224, 13);
            this.LabelPasswordCopiedToClipboard.TabIndex = 11;
            this.LabelPasswordCopiedToClipboard.Text = "Пароль скопирован в буфер обмена";
            // 
            // LabelWarningMessageTitle
            // 
            this.LabelWarningMessageTitle.AutoSize = true;
            this.LabelWarningMessageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.LabelWarningMessageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabelWarningMessageTitle.Location = new System.Drawing.Point(12, 251);
            this.LabelWarningMessageTitle.Name = "LabelWarningMessageTitle";
            this.LabelWarningMessageTitle.Size = new System.Drawing.Size(303, 13);
            this.LabelWarningMessageTitle.TabIndex = 12;
            this.LabelWarningMessageTitle.Text = "Рекомендации для генерации надёжного пароля:";
            // 
            // LabelWarningMessage
            // 
            this.LabelWarningMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabelWarningMessage.Location = new System.Drawing.Point(12, 269);
            this.LabelWarningMessage.Name = "LabelWarningMessage";
            this.LabelWarningMessage.Size = new System.Drawing.Size(416, 36);
            this.LabelWarningMessage.TabIndex = 13;
            this.LabelWarningMessage.Text = "длина от 8 символов и более, с использованием спецсимволов, цифр, строчных и проп" +
    "исных латинских букв";
            // 
            // TextBoxGeneratedPassword
            // 
            this.TextBoxGeneratedPassword.Location = new System.Drawing.Point(303, 201);
            this.TextBoxGeneratedPassword.Name = "TextBoxGeneratedPassword";
            this.TextBoxGeneratedPassword.Size = new System.Drawing.Size(230, 20);
            this.TextBoxGeneratedPassword.TabIndex = 14;
            this.TextBoxGeneratedPassword.TextChanged += new System.EventHandler(this.TextBoxGeneratedPassword_TextChanged);
            // 
            // TimerShowLabelCopiedToClipboard
            // 
            this.TimerShowLabelCopiedToClipboard.Interval = 2000;
            this.TimerShowLabelCopiedToClipboard.Tick += new System.EventHandler(this.TimerShowLabelCopiedToClipboard_Tick);
            // 
            // ImageListDefault
            // 
            this.ImageListDefault.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageListDefault.ImageStream")));
            this.ImageListDefault.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageListDefault.Images.SetKeyName(0, "2638315_bin_delete_dust_erace_garbage_icon.png");
            this.ImageListDefault.Images.SetKeyName(1, "9021590_password_bold_icon.ico");
            // 
            // FrmPasswordGenerator
            // 
            this.AcceptButton = this.ButtonGeneratePassword;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonExit;
            this.ClientSize = new System.Drawing.Size(584, 319);
            this.Controls.Add(this.TextBoxGeneratedPassword);
            this.Controls.Add(this.LabelWarningMessage);
            this.Controls.Add(this.LabelWarningMessageTitle);
            this.Controls.Add(this.LabelPasswordCopiedToClipboard);
            this.Controls.Add(this.LabelGeneratedPassword);
            this.Controls.Add(this.ButtonGeneratePassword);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonClearPassword);
            this.Controls.Add(this.GroupBoxGenerationParams);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPasswordGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[Allineed.Ru] - Генератор паролей";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPasswordGenerator_FormClosing);
            this.Load += new System.EventHandler(this.FrmPasswordGenerator_Load);
            this.GroupBoxGenerationParams.ResumeLayout(false);
            this.GroupBoxGenerationParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarPasswordLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxGenerationParams;
        private System.Windows.Forms.Label LabelPasswordLengthValue;
        private System.Windows.Forms.Label LabelPasswordLength;
        private System.Windows.Forms.TrackBar TrackBarPasswordLength;
        private System.Windows.Forms.CheckBox CheckBoxUseUppercaseLetters;
        private System.Windows.Forms.CheckBox CheckBoxUseLowercaseLetters;
        private System.Windows.Forms.CheckBox CheckBoxUseDigits;
        private System.Windows.Forms.CheckBox CheckBoxUseSpecialSymbols;
        private System.Windows.Forms.Button ButtonGeneratePassword;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Button ButtonClearPassword;
        private System.Windows.Forms.Label LabelGeneratedPassword;
        private System.Windows.Forms.Label LabelPasswordCopiedToClipboard;
        private System.Windows.Forms.Label LabelWarningMessageTitle;
        private System.Windows.Forms.Label LabelWarningMessage;
        private System.Windows.Forms.TextBox TextBoxGeneratedPassword;
        private System.Windows.Forms.Timer TimerShowLabelCopiedToClipboard;
        private System.Windows.Forms.ImageList ImageListDefault;
        private System.Windows.Forms.ToolTip ToolTipForControl;
    }
}

