using ActionRepeater.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;


namespace ActionRepeater {
    public partial class frmMain : Form {
        Thread tPlayback;
        KeyboardHook keyHook = new KeyboardHook();
        private List<ListView> arrTabs = new List<ListView>();
        private bool bRunning = false;
        public delegate void LoopEnd();
        private AddTypes addType = AddTypes.Add;
        public enum AddTypes {
            Add,
            Insert,
            Edit
        }

        public frmMain() {
            InitializeComponent();
            arrTabs.Add(listBefore);
            arrTabs.Add(listLoopEvents);
            arrTabs.Add(listAfter);
            keyHook.KeyPressed += new EventHandler<KeyPressedEventArgs>(hook_KeyPressed);
            keyHook.RegisterHotKey(ActionRepeater.ModifierKeys.None, Keys.F5);
            this.Icon = Properties.Resources.ActionRepeater;
            tabPages.SelectedTab = tabPages.TabPages["tabLoop"];
            ActionEventSeries.GetInstance().FinishedCallback = LoopCallback;
        }

        private void LoopCallback() {
            LoopEnd LoopEndActions = new LoopEnd(DecreaseRemaining);
            this.BeginInvoke(LoopEndActions, null);
        }
        private void DecreaseRemaining() {
            numRemaining.Value = Math.Max(0, numRemaining.Value - 1);
        }

        private void ReloadEvents() {
            for (int i = 0; i < tabPages.TabPages.Count; i++) {
                arrTabs[i].Items.Clear();
                List<ActionEvent> li = ActionEventSeries.GetInstance().EventQueues[i];
                foreach (ActionEvent e in li) {
                    AddEventToList(i, e);
                }
            }
            numLoops.Value = ActionEventSeries.GetInstance().Loops;
        }

        private void listEvents_SelectedIndexChanged(object sender, EventArgs e) {
            if (arrTabs[tabPages.SelectedIndex].SelectedIndices.Count > 0) {
                EnableButtons(true);
            }
        }

        private void listEvents_MouseUp(object sender, MouseEventArgs e) {
            if (arrTabs[tabPages.SelectedIndex].SelectedIndices.Count == 0) {
                EnableButtons(false);
            }
        }

        private void listEvents_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Delete) {
                if (arrTabs[tabPages.SelectedIndex].SelectedIndices.Count > 0) {
                    DeleteEvent();
                }
            }
        }

        private void DeleteEvent() {
            int iTab = tabPages.SelectedIndex;
            ListView listEvents = arrTabs[iTab];
            int index = arrTabs[tabPages.SelectedIndex].SelectedIndices[0];

            listEvents.Items.RemoveAt(index);
            ActionEventSeries.GetInstance().RemoveEvent(iTab, index);
            listEvents.Focus();

            if (index >= arrTabs[tabPages.SelectedIndex].Items.Count) {
                index -= 1;
            }

            if (listEvents.Items.Count > 0) {
                listEvents.Items[index].Selected = true;
            } else {
                ActionEventSeries.GetInstance().ClearEvents(iTab);
                listEvents.Items.Clear();
                listEvents.Focus();
                EnableButtons(false);
            }
        }

        private void btnDeleteEvent_Click(object sender, EventArgs e) {
            ListView listEvents = arrTabs[tabPages.SelectedIndex];
            if (listEvents.Items.Count > 0) {
                if (listEvents.SelectedIndices.Count > 0) {
                    DeleteEvent();
                }
            }
        }

        private void btnAddNewEvent_Click(object sender, EventArgs e) {
            addType = AddTypes.Add;
            frmAddEvent f = new frmAddEvent(RetrieveEvent);
            f.Show();
            f.Focus();
        }

        private void btnInsertEvent_Click(object sender, EventArgs e) {
            addType = AddTypes.Insert;
            frmAddEvent f = new frmAddEvent(RetrieveEvent);
            f.Show();
            f.Focus();
        }
        private void btnEdit_Click(object sender, EventArgs e) {
            addType = AddTypes.Edit;
            int iTab = tabPages.SelectedIndex;
            int iEventIndex = arrTabs[iTab].SelectedItems[0].Index;
            ActionEvent ev = ActionEventSeries.GetInstance().EventQueues[iTab][iEventIndex];
            frmAddEvent f = new frmAddEvent(UpdateEvent, ev);
            f.Show();
            f.Focus();
        }

        private void RetrieveEvent(ActionEvent ev) {
            int iTab = tabPages.SelectedIndex;
            ListView listEvents = arrTabs[iTab];
            switch (addType) {
                case AddTypes.Add: {
                        AddEventToIndex(iTab, ev);
                        break;
                    }
                case AddTypes.Insert: {
                        AddEventToIndex(iTab, ev, listEvents.SelectedIndices[0]);
                        break;
                    }
            }
        }

        private void UpdateEvent(ActionEvent ev) {
            int iTab = tabPages.SelectedIndex;
            ListView listEvents = arrTabs[iTab];
            int iPrevIndex = listEvents.SelectedIndices[0];
            AddEventToIndex(iTab, ev, iPrevIndex);
            DeleteEvent();
            int iIndex = listEvents.SelectedIndices[0];
            if (iPrevIndex != iIndex) {
                listEvents.Items[iIndex].Selected = false;
                listEvents.Items[iPrevIndex].Selected = true;
            }


        }

        private void RetrieveEvents(List<ActionEvent> ev) {
            List<ActionEvent> li = ActionEventSeries.GetInstance().EventQueues[tabPages.SelectedIndex];
            li.Clear();
            li.AddRange(ev);
            ReloadEvents();
        }


        private void AddEventToList(int queue, ActionEvent ev, int index = -1) {
            ListView listEvents = arrTabs[queue];
            if (index == -1) {
                index = listEvents.Items.Count;
            }
            ListViewItem li = new ListViewItem();
            li.Text = ev.ToString();
            listEvents.Items.Insert(index, li);
            listEvents.Columns[0].Width = -1;
        }

        private void AddEventToIndex(int queue, ActionEvent ev, int index = -1) {
            if (index == -1) {
                index = ActionEventSeries.GetInstance().EventQueues[queue].Count;
            }
            AddEventToList(queue, ev, index);
            ActionEventSeries.GetInstance().InsertEvent(queue, index, ev);
        }

        private void btnSave_Click(object sender, EventArgs e) {
            sfdMain.ShowDialog();
        }

        private void sfdMain_FileOk(object sender, CancelEventArgs e) {
            ActionEventSeries.GetInstance().SaveToFile(sfdMain.FileName);
        }

        private void btnLoad_Click(object sender, EventArgs e) {
            ofdMain.ShowDialog();
        }

        private void ofdMain_FileOk(object sender, CancelEventArgs e) {
            ActionEventSeries.LoadFromFile(ofdMain.FileName);

            ReloadEvents();
        }

        private void btnPlay_Click(object sender, EventArgs e) {
            StartStop(true);
        }

        private void btnStop_Click(object sender, EventArgs e) {
            StartStop(false);
        }

        private void EnableButtons(bool bEnable) {
            btnInsertEvent.Enabled = bEnable;
            btnEdit.Enabled = bEnable;
            btnDeleteEvent.Enabled = bEnable;
        }

        private void StartStop(bool start) {
            if (start) {
                if (tPlayback != null) {
                    tPlayback.Abort();
                    tPlayback = null;
                }
                numRemaining.Value = numLoops.Value;
                tPlayback = new Thread(() => PlayActions());
                tPlayback.Start();
            } else {
                tPlayback.Abort();
                tPlayback = null;
            }
            bRunning = start;
            PlayStopButtons(start);
        }
        private void PlayActions() {
            try {
                ActionEventSeries.GetInstance().PlayEvents();
            } finally {
                LoopEnd LoopEndActions = new LoopEnd(EndActions);
                this.BeginInvoke(LoopEndActions, null);
            }
        }

        private void EndActions() {
            bRunning = false;
            PlayStopButtons(false);
        }

        void hook_KeyPressed(object sender, KeyPressedEventArgs e) {
            StartStop(!bRunning);
        }

        private void PlayStopButtons(bool playbackRunning) {
            btnPlay.Enabled = !playbackRunning;
            btnStop.Enabled = playbackRunning;
            if (playbackRunning) {
                btnPlay.Image = Properties.Resources.btnPlay_Disabled;
                btnStop.Image = Properties.Resources.btnStop_Enabled;
            } else {
                btnPlay.Image = Properties.Resources.btnPlay_Enabled;
                btnStop.Image = Properties.Resources.btnStop_Disabled;
            }

        }

        private void numLoops_ValueChanged(object sender, EventArgs e) {
            ActionEventSeries.GetInstance().Loops = (int)numLoops.Value;
            numRemaining.Value = numLoops.Value;
        }

        private void btnRecord_Click(object sender, EventArgs e) {
            frmRecord f = new frmRecord(RetrieveEvents);
            f.Show();
            f.Focus();
        }

        private void tabPages_Selected(object sender, TabControlEventArgs e) {
            int iTab = tabPages.SelectedIndex;
            foreach (ListViewItem li in arrTabs[iTab].SelectedItems) {
                li.Selected = false;
            }
            EnableButtons(false);

        }

        private void list_MouseDoubleClick(object sender, MouseEventArgs e) {
            
            addType = AddTypes.Edit;
            int iTab = tabPages.SelectedIndex;
            if (arrTabs[iTab].SelectedItems.Count > 0) {
                int iEventIndex = arrTabs[iTab].SelectedItems[0].Index;
                ActionEvent ev = ActionEventSeries.GetInstance().EventQueues[iTab][iEventIndex];
                frmAddEvent f = new frmAddEvent(UpdateEvent, ev);
                f.Show();
                f.Focus();
            }
            
        }
    }
}
