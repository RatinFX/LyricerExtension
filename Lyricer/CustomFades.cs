using ScriptPortal.Vegas;
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
    public partial class CustomFades : UserControl
    {
        // Change Fade In/Out Curve
        public bool changeFIC = false;
        public bool changeFOC = false;

        // Fade In/Out To Zero
        public bool FITZ = false;
        public bool FOTZ = false;

        // Add (to) Fade In/Out Length
        public bool AFIL = false;
        public bool AFOL = false;

        // Reduce (to) Fade In/Out Length
        public bool RFIL = false;
        public bool RFOL = false;

        public CustomFades()
        {
            InitializeComponent();
        }

        private void lblCustomFadesAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/RatinA0/CustomFades");
        }

        /// <summary>
        /// Change the curve type too if the checkbox is checked
        /// </summary>
        private void cbxChangeFadeInCurveType_CheckedChanged(object sender, EventArgs e)
        {
            changeFIC = cbxFadeInCurve.Enabled = cbxChangeFadeInCurveType.Checked;
        }
        private void cbxChangeFadeOutCurveType_CheckedChanged(object sender, EventArgs e)
        {
            changeFOC = cbxFadeOutCurve.Enabled = cbxChangeFadeOutCurveType.Checked;
        }

        /// <summary>
        /// Change the fade length to 0 if the checkbox is checked
        /// </summary>
        private void cbxFadeInToZero_CheckedChanged(object sender, EventArgs e)
        {
            FITZ = cbxFadeInToZero.Checked;
            if(FITZ) nudFadeIn.Value = 0;
            nudFadeIn.Enabled = cbxFadeInTimecode.Enabled = cbxFIAddLength.Enabled = cbxFIReduceLength.Enabled = !cbxFadeInToZero.Checked;
        }
        private void cbxFadeOutToZero_CheckedChanged(object sender, EventArgs e)
        {
            FOTZ = cbxFadeOutToZero.Checked;
            if(FOTZ) nudFadeOut.Value = 0;
            nudFadeOut.Enabled = cbxFadeOutTimecode.Enabled = cbxFOAddLength.Enabled = cbxFOReduceLength.Enabled = !cbxFadeOutToZero.Checked;
        }

        /// <summary>
        /// Disable checkboxes and set the text of the labels
        /// </summary>
        private void SetLength(Label fadeLabel, string labelText, CheckBox checkBox_checked, CheckBox checkBox_other, CheckBox checkBox_setZero)
        {
            fadeLabel.Text = "New Length:";

            if (checkBox_checked.Checked)
            {
                fadeLabel.Text = labelText;
                checkBox_other.Enabled = false;
                checkBox_setZero.Enabled = false;
            }
            else
            {
                checkBox_other.Enabled = true;
                checkBox_setZero.Enabled = true;
            }
        }

        /// <summary>
        /// Option to add the current length of the Fades instead of setting it
        /// </summary>
        private void cbxFadeInAddLength_CheckedChanged(object sender, EventArgs e)
        {
            SetLength(lbFadeIn, "Increase by:", cbxFIAddLength, cbxFIReduceLength, cbxFadeInToZero);
            AFIL = cbxFIAddLength.Checked;
        }
        private void cbxFadeOutAddLength_CheckedChanged(object sender, EventArgs e)
        {
            SetLength(lbFadeOut, "Increase by:", cbxFOAddLength, cbxFOReduceLength, cbxFadeOutToZero);
            AFOL = cbxFOAddLength.Checked;
        }

        /// <summary>
        /// Option to reduce the current length of the Fades instead of setting it
        /// </summary>
        private void cbxFadeInReduceLength_CheckedChanged(object sender, EventArgs e)
        {
            SetLength(lbFadeIn, "Reduce by:", cbxFIReduceLength, cbxFIAddLength, cbxFadeInToZero);
            RFIL = cbxFIReduceLength.Checked;
        }
        private void cbxFadeOutReduceLength_CheckedChanged(object sender, EventArgs e)
        {
            SetLength(lbFadeOut, "Reduce by:", cbxFOReduceLength, cbxFOAddLength, cbxFadeOutToZero);
            RFOL = cbxFOReduceLength.Checked;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("- - - - - - - - - - - What can you do? - - - - - - - - - - -"    + "\n\n" +
                            "You can set the Fade In/Out:"                                    + "\n\n" +
                            "- Length (in either Frames or Seconds)"                          + "\n" +
                            "  > If Length stays 0 -> it stays the same"                      + "\n" +
                            "  > Use the CheckBox if you want the Fade In/Out length to be 0" + "\n\n" +
                            "- Curve Type (Fast, Linear, Sharp, Slow, Smooth)"                + "\n" +
                            "  > It doesn't change the Curve Type by default"                 + "\n" +
                            "  > Use the CheckBox if you want to change it", "Help", MessageBoxButtons.OK);
        }

        private void btRun_Click(object sender, EventArgs e)
        {
            try
            {
                using (UndoBlock undo = new UndoBlock($"Custom Fades: "))
                {
                    foreach (TrackEvent trackEvent in Data.SelectedMedias)
                    {
                        FrameChecker((int)nudFadeIn.Value, cbxFadeInTimecode.Text, RFIL, AFIL, FITZ, trackEvent.FadeIn);
                        FrameChecker((int)nudFadeOut.Value, cbxFadeOutTimecode.Text, RFOL, AFOL, FOTZ, trackEvent.FadeOut);

                        if (changeFIC) ChangeCurveTypes(cbxFadeInCurve.Text, trackEvent.FadeIn);
                        if (changeFOC) ChangeCurveTypes(cbxFadeOutCurve.Text, trackEvent.FadeOut);
                    }
                }
            }
            catch (Exception ex)
            {
                // show error message if any
                MessageBox.Show(ex.Message);
            }
        }

        // VEGAS METHODS
        /// <summary>
        /// Calculating for frames or seconds
        /// </summary>
        private void FrameChecker(int fadeValue, string fadeTimecode, bool reduceBool, bool addBool, bool fadeToZeroBool, Fade fade)
        {
            // if fade value is NOT 0 -> change stuff
            if (fadeValue > 0)
            {
                switch (fadeTimecode)
                {
                    // when we want to count in frames
                    case "Frames":
                        FrameCalculator(addBool, reduceBool, fade, Timecode.FromFrames(fadeValue));
                        break;
                    // when we want to count in seconds
                    case "Seconds":
                        FrameCalculator(addBool, reduceBool, fade, Timecode.FromSeconds(fadeValue));
                        break;
                    // save a heartbeat if the box is empty
                    default:
                        FrameCalculator(addBool, reduceBool, fade, Timecode.FromFrames(fadeValue));
                        break;
                }
            }
            // if fade to zero is checked, it's set length to 0
            else if (fadeToZeroBool && fadeValue == 0)
            {
                fade.Length = Timecode.FromFrames(0);
            }
        }
        private void FrameCalculator(bool addBool, bool reduceBool, Fade fade, Timecode timecode)
        {
            if (reduceBool) fade.Length -= timecode;
            else if (addBool) fade.Length += timecode;
            else fade.Length = timecode;
        }

        /// <summary>
        /// Change curve types
        /// </summary>
        private void ChangeCurveTypes(string fadeString, Fade fade)
        {
            // change fade in curve type according to the selection
            switch (fadeString)
            {
                case "Fast":
                    fade.Curve = CurveType.Fast;
                    break;
                case "Linear":
                    fade.Curve = CurveType.Linear;
                    break;
                case "Sharp":
                    fade.Curve = CurveType.Sharp;
                    break;
                case "Slow":
                    fade.Curve = CurveType.Slow;
                    break;
                case "Smooth":
                    fade.Curve = CurveType.Smooth;
                    break;
                // if the box is empty
                default:
                    fade.Curve = CurveType.Smooth;
                    break;
            }
        }

    }
}
