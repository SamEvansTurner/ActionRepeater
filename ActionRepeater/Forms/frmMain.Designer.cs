namespace MacroRecorder
{
    partial class frmMain
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
            this.listEvents = new System.Windows.Forms.ListView();
            this.columnEventType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddNewEvent = new System.Windows.Forms.Button();
            this.btnInsertEvent = new System.Windows.Forms.Button();
            this.btnDeleteEvent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listEvents
            // 
            this.listEvents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnEventType,
            this.columnData});
            this.listEvents.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listEvents.HideSelection = false;
            this.listEvents.LabelWrap = false;
            this.listEvents.Location = new System.Drawing.Point(12, 75);
            this.listEvents.MultiSelect = false;
            this.listEvents.Name = "listEvents";
            this.listEvents.Size = new System.Drawing.Size(445, 553);
            this.listEvents.TabIndex = 0;
            this.listEvents.UseCompatibleStateImageBehavior = false;
            this.listEvents.View = System.Windows.Forms.View.Details;
            this.listEvents.SelectedIndexChanged += new System.EventHandler(this.listEvents_SelectedIndexChanged);
            this.listEvents.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listEvents_KeyDown);
            this.listEvents.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listEvents_MouseUp);
            // 
            // columnEventType
            // 
            this.columnEventType.Text = "Event Type";
            // 
            // columnData
            // 
            this.columnData.Text = "Data";
            // 
            // btnAddNewEvent
            // 
            this.btnAddNewEvent.Location = new System.Drawing.Point(12, 635);
            this.btnAddNewEvent.Name = "btnAddNewEvent";
            this.btnAddNewEvent.Size = new System.Drawing.Size(138, 46);
            this.btnAddNewEvent.TabIndex = 1;
            this.btnAddNewEvent.Text = "Add Event";
            this.btnAddNewEvent.UseVisualStyleBackColor = true;
            // 
            // btnInsertEvent
            // 
            this.btnInsertEvent.Location = new System.Drawing.Point(165, 634);
            this.btnInsertEvent.Name = "btnInsertEvent";
            this.btnInsertEvent.Size = new System.Drawing.Size(138, 46);
            this.btnInsertEvent.TabIndex = 2;
            this.btnInsertEvent.Text = "Insert Event above cursor";
            this.btnInsertEvent.UseVisualStyleBackColor = true;
            // 
            // btnDeleteEvent
            // 
            this.btnDeleteEvent.Location = new System.Drawing.Point(321, 634);
            this.btnDeleteEvent.Name = "btnDeleteEvent";
            this.btnDeleteEvent.Size = new System.Drawing.Size(138, 46);
            this.btnDeleteEvent.TabIndex = 3;
            this.btnDeleteEvent.Text = "Delete Event";
            this.btnDeleteEvent.UseVisualStyleBackColor = true;
            this.btnDeleteEvent.Click += new System.EventHandler(this.btnDeleteEvent_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 693);
            this.Controls.Add(this.btnDeleteEvent);
            this.Controls.Add(this.btnInsertEvent);
            this.Controls.Add(this.btnAddNewEvent);
            this.Controls.Add(this.listEvents);
            this.Name = "frmMain";
            this.Text = "ActionRepeater";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listEvents;
        private System.Windows.Forms.ColumnHeader columnEventType;
        private System.Windows.Forms.ColumnHeader columnData;
        private System.Windows.Forms.Button btnAddNewEvent;
        private System.Windows.Forms.Button btnInsertEvent;
        private System.Windows.Forms.Button btnDeleteEvent;
    }
}

