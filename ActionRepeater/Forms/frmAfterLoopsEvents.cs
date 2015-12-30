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
    public partial class frmAfterLoopsEvents : Form
    {
        Thread playback;

        public enum AddTypes
        {
            Add,
            Insert
        }

        public frmAfterLoopsEvents()
        {
            InitializeComponent();
        }

        public void ReloadEventsEAL()
        {
            listEventsEAL.Items.Clear();
            for(int i = 0; i < ActionEventSeries.GetInstance().EventsAfterLoops.Count; i++)
            {
                AddEventToListIndex(i, ActionEventSeries.GetInstance().GetEvent(i));
            }
        }

        private void listEventsEAL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listEventsEAL.SelectedIndices.Count > 0)
            {
                btnInsertEventEAL.Enabled = true;
            }
        }

        private void listEventsEAL_MouseUp(object sender, MouseEventArgs e)
        {
            if(listEventsEAL.SelectedIndices.Count == 0)
            {
                btnInsertEventEAL.Enabled = false;
            }
        }

        private void listEventsEAL_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                if(listEventsEAL.SelectedIndices.Count > 0)
                {
                    DeleteEvent();
                }
                
            }
        }

        private void DeleteEvent()
        {
            int index = listEventsEAL.SelectedIndices[0];

            listEventsEAL.Items.RemoveAt(index);
            ActionEventSeries.GetInstance().RemoveEvent(index);
            listEventsEAL.Focus();

            if (index >= listEventsEAL.Items.Count)
            {
                index -= 1;
            }

            if (listEventsEAL.Items.Count > 0)
            {
                listEventsEAL.Items[index].Selected = true;
            }
            else
            {
                ActionEventSeries.GetInstance().ClearEvents();
                listEventsEAL.Items.Clear();
                listEventsEAL.Focus();
                btnInsertEventEAL.Enabled = false;
            }
        }

        private void btnDeleteEventEAL_Click(object sender, EventArgs e)
        {
            if (listEventsEAL.Items.Count > 0)
            {
                if (listEventsEAL.SelectedIndices.Count > 0)
                {
                    DeleteEvent();
                }
            }
        }

        private void btnAddNewEventEAL_Click(object sender, EventArgs e)
        {
            frmAddEvent f = new frmAddEvent(RetrieveEventEAL, frmMain.AddTypes.Add, frmMain.AddPos.AfterLoops);
            f.Show();
            f.Focus();
        }

        private void btnInsertEventEAL_Click(object sender, EventArgs e)
        {
            frmAddEvent f = new frmAddEvent(RetrieveEventEAL, frmMain.AddTypes.Insert, frmMain.AddPos.AfterLoops);
            f.Show();
            f.Focus();
        }

        private void RetrieveEventEAL(ActionEvent ev, frmMain.AddTypes addType)
        {
            switch(addType)
            {
                case frmMain.AddTypes.Add:
                {
                    AddEventToIndex(listEventsEAL.Items.Count, ev);
                    break;
                }
                case frmMain.AddTypes.Insert:
                {
                    AddEventToIndex(listEventsEAL.SelectedIndices[0], ev);
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
            listEventsEAL.Items.Insert(index, li);
            listEventsEAL.Columns[0].Width = -1;
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
            listEventsEAL.Items.Insert(index, li);
            listEventsEAL.Columns[0].Width = -1;

            ActionEventSeries.GetInstance().InsertEventToAfterLoops(index, ev);
        }

        private void btnCloseEAL_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


    }
}
