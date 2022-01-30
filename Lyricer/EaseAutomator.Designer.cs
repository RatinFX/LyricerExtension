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
            this.cbxWatchSelectedMedia = new System.Windows.Forms.CheckBox();
            this.grpSelectedMediaEffectsGroup = new System.Windows.Forms.GroupBox();
            this.listSelectedMediaEffects = new System.Windows.Forms.ListBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.grpEaseTypes = new System.Windows.Forms.GroupBox();
            this.cbxEaseTypes = new System.Windows.Forms.ComboBox();
            this.cbxEaseCurveTypes = new System.Windows.Forms.ComboBox();
            this.grpValues = new System.Windows.Forms.GroupBox();
            this.trbProp2 = new System.Windows.Forms.TrackBar();
            this.trbProp1 = new System.Windows.Forms.TrackBar();
            this.lblProp2 = new System.Windows.Forms.Label();
            this.nudProp2 = new System.Windows.Forms.NumericUpDown();
            this.lblProp1 = new System.Windows.Forms.Label();
            this.nudProp1 = new System.Windows.Forms.NumericUpDown();
            this.grpGraph = new System.Windows.Forms.GroupBox();
            this.grpTestAnimation = new System.Windows.Forms.GroupBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpSelectedEffectPropertiesGroup = new System.Windows.Forms.GroupBox();
            this.listSelectedEffectProperties = new System.Windows.Forms.ListBox();
            this.grpSelectedMediaEffectsGroup.SuspendLayout();
            this.grpEaseTypes.SuspendLayout();
            this.grpValues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbProp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbProp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProp1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpSelectedEffectPropertiesGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxWatchSelectedMedia
            // 
            this.cbxWatchSelectedMedia.AutoSize = true;
            this.cbxWatchSelectedMedia.Location = new System.Drawing.Point(10, 10);
            this.cbxWatchSelectedMedia.Margin = new System.Windows.Forms.Padding(10);
            this.cbxWatchSelectedMedia.Name = "cbxWatchSelectedMedia";
            this.cbxWatchSelectedMedia.Size = new System.Drawing.Size(135, 17);
            this.cbxWatchSelectedMedia.TabIndex = 2;
            this.cbxWatchSelectedMedia.Text = "Watch Selected Media";
            this.cbxWatchSelectedMedia.UseVisualStyleBackColor = true;
            // 
            // grpSelectedMediaEffectsGroup
            // 
            this.grpSelectedMediaEffectsGroup.Controls.Add(this.listSelectedMediaEffects);
            this.grpSelectedMediaEffectsGroup.Location = new System.Drawing.Point(10, 37);
            this.grpSelectedMediaEffectsGroup.Margin = new System.Windows.Forms.Padding(10, 0, 3, 10);
            this.grpSelectedMediaEffectsGroup.Name = "grpSelectedMediaEffectsGroup";
            this.grpSelectedMediaEffectsGroup.Size = new System.Drawing.Size(179, 88);
            this.grpSelectedMediaEffectsGroup.TabIndex = 6;
            this.grpSelectedMediaEffectsGroup.TabStop = false;
            this.grpSelectedMediaEffectsGroup.Text = "Selected Media Effects";
            // 
            // listSelectedMediaEffects
            // 
            this.listSelectedMediaEffects.FormattingEnabled = true;
            this.listSelectedMediaEffects.Location = new System.Drawing.Point(0, 19);
            this.listSelectedMediaEffects.Margin = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.listSelectedMediaEffects.Name = "listSelectedMediaEffects";
            this.listSelectedMediaEffects.Size = new System.Drawing.Size(179, 69);
            this.listSelectedMediaEffects.TabIndex = 0;
            this.listSelectedMediaEffects.SelectedIndexChanged += new System.EventHandler(this.listSelectedMediaEffects_SelectedIndexChanged);
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
            this.btnRun.Location = new System.Drawing.Point(186, 19);
            this.btnRun.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(153, 23);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            // 
            // grpEaseTypes
            // 
            this.grpEaseTypes.Controls.Add(this.cbxEaseTypes);
            this.grpEaseTypes.Controls.Add(this.cbxEaseCurveTypes);
            this.grpEaseTypes.Location = new System.Drawing.Point(10, 314);
            this.grpEaseTypes.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.grpEaseTypes.Name = "grpEaseTypes";
            this.grpEaseTypes.Size = new System.Drawing.Size(179, 84);
            this.grpEaseTypes.TabIndex = 9;
            this.grpEaseTypes.TabStop = false;
            this.grpEaseTypes.Text = "Ease Types";
            // 
            // cbxEaseTypes
            // 
            this.cbxEaseTypes.FormattingEnabled = true;
            this.cbxEaseTypes.Items.AddRange(new object[] {
            "Ease In",
            "Ease Out",
            "Ease In Out",
            "Ease Out In"});
            this.cbxEaseTypes.Location = new System.Drawing.Point(13, 50);
            this.cbxEaseTypes.Margin = new System.Windows.Forms.Padding(10);
            this.cbxEaseTypes.Name = "cbxEaseTypes";
            this.cbxEaseTypes.Size = new System.Drawing.Size(153, 21);
            this.cbxEaseTypes.TabIndex = 1;
            this.cbxEaseTypes.Text = "Ease in";
            this.cbxEaseTypes.SelectedIndexChanged += new System.EventHandler(this.cbxEaseType_SelectedIndexChanged);
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
            this.cbxEaseCurveTypes.Margin = new System.Windows.Forms.Padding(10, 3, 10, 0);
            this.cbxEaseCurveTypes.Name = "cbxEaseCurveTypes";
            this.cbxEaseCurveTypes.Size = new System.Drawing.Size(153, 21);
            this.cbxEaseCurveTypes.TabIndex = 0;
            this.cbxEaseCurveTypes.Text = "Polynominal";
            this.cbxEaseCurveTypes.SelectedIndexChanged += new System.EventHandler(this.cbxEaseCurveTypes_SelectedIndexChanged);
            // 
            // grpValues
            // 
            this.grpValues.Controls.Add(this.trbProp2);
            this.grpValues.Controls.Add(this.trbProp1);
            this.grpValues.Controls.Add(this.lblProp2);
            this.grpValues.Controls.Add(this.nudProp2);
            this.grpValues.Controls.Add(this.lblProp1);
            this.grpValues.Controls.Add(this.nudProp1);
            this.grpValues.Location = new System.Drawing.Point(202, 278);
            this.grpValues.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.grpValues.Name = "grpValues";
            this.grpValues.Size = new System.Drawing.Size(336, 120);
            this.grpValues.TabIndex = 10;
            this.grpValues.TabStop = false;
            this.grpValues.Text = "Values";
            // 
            // trbProp2
            // 
            this.trbProp2.BackColor = System.Drawing.Color.White;
            this.trbProp2.Location = new System.Drawing.Point(174, 45);
            this.trbProp2.Name = "trbProp2";
            this.trbProp2.Size = new System.Drawing.Size(156, 45);
            this.trbProp2.TabIndex = 5;
            this.trbProp2.Value = 5;
            // 
            // trbProp1
            // 
            this.trbProp1.BackColor = System.Drawing.Color.White;
            this.trbProp1.LargeChange = 1;
            this.trbProp1.Location = new System.Drawing.Point(9, 45);
            this.trbProp1.Name = "trbProp1";
            this.trbProp1.Size = new System.Drawing.Size(156, 45);
            this.trbProp1.TabIndex = 4;
            this.trbProp1.Value = 5;
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
            // lblProp1
            // 
            this.lblProp1.AutoSize = true;
            this.lblProp1.Location = new System.Drawing.Point(171, 21);
            this.lblProp1.Name = "lblProp1";
            this.lblProp1.Size = new System.Drawing.Size(67, 13);
            this.lblProp1.TabIndex = 1;
            this.lblProp1.Text = "Prop 1 name";
            // 
            // nudProp1
            // 
            this.nudProp1.Location = new System.Drawing.Point(244, 19);
            this.nudProp1.Name = "nudProp1";
            this.nudProp1.Size = new System.Drawing.Size(86, 20);
            this.nudProp1.TabIndex = 0;
            this.nudProp1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grpGraph
            // 
            this.grpGraph.Location = new System.Drawing.Point(202, 115);
            this.grpGraph.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.grpGraph.Name = "grpGraph";
            this.grpGraph.Size = new System.Drawing.Size(336, 150);
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
            this.btnHelp.Location = new System.Drawing.Point(359, 19);
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
            this.groupBox1.Location = new System.Drawing.Point(10, 408);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 57);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // grpSelectedEffectPropertiesGroup
            // 
            this.grpSelectedEffectPropertiesGroup.Controls.Add(this.listSelectedEffectProperties);
            this.grpSelectedEffectPropertiesGroup.Location = new System.Drawing.Point(10, 135);
            this.grpSelectedEffectPropertiesGroup.Margin = new System.Windows.Forms.Padding(10, 0, 3, 10);
            this.grpSelectedEffectPropertiesGroup.Name = "grpSelectedEffectPropertiesGroup";
            this.grpSelectedEffectPropertiesGroup.Size = new System.Drawing.Size(179, 166);
            this.grpSelectedEffectPropertiesGroup.TabIndex = 7;
            this.grpSelectedEffectPropertiesGroup.TabStop = false;
            this.grpSelectedEffectPropertiesGroup.Text = "Selected Effect Properties";
            // 
            // listSelectedEffectProperties
            // 
            this.listSelectedEffectProperties.FormattingEnabled = true;
            this.listSelectedEffectProperties.Location = new System.Drawing.Point(0, 19);
            this.listSelectedEffectProperties.Margin = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.listSelectedEffectProperties.Name = "listSelectedEffectProperties";
            this.listSelectedEffectProperties.Size = new System.Drawing.Size(179, 147);
            this.listSelectedEffectProperties.TabIndex = 0;
            this.listSelectedEffectProperties.SelectedIndexChanged += new System.EventHandler(this.listSelectedEffectProperties_SelectedIndexChanged);
            // 
            // EaseAutomator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.grpSelectedEffectPropertiesGroup);
            this.Controls.Add(this.cbxWatchSelectedMedia);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpTestAnimation);
            this.Controls.Add(this.grpGraph);
            this.Controls.Add(this.grpValues);
            this.Controls.Add(this.grpEaseTypes);
            this.Controls.Add(this.grpSelectedMediaEffectsGroup);
            this.Name = "EaseAutomator";
            this.Size = new System.Drawing.Size(620, 553);
            this.grpSelectedMediaEffectsGroup.ResumeLayout(false);
            this.grpEaseTypes.ResumeLayout(false);
            this.grpValues.ResumeLayout(false);
            this.grpValues.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbProp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbProp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProp1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.grpSelectedEffectPropertiesGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion
        private System.Windows.Forms.CheckBox cbxWatchSelectedMedia;
        private System.Windows.Forms.GroupBox grpSelectedMediaEffectsGroup;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.GroupBox grpEaseTypes;
        private System.Windows.Forms.ComboBox cbxEaseTypes;
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
        private System.Windows.Forms.ListBox listSelectedMediaEffects;
        private System.Windows.Forms.GroupBox grpSelectedEffectPropertiesGroup;
        private System.Windows.Forms.ListBox listSelectedEffectProperties;
    }
}
