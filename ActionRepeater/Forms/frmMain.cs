using ActionRepeater.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ActionRepeater
{
    public partial class frmMain : Form
    {
        Thread playback;
        KeyboardHook keyHook = new KeyboardHook();

        public enum AddTypes
        {
            Add,
            Insert
        }

        public frmMain()
        {
            InitializeComponent();

            keyHook.KeyPressed += new EventHandler<KeyPressedEventArgs>(hook_KeyPressed);
            keyHook.RegisterHotKey(ActionRepeater.Forms.ModifierKeys.None, Keys.F5);
            
        }

        void hook_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            if (playback == null)
            {
                playback = new Thread(() => PlayActions());
                playback.Start();
            }
            else
            {
                if (playback.ThreadState == ThreadState.Aborted || playback.ThreadState == ThreadState.Stopped)
                {
                    playback = new Thread(() => PlayActions());
                    playback.Start();
                }
                else//if (playback.ThreadState == ThreadState.Running)
                {
                    playback.Abort();
                }
            }
        }

        private void ReloadEvents()
        {
            listEvents.Items.Clear();
            for(int i = 0; i < ActionEventSeries.GetInstance().Events.Count; i++)
            {
                AddEventToListIndex(i, ActionEventSeries.GetInstance().GetEvent(i));
            }
        }

        private void listEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listEvents.SelectedIndices.Count > 0)
            {
                btnInsertEvent.Enabled = true;
            }
        }

        private void listEvents_MouseUp(object sender, MouseEventArgs e)
        {
            if(listEvents.SelectedIndices.Count == 0)
            {
                btnInsertEvent.Enabled = false;
            }
        }

        private void listEvents_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                if(listEvents.SelectedIndices.Count > 0)
                {
                    DeleteEvent();
                }
                
            }
        }

        private void PlayActions()
        {
            int nLoops = (int)numLoops.Value;
            for (int i = nLoops; i > 0; i--)
            {
                ActionEventSeries.GetInstance().PlayEvents();
            }

        }

        private void DeleteEvent()
        {
            int index = listEvents.SelectedIndices[0];

            listEvents.Items.RemoveAt(index);
            ActionEventSeries.GetInstance().RemoveEvent(index);
            listEvents.Focus();

            if (index >= listEvents.Items.Count)
            {
                index -= 1;
            }

            if (listEvents.Items.Count > 0)
            {
                listEvents.Items[index].Selected = true;
            }
            else
            {
                ActionEventSeries.GetInstance().ClearEvents();
                listEvents.Items.Clear();
                listEvents.Focus();
                btnInsertEvent.Enabled = false;
            }
        }

        private void btnDeleteEvent_Click(object sender, EventArgs e)
        {
            if (listEvents.Items.Count > 0)
            {
                if (listEvents.SelectedIndices.Count > 0)
                {
                    DeleteEvent();
                }
            }
        }

        private void btnAddNewEvent_Click(object sender, EventArgs e)
        {
            frmAddEvent f = new frmAddEvent(RetrieveEvent, AddTypes.Add);
            f.Show();
            f.Focus();
        }

        private void btnInsertEvent_Click(object sender, EventArgs e)
        {
            frmAddEvent f = new frmAddEvent(RetrieveEvent, AddTypes.Insert);
            f.Show();
            f.Focus();
        }

        private void RetrieveEvent(ActionEvent ev, AddTypes addType)
        {
            switch(addType)
            {
                case AddTypes.Add:
                {
                    AddEventToIndex(listEvents.Items.Count, ev);
                    break;
                }
                case AddTypes.Insert:
                {
                    AddEventToIndex(listEvents.SelectedIndices[0], ev);
                    break;
                }
            }
        }

        private void AddEventToListIndex(int index, ActionEvent ev)
        {
            ListViewItem li = new ListViewItem();
            switch (ev.EventType)
            {
                case ActionEvent.EventTypes.Wait:
                    {
                        li.Text = "Wait " + ev.WaitTimeMS.ToString() + " ms";
                        break;
                    }
                case ActionEvent.EventTypes.MouseMove:
                    {
                        if(ev.Relative)
                        {
                            li.Text = "Move Mouse " + ev.Destination.X + ", " + ev.Destination.Y + " plus a random " + ev.DestRand.X + ", " + ev.DestRand.Y + ", at a speed of " + ev.MouseSpeed + " from the current position";
                        }
                        else
                        {
                            li.Text = "Move Mouse to " + ev.Destination.X + ", " + ev.Destination.Y + " plus a random " + ev.DestRand.X + ", " + ev.DestRand.Y + ", at a speed of " + ev.MouseSpeed;
                        }
                        break;
                    }
                case ActionEvent.EventTypes.MouseButton:
                    {
                        switch (ev.MButton)
                        {
                            case ActionEvent.MouseButton.Left:
                                {
                                    li.Text = "Left Click";
                                    break;
                                }
                            case ActionEvent.MouseButton.Right:
                                {
                                    li.Text = "Right Click";
                                    break;
                                }
                        }
                        break;
                    }
                case ActionEvent.EventTypes.Keys:
                    {
                        li.Text = "Send keys " + ev.Key;
                        break;
                    }
            }
            listEvents.Items.Insert(index, li);
            listEvents.Columns[0].Width = -1;
        }

        private void AddEventToIndex(int index, ActionEvent ev)
        {
            ListViewItem li = new ListViewItem();
            switch (ev.EventType)
            {
                case ActionEvent.EventTypes.Wait:
                {
                    li.Text = "Wait " + ev.WaitTimeMS.ToString() + " ms";
                    break;
                }
                case ActionEvent.EventTypes.MouseMove:
                {
                    if (ev.Relative)
                    {
                        li.Text = "Move Mouse " + ev.Destination.X + ", " + ev.Destination.Y + " plus a random " + ev.DestRand.X + ", " + ev.DestRand.Y + ", at a speed of " + ev.MouseSpeed + " from the current position";
                    }
                    else
                    {
                        li.Text = "Move Mouse to " + ev.Destination.X + ", " + ev.Destination.Y + " plus a random " + ev.DestRand.X + ", " + ev.DestRand.Y + ", at a speed of " + ev.MouseSpeed;
                    }
                    break;
                }
                case ActionEvent.EventTypes.MouseButton:
                {
                    switch(ev.MButton)
                    {
                        case ActionEvent.MouseButton.Left:
                        {
                            li.Text = "Left Click";
                            break;
                        }
                        case ActionEvent.MouseButton.Right:
                        {
                            li.Text = "Right Click";
                            break;
                        }
                    }
                    break;
                }
                case ActionEvent.EventTypes.Keys:
                {
                    li.Text = "Send key " + ev.Key;
                    break;
                }
            }
            listEvents.Items.Insert(index, li);
            listEvents.Columns[0].Width = -1;

            ActionEventSeries.GetInstance().InsertEvent(index, ev);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sfdMain.ShowDialog();
        }

        private void sfdMain_FileOk(object sender, CancelEventArgs e)
        {
            ActionEventSeries.GetInstance().SaveToFile(sfdMain.FileName);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            ofdMain.ShowDialog();
        }

        private void ofdMain_FileOk(object sender, CancelEventArgs e)
        {
            ActionEventSeries.LoadFromFile(ofdMain.FileName);

            ReloadEvents();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if(playback == null)
            {
                playback = new Thread(() => PlayActions());
                playback.Start();
            }
            else
            {
                if(playback.ThreadState == ThreadState.Aborted || playback.ThreadState == ThreadState.Stopped)
                {
                    playback = new Thread(() => PlayActions());
                    playback.Start();
                }
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if(playback != null)
            {
                //if(playback.ThreadState == ThreadState.Running)
                {
                    playback.Abort();
                }
            }
        }

    }
}
