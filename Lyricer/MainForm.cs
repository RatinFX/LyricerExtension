using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ScriptPortal.Vegas;

namespace Lyricer
{
	public partial class MainForm : UserControl
	{
		Vegas myVegas;
		public MainForm(Vegas vegas)
		{
			myVegas = vegas;
			InitializeComponent();
		}

		public void CountTracks()
		{
			int vidTracks = 0;
			int audTracks = 0;

			foreach (Track track in myVegas.Project.Tracks)
			{
				if (track.IsVideo()) vidTracks++;
				else audTracks++;
			}

			lblTracks.Text = $"Tracks: {myVegas.Project.Tracks.Count}";
			lblVideo.Text = $"Video tracks: {vidTracks}";
			lblAudio.Text = $"Audio tracks: {audTracks}";
		}

		public void AddTrack(string trackType, int location, string trackName)
		{
			// create new
			if (trackType == "V")
			{
				// video track
				Track videoTrack = new VideoTrack(location, trackName);
				myVegas.Project.Tracks.Add(videoTrack);
			}
			else
			{
				// audio track
				Track audioTrack = new AudioTrack(location, trackName);
				myVegas.Project.Tracks.Add(audioTrack);
			}
		}

		private void btnCountTracks_Click(object sender, EventArgs e)
		{
			CountTracks();
		}

		private void btnAddVideoTrack_Click(object sender, EventArgs e)
		{
			using (UndoBlock undo = new UndoBlock("Add New Video Track"))
			{
				AddTrack("V", 0, "");
				CountTracks();
			}
		}

		private void btnAddAudioTrack_Click(object sender, EventArgs e)
		{
			using (UndoBlock undo = new UndoBlock("Add New Audio Track"))
			{
				AddTrack("A", myVegas.Project.Tracks.Count + 1, "");
				CountTracks();
			}
		}
	}
}
