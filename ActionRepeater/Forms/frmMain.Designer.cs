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
            this.btnAddNewEvent = new System.Windows.Forms.Button();
            this.btnInsertEvent = new System.Windows.Forms.Button();
            this.btnDeleteEvent = new System.Windows.Forms.Button();
            this.sfdMain = new System.Windows.Forms.SaveFileDialog();
            this.ofdMain = new System.Windows.Forms.OpenFileDialog();
            this.lblRepeats = new System.Windows.Forms.Label();
            this.numLoops = new System.Windows.Forms.NumericUpDown();
            this.tabPages = new System.Windows.Forms.TabControl();
            this.tabBefore = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.listBefore = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabLoop = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.listLoopEvents = new System.Windows.Forms.ListView();
            this.columnEventType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabAfter = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.listAfter = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.PictureBox();
            this.btnLoad = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numLoops)).BeginInit();
            this.tabPages.SuspendLayout();
            this.tabBefore.SuspendLayout();
            this.tabLoop.SuspendLayout();
            this.tabAfter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddNewEvent
            // 
            this.btnAddNewEvent.Location = new System.Drawing.Point(14, 716);
            this.btnAddNewEvent.Name = "btnAddNewEvent";
            this.btnAddNewEvent.Size = new System.Drawing.Size(124, 38);
            this.btnAddNewEvent.TabIndex = 1;
            this.btnAddNewEvent.Text = "Add Event";
            this.btnAddNewEvent.UseVisualStyleBackColor = true;
            this.btnAddNewEvent.Click += new System.EventHandler(this.btnAddNewEvent_Click);
            // 
            // btnInsertEvent
            // 
            this.btnInsertEvent.Enabled = false;
            this.btnInsertEvent.Location = new System.Drawing.Point(144, 716);
            this.btnInsertEvent.Name = "btnInsertEvent";
            this.btnInsertEvent.Size = new System.Drawing.Size(124, 38);
            this.btnInsertEvent.TabIndex = 2;
            this.btnInsertEvent.Text = "Insert Event Above";
            this.btnInsertEvent.UseVisualStyleBackColor = true;
            this.btnInsertEvent.Click += new System.EventHandler(this.btnInsertEvent_Click);
            // 
            // btnDeleteEvent
            // 
            this.btnDeleteEvent.Enabled = false;
            this.btnDeleteEvent.Location = new System.Drawing.Point(404, 716);
            this.btnDeleteEvent.Name = "btnDeleteEvent";
            this.btnDeleteEvent.Size = new System.Drawing.Size(124, 38);
            this.btnDeleteEvent.TabIndex = 3;
            this.btnDeleteEvent.Text = "Delete Event";
            this.btnDeleteEvent.UseVisualStyleBackColor = true;
            this.btnDeleteEvent.Click += new System.EventHandler(this.btnDeleteEvent_Click);
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
            this.lblRepeats.Location = new System.Drawing.Point(160, 30);
            this.lblRepeats.Name = "lblRepeats";
            this.lblRepeats.Size = new System.Drawing.Size(57, 20);
            this.lblRepeats.TabIndex = 10;
            this.lblRepeats.Text = "Loops:";
            // 
            // numLoops
            // 
            this.numLoops.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLoops.Location = new System.Drawing.Point(235, 27);
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
            this.numLoops.Size = new System.Drawing.Size(140, 26);
            this.numLoops.TabIndex = 11;
            this.numLoops.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLoops.ValueChanged += new System.EventHandler(this.numLoops_ValueChanged);
            // 
            // tabPages
            // 
            this.tabPages.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabPages.Controls.Add(this.tabBefore);
            this.tabPages.Controls.Add(this.tabLoop);
            this.tabPages.Controls.Add(this.tabAfter);
            this.tabPages.Location = new System.Drawing.Point(9, 87);
            this.tabPages.Multiline = true;
            this.tabPages.Name = "tabPages";
            this.tabPages.SelectedIndex = 0;
            this.tabPages.Size = new System.Drawing.Size(520, 578);
            this.tabPages.TabIndex = 14;
            this.tabPages.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabPages_Selected);
            // 
            // tabBefore
            // 
            this.tabBefore.Controls.Add(this.label1);
            this.tabBefore.Controls.Add(this.listBefore);
            this.tabBefore.Location = new System.Drawing.Point(4, 4);
            this.tabBefore.Name = "tabBefore";
            this.tabBefore.Padding = new System.Windows.Forms.Padding(3);
            this.tabBefore.Size = new System.Drawing.Size(512, 550);
            this.tabBefore.TabIndex = 0;
            this.tabBefore.Text = "Before";
            this.tabBefore.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, -5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Before";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBefore
            // 
            this.listBefore.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listBefore.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listBefore.HideSelection = false;
            this.listBefore.LabelWrap = false;
            this.listBefore.Location = new System.Drawing.Point(-1, 32);
            this.listBefore.MultiSelect = false;
            this.listBefore.Name = "listBefore";
            this.listBefore.Size = new System.Drawing.Size(518, 515);
            this.listBefore.TabIndex = 2;
            this.listBefore.UseCompatibleStateImageBehavior = false;
            this.listBefore.View = System.Windows.Forms.View.Details;
            this.listBefore.SelectedIndexChanged += new System.EventHandler(this.listEvents_SelectedIndexChanged);
            this.listBefore.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listEvents_KeyDown);
            this.listBefore.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.list_MouseDoubleClick);
            this.listBefore.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listEvents_MouseUp);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Event Type";
            // 
            // tabLoop
            // 
            this.tabLoop.Controls.Add(this.label2);
            this.tabLoop.Controls.Add(this.listLoopEvents);
            this.tabLoop.Location = new System.Drawing.Point(4, 4);
            this.tabLoop.Name = "tabLoop";
            this.tabLoop.Padding = new System.Windows.Forms.Padding(3);
            this.tabLoop.Size = new System.Drawing.Size(512, 550);
            this.tabLoop.TabIndex = 1;
            this.tabLoop.Text = "Loop";
            this.tabLoop.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, -5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(497, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "Loop";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listLoopEvents
            // 
            this.listLoopEvents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnEventType});
            this.listLoopEvents.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listLoopEvents.HideSelection = false;
            this.listLoopEvents.LabelWrap = false;
            this.listLoopEvents.Location = new System.Drawing.Point(-1, 32);
            this.listLoopEvents.MultiSelect = false;
            this.listLoopEvents.Name = "listLoopEvents";
            this.listLoopEvents.Size = new System.Drawing.Size(518, 515);
            this.listLoopEvents.TabIndex = 1;
            this.listLoopEvents.UseCompatibleStateImageBehavior = false;
            this.listLoopEvents.View = System.Windows.Forms.View.Details;
            this.listLoopEvents.SelectedIndexChanged += new System.EventHandler(this.listEvents_SelectedIndexChanged);
            this.listLoopEvents.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listEvents_KeyDown);
            this.listLoopEvents.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.list_MouseDoubleClick);
            this.listLoopEvents.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listEvents_MouseUp);
            // 
            // columnEventType
            // 
            this.columnEventType.Text = "Event Type";
            // 
            // tabAfter
            // 
            this.tabAfter.Controls.Add(this.label3);
            this.tabAfter.Controls.Add(this.listAfter);
            this.tabAfter.Location = new System.Drawing.Point(4, 4);
            this.tabAfter.Name = "tabAfter";
            this.tabAfter.Padding = new System.Windows.Forms.Padding(3);
            this.tabAfter.Size = new System.Drawing.Size(512, 550);
            this.tabAfter.TabIndex = 2;
            this.tabAfter.Text = "After";
            this.tabAfter.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, -5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(497, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "After";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listAfter
            // 
            this.listAfter.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listAfter.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listAfter.HideSelection = false;
            this.listAfter.LabelWrap = false;
            this.listAfter.Location = new System.Drawing.Point(-1, 32);
            this.listAfter.MultiSelect = false;
            this.listAfter.Name = "listAfter";
            this.listAfter.Size = new System.Drawing.Size(518, 515);
            this.listAfter.TabIndex = 2;
            this.listAfter.UseCompatibleStateImageBehavior = false;
            this.listAfter.View = System.Windows.Forms.View.Details;
            this.listAfter.SelectedIndexChanged += new System.EventHandler(this.listEvents_SelectedIndexChanged);
            this.listAfter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listEvents_KeyDown);
            this.listAfter.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.list_MouseDoubleClick);
            this.listAfter.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listEvents_MouseUp);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Event Type";
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(14, 672);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(516, 38);
            this.btnRecord.TabIndex = 15;
            this.btnRecord.Text = "Record Actions";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(274, 716);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(124, 38);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "Edit Event";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnStop
            // 
            this.btnStop.Image = global::ActionRepeater.Properties.Resources.btnStop_Disabled;
            this.btnStop.Location = new System.Drawing.Point(86, 12);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(56, 56);
            this.btnStop.TabIndex = 12;
            this.btnStop.TabStop = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.Location = new System.Drawing.Point(467, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(56, 56);
            this.btnLoad.TabIndex = 9;
            this.btnLoad.TabStop = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(393, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(56, 56);
            this.btnSave.TabIndex = 8;
            this.btnSave.TabStop = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Image = global::ActionRepeater.Properties.Resources.btnPlay_Enabled;
            this.btnPlay.Location = new System.Drawing.Point(12, 12);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(56, 56);
            this.btnPlay.TabIndex = 7;
            this.btnPlay.TabStop = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 760);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.tabPages);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.numLoops);
            this.Controls.Add(this.lblRepeats);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnDeleteEvent);
            this.Controls.Add(this.btnInsertEvent);
            this.Controls.Add(this.btnAddNewEvent);
            this.Font = new System.Drawing.Font("Calibri", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "ActionRepeater";
            ((System.ComponentModel.ISupportInitialize)(this.numLoops)).EndInit();
            this.tabPages.ResumeLayout(false);
            this.tabBefore.ResumeLayout(false);
            this.tabLoop.ResumeLayout(false);
            this.tabAfter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.TabControl tabPages;
        private System.Windows.Forms.TabPage tabBefore;
        private System.Windows.Forms.ListView listBefore;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TabPage tabLoop;
        private System.Windows.Forms.ListView listLoopEvents;
        private System.Windows.Forms.ColumnHeader columnEventType;
        private System.Windows.Forms.TabPage tabAfter;
        private System.Windows.Forms.ListView listAfter;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEdit;
    }
}

