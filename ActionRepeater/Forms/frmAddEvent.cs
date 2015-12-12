using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActionRepeater.Forms
{
    public partial class frmAddEvent : Form
    {
        public delegate void GrabEvent(ActionEvent ev, frmMain.AddTypes addType);
        GrabEvent returnEvent;

        ActionEvent newEvent;
        frmMain.AddTypes returnAddType;

        public frmAddEvent(GrabEvent callback, frmMain.AddTypes addType)
        {
            InitializeComponent();

            cmbEventType.SelectedIndex = 0;
            cmbMouseButton.SelectedIndex = 0;

            numMouseSpeed.Value = 15;

            returnEvent = callback;
            returnAddType = addType;

            tmrCursUpdate.Start();
        }

        private void cmbEventType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cmbEventType.SelectedIndex)
            {
                case (int)ActionEvent.EventTypes.Wait:
                {
                    numWaitMS.Enabled = true;
                    numMouseX.Enabled = false;
                    numMouseY.Enabled = false;
                    numMouseRX.Enabled = false;
                    numMouseRY.Enabled = false;
                    numMouseSpeed.Enabled = false;
                    txtKeys.Enabled = false;
                    cmbMouseButton.Enabled = false;

                    lblWait.Enabled = true;
                    lblMouseX.Enabled = false;
                    lblMouseY.Enabled = false;
                    lblMouseRX.Enabled = false;
                    lblMouseRY.Enabled = false;
                    lblMouseSpeed.Enabled = false;
                    lblKeys.Enabled = false;
                    lblButton.Enabled = false;
                    break;
                }
                case (int)ActionEvent.EventTypes.MouseMove:
                {
                    numWaitMS.Enabled = false;
                    numMouseX.Enabled = true;
                    numMouseY.Enabled = true;
                    numMouseRX.Enabled = true;
                    numMouseRY.Enabled = true;
                    numMouseSpeed.Enabled = true;
                    txtKeys.Enabled = false;
                    cmbMouseButton.Enabled = false;

                    lblWait.Enabled = false;
                    lblMouseX.Enabled = true;
                    lblMouseY.Enabled = true;
                    lblMouseRX.Enabled = true;
                    lblMouseRY.Enabled = true;
                    lblMouseSpeed.Enabled = true;
                    lblKeys.Enabled = false;
                    lblButton.Enabled = false;
                    break;
                }
                case (int)ActionEvent.EventTypes.Keys:
                {
                    numWaitMS.Enabled = false;
                    numMouseX.Enabled = false;
                    numMouseY.Enabled = false;
                    numMouseRX.Enabled = false;
                    numMouseRY.Enabled = false;
                    numMouseSpeed.Enabled = false;
                    txtKeys.Enabled = true;
                    cmbMouseButton.Enabled = false;

                    lblWait.Enabled = false;
                    lblMouseX.Enabled = false;
                    lblMouseY.Enabled = false;
                    lblMouseRX.Enabled = false;
                    lblMouseRY.Enabled = false;
                    lblMouseSpeed.Enabled = false;
                    lblKeys.Enabled = true;
                    lblButton.Enabled = false;
                    break;
                }
                case (int)ActionEvent.EventTypes.MouseButton:
                {
                    numWaitMS.Enabled = false;
                    numMouseX.Enabled = false;
                    numMouseY.Enabled = false;
                    numMouseRX.Enabled = false;
                    numMouseRY.Enabled = false;
                    numMouseSpeed.Enabled = false;
                    txtKeys.Enabled = false;
                    cmbMouseButton.Enabled = true;

                    lblWait.Enabled = false;
                    lblMouseX.Enabled = false;
                    lblMouseY.Enabled = false;
                    lblMouseRX.Enabled = false;
                    lblMouseRY.Enabled = false;
                    lblMouseSpeed.Enabled = false;
                    lblKeys.Enabled = false;
                    lblButton.Enabled = true;
                    break;
                }
                
            }
                
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tmrCursUpdate.Stop();
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            switch(cmbEventType.SelectedIndex)
            {
                case (int)ActionEvent.EventTypes.Wait:
                {
                    
                    newEvent = new ActionEvent((int)numWaitMS.Value);
                    break;
                }
                case (int)ActionEvent.EventTypes.MouseMove:
                {
                    newEvent = new ActionEvent((int)numMouseX.Value, (int)numMouseY.Value, (int)numMouseRX.Value, (int)numMouseRY.Value, (int)numMouseSpeed.Value);
                    break;
                }
                case (int)ActionEvent.EventTypes.Keys:
                {
                    newEvent = new ActionEvent(txtKeys.Text);
                    break;
                }
                case (int)ActionEvent.EventTypes.MouseButton:
                {
                    newEvent = new ActionEvent((ActionEvent.MouseButton)cmbMouseButton.SelectedIndex);
                    break;
                }
            }

            returnEvent(newEvent, returnAddType);
            tmrCursUpdate.Stop();
            this.Close();
        }

        private void tmrCursUpdate_Tick(object sender, EventArgs e)
        {
            Point mousePos = Cursor.Position;
            lblXPos.Text = mousePos.X.ToString();
            lblYPos.Text = mousePos.Y.ToString();
        }


    }
}
