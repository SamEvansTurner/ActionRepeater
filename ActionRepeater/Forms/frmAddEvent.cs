using System;
using System.Drawing;
using System.Windows.Forms;

namespace ActionRepeater.Forms {
    public partial class frmAddEvent : Form {
        public delegate void GrabEvent(ActionEvent ev);
        GrabEvent returnEvent;

        ActionEvent newEvent;

        public frmAddEvent(GrabEvent callback) {
            InitializeComponent();

            Text = "Add New Event";

            cmbEventType.SelectedIndex = 0;
            cmbMouseButton.SelectedIndex = 0;

            numMouseSpeed.Value = 15;

            cmbKey.DataSource = Enum.GetNames(typeof(InputImports.VirtualKeyShort));

            returnEvent = callback;

            tmrCursUpdate.Start();
            this.Icon = Properties.Resources.ActionRepeater;
        }

        public frmAddEvent(GrabEvent callback, ActionEvent evIn) {
            InitializeComponent();

            Text = "Edit Event";

            cmbEventType.SelectedIndex = 0;
            cmbMouseButton.SelectedIndex = 0;

            numMouseSpeed.Value = 15;

            cmbKey.DataSource = Enum.GetNames(typeof(InputImports.VirtualKeyShort));

            returnEvent = callback;

            tmrCursUpdate.Start();

            ProcessIncomingEvent(evIn);
            this.Icon = Properties.Resources.ActionRepeater;

        }

        private void cmbEventType_SelectedIndexChanged(object sender, EventArgs e) {
            switch (cmbEventType.SelectedIndex) {
                case (int)ActionEvent.EventTypes.Wait: {
                        numWaitMS.Enabled = true;
                        numMouseX.Enabled = false;
                        numMouseY.Enabled = false;
                        numMouseRX.Enabled = false;
                        numMouseRY.Enabled = false;
                        numMouseSpeed.Enabled = false;
                        cbRelative.Enabled = false;
                        cmbKey.Enabled = false;
                        cmbMouseButton.Enabled = false;
                        cbLinear.Enabled = true;

                        lblLinear.Enabled = true;
                        lblLinear.Text = "Fixed Duration";
                        lblWait.Enabled = true;
                        lblMouseX.Enabled = false;
                        lblMouseY.Enabled = false;
                        lblMouseRX.Enabled = false;
                        lblMouseRY.Enabled = false;
                        lblMouseSpeed.Enabled = false;
                        lblRelative.Enabled = false;
                        lblKeys.Enabled = false;
                        lblButton.Enabled = false;

                        numWaitMS.Focus();
                        break;
                    }
                case (int)ActionEvent.EventTypes.MouseMove: {
                        numWaitMS.Enabled = false;
                        numMouseX.Enabled = true;
                        numMouseY.Enabled = true;
                        numMouseRX.Enabled = true;
                        numMouseRY.Enabled = true;
                        numMouseSpeed.Enabled = true;
                        cbRelative.Enabled = true;
                        cmbKey.Enabled = false;
                        cmbMouseButton.Enabled = false;
                        cbLinear.Enabled = true;

                        lblLinear.Enabled = true;
                        lblLinear.Text = "Linear Movement";
                        lblWait.Enabled = false;
                        lblMouseX.Enabled = true;
                        lblMouseY.Enabled = true;
                        lblMouseRX.Enabled = true;
                        lblMouseRY.Enabled = true;
                        lblMouseSpeed.Enabled = true;
                        lblRelative.Enabled = true;
                        lblKeys.Enabled = false;
                        lblButton.Enabled = false;

                        numMouseX.Focus();
                        break;
                    }
                case (int)ActionEvent.EventTypes.Keys: {
                        numWaitMS.Enabled = false;
                        numMouseX.Enabled = false;
                        numMouseY.Enabled = false;
                        numMouseRX.Enabled = false;
                        numMouseRY.Enabled = false;
                        numMouseSpeed.Enabled = false;
                        cbRelative.Enabled = false;
                        cmbKey.Enabled = true;
                        cmbMouseButton.Enabled = false;
                        cbLinear.Enabled = false;
                        
                        
                        lblLinear.Enabled = false;
                        lblWait.Enabled = false;
                        lblMouseX.Enabled = false;
                        lblMouseY.Enabled = false;
                        lblMouseRX.Enabled = false;
                        lblMouseRY.Enabled = false;
                        lblMouseSpeed.Enabled = false;
                        lblRelative.Enabled = false;
                        lblKeys.Enabled = true;
                        lblButton.Enabled = false;

                        cmbKey.Focus();
                        break;
                    }
                case (int)ActionEvent.EventTypes.MouseButton: {
                        numWaitMS.Enabled = false;
                        numMouseX.Enabled = false;
                        numMouseY.Enabled = false;
                        numMouseRX.Enabled = false;
                        numMouseRY.Enabled = false;
                        numMouseSpeed.Enabled = false;
                        cbRelative.Enabled = false;
                        cmbKey.Enabled = false;
                        cmbMouseButton.Enabled = true;
                        cbLinear.Enabled = false;

                        lblLinear.Enabled = false;
                        lblWait.Enabled = false;
                        lblMouseX.Enabled = false;
                        lblMouseY.Enabled = false;
                        lblMouseRX.Enabled = false;
                        lblMouseRY.Enabled = false;
                        lblMouseSpeed.Enabled = false;
                        lblRelative.Enabled = false;
                        lblKeys.Enabled = false;
                        lblButton.Enabled = true;

                        cmbMouseButton.Focus();
                        break;
                    }

            }

        }

        private void btnCancel_Click(object sender, EventArgs e) {
            tmrCursUpdate.Stop();
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e) {
            ProcessEvent();

        }

        private void ProcessEvent() {
            switch (cmbEventType.SelectedIndex) {
                case (int)ActionEvent.EventTypes.Wait: {
                        newEvent = new ActionEvent((int)numWaitMS.Value);
                        newEvent.Linear = cbLinear.Checked;
                        break;
                    }
                case (int)ActionEvent.EventTypes.MouseMove: {
                        newEvent = new ActionEvent((int)numMouseX.Value, (int)numMouseY.Value, (int)numMouseRX.Value, (int)numMouseRY.Value, (int)numMouseSpeed.Value, cbRelative.Checked, cbLinear.Checked);
                        break;
                    }
                case (int)ActionEvent.EventTypes.Keys: {
                        newEvent = new ActionEvent((InputImports.VirtualKeyShort)Enum.Parse(typeof(InputImports.VirtualKeyShort), (string)cmbKey.SelectedItem));
                        break;
                    }
                case (int)ActionEvent.EventTypes.MouseButton: {
                        ActionEvent.MouseButton mb = ActionEvent.MouseButton.Left;
                        switch (cmbMouseButton.SelectedIndex) {
                            case 0:
                                mb = ActionEvent.MouseButton.Left;
                                break;
                            case 1:
                                mb = ActionEvent.MouseButton.Right;
                                break;
                        }
                        newEvent = new ActionEvent(mb);
                        break;
                    }
            }

            returnEvent(newEvent);
            tmrCursUpdate.Stop();
            this.Close();
        }

        private void ProcessIncomingEvent(ActionEvent evIn) {
            cmbEventType.SelectedIndex = (int)evIn.EventType;
            switch (cmbEventType.SelectedIndex) {
                case (int)ActionEvent.EventTypes.Wait: {

                        numWaitMS.Value = evIn.WaitTimeMS;
                        cbLinear.Checked = evIn.Linear;
                        break;
                    }
                case (int)ActionEvent.EventTypes.MouseMove: {
                        numMouseX.Value = evIn.Destination.X;
                        numMouseY.Value = evIn.Destination.Y;
                        numMouseRX.Value = evIn.DestRand.X;
                        numMouseRY.Value = evIn.DestRand.Y;
                        numMouseSpeed.Value = evIn.MouseSpeed;
                        cbRelative.Checked = evIn.Relative;
                        cbLinear.Checked = evIn.Linear;
                        break;
                    }
                case (int)ActionEvent.EventTypes.Keys: {
                        for (int i = 0; i < cmbKey.Items.Count; i++) {
                            if ((string)cmbKey.Items[i] == Enum.GetName(typeof(InputImports.VirtualKeyShort), evIn.Key)) {
                                cmbKey.SelectedIndex = i;
                            }
                        }
                        break;
                    }
                case (int)ActionEvent.EventTypes.MouseButton: {
                        switch (evIn.MButton) {
                            case ActionEvent.MouseButton.Left:
                                cmbMouseButton.SelectedIndex = 0;
                                break;
                            case ActionEvent.MouseButton.Right:
                                cmbMouseButton.SelectedIndex = 1;
                                break;
                            default:
                                break;
                        }
                        break;
                    }
            }
        }

        private void tmrCursUpdate_Tick(object sender, EventArgs e) {
            Point mousePos = Cursor.Position;
            lblXPos.Text = mousePos.X.ToString();
            lblYPos.Text = mousePos.Y.ToString();
        }

        private void numMouseX_Enter(object sender, EventArgs e) {
            numMouseX.Select(0, numMouseX.Value.ToString().Length);
        }

        private void numMouseY_Enter(object sender, EventArgs e) {
            numMouseY.Select(0, numMouseY.Value.ToString().Length);
        }

        private void numMouseRX_Enter(object sender, EventArgs e) {
            numMouseRX.Select(0, numMouseRX.Value.ToString().Length);
        }

        private void numMouseRY_Enter(object sender, EventArgs e) {
            numMouseRY.Select(0, numMouseRY.Value.ToString().Length);
        }

        private void numWaitMS_Enter(object sender, EventArgs e) {
            numWaitMS.Select(0, numWaitMS.Value.ToString().Length);
        }

        private void numMouseSpeed_Enter(object sender, EventArgs e) {
            numMouseSpeed.Select(0, numMouseSpeed.Value.ToString().Length);
        }


        private void numWaitMS_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                ProcessEvent();
            }
        }

        private void numMouseX_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                ProcessEvent();
            }
        }

        private void numMouseY_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                ProcessEvent();
            }
        }

        private void numMouseRX_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                ProcessEvent();
            }
        }

        private void numMouseRY_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                ProcessEvent();
            }
        }

        private void numMouseSpeed_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                ProcessEvent();
            }
        }

        private void cmbKey_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                ProcessEvent();
            }
        }

        private void cmbMouseButton_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                ProcessEvent();
            }
        }


    }
}
