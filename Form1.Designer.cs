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
            this.ActionDelayTextBox = new System.Windows.Forms.Label();
            this.ActionDelayTextBoxLbl = new System.Windows.Forms.TextBox();
            this.TriggerButt = new System.Windows.Forms.Button();
            this.InfoLbl = new System.Windows.Forms.Label();
            this.LoopDelayTextBoxLbl = new System.Windows.Forms.Label();
            this.LoopDelayTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // StopButt
            // 
            this.StopButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.StopButt.Location = new System.Drawing.Point(70, 283);
            this.StopButt.Name = "StopButt";
            this.StopButt.Size = new System.Drawing.Size(164, 78);
            this.StopButt.TabIndex = 0;
            this.StopButt.Text = "Stopnout";
            this.StopButt.UseVisualStyleBackColor = true;
            this.StopButt.Click += new System.EventHandler(this.OnPauseButtonClick);
            // 
            // TriggerButtLbl
            // 
            this.TriggerButtLbl.AutoSize = true;
            this.TriggerButtLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TriggerButtLbl.Location = new System.Drawing.Point(28, 26);
            this.TriggerButtLbl.Name = "TriggerButtLbl";
            this.TriggerButtLbl.Size = new System.Drawing.Size(195, 20);
            this.TriggerButtLbl.TabIndex = 2;
            this.TriggerButtLbl.Text = "Klávesa na zapnutí/vypnutí";
            // 
            // ActionDelayTextBox
            // 
            this.ActionDelayTextBox.AutoSize = true;
            this.ActionDelayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ActionDelayTextBox.Location = new System.Drawing.Point(25, 69);
            this.ActionDelayTextBox.Name = "ActionDelayTextBox";
            this.ActionDelayTextBox.Size = new System.Drawing.Size(198, 20);
            this.ActionDelayTextBox.TabIndex = 6;
            this.ActionDelayTextBox.Text = "Prodleva mezi stisky kláves";
            // 
            // ActionDelayTextBoxLbl
            // 
            this.ActionDelayTextBoxLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ActionDelayTextBoxLbl.Location = new System.Drawing.Point(240, 63);
            this.ActionDelayTextBoxLbl.MaxLength = 3;
            this.ActionDelayTextBoxLbl.Name = "ActionDelayTextBoxLbl";
            this.ActionDelayTextBoxLbl.Size = new System.Drawing.Size(35, 26);
            this.ActionDelayTextBoxLbl.TabIndex = 7;
            this.ActionDelayTextBoxLbl.Text = "18";
            this.ActionDelayTextBoxLbl.TextChanged += new System.EventHandler(this.OnActionDelayTextBoxTextChange);
            this.ActionDelayTextBoxLbl.LostFocus += new System.EventHandler(this.OnActionDelayTextBoxFocusLoss);
            // 
            // TriggerButt
            // 
            this.TriggerButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TriggerButt.Location = new System.Drawing.Point(240, 20);
            this.TriggerButt.Name = "TriggerButt";
            this.TriggerButt.Size = new System.Drawing.Size(35, 26);
            this.TriggerButt.TabIndex = 8;
            this.TriggerButt.Text = "P";
            this.TriggerButt.UseVisualStyleBackColor = true;
            this.TriggerButt.Click += new System.EventHandler(this.OnTriggerButtonClick);
            this.TriggerButt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnTriggerButtonKeyPress);
            // 
            // InfoLbl
            // 
            this.InfoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.InfoLbl.Location = new System.Drawing.Point(12, 163);
            this.InfoLbl.Name = "InfoLbl";
            this.InfoLbl.Size = new System.Drawing.Size(282, 83);
            this.InfoLbl.TabIndex = 9;
            this.InfoLbl.Text = "[Info]";
            this.InfoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoopDelayTextBoxLbl
            // 
            this.LoopDelayTextBoxLbl.AutoSize = true;
            this.LoopDelayTextBoxLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LoopDelayTextBoxLbl.Location = new System.Drawing.Point(24, 111);
            this.LoopDelayTextBoxLbl.Name = "LoopDelayTextBoxLbl";
            this.LoopDelayTextBoxLbl.Size = new System.Drawing.Size(199, 20);
            this.LoopDelayTextBoxLbl.TabIndex = 10;
            this.LoopDelayTextBoxLbl.Text = "Prodleva mezi opakováními";
            // 
            // LoopDelayTextBox
            // 
            this.LoopDelayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LoopDelayTextBox.Location = new System.Drawing.Point(240, 105);
            this.LoopDelayTextBox.MaxLength = 3;
            this.LoopDelayTextBox.Name = "LoopDelayTextBox";
            this.LoopDelayTextBox.Size = new System.Drawing.Size(35, 26);
            this.LoopDelayTextBox.TabIndex = 11;
            this.LoopDelayTextBox.Text = "40";
            this.LoopDelayTextBox.TextChanged += new System.EventHandler(this.OnLoopDelayTextBoxTextChange);
            this.LoopDelayTextBox.LostFocus += new System.EventHandler(this.OnLoopDelayTextBoxFocusLoss);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 394);
            this.Controls.Add(this.LoopDelayTextBox);
            this.Controls.Add(this.LoopDelayTextBoxLbl);
            this.Controls.Add(this.InfoLbl);
            this.Controls.Add(this.TriggerButt);
            this.Controls.Add(this.ActionDelayTextBoxLbl);
            this.Controls.Add(this.ActionDelayTextBox);
            this.Controls.Add(this.TriggerButtLbl);
            this.Controls.Add(this.StopButt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Fortnite AutoEditor";
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnFormKeypress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StopButt;
        private System.Windows.Forms.Label TriggerButtLbl;
        private System.Windows.Forms.Label ActionDelayTextBox;
        private System.Windows.Forms.TextBox ActionDelayTextBoxLbl;
        private System.Windows.Forms.Button TriggerButt;
        private System.Windows.Forms.Label InfoLbl;
        private System.Windows.Forms.Label LoopDelayTextBoxLbl;
        private System.Windows.Forms.TextBox LoopDelayTextBox;
    }
}

