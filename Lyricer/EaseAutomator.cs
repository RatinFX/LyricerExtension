using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using Sony.Vegas;
using ScriptPortal.Vegas;

namespace Lyricer
{
    public partial class EaseAutomator : UserControl
    {
        int videoEvents = 0;
        int audioEvents = 0;
        public EaseAutomator()
        {
            InitializeComponent();
        }

        public void SetMediaCountTexts()
        {
            lblSelectedVideoMediaCount.Text = $"Selected Video Media count: {videoEvents}";
            lblSelectedAudioMediaCount.Text = $"Selected Audio Media count: {audioEvents}";
        }

        // TODO: Separate to better methods
        /// <summary>
        /// Handle selected media changes
        /// </summary>
        public void HandleTrackEventStateChanged(object sender, EventArgs e)
        {
            if (!cbxWatchSelectedMedia.Checked) return;
            listSelectedMediaEffects.Items.Clear();
            listSelectedMedia.Items.Clear();
            videoEvents = audioEvents = 0;

            List<TrackEvent> selectedEvents = Methods.GetSelectedEvents(Data.Vegas.Project.Tracks);
            if (selectedEvents.Count == 0)
            {
                SetMediaCountTexts();
                return;
            }

            foreach (TrackEvent selected in selectedEvents)
            {
                if (selected.IsVideo())
                {
                    // TODO: get a better name than ActiveTake.Name
                    listSelectedMedia.Items.Add($"{selected.Track.Index}-{selected.Index}", $"Video: {selected.ActiveTake.Name}", videoEvents);
                    videoEvents++;
                }
                else
                {
                    listSelectedMedia.Items.Add($"{selected.Track.Index}-{selected.Index}", $"Autio: {selected.ActiveTake.Name}", audioEvents);
                    audioEvents++;
                }
            }
            SetMediaCountTexts();
            listSelectedMedia.Items[0].Selected = true;
            listSelectedMedia_SelectedIndexChanged(sender, e);
        }

        /// <summary>
        /// Add the Selected Media's effects to listSelectedMediaEffects
        /// </summary>
        /// <param name="index">track event index</param>
        /// <param name="effects">list of effect</param>
        public void ListEffects(int index, Effects effects)
        {
            if (effects.Count == 0) return;
            foreach (var effect in effects)
            {
                listSelectedMediaEffects.Items.Add($"{index}-{effect.Index}", $"FX: {effect.Description}", index);
            }
        }

        /// <summary>
        /// Selecting a Media from the main list
        /// </summary>
        private void listSelectedMedia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listSelectedMedia.SelectedItems.Count == 0) return;

            var split = listSelectedMedia.SelectedItems[0].Name.Split('-');
            if (split == null || split.Length != 2) throw new Exception("Selected Media naming error.");

            int trackIndex = int.Parse(split[0]);
            int eventIndex = int.Parse(split[1]);
            var selected = Data.Vegas.Project.Tracks[trackIndex].Events[eventIndex];
            if (selected == null) throw new Exception("Failed to get the selected event.");

            if (selected.IsVideo())
            {
                var s = (VideoEvent)selected;
                ListEffects(s.Index, s.Effects);
            }
            else
            {
                var s = (AudioEvent)selected;
                ListEffects(s.Index, s.Effects);
            }
        }
    }
}
