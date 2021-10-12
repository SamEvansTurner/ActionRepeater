using System;
using System.Drawing;
using System.Windows.Forms;

namespace ActionRepeater.Forms {
    public partial class frmHighlight : Form {
        public frmHighlight() {
            InitializeComponent();
            this.BackColor = Color.LimeGreen;
            this.SetStyle(ControlStyles.Selectable, false);
            this.SetStyle(ControlStyles.StandardClick, false);
            this.SetStyle(ControlStyles.UserMouse, true);
            InputImports.SetWindowExTransparent(this.Handle);
            this.Icon = Properties.Resources.ActionRepeater;

        }
        protected override void WndProc(ref Message m) {
            if (m.Msg == (int)0x84)
                m.Result = (IntPtr)(-1);
            else
                base.WndProc(ref m);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = true;
        }

        private void tmrMove_Tick(object sender, EventArgs e) {
            this.Location = Cursor.Position;
        }
    }
}
