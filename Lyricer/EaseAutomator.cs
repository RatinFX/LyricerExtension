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
    public partial class EaseAutomator : UserControl
    {
        public TrackEvent SelectedMedia { get; set; }

        /// <summary>
        /// List of Media Effects
        /// </summary>
        private List<Effect> _selectedMediaEffects = new List<Effect>();
        public Effect SelectedEffect => _selectedMediaEffects[listSelectedMediaEffects.SelectedIndex];

        /// <summary>
        /// (OFXParameter) Properties
        /// </summary>
        private List<object> _selectedEffectProperties = new List<object>();
        public object SelectedEffectProperty => _selectedEffectProperties[listSelectedEffectProperties.SelectedIndex];

        public static List<OFXParameterType> IgnoredParameterTypes = new List<OFXParameterType>() {
            //OFXParameterType.Choice,
            OFXParameterType.Custom,
            //OFXParameterType.Group,
            OFXParameterType.Page,
            OFXParameterType.PushButton,
            OFXParameterType.Unknown
        };

        public EaseAutomator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Empty the list of effects
        /// </summary>
        private void ClearEffectList()
        {
            if (listSelectedMediaEffects.Items.Count > 0) listSelectedMediaEffects.Items.Clear();
            if (SelectedMedia != null) SelectedMedia = null;
            if (_selectedMediaEffects != null && _selectedMediaEffects.Count > 0) _selectedMediaEffects.Clear();
        }

        private void ClearEffectPropList()
        {
            if (listSelectedEffectProperties.Items.Count > 0) listSelectedEffectProperties.Items.Clear();
            if (_selectedEffectProperties != null && _selectedEffectProperties.Count > 0) _selectedEffectProperties.Clear();
        }

        /// <summary>
        /// Handle selected media changes
        /// </summary>
        public void HandleTrackEventStateChanged(object sender, EventArgs e)
        {
            if (!cbxWatchSelectedMedia.Checked) return;

            ClearEffectList();
            ClearEffectPropList();
            if (Data.SelectedMedias.Count() == 0) return;

            SelectedMedia = Data.SelectedMedias.FirstOrDefault();
            if (SelectedMedia == null) throw new Exception("Failed to get the selected event.");

            CastSelectedMedia();
            SelectFirstEffect();
        }

        /// <summary>
        /// Cast selected media to the correct Video / Audio Event type
        /// </summary>
        /// <param name="index">track event index</param>
        /// <param name="effects">list of effect</param>
        private void CastSelectedMedia()
        {
            if (SelectedMedia.IsVideo())
            {
                var s = (VideoEvent)SelectedMedia;
                AddEffectsToList(s.Effects);
            }
            else
            {
                var s = (AudioEvent)SelectedMedia;
                AddEffectsToList(s.Effects);
            }
        }

        /// <summary>
        /// Add the Selected Media's effects to listSelectedMediaEffects
        /// </summary>
        /// <param name="effects">Effects on the selected media</param>
        private void AddEffectsToList(Effects effects)
        {
            if (effects.Count == 0) return;
            foreach (var effect in effects)
            {
                listSelectedMediaEffects.Items.Add($"{effect.Index + 1}: {effect.Description}");
                _selectedMediaEffects.Add(effect);
            }
        }

        /// <summary>
        /// Select the first effect found on the SelectedMedia
        /// </summary>
        private void SelectFirstEffect()
        {
            if (listSelectedMediaEffects.Items.Count == 0) return;
            listSelectedMediaEffects.SelectedItem = listSelectedMediaEffects.Items[0];

            ListEffectProps();
        }

        /// <summary>
        /// List the properties from the selected effect
        /// </summary>
        private void ListEffectProps()
        {
            ClearEffectPropList();
            if (SelectedEffect == null) throw new Exception("Failed to get the first effect.");
            if (!SelectedEffect.IsOFX) return;

            foreach (var item in SelectedEffect.OFXEffect.Parameters)
            {
                if (IgnoredParameterTypes.Contains(item.ParameterType) || item.Label == null) continue;
                if (item.ParameterType == OFXParameterType.Group)
                {
                    listSelectedEffectProperties.Items.Add($"▶ {item.Label}");
                }
                else
                {
                    if (item.ParentName == "")
                    {
                        listSelectedEffectProperties.Items.Add($"{item.Name}");
                    }
                    else
                    {
                        listSelectedEffectProperties.Items.Add($"    | - {item.Name}");
                    }
                }
                _selectedEffectProperties.Add(item);
            }
        }

        private void listSelectedMediaEffects_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListEffectProps();
        }

        private void listSelectedEffectProperties_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO
        }

        private void cbxEaseCurveTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = string.Join("", cbxEaseCurveTypes.SelectedItem.ToString().Split(' '));

        }

        private void cbxEaseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = string.Join("", cbxEaseTypes.SelectedItem.ToString().Split(' '));

        }

        // watch checkbox -> load selected if it exists
    }
}
