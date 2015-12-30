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
            this.btnAddNewEvent = new System.Windows.Forms.Button();
            this.btnInsertEvent = new System.Windows.Forms.Button();
            this.btnDeleteEvent = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.PictureBox();
            this.btnLoad = new System.Windows.Forms.PictureBox();
            this.sfdMain = new System.Windows.Forms.SaveFileDialog();
            this.ofdMain = new System.Windows.Forms.OpenFileDialog();
            this.lblRepeats = new System.Windows.Forms.Label();
            this.numLoops = new System.Windows.Forms.NumericUpDown();
            this.btnStop = new System.Windows.Forms.PictureBox();
            this.btnAfterLoopsEvents = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLoops)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).BeginInit();
            this.SuspendLayout();
            // 
            // listEvents
            // 
            this.listEvents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnEventType});
            this.listEvents.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listEvents.HideSelection = false;
            this.listEvents.LabelWrap = false;
            this.listEvents.Location = new System.Drawing.Point(12, 75);
            this.listEvents.MultiSelect = false;
            this.listEvents.Name = "listEvents";
            this.listEvents.Size = new System.Drawing.Size(445, 501);
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
            // btnPlay
            // 
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.Location = new System.Drawing.Point(12, 13);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(56, 56);
            this.btnPlay.TabIndex = 7;
            this.btnPlay.TabStop = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(337, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(56, 56);
            this.btnSave.TabIndex = 8;
            this.btnSave.TabStop = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.Location = new System.Drawing.Point(401, 13);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(56, 56);
            this.btnLoad.TabIndex = 9;
            this.btnLoad.TabStop = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // sfdMain
            // 
            this.sfdMain.DefaultExt = "arm";
            this.sfdMain.Filter = "Action Repeater Macro File (*.arm)|*.arm";
            this.sfdMain.FileOk += new System.ComponentModel.CancelEventHandler(this.sfdMain_FileOk);
            // 
            // ofdMain
            // 
            this.ofdMain.DefaultExt = "arm";
            this.ofdMain.Filter = "Action Repeater Macro File|*.arm";
            this.ofdMain.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdMain_FileOk);
            // 
            // lblRepeats
            // 
            this.lblRepeats.AutoSize = true;
            this.lblRepeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepeats.Location = new System.Drawing.Point(141, 30);
            this.lblRepeats.Name = "lblRepeats";
            this.lblRepeats.Size = new System.Drawing.Size(57, 20);
            this.lblRepeats.TabIndex = 10;
            this.lblRepeats.Text = "Loops:";
            // 
            // numLoops
            // 
            this.numLoops.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLoops.Location = new System.Drawing.Point(204, 28);
            this.numLoops.Maximum = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            this.numLoops.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLoops.Name = "numLoops";
            this.numLoops.Size = new System.Drawing.Size(120, 26);
            this.numLoops.TabIndex = 11;
            this.numLoops.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnStop
            // 
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.Location = new System.Drawing.Point(76, 13);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(56, 56);
            this.btnStop.TabIndex = 12;
            this.btnStop.TabStop = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnAfterLoopsEvents
            // 
            this.btnAfterLoopsEvents.Location = new System.Drawing.Point(13, 582);
            this.btnAfterLoopsEvents.Name = "btnAfterLoopsEvents";
            this.btnAfterLoopsEvents.Size = new System.Drawing.Size(444, 46);
            this.btnAfterLoopsEvents.TabIndex = 13;
            this.btnAfterLoopsEvents.Text = "Execute events after loops are complete";
            this.btnAfterLoopsEvents.UseVisualStyleBackColor = true;
            this.btnAfterLoopsEvents.Click += new System.EventHandler(this.btnAfterLoopsEvents_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 693);
            this.Controls.Add(this.btnAfterLoopsEvents);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.numLoops);
            this.Controls.Add(this.lblRepeats);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnDeleteEvent);
            this.Controls.Add(this.btnInsertEvent);
            this.Controls.Add(this.btnAddNewEvent);
            this.Controls.Add(this.listEvents);
            this.Name = "frmMain";
            this.Text = "ActionRepeater";
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLoops)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listEvents;
        private System.Windows.Forms.ColumnHeader columnEventType;
        private System.Windows.Forms.Button btnAddNewEvent;
        private System.Windows.Forms.Button btnInsertEvent;
        private System.Windows.Forms.Button btnDeleteEvent;
        private System.Windows.Forms.PictureBox btnPlay;
        private System.Windows.Forms.PictureBox btnSave;
        private System.Windows.Forms.PictureBox btnLoad;
        private System.Windows.Forms.SaveFileDialog sfdMain;
        private System.Windows.Forms.OpenFileDialog ofdMain;
        private System.Windows.Forms.Label lblRepeats;
        private System.Windows.Forms.NumericUpDown numLoops;
        private System.Windows.Forms.PictureBox btnStop;
        private System.Windows.Forms.Button btnAfterLoopsEvents;
    }
}

