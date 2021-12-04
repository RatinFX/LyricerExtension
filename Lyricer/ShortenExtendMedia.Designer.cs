namespace Lyricer
{
	partial class ShortenExtendMedia
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
            this.lblShortenExtendMediaAbout = new System.Windows.Forms.LinkLabel();
            this.nudExtend = new System.Windows.Forms.NumericUpDown();
            this.lblExtendLength = new System.Windows.Forms.Label();
            this.cbExtendTimecode = new System.Windows.Forms.ComboBox();
            this.gbxExtend = new System.Windows.Forms.GroupBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.nudShorten = new System.Windows.Forms.NumericUpDown();
            this.lblShortenLength = new System.Windows.Forms.Label();
            this.cbShortenTimecode = new System.Windows.Forms.ComboBox();
            this.gbxShorten = new System.Windows.Forms.GroupBox();
            this.lblBudgetTodo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudExtend)).BeginInit();
            this.gbxExtend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudShorten)).BeginInit();
            this.gbxShorten.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblShortenExtendMediaAbout
            // 
            this.lblShortenExtendMediaAbout.AutoSize = true;
            this.lblShortenExtendMediaAbout.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblShortenExtendMediaAbout.Location = new System.Drawing.Point(10, 10);
            this.lblShortenExtendMediaAbout.Margin = new System.Windows.Forms.Padding(10);
            this.lblShortenExtendMediaAbout.Name = "lblShortenExtendMediaAbout";
            this.lblShortenExtendMediaAbout.Size = new System.Drawing.Size(224, 13);
            this.lblShortenExtendMediaAbout.TabIndex = 6;
            this.lblShortenExtendMediaAbout.TabStop = true;
            this.lblShortenExtendMediaAbout.Text = "Shorten Extend Media by RatinA0 (github link)";
            this.lblShortenExtendMediaAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblShortenExtendMediaAbout_LinkClicked);
            // 
            // nudExtend
            // 
            this.nudExtend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudExtend.Location = new System.Drawing.Point(73, 18);
            this.nudExtend.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudExtend.Name = "nudExtend";
            this.nudExtend.Size = new System.Drawing.Size(86, 23);
            this.nudExtend.TabIndex = 2;
            // 
            // lblExtendLength
            // 
            this.lblExtendLength.AutoSize = true;
            this.lblExtendLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtendLength.Location = new System.Drawing.Point(11, 20);
            this.lblExtendLength.Name = "lblExtendLength";
            this.lblExtendLength.Size = new System.Drawing.Size(56, 17);
            this.lblExtendLength.TabIndex = 0;
            this.lblExtendLength.Text = "Length:";
            // 
            // cbExtendTimecode
            // 
            this.cbExtendTimecode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbExtendTimecode.FormattingEnabled = true;
            this.cbExtendTimecode.Items.AddRange(new object[] {
            "Frames",
            "Seconds"});
            this.cbExtendTimecode.Location = new System.Drawing.Point(166, 17);
            this.cbExtendTimecode.Margin = new System.Windows.Forms.Padding(4);
            this.cbExtendTimecode.Name = "cbExtendTimecode";
            this.cbExtendTimecode.Size = new System.Drawing.Size(98, 24);
            this.cbExtendTimecode.TabIndex = 3;
            this.cbExtendTimecode.Text = "Frames";
            // 
            // gbxExtend
            // 
            this.gbxExtend.Controls.Add(this.cbExtendTimecode);
            this.gbxExtend.Controls.Add(this.lblExtendLength);
            this.gbxExtend.Controls.Add(this.nudExtend);
            this.gbxExtend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxExtend.Location = new System.Drawing.Point(10, 94);
            this.gbxExtend.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.gbxExtend.Name = "gbxExtend";
            this.gbxExtend.Size = new System.Drawing.Size(277, 55);
            this.gbxExtend.TabIndex = 6;
            this.gbxExtend.TabStop = false;
            this.gbxExtend.Text = "Extend settings";
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(213, 155);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 30);
            this.btnHelp.TabIndex = 5;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(9, 155);
            this.btnRun.Margin = new System.Windows.Forms.Padding(10, 3, 3, 10);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(198, 30);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // nudShorten
            // 
            this.nudShorten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudShorten.Location = new System.Drawing.Point(73, 18);
            this.nudShorten.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudShorten.Name = "nudShorten";
            this.nudShorten.Size = new System.Drawing.Size(86, 23);
            this.nudShorten.TabIndex = 0;
            // 
            // lblShortenLength
            // 
            this.lblShortenLength.AutoSize = true;
            this.lblShortenLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShortenLength.Location = new System.Drawing.Point(11, 20);
            this.lblShortenLength.Name = "lblShortenLength";
            this.lblShortenLength.Size = new System.Drawing.Size(56, 17);
            this.lblShortenLength.TabIndex = 0;
            this.lblShortenLength.Text = "Length:";
            // 
            // cbShortenTimecode
            // 
            this.cbShortenTimecode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbShortenTimecode.FormattingEnabled = true;
            this.cbShortenTimecode.Items.AddRange(new object[] {
            "Frames",
            "Seconds"});
            this.cbShortenTimecode.Location = new System.Drawing.Point(166, 17);
            this.cbShortenTimecode.Margin = new System.Windows.Forms.Padding(4);
            this.cbShortenTimecode.Name = "cbShortenTimecode";
            this.cbShortenTimecode.Size = new System.Drawing.Size(98, 24);
            this.cbShortenTimecode.TabIndex = 1;
            this.cbShortenTimecode.Text = "Frames";
            // 
            // gbxShorten
            // 
            this.gbxShorten.Controls.Add(this.cbShortenTimecode);
            this.gbxShorten.Controls.Add(this.lblShortenLength);
            this.gbxShorten.Controls.Add(this.nudShorten);
            this.gbxShorten.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxShorten.Location = new System.Drawing.Point(10, 33);
            this.gbxShorten.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.gbxShorten.Name = "gbxShorten";
            this.gbxShorten.Size = new System.Drawing.Size(277, 55);
            this.gbxShorten.TabIndex = 5;
            this.gbxShorten.TabStop = false;
            this.gbxShorten.Text = "Shorten settings";
            // 
            // lblBudgetTodo
            // 
            this.lblBudgetTodo.AutoSize = true;
            this.lblBudgetTodo.Location = new System.Drawing.Point(10, 199);
            this.lblBudgetTodo.Name = "lblBudgetTodo";
            this.lblBudgetTodo.Size = new System.Drawing.Size(224, 13);
            this.lblBudgetTodo.TabIndex = 7;
            this.lblBudgetTodo.Text = "todo:?? - separate runs? - back to 0 after run?";
            // 
            // ShortenExtendMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lblBudgetTodo);
            this.Controls.Add(this.gbxShorten);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.gbxExtend);
            this.Controls.Add(this.lblShortenExtendMediaAbout);
            this.Name = "ShortenExtendMedia";
            this.Size = new System.Drawing.Size(400, 250);
            ((System.ComponentModel.ISupportInitialize)(this.nudExtend)).EndInit();
            this.gbxExtend.ResumeLayout(false);
            this.gbxExtend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudShorten)).EndInit();
            this.gbxShorten.ResumeLayout(false);
            this.gbxShorten.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.LinkLabel lblShortenExtendMediaAbout;
        private System.Windows.Forms.NumericUpDown nudExtend;
        private System.Windows.Forms.Label lblExtendLength;
        private System.Windows.Forms.ComboBox cbExtendTimecode;
        private System.Windows.Forms.GroupBox gbxExtend;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.NumericUpDown nudShorten;
        private System.Windows.Forms.Label lblShortenLength;
        private System.Windows.Forms.ComboBox cbShortenTimecode;
        private System.Windows.Forms.GroupBox gbxShorten;
        private System.Windows.Forms.Label lblBudgetTodo;
    }
}
