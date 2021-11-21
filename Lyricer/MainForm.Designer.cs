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
			this.btnCountTracks = new System.Windows.Forms.Button();
			this.btnAddVideoTrack = new System.Windows.Forms.Button();
			this.btnAddAudioTrack = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblTracks
			// 
			this.lblTracks.AutoSize = true;
			this.lblTracks.Location = new System.Drawing.Point(190, 121);
			this.lblTracks.Name = "lblTracks";
			this.lblTracks.Size = new System.Drawing.Size(52, 13);
			this.lblTracks.TabIndex = 0;
			this.lblTracks.Text = "Tracks: 0";
			// 
			// lblAudio
			// 
			this.lblAudio.AutoSize = true;
			this.lblAudio.Location = new System.Drawing.Point(190, 199);
			this.lblAudio.Name = "lblAudio";
			this.lblAudio.Size = new System.Drawing.Size(78, 13);
			this.lblAudio.TabIndex = 1;
			this.lblAudio.Text = "Audio tracks: 0";
			// 
			// lblVideo
			// 
			this.lblVideo.AutoSize = true;
			this.lblVideo.Location = new System.Drawing.Point(190, 158);
			this.lblVideo.Name = "lblVideo";
			this.lblVideo.Size = new System.Drawing.Size(78, 13);
			this.lblVideo.TabIndex = 2;
			this.lblVideo.Text = "Video tracks: 0";
			// 
			// btnCountTracks
			// 
			this.btnCountTracks.Location = new System.Drawing.Point(193, 235);
			this.btnCountTracks.Name = "btnCountTracks";
			this.btnCountTracks.Size = new System.Drawing.Size(95, 35);
			this.btnCountTracks.TabIndex = 3;
			this.btnCountTracks.Text = "Count Tracks";
			this.btnCountTracks.UseVisualStyleBackColor = true;
			this.btnCountTracks.Click += new System.EventHandler(this.btnCountTracks_Click);
			// 
			// btnAddVideoTrack
			// 
			this.btnAddVideoTrack.Location = new System.Drawing.Point(294, 235);
			this.btnAddVideoTrack.Name = "btnAddVideoTrack";
			this.btnAddVideoTrack.Size = new System.Drawing.Size(106, 35);
			this.btnAddVideoTrack.TabIndex = 4;
			this.btnAddVideoTrack.Text = "Add video track";
			this.btnAddVideoTrack.UseVisualStyleBackColor = true;
			this.btnAddVideoTrack.Click += new System.EventHandler(this.btnAddVideoTrack_Click);
			// 
			// btnAddAudioTrack
			// 
			this.btnAddAudioTrack.Location = new System.Drawing.Point(294, 276);
			this.btnAddAudioTrack.Name = "btnAddAudioTrack";
			this.btnAddAudioTrack.Size = new System.Drawing.Size(106, 35);
			this.btnAddAudioTrack.TabIndex = 4;
			this.btnAddAudioTrack.Text = "Add audio track";
			this.btnAddAudioTrack.UseVisualStyleBackColor = true;
			this.btnAddAudioTrack.Click += new System.EventHandler(this.btnAddAudioTrack_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnAddAudioTrack);
			this.Controls.Add(this.btnAddVideoTrack);
			this.Controls.Add(this.btnCountTracks);
			this.Controls.Add(this.lblVideo);
			this.Controls.Add(this.lblAudio);
			this.Controls.Add(this.lblTracks);
			this.Name = "MainForm";
			this.Size = new System.Drawing.Size(800, 454);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTracks;
		private System.Windows.Forms.Label lblAudio;
		private System.Windows.Forms.Label lblVideo;
		private System.Windows.Forms.Button btnCountTracks;
		private System.Windows.Forms.Button btnAddVideoTrack;
		private System.Windows.Forms.Button btnAddAudioTrack;
	}
}
