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
        //Vegas myVegas;
        Random random;
        public MainForm(Vegas vegas)
        {
            Data.Vegas = vegas;
            random = new Random();
            InitializeComponent();
        }

        /// <summary>
        /// Event Handlers
        /// </summary>
        // Automatically count the number of tracks on myVegas.TrackCountChanged
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

            foreach (Track track in Data.Vegas.Project.Tracks)
            {
                if (track.IsVideo()) vidTracks++;
                else audTracks++;
            }

            lblTracks.Text = $"Tracks: {Data.Vegas.Project.Tracks.Count}";
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
                Data.Vegas.Project.Tracks.Add(videoTrack);
            }
            else
            {
                // audio track
                Track audioTrack = new AudioTrack(location, trackName);
                Data.Vegas.Project.Tracks.Add(audioTrack);
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
                AddTrack("A", Data.Vegas.Project.Tracks.Count + 1, "");
            }
        }

        private void btnAddSShake_Click(object sender, EventArgs e)
        {
            using (UndoBlock undo = new UndoBlock("Add Effect"))
            {
                List<TrackEvent> selectedEvents = Methods.GetSelectedEvents(Data.Vegas.Project.Tracks);
                if (selectedEvents.Count == 0) return;

                string generatorUID = "{Svfx:com.genarts.sapphire.Distort.S_Shake}";
                //int presetName = "(Default)";
                //int presetIndex = 0;

                PlugInNode plugIn = Data.Vegas.VideoFX.GetChildByUniqueID(generatorUID);
                if (plugIn == null) return;

                foreach (TrackEvent trackEvent in selectedEvents)
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
                    Methods.SetParameterDouble(ofx, "Tilt Rand Amp", random.NextDouble() * 69);
                    Methods.SetParameterDouble(ofx, "Seed", random.NextDouble() * 5);
                }
            }
        }

        private void btnGetEffects_Click(object sender, EventArgs e)
        {
            GetEffectsGUID.GetEffects(Data.Vegas, true);
        }

        private void btnCreateText_Click(object sender, EventArgs e)
        {
            // Don't forget UndoBlock if you don't want to suffer for hours
            using (UndoBlock undo = new UndoBlock("Add Text"))
            {
                // get the Tiles & Text media generator
                PlugInNode generator = Data.Vegas.Generators.GetChildByUniqueID("{Svfx:com.sonycreativesoftware:titlesandtext}");
                if (generator == null) return;

                var media = new Media(generator);
                var stream = media.Streams.GetItemByMediaType(MediaType.Video, 0);
                var newEvent = new VideoEvent(Data.Vegas.Transport.CursorPosition); // , Timecode.FromSeconds(length));

                // create a new track if there's none
                if (Data.Vegas.Project.Tracks.Count == 0) AddTrack("V", 0, "");
                Data.Vegas.Project.Tracks[0].Events.Add(newEvent);

                var take = new Take(stream);
                newEvent.Takes.Add(take);

                // set preset
                //media.Generator.Preset = generator.Presets[0].Name;

                if (!media.Generator.IsOFX) return;
                OFXEffect ofx = media.Generator.OFXEffect;

                OFXStringParameter ofxParam = (OFXStringParameter)ofx["Text"];
                RichTextBox rtfText = new RichTextBox
                {
                    Rtf = ofxParam.Value,
                    Text = txtNewText.Text
                };
                ofxParam.Value = rtfText.Rtf;

                // make sure all the changes get applied
                ofx.AllParametersChanged();
            }
        }
    }
}
