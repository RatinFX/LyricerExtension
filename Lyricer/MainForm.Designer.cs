namespace Lyricer
{
	partial class MainForm
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
            this.lblTracks = new System.Windows.Forms.Label();
            this.lblAudio = new System.Windows.Forms.Label();
            this.lblVideo = new System.Windows.Forms.Label();
            this.btnAddVideoTrack = new System.Windows.Forms.Button();
            this.btnAddAudioTrack = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.listSearchResult = new System.Windows.Forms.ListBox();
            this.txtNewText = new System.Windows.Forms.TextBox();
            this.lblCustomFadesAbout = new System.Windows.Forms.LinkLabel();
            this.btnCreateText = new System.Windows.Forms.Button();
            this.btnGetEffects = new System.Windows.Forms.Button();
            this.btnAddSShake = new System.Windows.Forms.Button();
            this.tabCustomFades = new System.Windows.Forms.TabPage();
            this.customFades = new Lyricer.CustomFades();
            this.tabShortenExtendMedia = new System.Windows.Forms.TabPage();
            this.shortenExtendMedia = new Lyricer.ShortenExtendMedia();
            this.tabEaseAutomator = new System.Windows.Forms.TabPage();
            this.easeAutomator = new Lyricer.EaseAutomator();
            this.tabControl.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabCustomFades.SuspendLayout();
            this.tabShortenExtendMedia.SuspendLayout();
            this.tabEaseAutomator.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTracks
            // 
            this.lblTracks.AutoSize = true;
            this.lblTracks.Location = new System.Drawing.Point(10, 33);
            this.lblTracks.Name = "lblTracks";
            this.lblTracks.Size = new System.Drawing.Size(52, 13);
            this.lblTracks.TabIndex = 0;
            this.lblTracks.Text = "Tracks: 0";
            // 
            // lblAudio
            // 
            this.lblAudio.AutoSize = true;
            this.lblAudio.Location = new System.Drawing.Point(10, 80);
            this.lblAudio.Name = "lblAudio";
            this.lblAudio.Size = new System.Drawing.Size(78, 13);
            this.lblAudio.TabIndex = 1;
            this.lblAudio.Text = "Audio tracks: 0";
            // 
            // lblVideo
            // 
            this.lblVideo.AutoSize = true;
            this.lblVideo.Location = new System.Drawing.Point(10, 56);
            this.lblVideo.Name = "lblVideo";
            this.lblVideo.Size = new System.Drawing.Size(78, 13);
            this.lblVideo.TabIndex = 2;
            this.lblVideo.Text = "Video tracks: 0";
            // 
            // btnAddVideoTrack
            // 
            this.btnAddVideoTrack.Location = new System.Drawing.Point(13, 104);
            this.btnAddVideoTrack.Name = "btnAddVideoTrack";
            this.btnAddVideoTrack.Size = new System.Drawing.Size(123, 35);
            this.btnAddVideoTrack.TabIndex = 4;
            this.btnAddVideoTrack.Text = "Add video track";
            this.btnAddVideoTrack.UseVisualStyleBackColor = true;
            this.btnAddVideoTrack.Click += new System.EventHandler(this.btnAddVideoTrack_Click);
            // 
            // btnAddAudioTrack
            // 
            this.btnAddAudioTrack.Location = new System.Drawing.Point(13, 145);
            this.btnAddAudioTrack.Name = "btnAddAudioTrack";
            this.btnAddAudioTrack.Size = new System.Drawing.Size(123, 35);
            this.btnAddAudioTrack.TabIndex = 4;
            this.btnAddAudioTrack.Text = "Add audio track";
            this.btnAddAudioTrack.UseVisualStyleBackColor = true;
            this.btnAddAudioTrack.Click += new System.EventHandler(this.btnAddAudioTrack_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabMain);
            this.tabControl.Controls.Add(this.tabCustomFades);
            this.tabControl.Controls.Add(this.tabShortenExtendMedia);
            this.tabControl.Controls.Add(this.tabEaseAutomator);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 454);
            this.tabControl.TabIndex = 5;
            // 
            // tabMain
            // 
            this.tabMain.AutoScroll = true;
            this.tabMain.BackColor = System.Drawing.Color.White;
            this.tabMain.Controls.Add(this.txtSearch);
            this.tabMain.Controls.Add(this.listSearchResult);
            this.tabMain.Controls.Add(this.txtNewText);
            this.tabMain.Controls.Add(this.lblCustomFadesAbout);
            this.tabMain.Controls.Add(this.btnCreateText);
            this.tabMain.Controls.Add(this.btnGetEffects);
            this.tabMain.Controls.Add(this.btnAddSShake);
            this.tabMain.Controls.Add(this.btnAddAudioTrack);
            this.tabMain.Controls.Add(this.lblTracks);
            this.tabMain.Controls.Add(this.btnAddVideoTrack);
            this.tabMain.Controls.Add(this.lblAudio);
            this.tabMain.Controls.Add(this.lblVideo);
            this.tabMain.Location = new System.Drawing.Point(4, 22);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(792, 428);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Main";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(156, 186);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(218, 20);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // listSearchResult
            // 
            this.listSearchResult.FormattingEnabled = true;
            this.listSearchResult.Location = new System.Drawing.Point(156, 212);
            this.listSearchResult.Name = "listSearchResult";
            this.listSearchResult.Size = new System.Drawing.Size(218, 199);
            this.listSearchResult.TabIndex = 11;
            this.listSearchResult.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listSearchResult_MouseDoubleClick);
            // 
            // txtNewText
            // 
            this.txtNewText.Location = new System.Drawing.Point(268, 77);
            this.txtNewText.Name = "txtNewText";
            this.txtNewText.Size = new System.Drawing.Size(106, 20);
            this.txtNewText.TabIndex = 10;
            this.txtNewText.Text = "Sample Text";
            // 
            // lblCustomFadesAbout
            // 
            this.lblCustomFadesAbout.AutoSize = true;
            this.lblCustomFadesAbout.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblCustomFadesAbout.Location = new System.Drawing.Point(10, 10);
            this.lblCustomFadesAbout.Margin = new System.Windows.Forms.Padding(10);
            this.lblCustomFadesAbout.Name = "lblCustomFadesAbout";
            this.lblCustomFadesAbout.Size = new System.Drawing.Size(199, 13);
            this.lblCustomFadesAbout.TabIndex = 9;
            this.lblCustomFadesAbout.TabStop = true;
            this.lblCustomFadesAbout.Text = "Lyricer Extension by RatinA0 (github link)";
            this.lblCustomFadesAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCustomFadesAbout_LinkClicked);
            // 
            // btnCreateText
            // 
            this.btnCreateText.Location = new System.Drawing.Point(268, 104);
            this.btnCreateText.Name = "btnCreateText";
            this.btnCreateText.Size = new System.Drawing.Size(106, 35);
            this.btnCreateText.TabIndex = 8;
            this.btnCreateText.Text = "Create Text";
            this.btnCreateText.UseVisualStyleBackColor = true;
            this.btnCreateText.Click += new System.EventHandler(this.btnCreateText_Click);
            // 
            // btnGetEffects
            // 
            this.btnGetEffects.Enabled = false;
            this.btnGetEffects.Location = new System.Drawing.Point(13, 186);
            this.btnGetEffects.Name = "btnGetEffects";
            this.btnGetEffects.Size = new System.Drawing.Size(123, 35);
            this.btnGetEffects.TabIndex = 7;
            this.btnGetEffects.Text = "Get Existing Effects";
            this.btnGetEffects.UseVisualStyleBackColor = true;
            this.btnGetEffects.Click += new System.EventHandler(this.btnGetEffects_Click);
            // 
            // btnAddSShake
            // 
            this.btnAddSShake.Location = new System.Drawing.Point(156, 104);
            this.btnAddSShake.Name = "btnAddSShake";
            this.btnAddSShake.Size = new System.Drawing.Size(106, 35);
            this.btnAddSShake.TabIndex = 6;
            this.btnAddSShake.Text = "S_SHAKE";
            this.btnAddSShake.UseVisualStyleBackColor = true;
            this.btnAddSShake.Click += new System.EventHandler(this.btnAddSShake_Click);
            // 
            // tabCustomFades
            // 
            this.tabCustomFades.Controls.Add(this.customFades);
            this.tabCustomFades.Location = new System.Drawing.Point(4, 22);
            this.tabCustomFades.Name = "tabCustomFades";
            this.tabCustomFades.Size = new System.Drawing.Size(792, 428);
            this.tabCustomFades.TabIndex = 1;
            this.tabCustomFades.Text = "Custom Fades";
            this.tabCustomFades.UseVisualStyleBackColor = true;
            // 
            // customFades
            // 
            this.customFades.AutoScroll = true;
            this.customFades.BackColor = System.Drawing.Color.Transparent;
            this.customFades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customFades.Location = new System.Drawing.Point(0, 0);
            this.customFades.Name = "customFades";
            this.customFades.Size = new System.Drawing.Size(792, 428);
            this.customFades.TabIndex = 0;
            // 
            // tabShortenExtendMedia
            // 
            this.tabShortenExtendMedia.Controls.Add(this.shortenExtendMedia);
            this.tabShortenExtendMedia.Location = new System.Drawing.Point(4, 22);
            this.tabShortenExtendMedia.Name = "tabShortenExtendMedia";
            this.tabShortenExtendMedia.Size = new System.Drawing.Size(792, 428);
            this.tabShortenExtendMedia.TabIndex = 2;
            this.tabShortenExtendMedia.Text = "Shorten/Extend Media";
            this.tabShortenExtendMedia.UseVisualStyleBackColor = true;
            // 
            // shortenExtendMedia
            // 
            this.shortenExtendMedia.AutoScroll = true;
            this.shortenExtendMedia.BackColor = System.Drawing.Color.Transparent;
            this.shortenExtendMedia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shortenExtendMedia.Location = new System.Drawing.Point(0, 0);
            this.shortenExtendMedia.Name = "shortenExtendMedia";
            this.shortenExtendMedia.Size = new System.Drawing.Size(792, 428);
            this.shortenExtendMedia.TabIndex = 0;
            // 
            // tabEaseAutomator
            // 
            this.tabEaseAutomator.Controls.Add(this.easeAutomator);
            this.tabEaseAutomator.Location = new System.Drawing.Point(4, 22);
            this.tabEaseAutomator.Name = "tabEaseAutomator";
            this.tabEaseAutomator.Size = new System.Drawing.Size(792, 428);
            this.tabEaseAutomator.TabIndex = 3;
            this.tabEaseAutomator.Text = "Ease Automator";
            this.tabEaseAutomator.UseVisualStyleBackColor = true;
            // 
            // easeAutomator
            // 
            this.easeAutomator.AutoScroll = true;
            this.easeAutomator.BackColor = System.Drawing.Color.Transparent;
            this.easeAutomator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.easeAutomator.Location = new System.Drawing.Point(0, 0);
            this.easeAutomator.Name = "easeAutomator";
            this.easeAutomator.SelectedMedia = null;
            this.easeAutomator.Size = new System.Drawing.Size(792, 428);
            this.easeAutomator.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Size = new System.Drawing.Size(800, 454);
            this.tabControl.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            this.tabCustomFades.ResumeLayout(false);
            this.tabShortenExtendMedia.ResumeLayout(false);
            this.tabEaseAutomator.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblTracks;
		private System.Windows.Forms.Label lblAudio;
		private System.Windows.Forms.Label lblVideo;
		private System.Windows.Forms.Button btnAddVideoTrack;
		private System.Windows.Forms.Button btnAddAudioTrack;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.Button btnAddSShake;
        private System.Windows.Forms.Button btnGetEffects;
        private System.Windows.Forms.Button btnCreateText;
        private System.Windows.Forms.TabPage tabCustomFades;
        private System.Windows.Forms.TabPage tabShortenExtendMedia;
        private System.Windows.Forms.TabPage tabEaseAutomator;
        private CustomFades customFades;
        private ShortenExtendMedia shortenExtendMedia;
        private EaseAutomator easeAutomator;
        private System.Windows.Forms.LinkLabel lblCustomFadesAbout;
        private System.Windows.Forms.TextBox txtNewText;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListBox listSearchResult;
    }
}
