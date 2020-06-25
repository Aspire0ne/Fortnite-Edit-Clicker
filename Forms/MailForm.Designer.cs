namespace FortniteAutoclicker
{
    partial class MailPopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailPopup));
            this.BugRadioButton = new System.Windows.Forms.RadioButton();
            this.OtherRadioButton = new System.Windows.Forms.RadioButton();
            this.SuggestionRadioButton = new System.Windows.Forms.RadioButton();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.LineDecorationLabel = new System.Windows.Forms.Label();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.SendButton = new System.Windows.Forms.Button();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.MailTextBox = new EditClicker.OneLineHintTextBox();
            this.SuspendLayout();
            // 
            // BugRadioButton
            // 
            this.BugRadioButton.AutoSize = true;
            this.BugRadioButton.Location = new System.Drawing.Point(31, 12);
            this.BugRadioButton.Name = "BugRadioButton";
            this.BugRadioButton.Size = new System.Drawing.Size(56, 24);
            this.BugRadioButton.TabIndex = 0;
            this.BugRadioButton.Text = "Bug";
            this.BugRadioButton.UseVisualStyleBackColor = true;
            // 
            // OtherRadioButton
            // 
            this.OtherRadioButton.AutoSize = true;
            this.OtherRadioButton.Location = new System.Drawing.Point(260, 12);
            this.OtherRadioButton.Name = "OtherRadioButton";
            this.OtherRadioButton.Size = new System.Drawing.Size(67, 24);
            this.OtherRadioButton.TabIndex = 1;
            this.OtherRadioButton.Text = "Other";
            this.OtherRadioButton.UseVisualStyleBackColor = true;
            // 
            // SuggestionRadioButton
            // 
            this.SuggestionRadioButton.AutoSize = true;
            this.SuggestionRadioButton.Checked = true;
            this.SuggestionRadioButton.Location = new System.Drawing.Point(119, 12);
            this.SuggestionRadioButton.Name = "SuggestionRadioButton";
            this.SuggestionRadioButton.Size = new System.Drawing.Size(108, 24);
            this.SuggestionRadioButton.TabIndex = 2;
            this.SuggestionRadioButton.TabStop = true;
            this.SuggestionRadioButton.Text = "Suggestion";
            this.SuggestionRadioButton.UseVisualStyleBackColor = true;
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MessageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MessageTextBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MessageTextBox.Location = new System.Drawing.Point(31, 95);
            this.MessageTextBox.Multiline = true;
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(296, 145);
            this.MessageTextBox.TabIndex = 3;
            // 
            // LineDecorationLabel
            // 
            this.LineDecorationLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LineDecorationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LineDecorationLabel.Location = new System.Drawing.Point(20, 43);
            this.LineDecorationLabel.Name = "LineDecorationLabel";
            this.LineDecorationLabel.Size = new System.Drawing.Size(320, 2);
            this.LineDecorationLabel.TabIndex = 4;
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.MessageLabel.Location = new System.Drawing.Point(139, 61);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(82, 22);
            this.MessageLabel.TabIndex = 5;
            this.MessageLabel.Text = "Message";
            // 
            // SendButton
            // 
            this.SendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SendButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SendButton.Location = new System.Drawing.Point(252, 278);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 27);
            this.SendButton.TabIndex = 6;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_ClickAsync);
            this.SendButton.LostFocus += new System.EventHandler(this.OnSendButton_FocusLoss);
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoEllipsis = true;
            this.InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.InfoLabel.Location = new System.Drawing.Point(29, 278);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.InfoLabel.Size = new System.Drawing.Size(217, 37);
            this.InfoLabel.TabIndex = 7;
            // 
            // MailTextBox
            // 
            this.MailTextBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MailTextBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MailTextBox.Hint = "Your e-mail (Optional)";
            this.MailTextBox.HintColor = System.Drawing.SystemColors.ButtonShadow;
            this.MailTextBox.Location = new System.Drawing.Point(31, 248);
            this.MailTextBox.MaximumSize = new System.Drawing.Size(296, 25);
            this.MailTextBox.MinimumSize = new System.Drawing.Size(296, 24);
            this.MailTextBox.Multiline = true;
            this.MailTextBox.Name = "MailTextBox";
            this.MailTextBox.Size = new System.Drawing.Size(296, 24);
            this.MailTextBox.TabIndex = 9;
            // 
            // MailPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(358, 324);
            this.Controls.Add(this.MailTextBox);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.LineDecorationLabel);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.SuggestionRadioButton);
            this.Controls.Add(this.OtherRadioButton);
            this.Controls.Add(this.BugRadioButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MailPopup";
            this.Text = "Feedback";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton BugRadioButton;
        private System.Windows.Forms.RadioButton OtherRadioButton;
        private System.Windows.Forms.RadioButton SuggestionRadioButton;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.Label LineDecorationLabel;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Label InfoLabel;
        private EditClicker.OneLineHintTextBox MailTextBox;
    }
}