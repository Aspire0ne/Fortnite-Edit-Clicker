using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace EditClicker
{
    public class OneLineHintTextBox : TextBox
    {
        string hint;

        [DefaultValue("")]
        public string Hint
        {
            get { return hint; }
            set { hint = value; Invalidate(); }
        }

        Color hintColor = SystemColors.GrayText;

        public Color HintColor
        {
            get { return hintColor; }
            set { hintColor = value; Invalidate(); }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (Focused && (keyData & Keys.Return) == Keys.Return)
                return true;

            return base.ProcessCmdKey(ref msg, keyData);
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == 0xf)
            {
                if (!Focused && string.IsNullOrEmpty(Text)
                    && !string.IsNullOrEmpty(Hint))
                {
                    using var g = CreateGraphics();
                    TextRenderer.DrawText(g, Hint, Font,
                        ClientRectangle, HintColor, BackColor,
                         TextFormatFlags.Top | TextFormatFlags.Left);
                }
            }
        }

        private bool ShouldSerializeHintColor() => HintColor != SystemColors.GrayText;

        private void ResetHintColor() => HintColor = SystemColors.GrayText;
    }
}
