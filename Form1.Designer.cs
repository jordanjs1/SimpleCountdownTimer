namespace Timer
{
    partial class Form1
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
            this.numericUpDownHour = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinute = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSecond = new System.Windows.Forms.NumericUpDown();
            this.buttonStartPause = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.labelTimer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSecond)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownHour
            // 
            this.numericUpDownHour.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numericUpDownHour.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownHour.Location = new System.Drawing.Point(34, 71);
            this.numericUpDownHour.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownHour.Name = "numericUpDownHour";
            this.numericUpDownHour.Size = new System.Drawing.Size(50, 29);
            this.numericUpDownHour.TabIndex = 1;
            this.numericUpDownHour.Enter += new System.EventHandler(this.numericUpDownHour_Enter);
            this.numericUpDownHour.Leave += new System.EventHandler(this.numericUpDownHour_Leave);
            // 
            // numericUpDownMinute
            // 
            this.numericUpDownMinute.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numericUpDownMinute.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownMinute.Location = new System.Drawing.Point(92, 71);
            this.numericUpDownMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownMinute.Name = "numericUpDownMinute";
            this.numericUpDownMinute.Size = new System.Drawing.Size(50, 29);
            this.numericUpDownMinute.TabIndex = 2;
            this.numericUpDownMinute.Enter += new System.EventHandler(this.numericUpDownMinute_Enter);
            this.numericUpDownMinute.Leave += new System.EventHandler(this.numericUpDownMinute_Leave);
            // 
            // numericUpDownSecond
            // 
            this.numericUpDownSecond.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numericUpDownSecond.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownSecond.Location = new System.Drawing.Point(148, 71);
            this.numericUpDownSecond.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownSecond.Name = "numericUpDownSecond";
            this.numericUpDownSecond.Size = new System.Drawing.Size(50, 29);
            this.numericUpDownSecond.TabIndex = 3;
            this.numericUpDownSecond.Enter += new System.EventHandler(this.numericUpDownSecond_Enter);
            this.numericUpDownSecond.Leave += new System.EventHandler(this.numericUpDownSecond_Leave);
            // 
            // buttonStartPause
            // 
            this.buttonStartPause.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonStartPause.Location = new System.Drawing.Point(33, 106);
            this.buttonStartPause.Name = "buttonStartPause";
            this.buttonStartPause.Size = new System.Drawing.Size(80, 23);
            this.buttonStartPause.TabIndex = 4;
            this.buttonStartPause.Text = "&Start";
            this.buttonStartPause.UseVisualStyleBackColor = true;
            this.buttonStartPause.Click += new System.EventHandler(this.buttonStartPause_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonStop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonStop.Enabled = false;
            this.buttonStop.Location = new System.Drawing.Point(119, 106);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(80, 23);
            this.buttonStop.TabIndex = 5;
            this.buttonStop.Text = "Sto&p";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimer.Location = new System.Drawing.Point(2, 3);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(240, 65);
            this.labelTimer.TabIndex = 0;
            this.labelTimer.Text = "00.00.00.0";
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonStartPause;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.buttonStop;
            this.ClientSize = new System.Drawing.Size(238, 138);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStartPause);
            this.Controls.Add(this.numericUpDownSecond);
            this.Controls.Add(this.numericUpDownMinute);
            this.Controls.Add(this.numericUpDownHour);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Countdown Timer";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSecond)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownHour;
        private System.Windows.Forms.NumericUpDown numericUpDownMinute;
        private System.Windows.Forms.NumericUpDown numericUpDownSecond;
        private System.Windows.Forms.Button buttonStartPause;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label labelTimer;
    }
}

