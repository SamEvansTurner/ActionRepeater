namespace MacroRecorder.Forms
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
            this.cmbEventType = new System.Windows.Forms.ComboBox();
            this.txtMouseMoveX = new System.Windows.Forms.TextBox();
            this.txtMouseMoveY = new System.Windows.Forms.TextBox();
            this.txtMouseMoveRX = new System.Windows.Forms.TextBox();
            this.txtMouseMoveRY = new System.Windows.Forms.TextBox();
            this.txtMouseMoveSpd = new System.Windows.Forms.TextBox();
            this.txtKeys = new System.Windows.Forms.TextBox();
            this.cmbMouseButton = new System.Windows.Forms.ComboBox();
            this.numWaitMS = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numWaitMS)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbEventType
            // 
            this.cmbEventType.FormattingEnabled = true;
            this.cmbEventType.Location = new System.Drawing.Point(120, 12);
            this.cmbEventType.Name = "cmbEventType";
            this.cmbEventType.Size = new System.Drawing.Size(186, 21);
            this.cmbEventType.TabIndex = 0;
            // 
            // txtMouseMoveX
            // 
            this.txtMouseMoveX.Location = new System.Drawing.Point(93, 111);
            this.txtMouseMoveX.Name = "txtMouseMoveX";
            this.txtMouseMoveX.Size = new System.Drawing.Size(120, 20);
            this.txtMouseMoveX.TabIndex = 2;
            // 
            // txtMouseMoveY
            // 
            this.txtMouseMoveY.Location = new System.Drawing.Point(93, 137);
            this.txtMouseMoveY.Name = "txtMouseMoveY";
            this.txtMouseMoveY.Size = new System.Drawing.Size(120, 20);
            this.txtMouseMoveY.TabIndex = 3;
            // 
            // txtMouseMoveRX
            // 
            this.txtMouseMoveRX.Location = new System.Drawing.Point(93, 163);
            this.txtMouseMoveRX.Name = "txtMouseMoveRX";
            this.txtMouseMoveRX.Size = new System.Drawing.Size(120, 20);
            this.txtMouseMoveRX.TabIndex = 4;
            // 
            // txtMouseMoveRY
            // 
            this.txtMouseMoveRY.Location = new System.Drawing.Point(93, 189);
            this.txtMouseMoveRY.Name = "txtMouseMoveRY";
            this.txtMouseMoveRY.Size = new System.Drawing.Size(120, 20);
            this.txtMouseMoveRY.TabIndex = 5;
            // 
            // txtMouseMoveSpd
            // 
            this.txtMouseMoveSpd.Location = new System.Drawing.Point(93, 215);
            this.txtMouseMoveSpd.Name = "txtMouseMoveSpd";
            this.txtMouseMoveSpd.Size = new System.Drawing.Size(120, 20);
            this.txtMouseMoveSpd.TabIndex = 6;
            // 
            // txtKeys
            // 
            this.txtKeys.Location = new System.Drawing.Point(291, 61);
            this.txtKeys.Name = "txtKeys";
            this.txtKeys.Size = new System.Drawing.Size(120, 20);
            this.txtKeys.TabIndex = 7;
            // 
            // cmbMouseButton
            // 
            this.cmbMouseButton.FormattingEnabled = true;
            this.cmbMouseButton.Location = new System.Drawing.Point(340, 137);
            this.cmbMouseButton.Name = "cmbMouseButton";
            this.cmbMouseButton.Size = new System.Drawing.Size(186, 21);
            this.cmbMouseButton.TabIndex = 8;
            // 
            // numWaitMS
            // 
            this.numWaitMS.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numWaitMS.Location = new System.Drawing.Point(50, 61);
            this.numWaitMS.Maximum = new decimal(new int[] {
            99990,
            0,
            0,
            0});
            this.numWaitMS.Name = "numWaitMS";
            this.numWaitMS.Size = new System.Drawing.Size(120, 20);
            this.numWaitMS.TabIndex = 9;
            // 
            // frmAddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 263);
            this.Controls.Add(this.numWaitMS);
            this.Controls.Add(this.cmbMouseButton);
            this.Controls.Add(this.txtKeys);
            this.Controls.Add(this.txtMouseMoveSpd);
            this.Controls.Add(this.txtMouseMoveRY);
            this.Controls.Add(this.txtMouseMoveRX);
            this.Controls.Add(this.txtMouseMoveY);
            this.Controls.Add(this.txtMouseMoveX);
            this.Controls.Add(this.cmbEventType);
            this.Name = "frmAddEvent";
            this.Text = "frmAddEvent";
            ((System.ComponentModel.ISupportInitialize)(this.numWaitMS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEventType;
        private System.Windows.Forms.TextBox txtMouseMoveX;
        private System.Windows.Forms.TextBox txtMouseMoveY;
        private System.Windows.Forms.TextBox txtMouseMoveRX;
        private System.Windows.Forms.TextBox txtMouseMoveRY;
        private System.Windows.Forms.TextBox txtMouseMoveSpd;
        private System.Windows.Forms.TextBox txtKeys;
        private System.Windows.Forms.ComboBox cmbMouseButton;
        private System.Windows.Forms.NumericUpDown numWaitMS;
    }
}