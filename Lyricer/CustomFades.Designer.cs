namespace Lyricer
{
	partial class CustomFades
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.lblCustomFadesAbout = new System.Windows.Forms.LinkLabel();
            this.cbxFOReduceLength = new System.Windows.Forms.CheckBox();
            this.FadeOutGroup = new System.Windows.Forms.GroupBox();
            this.cbxFOAddLength = new System.Windows.Forms.CheckBox();
            this.lbFadeOut = new System.Windows.Forms.Label();
            this.nudFadeOut = new System.Windows.Forms.NumericUpDown();
            this.cbxFadeOutToZero = new System.Windows.Forms.CheckBox();
            this.lbFadeOutCurve = new System.Windows.Forms.Label();
            this.cbFadeOutCurve = new System.Windows.Forms.ComboBox();
            this.cbxChangeFadeOutCurveType = new System.Windows.Forms.CheckBox();
            this.cbFadeOutTimecode = new System.Windows.Forms.ComboBox();
            this.cbxFIReduceLength = new System.Windows.Forms.CheckBox();
            this.cbxFIAddLength = new System.Windows.Forms.CheckBox();
            this.FadeInGroup = new System.Windows.Forms.GroupBox();
            this.lbFadeIn = new System.Windows.Forms.Label();
            this.cbxFadeInToZero = new System.Windows.Forms.CheckBox();
            this.nudFadeIn = new System.Windows.Forms.NumericUpDown();
            this.lbFadeInCurve = new System.Windows.Forms.Label();
            this.cbFadeInCurve = new System.Windows.Forms.ComboBox();
            this.cbFadeInTimecode = new System.Windows.Forms.ComboBox();
            this.cbxChangeFadeInCurveType = new System.Windows.Forms.CheckBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btRun = new System.Windows.Forms.Button();
            this.FadeOutGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFadeOut)).BeginInit();
            this.FadeInGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFadeIn)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustomFadesAbout
            // 
            this.lblCustomFadesAbout.AutoSize = true;
            this.lblCustomFadesAbout.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblCustomFadesAbout.Location = new System.Drawing.Point(10, 10);
            this.lblCustomFadesAbout.Margin = new System.Windows.Forms.Padding(10);
            this.lblCustomFadesAbout.Name = "lblCustomFadesAbout";
            this.lblCustomFadesAbout.Size = new System.Drawing.Size(186, 13);
            this.lblCustomFadesAbout.TabIndex = 7;
            this.lblCustomFadesAbout.TabStop = true;
            this.lblCustomFadesAbout.Text = "Custom Fades by RatinA0 (github link)";
            this.lblCustomFadesAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCustomFadesAbout_LinkClicked);
            // 
            // cbxFOReduceLength
            // 
            this.cbxFOReduceLength.AutoSize = true;
            this.cbxFOReduceLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbxFOReduceLength.Location = new System.Drawing.Point(200, 54);
            this.cbxFOReduceLength.Name = "cbxFOReduceLength";
            this.cbxFOReduceLength.Size = new System.Drawing.Size(124, 21);
            this.cbxFOReduceLength.TabIndex = 4;
            this.cbxFOReduceLength.Text = "Reduce Length";
            this.cbxFOReduceLength.UseVisualStyleBackColor = true;
            this.cbxFOReduceLength.CheckedChanged += new System.EventHandler(this.cbxFadeOutReduceLength_CheckedChanged);
            // 
            // FadeOutGroup
            // 
            this.FadeOutGroup.Controls.Add(this.cbxFOAddLength);
            this.FadeOutGroup.Controls.Add(this.cbxFOReduceLength);
            this.FadeOutGroup.Controls.Add(this.lbFadeOut);
            this.FadeOutGroup.Controls.Add(this.nudFadeOut);
            this.FadeOutGroup.Controls.Add(this.cbxFadeOutToZero);
            this.FadeOutGroup.Controls.Add(this.lbFadeOutCurve);
            this.FadeOutGroup.Controls.Add(this.cbFadeOutCurve);
            this.FadeOutGroup.Controls.Add(this.cbxChangeFadeOutCurveType);
            this.FadeOutGroup.Controls.Add(this.cbFadeOutTimecode);
            this.FadeOutGroup.Location = new System.Drawing.Point(10, 165);
            this.FadeOutGroup.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.FadeOutGroup.Name = "FadeOutGroup";
            this.FadeOutGroup.Size = new System.Drawing.Size(331, 126);
            this.FadeOutGroup.TabIndex = 10;
            this.FadeOutGroup.TabStop = false;
            this.FadeOutGroup.Text = "Fade Out settings";
            // 
            // cbxFOAddLength
            // 
            this.cbxFOAddLength.AutoSize = true;
            this.cbxFOAddLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbxFOAddLength.Location = new System.Drawing.Point(142, 54);
            this.cbxFOAddLength.Name = "cbxFOAddLength";
            this.cbxFOAddLength.Size = new System.Drawing.Size(52, 21);
            this.cbxFOAddLength.TabIndex = 3;
            this.cbxFOAddLength.Text = "Add";
            this.cbxFOAddLength.UseVisualStyleBackColor = true;
            this.cbxFOAddLength.CheckedChanged += new System.EventHandler(this.cbxFadeOutAddLength_CheckedChanged);
            // 
            // lbFadeOut
            // 
            this.lbFadeOut.AutoSize = true;
            this.lbFadeOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbFadeOut.Location = new System.Drawing.Point(8, 24);
            this.lbFadeOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFadeOut.Name = "lbFadeOut";
            this.lbFadeOut.Size = new System.Drawing.Size(87, 17);
            this.lbFadeOut.TabIndex = 0;
            this.lbFadeOut.Text = "New Length:";
            // 
            // nudFadeOut
            // 
            this.nudFadeOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nudFadeOut.Location = new System.Drawing.Point(96, 22);
            this.nudFadeOut.Margin = new System.Windows.Forms.Padding(4);
            this.nudFadeOut.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudFadeOut.Name = "nudFadeOut";
            this.nudFadeOut.Size = new System.Drawing.Size(98, 23);
            this.nudFadeOut.TabIndex = 0;
            // 
            // cbxFadeOutToZero
            // 
            this.cbxFadeOutToZero.AutoSize = true;
            this.cbxFadeOutToZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbxFadeOutToZero.Location = new System.Drawing.Point(11, 54);
            this.cbxFadeOutToZero.Name = "cbxFadeOutToZero";
            this.cbxFadeOutToZero.Size = new System.Drawing.Size(119, 21);
            this.cbxFadeOutToZero.TabIndex = 2;
            this.cbxFadeOutToZero.Text = "Set length to 0";
            this.cbxFadeOutToZero.UseVisualStyleBackColor = true;
            this.cbxFadeOutToZero.CheckedChanged += new System.EventHandler(this.cbxFadeOutToZero_CheckedChanged);
            // 
            // lbFadeOutCurve
            // 
            this.lbFadeOutCurve.AutoSize = true;
            this.lbFadeOutCurve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbFadeOutCurve.Location = new System.Drawing.Point(8, 89);
            this.lbFadeOutCurve.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFadeOutCurve.Name = "lbFadeOutCurve";
            this.lbFadeOutCurve.Size = new System.Drawing.Size(80, 17);
            this.lbFadeOutCurve.TabIndex = 2;
            this.lbFadeOutCurve.Text = "Curve type:";
            // 
            // cbFadeOutCurve
            // 
            this.cbFadeOutCurve.Enabled = false;
            this.cbFadeOutCurve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbFadeOutCurve.FormattingEnabled = true;
            this.cbFadeOutCurve.Items.AddRange(new object[] {
            "Fast",
            "Linear",
            "Sharp",
            "Slow",
            "Smooth"});
            this.cbFadeOutCurve.Location = new System.Drawing.Point(96, 86);
            this.cbFadeOutCurve.Margin = new System.Windows.Forms.Padding(4);
            this.cbFadeOutCurve.Name = "cbFadeOutCurve";
            this.cbFadeOutCurve.Size = new System.Drawing.Size(98, 24);
            this.cbFadeOutCurve.TabIndex = 5;
            this.cbFadeOutCurve.Text = "Smooth";
            // 
            // cbxChangeFadeOutCurveType
            // 
            this.cbxChangeFadeOutCurveType.AutoSize = true;
            this.cbxChangeFadeOutCurveType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbxChangeFadeOutCurveType.Location = new System.Drawing.Point(200, 88);
            this.cbxChangeFadeOutCurveType.Name = "cbxChangeFadeOutCurveType";
            this.cbxChangeFadeOutCurveType.Size = new System.Drawing.Size(115, 21);
            this.cbxChangeFadeOutCurveType.TabIndex = 6;
            this.cbxChangeFadeOutCurveType.Text = "Change curve";
            this.cbxChangeFadeOutCurveType.UseVisualStyleBackColor = true;
            this.cbxChangeFadeOutCurveType.CheckedChanged += new System.EventHandler(this.cbxChangeFadeOutCurveType_CheckedChanged);
            // 
            // cbFadeOutTimecode
            // 
            this.cbFadeOutTimecode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbFadeOutTimecode.FormattingEnabled = true;
            this.cbFadeOutTimecode.Items.AddRange(new object[] {
            "Frames",
            "Seconds"});
            this.cbFadeOutTimecode.Location = new System.Drawing.Point(200, 21);
            this.cbFadeOutTimecode.Margin = new System.Windows.Forms.Padding(4, 4, 8, 4);
            this.cbFadeOutTimecode.Name = "cbFadeOutTimecode";
            this.cbFadeOutTimecode.Size = new System.Drawing.Size(120, 24);
            this.cbFadeOutTimecode.TabIndex = 1;
            this.cbFadeOutTimecode.Text = "Frames";
            // 
            // cbxFIReduceLength
            // 
            this.cbxFIReduceLength.AutoSize = true;
            this.cbxFIReduceLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbxFIReduceLength.Location = new System.Drawing.Point(200, 50);
            this.cbxFIReduceLength.Name = "cbxFIReduceLength";
            this.cbxFIReduceLength.Size = new System.Drawing.Size(124, 21);
            this.cbxFIReduceLength.TabIndex = 4;
            this.cbxFIReduceLength.Text = "Reduce Length";
            this.cbxFIReduceLength.UseVisualStyleBackColor = true;
            this.cbxFIReduceLength.CheckedChanged += new System.EventHandler(this.cbxFadeInReduceLength_CheckedChanged);
            // 
            // cbxFIAddLength
            // 
            this.cbxFIAddLength.AutoSize = true;
            this.cbxFIAddLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbxFIAddLength.Location = new System.Drawing.Point(142, 50);
            this.cbxFIAddLength.Name = "cbxFIAddLength";
            this.cbxFIAddLength.Size = new System.Drawing.Size(52, 21);
            this.cbxFIAddLength.TabIndex = 3;
            this.cbxFIAddLength.Text = "Add";
            this.cbxFIAddLength.UseVisualStyleBackColor = true;
            this.cbxFIAddLength.CheckedChanged += new System.EventHandler(this.cbxFadeInAddLength_CheckedChanged);
            // 
            // FadeInGroup
            // 
            this.FadeInGroup.Controls.Add(this.cbxFIAddLength);
            this.FadeInGroup.Controls.Add(this.cbxFIReduceLength);
            this.FadeInGroup.Controls.Add(this.lbFadeIn);
            this.FadeInGroup.Controls.Add(this.cbxFadeInToZero);
            this.FadeInGroup.Controls.Add(this.nudFadeIn);
            this.FadeInGroup.Controls.Add(this.lbFadeInCurve);
            this.FadeInGroup.Controls.Add(this.cbFadeInCurve);
            this.FadeInGroup.Controls.Add(this.cbFadeInTimecode);
            this.FadeInGroup.Controls.Add(this.cbxChangeFadeInCurveType);
            this.FadeInGroup.Location = new System.Drawing.Point(10, 33);
            this.FadeInGroup.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.FadeInGroup.Name = "FadeInGroup";
            this.FadeInGroup.Size = new System.Drawing.Size(331, 126);
            this.FadeInGroup.TabIndex = 9;
            this.FadeInGroup.TabStop = false;
            this.FadeInGroup.Text = "Fade In settings";
            // 
            // lbFadeIn
            // 
            this.lbFadeIn.AutoSize = true;
            this.lbFadeIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbFadeIn.Location = new System.Drawing.Point(8, 20);
            this.lbFadeIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFadeIn.Name = "lbFadeIn";
            this.lbFadeIn.Size = new System.Drawing.Size(87, 17);
            this.lbFadeIn.TabIndex = 0;
            this.lbFadeIn.Text = "New Length:";
            // 
            // cbxFadeInToZero
            // 
            this.cbxFadeInToZero.AutoSize = true;
            this.cbxFadeInToZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbxFadeInToZero.Location = new System.Drawing.Point(11, 50);
            this.cbxFadeInToZero.Name = "cbxFadeInToZero";
            this.cbxFadeInToZero.Size = new System.Drawing.Size(119, 21);
            this.cbxFadeInToZero.TabIndex = 2;
            this.cbxFadeInToZero.Text = "Set length to 0";
            this.cbxFadeInToZero.UseVisualStyleBackColor = true;
            this.cbxFadeInToZero.CheckedChanged += new System.EventHandler(this.cbxFadeInToZero_CheckedChanged);
            // 
            // nudFadeIn
            // 
            this.nudFadeIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nudFadeIn.Location = new System.Drawing.Point(96, 18);
            this.nudFadeIn.Margin = new System.Windows.Forms.Padding(4);
            this.nudFadeIn.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudFadeIn.Name = "nudFadeIn";
            this.nudFadeIn.Size = new System.Drawing.Size(98, 23);
            this.nudFadeIn.TabIndex = 0;
            // 
            // lbFadeInCurve
            // 
            this.lbFadeInCurve.AutoSize = true;
            this.lbFadeInCurve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbFadeInCurve.Location = new System.Drawing.Point(8, 85);
            this.lbFadeInCurve.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFadeInCurve.Name = "lbFadeInCurve";
            this.lbFadeInCurve.Size = new System.Drawing.Size(80, 17);
            this.lbFadeInCurve.TabIndex = 2;
            this.lbFadeInCurve.Text = "Curve type:";
            // 
            // cbFadeInCurve
            // 
            this.cbFadeInCurve.Enabled = false;
            this.cbFadeInCurve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbFadeInCurve.FormattingEnabled = true;
            this.cbFadeInCurve.Items.AddRange(new object[] {
            "Fast",
            "Linear",
            "Sharp",
            "Slow",
            "Smooth"});
            this.cbFadeInCurve.Location = new System.Drawing.Point(96, 82);
            this.cbFadeInCurve.Margin = new System.Windows.Forms.Padding(4);
            this.cbFadeInCurve.Name = "cbFadeInCurve";
            this.cbFadeInCurve.Size = new System.Drawing.Size(98, 24);
            this.cbFadeInCurve.TabIndex = 5;
            this.cbFadeInCurve.Text = "Smooth";
            // 
            // cbFadeInTimecode
            // 
            this.cbFadeInTimecode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbFadeInTimecode.FormattingEnabled = true;
            this.cbFadeInTimecode.Items.AddRange(new object[] {
            "Frames",
            "Seconds"});
            this.cbFadeInTimecode.Location = new System.Drawing.Point(200, 17);
            this.cbFadeInTimecode.Margin = new System.Windows.Forms.Padding(4, 4, 8, 4);
            this.cbFadeInTimecode.Name = "cbFadeInTimecode";
            this.cbFadeInTimecode.Size = new System.Drawing.Size(120, 24);
            this.cbFadeInTimecode.TabIndex = 1;
            this.cbFadeInTimecode.Text = "Frames";
            // 
            // cbxChangeFadeInCurveType
            // 
            this.cbxChangeFadeInCurveType.AutoSize = true;
            this.cbxChangeFadeInCurveType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbxChangeFadeInCurveType.Location = new System.Drawing.Point(200, 85);
            this.cbxChangeFadeInCurveType.Name = "cbxChangeFadeInCurveType";
            this.cbxChangeFadeInCurveType.Size = new System.Drawing.Size(115, 21);
            this.cbxChangeFadeInCurveType.TabIndex = 6;
            this.cbxChangeFadeInCurveType.Text = "Change curve";
            this.cbxChangeFadeInCurveType.UseVisualStyleBackColor = true;
            this.cbxChangeFadeInCurveType.CheckedChanged += new System.EventHandler(this.cbxChangeFadeInCurveType_CheckedChanged);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(264, 297);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(78, 34);
            this.btnHelp.TabIndex = 12;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btRun
            // 
            this.btRun.Location = new System.Drawing.Point(10, 297);
            this.btRun.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btRun.Name = "btRun";
            this.btRun.Size = new System.Drawing.Size(248, 34);
            this.btRun.TabIndex = 11;
            this.btRun.Text = "Run";
            this.btRun.UseVisualStyleBackColor = true;
            this.btRun.Click += new System.EventHandler(this.btRun_Click);
            // 
            // CustomFades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.FadeOutGroup);
            this.Controls.Add(this.FadeInGroup);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btRun);
            this.Controls.Add(this.lblCustomFadesAbout);
            this.Name = "CustomFades";
            this.Size = new System.Drawing.Size(421, 417);
            this.FadeOutGroup.ResumeLayout(false);
            this.FadeOutGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFadeOut)).EndInit();
            this.FadeInGroup.ResumeLayout(false);
            this.FadeInGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFadeIn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.LinkLabel lblCustomFadesAbout;
        private System.Windows.Forms.CheckBox cbxFOReduceLength;
        private System.Windows.Forms.GroupBox FadeOutGroup;
        private System.Windows.Forms.CheckBox cbxFOAddLength;
        private System.Windows.Forms.Label lbFadeOut;
        private System.Windows.Forms.NumericUpDown nudFadeOut;
        private System.Windows.Forms.CheckBox cbxFadeOutToZero;
        private System.Windows.Forms.Label lbFadeOutCurve;
        private System.Windows.Forms.ComboBox cbFadeOutCurve;
        private System.Windows.Forms.CheckBox cbxChangeFadeOutCurveType;
        private System.Windows.Forms.ComboBox cbFadeOutTimecode;
        private System.Windows.Forms.CheckBox cbxFIReduceLength;
        private System.Windows.Forms.CheckBox cbxFIAddLength;
        private System.Windows.Forms.GroupBox FadeInGroup;
        private System.Windows.Forms.Label lbFadeIn;
        private System.Windows.Forms.CheckBox cbxFadeInToZero;
        private System.Windows.Forms.NumericUpDown nudFadeIn;
        private System.Windows.Forms.Label lbFadeInCurve;
        private System.Windows.Forms.ComboBox cbFadeInCurve;
        private System.Windows.Forms.ComboBox cbFadeInTimecode;
        private System.Windows.Forms.CheckBox cbxChangeFadeInCurveType;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btRun;
    }
}
