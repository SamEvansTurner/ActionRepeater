namespace ActionRepeater
{
    partial class frmAfterLoopsEvents
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
            this.listEventsEAL = new System.Windows.Forms.ListView();
            this.columnEventType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddNewEventEAL = new System.Windows.Forms.Button();
            this.btnInsertEventEAL = new System.Windows.Forms.Button();
            this.btnDeleteEventEAL = new System.Windows.Forms.Button();
            this.btnCloseEAL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listEventsEAL
            // 
            this.listEventsEAL.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnEventType});
            this.listEventsEAL.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listEventsEAL.HideSelection = false;
            this.listEventsEAL.LabelWrap = false;
            this.listEventsEAL.Location = new System.Drawing.Point(12, 12);
            this.listEventsEAL.MultiSelect = false;
            this.listEventsEAL.Name = "listEventsEAL";
            this.listEventsEAL.Size = new System.Drawing.Size(445, 564);
            this.listEventsEAL.TabIndex = 0;
            this.listEventsEAL.UseCompatibleStateImageBehavior = false;
            this.listEventsEAL.View = System.Windows.Forms.View.Details;
            this.listEventsEAL.SelectedIndexChanged += new System.EventHandler(this.listEventsEAL_SelectedIndexChanged);
            this.listEventsEAL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listEventsEAL_KeyDown);
            this.listEventsEAL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listEventsEAL_MouseUp);
            // 
            // columnEventType
            // 
            this.columnEventType.Text = "Event Type";
            // 
            // btnAddNewEventEAL
            // 
            this.btnAddNewEventEAL.Location = new System.Drawing.Point(12, 582);
            this.btnAddNewEventEAL.Name = "btnAddNewEventEAL";
            this.btnAddNewEventEAL.Size = new System.Drawing.Size(138, 46);
            this.btnAddNewEventEAL.TabIndex = 1;
            this.btnAddNewEventEAL.Text = "Add Event";
            this.btnAddNewEventEAL.UseVisualStyleBackColor = true;
            this.btnAddNewEventEAL.Click += new System.EventHandler(this.btnAddNewEventEAL_Click);
            // 
            // btnInsertEventEAL
            // 
            this.btnInsertEventEAL.Enabled = false;
            this.btnInsertEventEAL.Location = new System.Drawing.Point(164, 582);
            this.btnInsertEventEAL.Name = "btnInsertEventEAL";
            this.btnInsertEventEAL.Size = new System.Drawing.Size(138, 46);
            this.btnInsertEventEAL.TabIndex = 2;
            this.btnInsertEventEAL.Text = "Insert Event above cursor";
            this.btnInsertEventEAL.UseVisualStyleBackColor = true;
            this.btnInsertEventEAL.Click += new System.EventHandler(this.btnInsertEventEAL_Click);
            // 
            // btnDeleteEventEAL
            // 
            this.btnDeleteEventEAL.Location = new System.Drawing.Point(319, 582);
            this.btnDeleteEventEAL.Name = "btnDeleteEventEAL";
            this.btnDeleteEventEAL.Size = new System.Drawing.Size(138, 46);
            this.btnDeleteEventEAL.TabIndex = 3;
            this.btnDeleteEventEAL.Text = "Delete Event";
            this.btnDeleteEventEAL.UseVisualStyleBackColor = true;
            this.btnDeleteEventEAL.Click += new System.EventHandler(this.btnDeleteEventEAL_Click);
            // 
            // btnCloseEAL
            // 
            this.btnCloseEAL.Location = new System.Drawing.Point(12, 634);
            this.btnCloseEAL.Name = "btnCloseEAL";
            this.btnCloseEAL.Size = new System.Drawing.Size(445, 47);
            this.btnCloseEAL.TabIndex = 4;
            this.btnCloseEAL.Text = "Close";
            this.btnCloseEAL.UseVisualStyleBackColor = true;
            this.btnCloseEAL.Click += new System.EventHandler(this.btnCloseEAL_Click);
            // 
            // frmAfterLoopsEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 693);
            this.Controls.Add(this.btnCloseEAL);
            this.Controls.Add(this.btnDeleteEventEAL);
            this.Controls.Add(this.btnInsertEventEAL);
            this.Controls.Add(this.btnAddNewEventEAL);
            this.Controls.Add(this.listEventsEAL);
            this.Name = "frmAfterLoopsEvents";
            this.Text = "Events After Loops";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listEventsEAL;
        private System.Windows.Forms.ColumnHeader columnEventType;
        private System.Windows.Forms.Button btnAddNewEventEAL;
        private System.Windows.Forms.Button btnInsertEventEAL;
        private System.Windows.Forms.Button btnDeleteEventEAL;
        private System.Windows.Forms.Button btnCloseEAL;
    }
}

