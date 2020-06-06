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
            this.ClosePictureBox = new System.Windows.Forms.PictureBox();
            this.MinimizePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // StopButt
            // 
            this.StopButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.StopButt.ForeColor = System.Drawing.SystemColors.Desktop;
            this.StopButt.Location = new System.Drawing.Point(68, 294);
            this.StopButt.Name = "StopButt";
            this.StopButt.Size = new System.Drawing.Size(164, 78);
            this.StopButt.TabIndex = 0;
            this.StopButt.Text = "Stopnout";
            this.StopButt.UseVisualStyleBackColor = true;
            this.StopButt.Click += new System.EventHandler(this.OnPauseButton_Click);
            // 
            // TriggerButtLbl
            // 
            this.TriggerButtLbl.AutoSize = true;
            this.TriggerButtLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TriggerButtLbl.Location = new System.Drawing.Point(22, 51);
            this.TriggerButtLbl.Name = "TriggerButtLbl";
            this.TriggerButtLbl.Size = new System.Drawing.Size(195, 20);
            this.TriggerButtLbl.TabIndex = 2;
            this.TriggerButtLbl.Text = "Klávesa na zapnutí/vypnutí";
            // 
            // ActionDelayTextBoxLbl
            // 
            this.ActionDelayTextBoxLbl.AutoSize = true;
            this.ActionDelayTextBoxLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ActionDelayTextBoxLbl.Location = new System.Drawing.Point(22, 86);
            this.ActionDelayTextBoxLbl.Name = "ActionDelayTextBoxLbl";
            this.ActionDelayTextBoxLbl.Size = new System.Drawing.Size(198, 20);
            this.ActionDelayTextBoxLbl.TabIndex = 6;
            this.ActionDelayTextBoxLbl.Text = "Prodleva mezi stisky kláves";
            // 
            // ActionDelayTextBox
            // 
            this.ActionDelayTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ActionDelayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ActionDelayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ActionDelayTextBox.Location = new System.Drawing.Point(242, 80);
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
            this.TriggerButt.Location = new System.Drawing.Point(242, 45);
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
            this.InfoLbl.Location = new System.Drawing.Point(65, 228);
            this.InfoLbl.Name = "InfoLbl";
            this.InfoLbl.Size = new System.Drawing.Size(164, 20);
            this.InfoLbl.TabIndex = 9;
            this.InfoLbl.Text = "[Info]";
            this.InfoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoopDelayTextBoxLbl
            // 
            this.LoopDelayTextBoxLbl.AutoSize = true;
            this.LoopDelayTextBoxLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LoopDelayTextBoxLbl.Location = new System.Drawing.Point(22, 122);
            this.LoopDelayTextBoxLbl.Name = "LoopDelayTextBoxLbl";
            this.LoopDelayTextBoxLbl.Size = new System.Drawing.Size(199, 20);
            this.LoopDelayTextBoxLbl.TabIndex = 10;
            this.LoopDelayTextBoxLbl.Text = "Prodleva mezi opakováními";
            // 
            // LoopDelayTextBox
            // 
            this.LoopDelayTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LoopDelayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoopDelayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LoopDelayTextBox.Location = new System.Drawing.Point(242, 116);
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
            this.MouseClickTurnsOffCheckBox.Location = new System.Drawing.Point(23, 156);
            this.MouseClickTurnsOffCheckBox.Name = "MouseClickTurnsOffCheckBox";
            this.MouseClickTurnsOffCheckBox.Size = new System.Drawing.Size(183, 24);
            this.MouseClickTurnsOffCheckBox.TabIndex = 12;
            this.MouseClickTurnsOffCheckBox.Text = "vypnout kliknutím myši";
            this.MouseClickTurnsOffCheckBox.UseVisualStyleBackColor = true;
            this.MouseClickTurnsOffCheckBox.CheckedChanged += new System.EventHandler(this.OnTurnOffWithLeftClickCheckBox_CheckedChange);
            // 
            // ClosePictureBox
            // 
            this.ClosePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClosePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ClosePictureBox.Image")));
            this.ClosePictureBox.Location = new System.Drawing.Point(272, 6);
            this.ClosePictureBox.Name = "ClosePictureBox";
            this.ClosePictureBox.Size = new System.Drawing.Size(21, 21);
            this.ClosePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClosePictureBox.TabIndex = 13;
            this.ClosePictureBox.TabStop = false;
            this.ClosePictureBox.Click += new System.EventHandler(this.OnClosePictureBox_Click);
            // 
            // MinimizePictureBox
            // 
            this.MinimizePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MinimizePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("MinimizePictureBox.Image")));
            this.MinimizePictureBox.Location = new System.Drawing.Point(2, 6);
            this.MinimizePictureBox.Name = "MinimizePictureBox";
            this.MinimizePictureBox.Size = new System.Drawing.Size(39, 27);
            this.MinimizePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MinimizePictureBox.TabIndex = 14;
            this.MinimizePictureBox.TabStop = false;
            this.MinimizePictureBox.Click += new System.EventHandler(this.OnMinimizePictureBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(299, 394);
            this.Controls.Add(this.MinimizePictureBox);
            this.Controls.Add(this.ClosePictureBox);
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
            ((System.ComponentModel.ISupportInitialize)(this.ClosePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePictureBox)).EndInit();
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
        private System.Windows.Forms.PictureBox ClosePictureBox;
        private System.Windows.Forms.PictureBox MinimizePictureBox;
    }
}

