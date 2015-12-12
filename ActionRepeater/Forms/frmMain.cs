using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MacroRecorder
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            listEvents.Items.Add("SERER");
            listEvents.Items.Add("kerjekr");
            
        }

        private void ReloadEvents()
        {

        }

        private void listEvents_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void DeleteEvent()
        {
            int index = listEvents.SelectedIndices[0];

            listEvents.Items.RemoveAt(index);
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

    }
}
