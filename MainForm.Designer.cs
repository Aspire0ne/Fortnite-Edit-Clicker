namespace EditClicker
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.CheckIfFortniteRunning_CheckBox = new System.Windows.Forms.CheckBox();
            this.EditKeyButtLbl = new System.Windows.Forms.Label();
            this.PowerModeMenu = new System.Windows.Forms.ComboBox();
            this.EditKeyButt = new System.Windows.Forms.Button();
            this.TriggerTypeToggleRadioBox = new System.Windows.Forms.RadioButton();
            this.TriggerTypeHoldRadioBox = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // StopButt
            // 
            this.StopButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StopButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.StopButt.ForeColor = System.Drawing.SystemColors.Desktop;
            this.StopButt.Location = new System.Drawing.Point(86, 292);
            this.StopButt.Name = "StopButt";
            this.StopButt.Size = new System.Drawing.Size(235, 78);
            this.StopButt.TabIndex = 0;
            this.StopButt.Text = "Pause";
            this.toolTip1.SetToolTip(this.StopButt, "Will stop listening to key presses.");
            this.StopButt.UseVisualStyleBackColor = true;
            this.StopButt.Click += new System.EventHandler(this.OnPauseButton_Click);
            // 
            // TriggerButtLbl
            // 
            this.TriggerButtLbl.AutoSize = true;
            this.TriggerButtLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TriggerButtLbl.Location = new System.Drawing.Point(183, 28);
            this.TriggerButtLbl.Name = "TriggerButtLbl";
            this.TriggerButtLbl.Size = new System.Drawing.Size(59, 20);
            this.TriggerButtLbl.TabIndex = 2;
            this.TriggerButtLbl.Text = "Hotkey";
            this.toolTip1.SetToolTip(this.TriggerButtLbl, "The key that\'ll turn editing on & off.");
            // 
            // ActionDelayTextBoxLbl
            // 
            this.ActionDelayTextBoxLbl.AutoSize = true;
            this.ActionDelayTextBoxLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ActionDelayTextBoxLbl.Location = new System.Drawing.Point(12, 75);
            this.ActionDelayTextBoxLbl.Name = "ActionDelayTextBoxLbl";
            this.ActionDelayTextBoxLbl.Size = new System.Drawing.Size(90, 20);
            this.ActionDelayTextBoxLbl.TabIndex = 6;
            this.ActionDelayTextBoxLbl.Text = "Press delay";
            this.toolTip1.SetToolTip(this.ActionDelayTextBoxLbl, "Delay between presses while editing (e.g. G [delay] left click [delay] G [delay] " +
        "right click).");
            // 
            // ActionDelayTextBox
            // 
            this.ActionDelayTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ActionDelayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ActionDelayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ActionDelayTextBox.Location = new System.Drawing.Point(126, 69);
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
            this.TriggerButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TriggerButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TriggerButt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TriggerButt.Location = new System.Drawing.Point(290, 20);
            this.TriggerButt.Name = "TriggerButt";
            this.TriggerButt.Size = new System.Drawing.Size(104, 28);
            this.TriggerButt.TabIndex = 8;
            this.TriggerButt.Text = "P";
            this.TriggerButt.UseVisualStyleBackColor = true;
            this.TriggerButt.Click += new System.EventHandler(this.OnKeyMapperButton_Click);
            this.TriggerButt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnTriggerButton_KeyPress);
            // 
            // InfoLbl
            // 
            this.InfoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.InfoLbl.Location = new System.Drawing.Point(86, 237);
            this.InfoLbl.Name = "InfoLbl";
            this.InfoLbl.Size = new System.Drawing.Size(235, 43);
            this.InfoLbl.TabIndex = 9;
            this.InfoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoopDelayTextBoxLbl
            // 
            this.LoopDelayTextBoxLbl.AutoSize = true;
            this.LoopDelayTextBoxLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LoopDelayTextBoxLbl.Location = new System.Drawing.Point(12, 123);
            this.LoopDelayTextBoxLbl.Name = "LoopDelayTextBoxLbl";
            this.LoopDelayTextBoxLbl.Size = new System.Drawing.Size(103, 20);
            this.LoopDelayTextBoxLbl.TabIndex = 10;
            this.LoopDelayTextBoxLbl.Text = "Repeat delay";
            this.toolTip1.SetToolTip(this.LoopDelayTextBoxLbl, "Delay between each full edit (e.g. make a window = full edit).");
            // 
            // LoopDelayTextBox
            // 
            this.LoopDelayTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LoopDelayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoopDelayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LoopDelayTextBox.Location = new System.Drawing.Point(126, 117);
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
            this.MouseClickTurnsOffCheckBox.Location = new System.Drawing.Point(193, 172);
            this.MouseClickTurnsOffCheckBox.Name = "MouseClickTurnsOffCheckBox";
            this.MouseClickTurnsOffCheckBox.Size = new System.Drawing.Size(201, 24);
            this.MouseClickTurnsOffCheckBox.TabIndex = 12;
            this.MouseClickTurnsOffCheckBox.Text = "Turn off with mouse click";
            this.toolTip1.SetToolTip(this.MouseClickTurnsOffCheckBox, "If the program is currently editing, left click will turn it off (will work as th" +
        "e toggle key).");
            this.MouseClickTurnsOffCheckBox.UseVisualStyleBackColor = true;
            this.MouseClickTurnsOffCheckBox.CheckedChanged += new System.EventHandler(this.OnTurnOffWithLeftClickCheckBox_CheckedChange);
            // 
            // PowerModeMenuLabel
            // 
            this.PowerModeMenuLabel.AutoSize = true;
            this.PowerModeMenuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PowerModeMenuLabel.Location = new System.Drawing.Point(183, 123);
            this.PowerModeMenuLabel.Name = "PowerModeMenuLabel";
            this.PowerModeMenuLabel.Size = new System.Drawing.Size(97, 20);
            this.PowerModeMenuLabel.TabIndex = 14;
            this.PowerModeMenuLabel.Text = "Power mode";
            this.toolTip1.SetToolTip(this.PowerModeMenuLabel, "Higher power mode can make edits faster and more stable when the edit speed is <2" +
        "0, but will be more CPU intensive.");
            // 
            // CheckIfFortniteRunning_CheckBox
            // 
            this.CheckIfFortniteRunning_CheckBox.AutoSize = true;
            this.CheckIfFortniteRunning_CheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CheckIfFortniteRunning_CheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CheckIfFortniteRunning_CheckBox.Location = new System.Drawing.Point(12, 172);
            this.CheckIfFortniteRunning_CheckBox.Name = "CheckIfFortniteRunning_CheckBox";
            this.CheckIfFortniteRunning_CheckBox.Size = new System.Drawing.Size(175, 24);
            this.CheckIfFortniteRunning_CheckBox.TabIndex = 15;
            this.CheckIfFortniteRunning_CheckBox.Text = "Check Fortnite focus";
            this.toolTip1.SetToolTip(this.CheckIfFortniteRunning_CheckBox, "Before initiating editing check if Fortnite is focused, and if it isn\'t don\'t ini" +
        "tiate. Can slow down initiating (~10ms)");
            this.CheckIfFortniteRunning_CheckBox.UseVisualStyleBackColor = false;
            this.CheckIfFortniteRunning_CheckBox.CheckedChanged += new System.EventHandler(this.OnFortniteRunningCheckCheckBox_CheckedChange);
            // 
            // EditKeyButtLbl
            // 
            this.EditKeyButtLbl.AutoSize = true;
            this.EditKeyButtLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EditKeyButtLbl.Location = new System.Drawing.Point(183, 75);
            this.EditKeyButtLbl.Name = "EditKeyButtLbl";
            this.EditKeyButtLbl.Size = new System.Drawing.Size(65, 20);
            this.EditKeyButtLbl.TabIndex = 16;
            this.EditKeyButtLbl.Text = "Edit key";
            this.toolTip1.SetToolTip(this.EditKeyButtLbl, "They key that is used in the game to edit.");
            // 
            // PowerModeMenu
            // 
            this.PowerModeMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PowerModeMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PowerModeMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PowerModeMenu.FormattingEnabled = true;
            this.PowerModeMenu.Location = new System.Drawing.Point(290, 115);
            this.PowerModeMenu.Name = "PowerModeMenu";
            this.PowerModeMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PowerModeMenu.Size = new System.Drawing.Size(104, 28);
            this.PowerModeMenu.TabIndex = 13;
            this.PowerModeMenu.Tag = "";
            this.PowerModeMenu.SelectedIndexChanged += new System.EventHandler(this.OnPowerModeMenuComboBox_ItemChange);
            // 
            // EditKeyButt
            // 
            this.EditKeyButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditKeyButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EditKeyButt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EditKeyButt.Location = new System.Drawing.Point(290, 67);
            this.EditKeyButt.Name = "EditKeyButt";
            this.EditKeyButt.Size = new System.Drawing.Size(104, 28);
            this.EditKeyButt.TabIndex = 17;
            this.EditKeyButt.Text = "G";
            this.EditKeyButt.UseVisualStyleBackColor = true;
            this.EditKeyButt.Click += new System.EventHandler(this.OnKeyMapperButton_Click);
            this.EditKeyButt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnEditKeyButton_KeyPress);
            // 
            // TriggerTypeToggleRadioBox
            // 
            this.TriggerTypeToggleRadioBox.AutoSize = true;
            this.TriggerTypeToggleRadioBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TriggerTypeToggleRadioBox.Checked = true;
            this.TriggerTypeToggleRadioBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TriggerTypeToggleRadioBox.Location = new System.Drawing.Point(12, 26);
            this.TriggerTypeToggleRadioBox.Name = "TriggerTypeToggleRadioBox";
            this.TriggerTypeToggleRadioBox.Size = new System.Drawing.Size(75, 24);
            this.TriggerTypeToggleRadioBox.TabIndex = 18;
            this.TriggerTypeToggleRadioBox.TabStop = true;
            this.TriggerTypeToggleRadioBox.Text = "Toggle";
            this.TriggerTypeToggleRadioBox.UseVisualStyleBackColor = true;
            this.TriggerTypeToggleRadioBox.CheckedChanged += new System.EventHandler(this.OnTriggerTypeToggleRadioBox_CheckedChange);
            // 
            // TriggerTypeHoldRadioBox
            // 
            this.TriggerTypeHoldRadioBox.AutoSize = true;
            this.TriggerTypeHoldRadioBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TriggerTypeHoldRadioBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TriggerTypeHoldRadioBox.Location = new System.Drawing.Point(101, 26);
            this.TriggerTypeHoldRadioBox.Name = "TriggerTypeHoldRadioBox";
            this.TriggerTypeHoldRadioBox.Size = new System.Drawing.Size(60, 24);
            this.TriggerTypeHoldRadioBox.TabIndex = 19;
            this.TriggerTypeHoldRadioBox.Text = "Hold";
            this.TriggerTypeHoldRadioBox.UseVisualStyleBackColor = true;
            this.TriggerTypeHoldRadioBox.CheckedChanged += new System.EventHandler(this.OnTriggerTypeHoldRadioBox_CheckedChange);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(410, 400);
            this.Controls.Add(this.TriggerTypeHoldRadioBox);
            this.Controls.Add(this.TriggerTypeToggleRadioBox);
            this.Controls.Add(this.EditKeyButt);
            this.Controls.Add(this.EditKeyButtLbl);
            this.Controls.Add(this.CheckIfFortniteRunning_CheckBox);
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
            this.Name = "MainForm";
            this.Text = "EditClicker";
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
        private System.Windows.Forms.CheckBox CheckIfFortniteRunning_CheckBox;
        private System.Windows.Forms.Button EditKeyButt;
        private System.Windows.Forms.Label EditKeyButtLbl;
        private System.Windows.Forms.RadioButton TriggerTypeToggleRadioBox;
        private System.Windows.Forms.RadioButton TriggerTypeHoldRadioBox;
    }
}

