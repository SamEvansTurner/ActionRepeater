namespace ActionRepeater
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.listEvents = new System.Windows.Forms.ListView();
            this.columnEventType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddNewEvent = new System.Windows.Forms.Button();
            this.btnInsertEvent = new System.Windows.Forms.Button();
            this.btnDeleteEvent = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
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
            this.btnAddNewEvent.Click += new System.EventHandler(this.btnAddNewEvent_Click);
            // 
            // btnInsertEvent
            // 
            this.btnInsertEvent.Enabled = false;
            this.btnInsertEvent.Location = new System.Drawing.Point(165, 634);
            this.btnInsertEvent.Name = "btnInsertEvent";
            this.btnInsertEvent.Size = new System.Drawing.Size(138, 46);
            this.btnInsertEvent.TabIndex = 2;
            this.btnInsertEvent.Text = "Insert Event above cursor";
            this.btnInsertEvent.UseVisualStyleBackColor = true;
            this.btnInsertEvent.Click += new System.EventHandler(this.btnInsertEvent_Click);
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(227, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(321, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.Location = new System.Drawing.Point(31, 13);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(56, 56);
            this.btnPlay.TabIndex = 7;
            this.btnPlay.TabStop = false;
            this.btnPlay.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 693);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDeleteEvent);
            this.Controls.Add(this.btnInsertEvent);
            this.Controls.Add(this.btnAddNewEvent);
            this.Controls.Add(this.listEvents);
            this.Name = "frmMain";
            this.Text = "ActionRepeater";
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listEvents;
        private System.Windows.Forms.ColumnHeader columnEventType;
        private System.Windows.Forms.ColumnHeader columnData;
        private System.Windows.Forms.Button btnAddNewEvent;
        private System.Windows.Forms.Button btnInsertEvent;
        private System.Windows.Forms.Button btnDeleteEvent;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox btnPlay;
    }
}

