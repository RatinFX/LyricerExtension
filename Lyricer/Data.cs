using ScriptPortal.Vegas;
//using Sony.Vegas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lyricer
{
    public class Data
    {
        public static Vegas Vegas { get; set; }
        //                                      remove " Vegas.Project. " later -> test if stuff breaks or not
        public static List<TrackEvent> SelectedMedias => Vegas.Project.Tracks.SelectMany(x => x.Events.Where(y => y.Selected).ToList()).ToList();
        public static List<PlugInNode> VideoFx => Vegas.VideoFX.ToList();
        public static List<PlugInNode> AudioFX => Vegas.AudioFX.ToList();
        public static List<PlugInNode> Generators => Vegas.Generators.ToList();
        public static List<PlugInNode> Transitions => Vegas.Transitions.ToList();
        public static Tracks Tracks => Vegas.Project.Tracks;

        public static Control MainForm { get; set; }

        public Data(Vegas vegas, Control mainForm)
        {
            Vegas = vegas;
            MainForm = mainForm;
        }
    }
}
