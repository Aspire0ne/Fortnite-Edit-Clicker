namespace FortniteAutoclicker
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StopButt = new System.Windows.Forms.Button();
            this.TriggerButtLbl = new System.Windows.Forms.Label();
            this.ActionDelayTextBoxLbl = new System.Windows.Forms.Label();
            this.ActionDelayTextBox = new System.Windows.Forms.TextBox();
            this.TriggerButt = new System.Windows.Forms.Button();
            this.InfoLbl = new System.Windows.Forms.Label();
            this.LoopDelayTextBoxLbl = new System.Windows.Forms.Label();
            this.LoopDelayTextBox = new System.Windows.Forms.TextBox();
            this.MouseClickTurnsOffCheckBox = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.PowerModeMenuLabel = new System.Windows.Forms.Label();
            this.PowerModeMenu = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // StopButt
            // 
            this.StopButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.StopButt.ForeColor = System.Drawing.SystemColors.Desktop;
            this.StopButt.Location = new System.Drawing.Point(68, 326);
            this.StopButt.Name = "StopButt";
            this.StopButt.Size = new System.Drawing.Size(164, 78);
            this.StopButt.TabIndex = 0;
            this.StopButt.Text = "Pozastavit";
            this.toolTip1.SetToolTip(this.StopButt, "Přestane poslouchat mačkání kláves a myši.");
            this.StopButt.UseVisualStyleBackColor = true;
            this.StopButt.Click += new System.EventHandler(this.OnPauseButton_Click);
            // 
            // TriggerButtLbl
            // 
            this.TriggerButtLbl.AutoSize = true;
            this.TriggerButtLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TriggerButtLbl.Location = new System.Drawing.Point(23, 24);
            this.TriggerButtLbl.Name = "TriggerButtLbl";
            this.TriggerButtLbl.Size = new System.Drawing.Size(195, 20);
            this.TriggerButtLbl.TabIndex = 2;
            this.TriggerButtLbl.Text = "Klávesa na zapnutí/vypnutí";
            this.toolTip1.SetToolTip(this.TriggerButtLbl, "Klávesa, kterou se auto-edit zapne a vypne.");
            // 
            // ActionDelayTextBoxLbl
            // 
            this.ActionDelayTextBoxLbl.AutoSize = true;
            this.ActionDelayTextBoxLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ActionDelayTextBoxLbl.Location = new System.Drawing.Point(23, 67);
            this.ActionDelayTextBoxLbl.Name = "ActionDelayTextBoxLbl";
            this.ActionDelayTextBoxLbl.Size = new System.Drawing.Size(198, 20);
            this.ActionDelayTextBoxLbl.TabIndex = 6;
            this.ActionDelayTextBoxLbl.Text = "Prodleva mezi stisky kláves";
            this.toolTip1.SetToolTip(this.ActionDelayTextBoxLbl, "Prodleva mezi kliky při editování (např. G [prodleva] levý klik [prodleva] G [pro" +
        "dleva] pravý klik).");
            // 
            // ActionDelayTextBox
            // 
            this.ActionDelayTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ActionDelayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ActionDelayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ActionDelayTextBox.Location = new System.Drawing.Point(243, 61);
            this.ActionDelayTextBox.MaxLength = 3;
            this.ActionDelayTextBox.Name = "ActionDelayTextBox";
            this.ActionDelayTextBox.Size = new System.Drawing.Size(35, 26);
            this.ActionDelayTextBox.TabIndex = 7;
            this.ActionDelayTextBox.Text = "20";
            this.ActionDelayTextBox.TextChanged += new System.EventHandler(this.OnActionDelayTextBox_TextChange);
            this.ActionDelayTextBox.LostFocus += new System.EventHandler(this.OnActionDelayTextBox_FocusLoss);
            // 
            // TriggerButt
            // 
            this.TriggerButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TriggerButt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TriggerButt.Location = new System.Drawing.Point(243, 18);
            this.TriggerButt.Name = "TriggerButt";
            this.TriggerButt.Size = new System.Drawing.Size(35, 26);
            this.TriggerButt.TabIndex = 8;
            this.TriggerButt.Text = "P";
            this.TriggerButt.UseVisualStyleBackColor = true;
            this.TriggerButt.Click += new System.EventHandler(this.OnTriggerButton_Click);
            this.TriggerButt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnTriggerButton_KeyPress);
            // 
            // InfoLbl
            // 
            this.InfoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.InfoLbl.Location = new System.Drawing.Point(68, 290);
            this.InfoLbl.Name = "InfoLbl";
            this.InfoLbl.Size = new System.Drawing.Size(164, 20);
            this.InfoLbl.TabIndex = 9;
            this.InfoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoopDelayTextBoxLbl
            // 
            this.LoopDelayTextBoxLbl.AutoSize = true;
            this.LoopDelayTextBoxLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LoopDelayTextBoxLbl.Location = new System.Drawing.Point(23, 112);
            this.LoopDelayTextBoxLbl.Name = "LoopDelayTextBoxLbl";
            this.LoopDelayTextBoxLbl.Size = new System.Drawing.Size(199, 20);
            this.LoopDelayTextBoxLbl.TabIndex = 10;
            this.LoopDelayTextBoxLbl.Text = "Prodleva mezi opakováními";
            this.toolTip1.SetToolTip(this.LoopDelayTextBoxLbl, "Prodleva mezi celými edity (např. okno udělat, okno oddělat = jeden celý edit).");
            // 
            // LoopDelayTextBox
            // 
            this.LoopDelayTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LoopDelayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoopDelayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LoopDelayTextBox.Location = new System.Drawing.Point(243, 106);
            this.LoopDelayTextBox.MaxLength = 3;
            this.LoopDelayTextBox.Name = "LoopDelayTextBox";
            this.LoopDelayTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LoopDelayTextBox.Size = new System.Drawing.Size(35, 26);
            this.LoopDelayTextBox.TabIndex = 11;
            this.LoopDelayTextBox.Text = "80";
            this.LoopDelayTextBox.TextChanged += new System.EventHandler(this.OnLoopDelayTextBox_TextChange);
            this.LoopDelayTextBox.LostFocus += new System.EventHandler(this.OnLoopDelayTextBox_FocusLoss);
            // 
            // MouseClickTurnsOffCheckBox
            // 
            this.MouseClickTurnsOffCheckBox.AutoSize = true;
            this.MouseClickTurnsOffCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MouseClickTurnsOffCheckBox.Checked = true;
            this.MouseClickTurnsOffCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MouseClickTurnsOffCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MouseClickTurnsOffCheckBox.Location = new System.Drawing.Point(24, 201);
            this.MouseClickTurnsOffCheckBox.Name = "MouseClickTurnsOffCheckBox";
            this.MouseClickTurnsOffCheckBox.Size = new System.Drawing.Size(183, 24);
            this.MouseClickTurnsOffCheckBox.TabIndex = 12;
            this.MouseClickTurnsOffCheckBox.Text = "vypnout kliknutím myši";
            this.toolTip1.SetToolTip(this.MouseClickTurnsOffCheckBox, "Pokud je auto-edit právě zapnut, stisk tlačítka myši ho vypne.");
            this.MouseClickTurnsOffCheckBox.UseVisualStyleBackColor = true;
            this.MouseClickTurnsOffCheckBox.CheckedChanged += new System.EventHandler(this.OnTurnOffWithLeftClickCheckBox_CheckedChange);
            // 
            // PowerModeMenuLabel
            // 
            this.PowerModeMenuLabel.AutoSize = true;
            this.PowerModeMenuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PowerModeMenuLabel.Location = new System.Drawing.Point(23, 157);
            this.PowerModeMenuLabel.Name = "PowerModeMenuLabel";
            this.PowerModeMenuLabel.Size = new System.Drawing.Size(138, 20);
            this.PowerModeMenuLabel.TabIndex = 14;
            this.PowerModeMenuLabel.Text = "Výkonnostní režim";
            this.toolTip1.SetToolTip(this.PowerModeMenuLabel, "Vyšší výkon může zrychlit edit, ale za cenu vyššího využití CPU.");
            // 
            // PowerModeMenu
            // 
            this.PowerModeMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PowerModeMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PowerModeMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PowerModeMenu.FormattingEnabled = true;
            this.PowerModeMenu.Location = new System.Drawing.Point(174, 153);
            this.PowerModeMenu.Name = "PowerModeMenu";
            this.PowerModeMenu.Size = new System.Drawing.Size(104, 24);
            this.PowerModeMenu.TabIndex = 13;
            this.PowerModeMenu.Tag = "";
            this.PowerModeMenu.SelectedIndexChanged += new System.EventHandler(this.OnPowerModeMenu_ItemChange);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(299, 425);
            this.Controls.Add(this.PowerModeMenuLabel);
            this.Controls.Add(this.PowerModeMenu);
            this.Controls.Add(this.MouseClickTurnsOffCheckBox);
            this.Controls.Add(this.LoopDelayTextBox);
            this.Controls.Add(this.LoopDelayTextBoxLbl);
            this.Controls.Add(this.InfoLbl);
            this.Controls.Add(this.TriggerButt);
            this.Controls.Add(this.ActionDelayTextBox);
            this.Controls.Add(this.ActionDelayTextBoxLbl);
            this.Controls.Add(this.TriggerButtLbl);
            this.Controls.Add(this.StopButt);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Fortnite EditClicker";
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StopButt;
        private System.Windows.Forms.Label TriggerButtLbl;
        private System.Windows.Forms.Label ActionDelayTextBoxLbl;
        private System.Windows.Forms.TextBox ActionDelayTextBox;
        private System.Windows.Forms.Button TriggerButt;
        private System.Windows.Forms.Label InfoLbl;
        private System.Windows.Forms.Label LoopDelayTextBoxLbl;
        private System.Windows.Forms.TextBox LoopDelayTextBox;
        private System.Windows.Forms.CheckBox MouseClickTurnsOffCheckBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox PowerModeMenu;
        private System.Windows.Forms.Label PowerModeMenuLabel;
    }
}

