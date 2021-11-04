namespace ActionRepeater.Forms
{
    partial class frmAddEvent
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
            this.components = new System.ComponentModel.Container();
            this.cmbEventType = new System.Windows.Forms.ComboBox();
            this.cmbMouseButton = new System.Windows.Forms.ComboBox();
            this.numWaitMS = new System.Windows.Forms.NumericUpDown();
            this.lblEventType = new System.Windows.Forms.Label();
            this.lblWait = new System.Windows.Forms.Label();
            this.lblMouseX = new System.Windows.Forms.Label();
            this.lblMouseY = new System.Windows.Forms.Label();
            this.lblMouseRX = new System.Windows.Forms.Label();
            this.lblMouseRY = new System.Windows.Forms.Label();
            this.lblMouseSpeed = new System.Windows.Forms.Label();
            this.lblKeys = new System.Windows.Forms.Label();
            this.lblButton = new System.Windows.Forms.Label();
            this.numMouseX = new System.Windows.Forms.NumericUpDown();
            this.numMouseY = new System.Windows.Forms.NumericUpDown();
            this.numMouseRX = new System.Windows.Forms.NumericUpDown();
            this.numMouseRY = new System.Windows.Forms.NumericUpDown();
            this.numMouseSpeed = new System.Windows.Forms.NumericUpDown();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblCurrMousePos = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblXPos = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblYPos = new System.Windows.Forms.Label();
            this.tmrCursUpdate = new System.Windows.Forms.Timer(this.components);
            this.lblRelative = new System.Windows.Forms.Label();
            this.cbRelative = new System.Windows.Forms.CheckBox();
            this.cmbKey = new System.Windows.Forms.ComboBox();
            this.cbLinear = new System.Windows.Forms.CheckBox();
            this.lblLinear = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numWaitMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMouseX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMouseY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMouseRX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMouseRY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMouseSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbEventType
            // 
            this.cmbEventType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEventType.FormattingEnabled = true;
            this.cmbEventType.Items.AddRange(new object[] {
            "Wait",
            "Move Mouse",
            "Send Key",
            "Click Mouse"});
            this.cmbEventType.Location = new System.Drawing.Point(170, 5);
            this.cmbEventType.Name = "cmbEventType";
            this.cmbEventType.Size = new System.Drawing.Size(165, 23);
            this.cmbEventType.TabIndex = 0;
            this.cmbEventType.SelectedIndexChanged += new System.EventHandler(this.cmbEventType_SelectedIndexChanged);
            // 
            // cmbMouseButton
            // 
            this.cmbMouseButton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMouseButton.Enabled = false;
            this.cmbMouseButton.FormattingEnabled = true;
            this.cmbMouseButton.Items.AddRange(new object[] {
            "Left",
            "Right"});
            this.cmbMouseButton.Location = new System.Drawing.Point(196, 309);
            this.cmbMouseButton.Name = "cmbMouseButton";
            this.cmbMouseButton.Size = new System.Drawing.Size(139, 23);
            this.cmbMouseButton.TabIndex = 9;
            this.cmbMouseButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbMouseButton_KeyDown);
            // 
            // numWaitMS
            // 
            this.numWaitMS.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numWaitMS.Location = new System.Drawing.Point(195, 41);
            this.numWaitMS.Maximum = new decimal(new int[] {
            99990,
            0,
            0,
            0});
            this.numWaitMS.Name = "numWaitMS";
            this.numWaitMS.Size = new System.Drawing.Size(140, 24);
            this.numWaitMS.TabIndex = 1;
            this.numWaitMS.Enter += new System.EventHandler(this.numWaitMS_Enter);
            this.numWaitMS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numWaitMS_KeyDown);
            // 
            // lblEventType
            // 
            this.lblEventType.AutoSize = true;
            this.lblEventType.Location = new System.Drawing.Point(10, 8);
            this.lblEventType.Name = "lblEventType";
            this.lblEventType.Size = new System.Drawing.Size(73, 17);
            this.lblEventType.TabIndex = 10;
            this.lblEventType.Text = "Event Type:";
            // 
            // lblWait
            // 
            this.lblWait.AutoSize = true;
            this.lblWait.Location = new System.Drawing.Point(10, 43);
            this.lblWait.Name = "lblWait";
            this.lblWait.Size = new System.Drawing.Size(97, 17);
            this.lblWait.TabIndex = 11;
            this.lblWait.Text = "Wait Time (ms):";
            // 
            // lblMouseX
            // 
            this.lblMouseX.AutoSize = true;
            this.lblMouseX.Enabled = false;
            this.lblMouseX.Location = new System.Drawing.Point(10, 76);
            this.lblMouseX.Name = "lblMouseX";
            this.lblMouseX.Size = new System.Drawing.Size(60, 17);
            this.lblMouseX.TabIndex = 12;
            this.lblMouseX.Text = "Mouse X:";
            // 
            // lblMouseY
            // 
            this.lblMouseY.AutoSize = true;
            this.lblMouseY.Enabled = false;
            this.lblMouseY.Location = new System.Drawing.Point(10, 106);
            this.lblMouseY.Name = "lblMouseY";
            this.lblMouseY.Size = new System.Drawing.Size(59, 17);
            this.lblMouseY.TabIndex = 13;
            this.lblMouseY.Text = "Mouse Y:";
            // 
            // lblMouseRX
            // 
            this.lblMouseRX.AutoSize = true;
            this.lblMouseRX.Enabled = false;
            this.lblMouseRX.Location = new System.Drawing.Point(10, 136);
            this.lblMouseRX.Name = "lblMouseRX";
            this.lblMouseRX.Size = new System.Drawing.Size(110, 17);
            this.lblMouseRX.TabIndex = 14;
            this.lblMouseRX.Text = "Mouse Random X:";
            // 
            // lblMouseRY
            // 
            this.lblMouseRY.AutoSize = true;
            this.lblMouseRY.Enabled = false;
            this.lblMouseRY.Location = new System.Drawing.Point(10, 166);
            this.lblMouseRY.Name = "lblMouseRY";
            this.lblMouseRY.Size = new System.Drawing.Size(109, 17);
            this.lblMouseRY.TabIndex = 15;
            this.lblMouseRY.Text = "Mouse Random Y:";
            // 
            // lblMouseSpeed
            // 
            this.lblMouseSpeed.AutoSize = true;
            this.lblMouseSpeed.Enabled = false;
            this.lblMouseSpeed.Location = new System.Drawing.Point(10, 196);
            this.lblMouseSpeed.Name = "lblMouseSpeed";
            this.lblMouseSpeed.Size = new System.Drawing.Size(83, 17);
            this.lblMouseSpeed.TabIndex = 16;
            this.lblMouseSpeed.Text = "Mouse Speed";
            // 
            // lblKeys
            // 
            this.lblKeys.AutoSize = true;
            this.lblKeys.Enabled = false;
            this.lblKeys.Location = new System.Drawing.Point(10, 282);
            this.lblKeys.Name = "lblKeys";
            this.lblKeys.Size = new System.Drawing.Size(77, 17);
            this.lblKeys.TabIndex = 17;
            this.lblKeys.Text = "Key to Send:";
            // 
            // lblButton
            // 
            this.lblButton.AutoSize = true;
            this.lblButton.Enabled = false;
            this.lblButton.Location = new System.Drawing.Point(10, 312);
            this.lblButton.Name = "lblButton";
            this.lblButton.Size = new System.Drawing.Size(115, 17);
            this.lblButton.TabIndex = 18;
            this.lblButton.Text = "Mouse Button Click";
            // 
            // numMouseX
            // 
            this.numMouseX.Enabled = false;
            this.numMouseX.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numMouseX.Location = new System.Drawing.Point(195, 74);
            this.numMouseX.Maximum = new decimal(new int[] {
            99990,
            0,
            0,
            0});
            this.numMouseX.Minimum = new decimal(new int[] {
            99990,
            0,
            0,
            -2147483648});
            this.numMouseX.Name = "numMouseX";
            this.numMouseX.Size = new System.Drawing.Size(140, 24);
            this.numMouseX.TabIndex = 2;
            this.numMouseX.Enter += new System.EventHandler(this.numMouseX_Enter);
            this.numMouseX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numMouseX_KeyDown);
            // 
            // numMouseY
            // 
            this.numMouseY.Enabled = false;
            this.numMouseY.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numMouseY.Location = new System.Drawing.Point(195, 104);
            this.numMouseY.Maximum = new decimal(new int[] {
            99990,
            0,
            0,
            0});
            this.numMouseY.Minimum = new decimal(new int[] {
            99990,
            0,
            0,
            -2147483648});
            this.numMouseY.Name = "numMouseY";
            this.numMouseY.Size = new System.Drawing.Size(140, 24);
            this.numMouseY.TabIndex = 3;
            this.numMouseY.Enter += new System.EventHandler(this.numMouseY_Enter);
            this.numMouseY.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numMouseY_KeyDown);
            // 
            // numMouseRX
            // 
            this.numMouseRX.Enabled = false;
            this.numMouseRX.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numMouseRX.Location = new System.Drawing.Point(195, 134);
            this.numMouseRX.Maximum = new decimal(new int[] {
            99990,
            0,
            0,
            0});
            this.numMouseRX.Minimum = new decimal(new int[] {
            99990,
            0,
            0,
            -2147483648});
            this.numMouseRX.Name = "numMouseRX";
            this.numMouseRX.Size = new System.Drawing.Size(140, 24);
            this.numMouseRX.TabIndex = 4;
            this.numMouseRX.Enter += new System.EventHandler(this.numMouseRX_Enter);
            this.numMouseRX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numMouseRX_KeyDown);
            // 
            // numMouseRY
            // 
            this.numMouseRY.Enabled = false;
            this.numMouseRY.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numMouseRY.Location = new System.Drawing.Point(195, 164);
            this.numMouseRY.Maximum = new decimal(new int[] {
            99990,
            0,
            0,
            0});
            this.numMouseRY.Minimum = new decimal(new int[] {
            99990,
            0,
            0,
            -2147483648});
            this.numMouseRY.Name = "numMouseRY";
            this.numMouseRY.Size = new System.Drawing.Size(140, 24);
            this.numMouseRY.TabIndex = 5;
            this.numMouseRY.Enter += new System.EventHandler(this.numMouseRY_Enter);
            this.numMouseRY.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numMouseRY_KeyDown);
            // 
            // numMouseSpeed
            // 
            this.numMouseSpeed.Enabled = false;
            this.numMouseSpeed.Location = new System.Drawing.Point(195, 194);
            this.numMouseSpeed.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numMouseSpeed.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numMouseSpeed.Name = "numMouseSpeed";
            this.numMouseSpeed.Size = new System.Drawing.Size(140, 24);
            this.numMouseSpeed.TabIndex = 6;
            this.numMouseSpeed.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numMouseSpeed.Enter += new System.EventHandler(this.numMouseSpeed_Enter);
            this.numMouseSpeed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numMouseSpeed_KeyDown);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(37, 407);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(105, 38);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(195, 407);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 38);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblCurrMousePos
            // 
            this.lblCurrMousePos.AutoSize = true;
            this.lblCurrMousePos.Font = new System.Drawing.Font("Calibri", 14F);
            this.lblCurrMousePos.Location = new System.Drawing.Point(9, 341);
            this.lblCurrMousePos.Name = "lblCurrMousePos";
            this.lblCurrMousePos.Size = new System.Drawing.Size(192, 23);
            this.lblCurrMousePos.TabIndex = 19;
            this.lblCurrMousePos.Text = "Current Cursor Position";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(10, 363);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(19, 17);
            this.lblX.TabIndex = 20;
            this.lblX.Text = "X:";
            // 
            // lblXPos
            // 
            this.lblXPos.AutoSize = true;
            this.lblXPos.Location = new System.Drawing.Point(34, 363);
            this.lblXPos.Name = "lblXPos";
            this.lblXPos.Size = new System.Drawing.Size(0, 17);
            this.lblXPos.TabIndex = 21;
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(10, 380);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(18, 17);
            this.lblY.TabIndex = 22;
            this.lblY.Text = "Y:";
            // 
            // lblYPos
            // 
            this.lblYPos.AutoSize = true;
            this.lblYPos.Location = new System.Drawing.Point(34, 380);
            this.lblYPos.Name = "lblYPos";
            this.lblYPos.Size = new System.Drawing.Size(0, 17);
            this.lblYPos.TabIndex = 23;
            // 
            // tmrCursUpdate
            // 
            this.tmrCursUpdate.Interval = 10;
            this.tmrCursUpdate.Tick += new System.EventHandler(this.tmrCursUpdate_Tick);
            // 
            // lblRelative
            // 
            this.lblRelative.AutoSize = true;
            this.lblRelative.Location = new System.Drawing.Point(10, 226);
            this.lblRelative.Name = "lblRelative";
            this.lblRelative.Size = new System.Drawing.Size(167, 17);
            this.lblRelative.TabIndex = 24;
            this.lblRelative.Text = "Relative To Previous Position";
            // 
            // cbRelative
            // 
            this.cbRelative.AutoSize = true;
            this.cbRelative.Location = new System.Drawing.Point(195, 227);
            this.cbRelative.Name = "cbRelative";
            this.cbRelative.Size = new System.Drawing.Size(15, 14);
            this.cbRelative.TabIndex = 7;
            this.cbRelative.UseVisualStyleBackColor = true;
            // 
            // cmbKey
            // 
            this.cmbKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKey.FormattingEnabled = true;
            this.cmbKey.Location = new System.Drawing.Point(195, 279);
            this.cmbKey.Name = "cmbKey";
            this.cmbKey.Size = new System.Drawing.Size(140, 23);
            this.cmbKey.TabIndex = 8;
            this.cmbKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbKey_KeyDown);
            // 
            // cbLinear
            // 
            this.cbLinear.AutoSize = true;
            this.cbLinear.Location = new System.Drawing.Point(195, 253);
            this.cbLinear.Name = "cbLinear";
            this.cbLinear.Size = new System.Drawing.Size(15, 14);
            this.cbLinear.TabIndex = 25;
            this.cbLinear.UseVisualStyleBackColor = true;
            // 
            // lblLinear
            // 
            this.lblLinear.AutoSize = true;
            this.lblLinear.Enabled = false;
            this.lblLinear.Location = new System.Drawing.Point(10, 252);
            this.lblLinear.Name = "lblLinear";
            this.lblLinear.Size = new System.Drawing.Size(108, 17);
            this.lblLinear.TabIndex = 26;
            this.lblLinear.Text = "Linear Movement";
            // 
            // frmAddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 449);
            this.ControlBox = false;
            this.Controls.Add(this.lblLinear);
            this.Controls.Add(this.cbLinear);
            this.Controls.Add(this.cmbKey);
            this.Controls.Add(this.cbRelative);
            this.Controls.Add(this.lblRelative);
            this.Controls.Add(this.lblYPos);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblXPos);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblCurrMousePos);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.numMouseSpeed);
            this.Controls.Add(this.numMouseRY);
            this.Controls.Add(this.numMouseRX);
            this.Controls.Add(this.numMouseY);
            this.Controls.Add(this.numMouseX);
            this.Controls.Add(this.lblButton);
            this.Controls.Add(this.lblKeys);
            this.Controls.Add(this.lblMouseSpeed);
            this.Controls.Add(this.lblMouseRY);
            this.Controls.Add(this.lblMouseRX);
            this.Controls.Add(this.lblMouseY);
            this.Controls.Add(this.lblMouseX);
            this.Controls.Add(this.lblWait);
            this.Controls.Add(this.lblEventType);
            this.Controls.Add(this.numWaitMS);
            this.Controls.Add(this.cmbMouseButton);
            this.Controls.Add(this.cmbEventType);
            this.Font = new System.Drawing.Font("Calibri", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Event";
            ((System.ComponentModel.ISupportInitialize)(this.numWaitMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMouseX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMouseY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMouseRX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMouseRY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMouseSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEventType;
        private System.Windows.Forms.ComboBox cmbMouseButton;
        private System.Windows.Forms.NumericUpDown numWaitMS;
        private System.Windows.Forms.Label lblEventType;
        private System.Windows.Forms.Label lblWait;
        private System.Windows.Forms.Label lblMouseX;
        private System.Windows.Forms.Label lblMouseY;
        private System.Windows.Forms.Label lblMouseRX;
        private System.Windows.Forms.Label lblMouseRY;
        private System.Windows.Forms.Label lblMouseSpeed;
        private System.Windows.Forms.Label lblKeys;
        private System.Windows.Forms.Label lblButton;
        private System.Windows.Forms.NumericUpDown numMouseX;
        private System.Windows.Forms.NumericUpDown numMouseY;
        private System.Windows.Forms.NumericUpDown numMouseRX;
        private System.Windows.Forms.NumericUpDown numMouseRY;
        private System.Windows.Forms.NumericUpDown numMouseSpeed;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblCurrMousePos;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblXPos;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblYPos;
        private System.Windows.Forms.Timer tmrCursUpdate;
        private System.Windows.Forms.Label lblRelative;
        private System.Windows.Forms.CheckBox cbRelative;
        private System.Windows.Forms.ComboBox cmbKey;
        private System.Windows.Forms.CheckBox cbLinear;
        private System.Windows.Forms.Label lblLinear;
    }
}