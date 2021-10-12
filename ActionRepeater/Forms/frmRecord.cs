using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ActionRepeater.Forms {
    public partial class frmRecord : Form {
        public delegate void GrabEvents(List<ActionEvent> ev);
        GrabEvents returnEvent;

        KeyboardHook keyHook = new KeyboardHook();

        private bool bRecording = false;

        private frmHighlight fHighlight = new frmHighlight();
        private frmSpeedLabel fLabel = new frmSpeedLabel();

        private int iRandAreaSize = 15;
        private int iMouseSpeed = 15;

        private int iLastEventTime = -1;
        private int iLastX = 0;
        private int iLastY = 0;

        private bool bLinear = false;
        private bool bWaitDone = false;

        private Point pLastMouse = new Point();

        private List<ActionEvent> lEventList = new List<ActionEvent>();
        private List<ActionEvent> lWaits = new List<ActionEvent>();

        private frmRecordHelp fHelp;


        public frmRecord(GrabEvents callback) {
            InitializeComponent();

            returnEvent = callback;

            keyHook.KeyPressed += new EventHandler<KeyPressedEventArgs>(hook_KeyPressed);
            keyHook.RegisterHotKey(ActionRepeater.ModifierKeys.None, Keys.F2);

            fHighlight.Size = new Size(iRandAreaSize, iRandAreaSize);
            fLabel.SpeedLabel.Text = "Speed: " + iMouseSpeed;

            this.Icon = Properties.Resources.ActionRepeater;

            MouseRecord.SetCallBack(MouseRecordEvent);
            KeyRecord.SetCallBack(KeyRecordEvent);
        }

        void hook_KeyPressed(object sender, KeyPressedEventArgs e) {
            StartStopRecording();
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing) {
                if (bRecording) {
                    StartStopRecording();
                }
                keyHook.Dispose();
                fHighlight.Dispose();
                fLabel.Dispose();
                if (components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e) {
            returnEvent(lEventList);
            this.Close();
        }

        private void EventProc(ActionEvent inEv) {
            ListViewItem li = new ListViewItem();
            li.Text = inEv.ToString();
            listViewActions.Items.Add(li);
            listViewActions.Columns[0].Width = -1;
            listViewActions.EnsureVisible(listViewActions.Items.Count - 1);
            lEventList.Add(inEv);
        }

        private void MouseRecordEvent(MouseRecord.MouseEvent mEv, int time) {
            if (mEv.mb == ActionEvent.MouseButton.Wheel) {
                iRandAreaSize += (mEv.delta / 120);

                if (mEv.delta % 120 != 0) {
                    if (mEv.delta > 0) {
                        iRandAreaSize += 1;
                    } else {
                        iRandAreaSize -= 1;
                    }
                }
                fHighlight.Size = new Size(iRandAreaSize, iRandAreaSize);
            } else if (mEv.mb == ActionEvent.MouseButton.ControlWheel) {
                iMouseSpeed += (mEv.delta / 120);

                if (mEv.delta % 120 != 0) {
                    if (mEv.delta > 0) {
                        iMouseSpeed += 1;
                    } else {
                        iMouseSpeed -= 1;
                    }
                }
                if (iMouseSpeed > 30) {
                    iMouseSpeed = 30;
                }
                if (iMouseSpeed < 5) {
                    iMouseSpeed = 5;
                }
                fLabel.SpeedLabel.Text = "Speed: " + iMouseSpeed;
            } else if (mEv.mb == ActionEvent.MouseButton.Left || mEv.mb == ActionEvent.MouseButton.Right) {
                if (iLastEventTime < 0) {
                    iLastEventTime = time;
                    iLastX = mEv.x;
                    iLastY = mEv.y;
                } else {
                    int iTime = time - iLastEventTime;
                    if (iLastX != mEv.x || iLastY != mEv.y) {
                        int iCurrSpeed = iMouseSpeed;
                        if(bLinear) {
                            iCurrSpeed = MouseMover.LinearSpeedForTime(iLastX, iLastY, mEv.x, mEv.y, iTime);
                        }
                        ActionEvent ev = new ActionEvent(mEv.x, mEv.y, iRandAreaSize, iRandAreaSize, iCurrSpeed, false);
                        ev.Linear = bLinear;
                        bWaitDone = false;
                        EventProc(ev);
                    } else {
                        ActionEvent ev = new ActionEvent(iTime);
                        ev.Linear = bLinear;
                        EventProc(ev);
                    }
                    ActionEvent ev2 = new ActionEvent(mEv.mb);
                    EventProc(ev2);
                    iLastEventTime = time;
                    iLastX = mEv.x;
                    iLastY = mEv.y;
                }

            } else {
                if (iLastEventTime < 0) {
                    iLastEventTime = time;
                    iLastX = mEv.x;
                    iLastY = mEv.y;
                } else {
                    int iTime = time - iLastEventTime;
                    if (!bWaitDone) {
                        bWaitDone = true;
                        ActionEvent ev = new ActionEvent(iTime);
                        ev.Linear = bLinear;
                        EventProc(ev);
                        iLastEventTime = time;
                        iLastX = mEv.x;
                        iLastY = mEv.y;
                    }
                }
                
            }

        }

        private void KeyRecordEvent(InputImports.VirtualKeyShort keyPressed, int time) {
            if (iLastEventTime >= 0) {
                int iTime = time - iLastEventTime;
                ActionEvent ev = new ActionEvent(iTime);
                ev.Linear = bLinear;
                EventProc(ev);
                iLastEventTime = time;
            }
            ActionEvent ev2 = new ActionEvent(keyPressed);
            EventProc(ev2);
            iLastEventTime = time;
            
        }

        void StartStopRecording() {
            bRecording = !bRecording;

            KeyRecord.StartStopRecording();
            MouseRecord.StartStopRecording();

            iLastEventTime = Environment.TickCount;
            iLastX = Cursor.Position.X;
            iLastY = Cursor.Position.Y;

            if (!bRecording) {
                fHighlight.Hide();
                fLabel.Hide();
                FinishActions();
                iLastEventTime = -1;
            } else {
                fHighlight.Show();
                if (!bLinear) {
                    fLabel.Show();
                }
            }
        }

        private void FinishActions() {
            foreach (InputImports.VirtualKeyShort key in KeyRecord.Events) {
                Console.Write(key);
            }
            Console.WriteLine("");
        }
        private void btnStartStop_Click(object sender, EventArgs e) {
            StartStopRecording();
        }

        private void btnHelp_Click(object sender, EventArgs e) {
            fHelp = new frmRecordHelp();
            fHelp.Show();
            fHelp.Focus();
        }

        private void btnLinear_Click(object sender, EventArgs e) {
            bLinear = !bLinear;
            if(bLinear) {
                btnLinear.Text = "Disable Linear";
            } else {
                btnLinear.Text = "Enable Linear";
            }
        }
    }
}
