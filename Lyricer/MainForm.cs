﻿using ScriptPortal.Vegas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VegasProData;

namespace Lyricer
{
    public partial class MainForm : UserControl
    {
        Random Random = new Random();

        public MainForm(Vegas vegas)
        {
            Data.Vegas = vegas;
            InitializeComponent();
        }

        /// <summary>
        /// Event Handlers
        /// </summary>
        // Automatically count the number of tracks on Vegas.TrackCountChanged
        public void HandleTrackCountChange(object sender, EventArgs e)
        {
            CountTracks();
        }

        /// <summary>
        /// Let the appropriate tab deal with Handling the changes
        /// </summary>
        public void HandleTrackEventStateChanged(object sender, EventArgs e)
        {
            easeAutomator.HandleTrackEventStateChanged(sender, e);
        }

        /// <summary>
        /// Get the number of tracks
        /// </summary>
        public void CountTracks()
        {
            int vidTracks = 0;
            int audTracks = 0;

            foreach (Track track in Data.Tracks)
            {
                if (track.IsVideo()) vidTracks++;
                else audTracks++;
            }

            lblTracks.Text = $"Tracks: {Data.Tracks.Count}";
            lblVideo.Text = $"Video tracks: {vidTracks}";
            lblAudio.Text = $"Audio tracks: {audTracks}";
        }

        /// <summary>
        /// Add Video or Audio track (layer)
        /// </summary>
        /// <param name="trackType">V or A</param>
        /// <param name="location">Location index</param>
        /// <param name="trackName">Track Name</param>
        public void AddTrack(string trackType, int location, string trackName)
        {
            // create new
            if (trackType == "V")
            {
                // video track
                Track videoTrack = new VideoTrack(location, trackName);
                Data.Tracks.Add(videoTrack);
            }
            else
            {
                // audio track
                Track audioTrack = new AudioTrack(location, trackName);
                Data.Tracks.Add(audioTrack);
            }
        }

        /// <summary>
        /// Form events
        /// </summary>
        private void lblCustomFadesAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/RatinA0/LyricerExtension");
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
            }
        }

        private void btnAddAudioTrack_Click(object sender, EventArgs e)
        {
            using (UndoBlock undo = new UndoBlock("Add New Audio Track"))
            {
                AddTrack("A", Data.Tracks.Count + 1, "");
            }
        }

        private void btnAddSShake_Click(object sender, EventArgs e)
        {
            using (UndoBlock undo = new UndoBlock("Add Effect"))
            {
                if (Data.SelectedMedias.Count() == 0) return;

                PlugInNode plugIn = Data.VideoFX.FirstOrDefault(x => x.Name.ToLower().Contains("s_shake"))?.Plugin;
                if (plugIn == null) return;

                foreach (TrackEvent trackEvent in Data.SelectedMedias)
                {
                    if (trackEvent.IsAudio()) continue;
                    var videoEvent = (VideoEvent)trackEvent;

                    Effect effect = new Effect(plugIn);
                    videoEvent.Effects.Add(effect);

                    //effect.Preset = effect.Presets[presetIndex].Name;
                    //effect.Preset = effect.Presets.FirstOrDefault(x => x.Name == presetName);

                    if (!effect.PlugIn.IsOFX) continue;
                    OFXEffect ofx = effect.OFXEffect;
                    Methods.SetParameterDouble(ofx, "Z Dist", 2);
                    Methods.SetParameterDouble(ofx, "Tilt Rand Amp", Random.NextDouble() * 69);
                    Methods.SetParameterDouble(ofx, "Seed", Random.NextDouble() * 5);
                }
            }
        }

        private void btnGetEffects_Click(object sender, EventArgs e)
        {
            GetEffectsGUID.GetEffects(true);
        }

        private void btnCreateText_Click(object sender, EventArgs e)
        {
            /// Don't forget UndoBlock if you don't want to suffer for hours
            using (UndoBlock undo = new UndoBlock($"Create Text {txtNewText.Text}"))
            {
                // get the Tiles & Text media generator
                PlugInNode generator = Data.Vegas.Generators.GetChildByUniqueID("{Svfx:com.sonycreativesoftware:titlesandtext}");
                if (generator == null) return;

                var media = new Media(generator);
                var stream = media.Streams.GetItemByMediaType(MediaType.Video, 0);
                var newEvent = new VideoEvent(Data.Vegas.Transport.CursorPosition); // , Timecode.FromSeconds(length));

                // deselect audio tracks
                foreach (var t in Data.Tracks.Where(x => x.MediaType != MediaType.Video && x.Selected))
                {
                    t.Selected = false;
                }

                // check for video tracks
                var vidTrack = Data.Tracks.Where(x => x.MediaType == MediaType.Video);

                // create a new track if there's none
                if (vidTrack.Count() == 0) AddTrack("V", 0, "");

                // no selected / vid -> select first video
                if (vidTrack.Where(x => x.Selected).Count() == 0) vidTrack.ToList()[0].Selected = true;

                // has selected -> add to it
                vidTrack.FirstOrDefault(x => x.Selected).Events.Add(newEvent);

                var take = new Take(stream);
                newEvent.Takes.Add(take);

                // set preset
                //media.Generator.Preset = generator.Presets[0].Name;

                if (!media.Generator.IsOFX) return;
                OFXEffect ofx = media.Generator.OFXEffect;

                Methods.SetParameterRichText(ofx, "Text", txtNewText.Text);

                // make sure all the changes get applied
                ofx.AllParametersChanged();
            }
        }
    }
}
