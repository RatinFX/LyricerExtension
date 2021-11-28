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
        Methods methods;
        Random random;
        public MainForm(Vegas vegas)
        {
            myVegas = vegas;
            methods = new Methods(vegas);
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
        /// Local methods
        /// </summary>
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
                myVegas.Project.Tracks.Add(videoTrack);
            }
            else
            {
                // audio track
                Track audioTrack = new AudioTrack(location, trackName);
                myVegas.Project.Tracks.Add(audioTrack);
            }
        }

        /// <summary>
        /// Form actions
        /// </summary>
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
                AddTrack("A", myVegas.Project.Tracks.Count + 1, "");
            }
        }

        private void btnAddSShake_Click(object sender, EventArgs e)
        {
            using (UndoBlock undo = new UndoBlock("Add Effect"))
            {
                List<TrackEvent> selectedEvents = Methods.GetSelectedEvents(myVegas.Project.Tracks);
                if (selectedEvents.Count == 0) return;

                string generatorUID = "{Svfx:com.genarts.sapphire.Distort.S_Shake}";
                //int presetName = "(Default)";
                //int presetIndex = 0;

                PlugInNode plugIn = myVegas.VideoFX.GetChildByUniqueID(generatorUID);
                if (plugIn == null) return;
                Effect effect = new Effect(plugIn);

                foreach (TrackEvent trackEvent in selectedEvents)
                {
                    if (trackEvent.IsAudio()) continue;
                    var videoEvent = (VideoEvent)trackEvent;

                    videoEvent.Effects.Add(effect);

                    //effect.Preset = effect.Presets[presetIndex].Name;
                    //effect.Preset = effect.Presets.FirstOrDefault(x => x.Name == presetName);

                    if (!effect.PlugIn.IsOFX) continue;
                    OFXEffect ofx = effect.OFXEffect;
                    Methods.SetParameterDouble(ofx, "Z Dist", 2);
                    Methods.SetParameterDouble(ofx, "Tilt Rand Amp", 69);
                    Methods.SetParameterDouble(ofx, "Seed", random.NextDouble() * 5);
                }
            }
        }

        private void btnGetEffects_Click(object sender, EventArgs e)
        {
            GetEffectsGUID.GetEffects(myVegas, true);
        }

        private void btnCreateText_Click(object sender, EventArgs e)
        {
            // Don't forget UndoBlock if you don't want to suffer for hours
            using (UndoBlock undo = new UndoBlock("Add Text"))
            {
                // get the Tiles & Text media generator
                PlugInNode generator = myVegas.Generators.GetChildByUniqueID("{Svfx:com.sonycreativesoftware:titlesandtext}");
                if (generator == null) return;

                var media = new Media(generator);
                var stream = media.Streams.GetItemByMediaType(MediaType.Video, 0);
                var newEvent = new VideoEvent(myVegas.Transport.CursorPosition); // , Timecode.FromSeconds(length));

                if (myVegas.Project.Tracks.Count == 0) AddTrack("V", 0, "");
                myVegas.Project.Tracks[0].Events.Add(newEvent);

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
                    Text = "text"
                };
                ofxParam.Value = rtfText.Rtf;

                // make sure all the changes get applied
                ofx.AllParametersChanged();
            }
        }

        private void tabControl_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            //if (ClientSize.Width < 850) tabControl.Width = ClientSize.Width;
            //else tabControl.Width = 850;

            //if (ClientSize.Height < 580) tabControl.Height = ClientSize.Height;
            //else tabControl.Height = 580;
        }
    }
}
