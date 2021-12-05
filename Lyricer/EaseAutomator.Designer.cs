namespace Lyricer
{
	partial class EaseAutomator
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
            this.components = new System.ComponentModel.Container();
            this.lblSelectedVideoMediaCount = new System.Windows.Forms.Label();
            this.lblSelectedAudioMediaCount = new System.Windows.Forms.Label();
            this.cbxWatchSelectedMedia = new System.Windows.Forms.CheckBox();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.listSelectedMedia = new System.Windows.Forms.ListView();
            this.listSelectedMediaEffects = new System.Windows.Forms.ListView();
            this.grpSelectedMediaEffectsGroup = new System.Windows.Forms.GroupBox();
            this.grpSelectedMediasGroup = new System.Windows.Forms.GroupBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.grpEaseTypes = new System.Windows.Forms.GroupBox();
            this.cbxEaseCurveTypes = new System.Windows.Forms.ComboBox();
            this.cbxEaseType = new System.Windows.Forms.ComboBox();
            this.grpValues = new System.Windows.Forms.GroupBox();
            this.grpGraph = new System.Windows.Forms.GroupBox();
            this.grpTestAnimation = new System.Windows.Forms.GroupBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudProp1 = new System.Windows.Forms.NumericUpDown();
            this.lblProp1 = new System.Windows.Forms.Label();
            this.lblProp2 = new System.Windows.Forms.Label();
            this.nudProp2 = new System.Windows.Forms.NumericUpDown();
            this.trbProp1 = new System.Windows.Forms.TrackBar();
            this.trbProp2 = new System.Windows.Forms.TrackBar();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.grpInfo.SuspendLayout();
            this.grpSelectedMediaEffectsGroup.SuspendLayout();
            this.grpSelectedMediasGroup.SuspendLayout();
            this.grpEaseTypes.SuspendLayout();
            this.grpValues.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbProp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbProp2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelectedVideoMediaCount
            // 
            this.lblSelectedVideoMediaCount.AutoSize = true;
            this.lblSelectedVideoMediaCount.Location = new System.Drawing.Point(10, 42);
            this.lblSelectedVideoMediaCount.Margin = new System.Windows.Forms.Padding(3);
            this.lblSelectedVideoMediaCount.Name = "lblSelectedVideoMediaCount";
            this.lblSelectedVideoMediaCount.Size = new System.Drawing.Size(153, 13);
            this.lblSelectedVideoMediaCount.TabIndex = 0;
            this.lblSelectedVideoMediaCount.Text = "Selected Video Media count: 0";
            // 
            // lblSelectedAudioMediaCount
            // 
            this.lblSelectedAudioMediaCount.AutoSize = true;
            this.lblSelectedAudioMediaCount.Location = new System.Drawing.Point(10, 65);
            this.lblSelectedAudioMediaCount.Margin = new System.Windows.Forms.Padding(3);
            this.lblSelectedAudioMediaCount.Name = "lblSelectedAudioMediaCount";
            this.lblSelectedAudioMediaCount.Size = new System.Drawing.Size(153, 13);
            this.lblSelectedAudioMediaCount.TabIndex = 1;
            this.lblSelectedAudioMediaCount.Text = "Selected Audio Media count: 0";
            // 
            // cbxWatchSelectedMedia
            // 
            this.cbxWatchSelectedMedia.AutoSize = true;
            this.cbxWatchSelectedMedia.Checked = true;
            this.cbxWatchSelectedMedia.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxWatchSelectedMedia.Location = new System.Drawing.Point(13, 19);
            this.cbxWatchSelectedMedia.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.cbxWatchSelectedMedia.Name = "cbxWatchSelectedMedia";
            this.cbxWatchSelectedMedia.Size = new System.Drawing.Size(135, 17);
            this.cbxWatchSelectedMedia.TabIndex = 2;
            this.cbxWatchSelectedMedia.Text = "Watch Selected Media";
            this.cbxWatchSelectedMedia.UseVisualStyleBackColor = true;
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.cbxWatchSelectedMedia);
            this.grpInfo.Controls.Add(this.lblSelectedAudioMediaCount);
            this.grpInfo.Controls.Add(this.lblSelectedVideoMediaCount);
            this.grpInfo.Location = new System.Drawing.Point(10, 10);
            this.grpInfo.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(179, 95);
            this.grpInfo.TabIndex = 3;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Info";
            // 
            // listSelectedMedia
            // 
            this.listSelectedMedia.HideSelection = false;
            this.listSelectedMedia.Location = new System.Drawing.Point(13, 19);
            this.listSelectedMedia.Margin = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.listSelectedMedia.Name = "listSelectedMedia";
            this.listSelectedMedia.Size = new System.Drawing.Size(153, 38);
            this.listSelectedMedia.TabIndex = 4;
            this.listSelectedMedia.UseCompatibleStateImageBehavior = false;
            this.listSelectedMedia.View = System.Windows.Forms.View.List;
            this.listSelectedMedia.SelectedIndexChanged += new System.EventHandler(this.listSelectedMedia_SelectedIndexChanged);
            // 
            // listSelectedMediaEffects
            // 
            this.listSelectedMediaEffects.HideSelection = false;
            this.listSelectedMediaEffects.Location = new System.Drawing.Point(13, 19);
            this.listSelectedMediaEffects.Margin = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.listSelectedMediaEffects.Name = "listSelectedMediaEffects";
            this.listSelectedMediaEffects.Size = new System.Drawing.Size(153, 38);
            this.listSelectedMediaEffects.TabIndex = 5;
            this.listSelectedMediaEffects.UseCompatibleStateImageBehavior = false;
            this.listSelectedMediaEffects.View = System.Windows.Forms.View.List;
            // 
            // grpSelectedMediaEffectsGroup
            // 
            this.grpSelectedMediaEffectsGroup.Controls.Add(this.listSelectedMediaEffects);
            this.grpSelectedMediaEffectsGroup.Location = new System.Drawing.Point(10, 195);
            this.grpSelectedMediaEffectsGroup.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.grpSelectedMediaEffectsGroup.Name = "grpSelectedMediaEffectsGroup";
            this.grpSelectedMediaEffectsGroup.Size = new System.Drawing.Size(179, 70);
            this.grpSelectedMediaEffectsGroup.TabIndex = 6;
            this.grpSelectedMediaEffectsGroup.TabStop = false;
            this.grpSelectedMediaEffectsGroup.Text = "Selected Media Effects";
            // 
            // grpSelectedMediasGroup
            // 
            this.grpSelectedMediasGroup.Controls.Add(this.listSelectedMedia);
            this.grpSelectedMediasGroup.Location = new System.Drawing.Point(10, 115);
            this.grpSelectedMediasGroup.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.grpSelectedMediasGroup.Name = "grpSelectedMediasGroup";
            this.grpSelectedMediasGroup.Size = new System.Drawing.Size(179, 70);
            this.grpSelectedMediasGroup.TabIndex = 7;
            this.grpSelectedMediasGroup.TabStop = false;
            this.grpSelectedMediasGroup.Text = "Selected Medias";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(13, 19);
            this.btnTest.Margin = new System.Windows.Forms.Padding(10, 3, 10, 0);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(153, 23);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            // 
            // btnRun
            // 
            this.btnRun.Enabled = false;
            this.btnRun.Location = new System.Drawing.Point(13, 52);
            this.btnRun.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(153, 23);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            // 
            // grpEaseTypes
            // 
            this.grpEaseTypes.Controls.Add(this.cbxEaseType);
            this.grpEaseTypes.Controls.Add(this.cbxEaseCurveTypes);
            this.grpEaseTypes.Location = new System.Drawing.Point(10, 278);
            this.grpEaseTypes.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.grpEaseTypes.Name = "grpEaseTypes";
            this.grpEaseTypes.Size = new System.Drawing.Size(179, 87);
            this.grpEaseTypes.TabIndex = 9;
            this.grpEaseTypes.TabStop = false;
            this.grpEaseTypes.Text = "Ease Types";
            // 
            // cbxEaseCurveTypes
            // 
            this.cbxEaseCurveTypes.FormattingEnabled = true;
            this.cbxEaseCurveTypes.Items.AddRange(new object[] {
            "Polynominal",
            "Exponential",
            "Fractional",
            "Circular",
            "Sine",
            "Hyp Sine",
            "Tangent",
            "Hyp Tangent",
            "Bounce",
            "Elastic"});
            this.cbxEaseCurveTypes.Location = new System.Drawing.Point(13, 19);
            this.cbxEaseCurveTypes.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.cbxEaseCurveTypes.Name = "cbxEaseCurveTypes";
            this.cbxEaseCurveTypes.Size = new System.Drawing.Size(153, 21);
            this.cbxEaseCurveTypes.TabIndex = 0;
            this.cbxEaseCurveTypes.Text = "Polynominal";
            // 
            // cbxEaseType
            // 
            this.cbxEaseType.FormattingEnabled = true;
            this.cbxEaseType.Items.AddRange(new object[] {
            "Ease in",
            "Ease out",
            "Ease in out",
            "Ease out in"});
            this.cbxEaseType.Location = new System.Drawing.Point(13, 53);
            this.cbxEaseType.Margin = new System.Windows.Forms.Padding(10);
            this.cbxEaseType.Name = "cbxEaseType";
            this.cbxEaseType.Size = new System.Drawing.Size(153, 21);
            this.cbxEaseType.TabIndex = 1;
            this.cbxEaseType.Text = "Ease in";
            // 
            // grpValues
            // 
            this.grpValues.Controls.Add(this.trbProp2);
            this.grpValues.Controls.Add(this.trbProp1);
            this.grpValues.Controls.Add(this.lblProp2);
            this.grpValues.Controls.Add(this.nudProp2);
            this.grpValues.Controls.Add(this.lblProp1);
            this.grpValues.Controls.Add(this.nudProp1);
            this.grpValues.Location = new System.Drawing.Point(202, 115);
            this.grpValues.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.grpValues.Name = "grpValues";
            this.grpValues.Size = new System.Drawing.Size(336, 203);
            this.grpValues.TabIndex = 10;
            this.grpValues.TabStop = false;
            this.grpValues.Text = "Values";
            // 
            // grpGraph
            // 
            this.grpGraph.Location = new System.Drawing.Point(202, 328);
            this.grpGraph.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.grpGraph.Name = "grpGraph";
            this.grpGraph.Size = new System.Drawing.Size(336, 168);
            this.grpGraph.TabIndex = 11;
            this.grpGraph.TabStop = false;
            this.grpGraph.Text = "Graph";
            // 
            // grpTestAnimation
            // 
            this.grpTestAnimation.Location = new System.Drawing.Point(202, 10);
            this.grpTestAnimation.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.grpTestAnimation.Name = "grpTestAnimation";
            this.grpTestAnimation.Size = new System.Drawing.Size(336, 95);
            this.grpTestAnimation.TabIndex = 12;
            this.grpTestAnimation.TabStop = false;
            this.grpTestAnimation.Text = "Test Animation";
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(13, 85);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(10);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(153, 23);
            this.btnHelp.TabIndex = 13;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTest);
            this.groupBox1.Controls.Add(this.btnHelp);
            this.groupBox1.Controls.Add(this.btnRun);
            this.groupBox1.Location = new System.Drawing.Point(10, 375);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 121);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // nudProp1
            // 
            this.nudProp1.Location = new System.Drawing.Point(244, 19);
            this.nudProp1.Name = "nudProp1";
            this.nudProp1.Size = new System.Drawing.Size(86, 20);
            this.nudProp1.TabIndex = 0;
            this.nudProp1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblProp1
            // 
            this.lblProp1.AutoSize = true;
            this.lblProp1.Location = new System.Drawing.Point(171, 21);
            this.lblProp1.Name = "lblProp1";
            this.lblProp1.Size = new System.Drawing.Size(67, 13);
            this.lblProp1.TabIndex = 1;
            this.lblProp1.Text = "Prop 1 name";
            // 
            // lblProp2
            // 
            this.lblProp2.AutoSize = true;
            this.lblProp2.Location = new System.Drawing.Point(6, 21);
            this.lblProp2.Name = "lblProp2";
            this.lblProp2.Size = new System.Drawing.Size(67, 13);
            this.lblProp2.TabIndex = 3;
            this.lblProp2.Text = "Prop 2 name";
            // 
            // nudProp2
            // 
            this.nudProp2.Location = new System.Drawing.Point(79, 19);
            this.nudProp2.Name = "nudProp2";
            this.nudProp2.Size = new System.Drawing.Size(86, 20);
            this.nudProp2.TabIndex = 2;
            this.nudProp2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // trbProp1
            // 
            this.trbProp1.LargeChange = 1;
            this.trbProp1.Location = new System.Drawing.Point(9, 45);
            this.trbProp1.Name = "trbProp1";
            this.trbProp1.Size = new System.Drawing.Size(156, 45);
            this.trbProp1.TabIndex = 4;
            this.trbProp1.Value = 5;
            // 
            // trbProp2
            // 
            this.trbProp2.Location = new System.Drawing.Point(174, 45);
            this.trbProp2.Name = "trbProp2";
            this.trbProp2.Size = new System.Drawing.Size(156, 45);
            this.trbProp2.TabIndex = 5;
            this.trbProp2.Value = 5;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // EaseAutomator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpTestAnimation);
            this.Controls.Add(this.grpGraph);
            this.Controls.Add(this.grpValues);
            this.Controls.Add(this.grpEaseTypes);
            this.Controls.Add(this.grpSelectedMediasGroup);
            this.Controls.Add(this.grpSelectedMediaEffectsGroup);
            this.Controls.Add(this.grpInfo);
            this.Name = "EaseAutomator";
            this.Size = new System.Drawing.Size(645, 621);
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.grpSelectedMediaEffectsGroup.ResumeLayout(false);
            this.grpSelectedMediasGroup.ResumeLayout(false);
            this.grpEaseTypes.ResumeLayout(false);
            this.grpValues.ResumeLayout(false);
            this.grpValues.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudProp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbProp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbProp2)).EndInit();
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.Label lblSelectedVideoMediaCount;
        private System.Windows.Forms.Label lblSelectedAudioMediaCount;
        private System.Windows.Forms.CheckBox cbxWatchSelectedMedia;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.ListView listSelectedMedia;
        private System.Windows.Forms.ListView listSelectedMediaEffects;
        private System.Windows.Forms.GroupBox grpSelectedMediaEffectsGroup;
        private System.Windows.Forms.GroupBox grpSelectedMediasGroup;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.GroupBox grpEaseTypes;
        private System.Windows.Forms.ComboBox cbxEaseType;
        private System.Windows.Forms.ComboBox cbxEaseCurveTypes;
        private System.Windows.Forms.GroupBox grpValues;
        private System.Windows.Forms.GroupBox grpGraph;
        private System.Windows.Forms.GroupBox grpTestAnimation;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblProp2;
        private System.Windows.Forms.NumericUpDown nudProp2;
        private System.Windows.Forms.Label lblProp1;
        private System.Windows.Forms.NumericUpDown nudProp1;
        private System.Windows.Forms.TrackBar trbProp2;
        private System.Windows.Forms.TrackBar trbProp1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}
