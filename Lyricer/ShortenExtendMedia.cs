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
    public partial class ShortenExtendMedia : UserControl
    {
        public long ShortenLength = 0;
        public long ExtendLength = 0;
        public ShortenExtendMedia()
        {
            InitializeComponent();
        }

        private void lblShortenExtendMediaAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/RatinA0/ShortenExtendMedia");
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            ShortenLength = (long)nudShorten.Value;
            ExtendLength = (long)nudExtend.Value;
            using (UndoBlock undo = new UndoBlock($"Shorten Extend Media: {ShortenLength} {cbShortenTimecode.Text} & {ExtendLength} {cbExtendTimecode.Text}"))
            {
                try
                {
                    foreach (TrackEvent trackEvent in Data.SelectedMedias)
                    {
                        var tempFadeInLength = trackEvent.FadeIn.Length;
                        var tempFadeOutLength = trackEvent.FadeOut.Length;

                        // decrease length of the selected media
                        switch (cbShortenTimecode.Text)
                        {
                            case "Frames":
                                trackEvent.Length = Timecode.FromFrames(trackEvent.Length.FrameCount - ShortenLength);
                                break;
                            case "Seconds":
                                if (trackEvent.Length < Timecode.FromSeconds(ShortenLength)) break;
                                // shorten e.g.: 600 frame / 60 fps (-> 10sec) - x sec
                                trackEvent.Length = Timecode.FromSeconds(trackEvent.Length.FrameCount / trackEvent.Length.FrameRate - ShortenLength);
                                break;
                            default:
                                // Default is "Frames"
                                trackEvent.Length = Timecode.FromFrames(trackEvent.Length.FrameCount - ShortenLength);
                                break;
                        }

                        // increase length of the selected media
                        switch (cbExtendTimecode.Text)
                        {
                            case "Frames":
                                trackEvent.Length = Timecode.FromFrames(trackEvent.Length.FrameCount + ExtendLength);
                                break;
                            case "Seconds":
                                // extend e.g.: 600 frame / 60 fps (-> 10sec) + x sec
                                trackEvent.Length = Timecode.FromSeconds(trackEvent.Length.FrameCount / trackEvent.Length.FrameRate + ExtendLength);
                                break;
                            default:
                                // Default is "Frames"
                                trackEvent.Length = Timecode.FromFrames(trackEvent.Length.FrameCount + ExtendLength);
                                break;
                        }
                        trackEvent.FadeIn.Length = tempFadeInLength;
                        trackEvent.FadeOut.Length = tempFadeOutLength;
                    }
                }
                catch (Exception ex)
                {
                    // show error message if any
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("- - - - - - - - - - - What can you do? - - - - - - - - - - -" + "\n\n" +
                            "> Decreasing the length of the selected objects (Shorten)"    + "\n\n" +
                            "> Increase the length of the selected objects (Extend)"       + "\n\n" +
                            "(!) If you change the duration like this,"                    + "\n" +
                            "    the Composite/FX Keyframes will NOT move.", "help?", MessageBoxButtons.OK);
        }
    }
}
