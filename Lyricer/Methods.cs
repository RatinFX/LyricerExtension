using ScriptPortal.Vegas;
using System.Collections.Generic;
using System.Linq;
//using Sony.Vegas;

namespace Lyricer
{
    public class Methods
    {
        private Vegas Vegas;
        //public static FileStream LogStream;
        //public static StreamWriter LogWriter;
        public Methods(Vegas vegas)
        {
            Vegas = vegas;
        }

        /// <summary>
        /// Get selected TrackEvents from the timeline
        /// </summary>
        /// <param name="tracks">Vegas.Project.Tracks</param>
        /// <returns></returns>
        public static List<TrackEvent> GetSelectedEvents(Tracks tracks)
        {
            // if we're gonna change the timecode of the Event,
            // it's recommended to put it in a new Array/List
            // so it won't update and mess up the Event order
            List<TrackEvent> selectedList = new List<TrackEvent>();

            foreach (Track track in tracks)
            {
                foreach (TrackEvent trackEvent in track.Events)
                {
                    if (!trackEvent.Selected) continue;
                    selectedList.Add(trackEvent);
                }
            }
            return selectedList;
        }
















        /// <summary>
        /// Setting parameters
        /// </summary>

        /// TODO: figure out how to make this Generic
        // Did not work as expected:
        // - SetParameter<T>(...)
        // - where T : OFXParameter<T, OFXKeyframe<T>>
        // - var ofxParam = (T)ofx[param];
        /// unmanaged types -> https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/unmanaged-types

        /// bool + animated
        public static void SetParameterBool(OFXEffect ofx, string param, bool value)
        {
            var ofxParam = (OFXBooleanParameter)ofx[param];
            ofxParam.IsAnimated = false;
            ofxParam.Value = value;
        }
        public static void SetParameterBool(OFXEffect ofx, string param, bool value, Timecode timecode)
        {
            var ofxParam = (OFXBooleanParameter)ofx[param];
            if (!ofxParam.IsAnimated) ofxParam.IsAnimated = true;
            ofxParam.SetValueAtTime(timecode, value);
        }
        /// choice + animated
        public static void SetParameterChoice(OFXEffect ofx, string param, OFXChoice value)
        {
            var ofxParam = (OFXChoiceParameter)ofx[param];
            ofxParam.IsAnimated = false;
            if(value != null) ofxParam.Value = value;
        }
        public static void SetParameterChoice(OFXEffect ofx, string param, OFXChoice value, Timecode timecode)
        {
            var ofxParam = (OFXChoiceParameter)ofx[param];
            if(!ofxParam.IsAnimated) ofxParam.IsAnimated = true;
            ofxParam.SetValueAtTime(timecode, value);
        }
        /// color + animated
        public static void SetParameterColor(OFXEffect ofx, string param, string value)
        {
            var ofxParam = (OFXCustomParameter)ofx[param];
            ofxParam.IsAnimated = false;
            ofxParam.Value = value;
        }
        public static void SetParameterColor(OFXEffect ofx, string param, string value, Timecode timecode)
        {
            var ofxParam = (OFXCustomParameter)ofx[param];
            if (!ofxParam.IsAnimated) ofxParam.IsAnimated = true;
            ofxParam.SetValueAtTime(timecode, value);
        }
        /// double 2D + animated
        public static void SetParameterDouble2D(OFXEffect ofx, string param, OFXDouble2D value)
        {
            var ofxParam = (OFXDouble2DParameter)ofx[param];
            ofxParam.IsAnimated = false;
            ofxParam.Value = value;
        }
        public static void SetParameterDouble2D(OFXEffect ofx, string param, OFXDouble2D value, Timecode timecode)
        {
            var ofxParam = (OFXDouble2DParameter)ofx[param];
            if (!ofxParam.IsAnimated) ofxParam.IsAnimated = true;
            ofxParam.SetValueAtTime(timecode, value);
        }
        /// double 3D + animated
        public static void SetParameterDouble3D(OFXEffect ofx, string param, OFXDouble3D value)
        {
            var ofxParam = (OFXDouble3DParameter)ofx[param];
            ofxParam.IsAnimated = false;
            ofxParam.Value = value;
        }
        public static void SetParameterDouble3D(OFXEffect ofx, string param, OFXDouble3D value, Timecode timecode)
        {
            var ofxParam = (OFXDouble3DParameter)ofx[param];
            if (!ofxParam.IsAnimated) ofxParam.IsAnimated = true;
            ofxParam.SetValueAtTime(timecode, value);
        }
        /// double + animated
        public static void SetParameterDouble(OFXEffect ofx, string param, double value)
        {
            var ofxParam = (OFXDoubleParameter)ofx[param];
            ofxParam.IsAnimated = false;
            ofxParam.Value = value;
        }
        public static void SetParameterDouble(OFXEffect ofx, string param, double value, Timecode timecode)
        {
            var ofxParam = (OFXDoubleParameter)ofx[param];
            if (!ofxParam.IsAnimated) ofxParam.IsAnimated = true;
            ofxParam.SetValueAtTime(timecode, value);
        }
        /// int 2D + animated
        public static void SetParameterInt2D(OFXEffect ofx, string param, OFXInteger2D value)
        {
            var ofxParam = (OFXInteger2DParameter)ofx[param];
            ofxParam.IsAnimated = false;
            ofxParam.Value = value;
        }
        public static void SetParameterInt2D(OFXEffect ofx, string param, OFXInteger2D value, Timecode timecode)
        {
            var ofxParam = (OFXInteger2DParameter)ofx[param];
            if (!ofxParam.IsAnimated) ofxParam.IsAnimated = true;
            ofxParam.SetValueAtTime(timecode, value);
        }
        /// int 3D + animated
        public static void SetParameterInt3D(OFXEffect ofx, string param, OFXInteger3D value)
        {
            var ofxParam = (OFXInteger3DParameter)ofx[param];
            ofxParam.IsAnimated = false;
            ofxParam.Value = value;
        }
        public static void SetParameterInt3D(OFXEffect ofx, string param, OFXInteger3D value, Timecode timecode)
        {
            var ofxParam = (OFXInteger3DParameter)ofx[param];
            if (!ofxParam.IsAnimated) ofxParam.IsAnimated = true;
            ofxParam.SetValueAtTime(timecode, value);
        }
        /// int + animated
        public static void SetParameterInt(OFXEffect ofx, string param, int value)
        {
            var ofxParam = (OFXIntegerParameter)ofx[param];
            ofxParam.IsAnimated = false;
            ofxParam.Value = value;
        }
        public static void SetParameterInt(OFXEffect ofx, string param, int value, Timecode timecode)
        {
            var ofxParam = (OFXIntegerParameter)ofx[param];
            if (!ofxParam.IsAnimated) ofxParam.IsAnimated = true;
            ofxParam.SetValueAtTime(timecode, value);
        }
        /// RGBA + animated
        public static void SetParameterRGBA(OFXEffect ofx, string param, double r, double g, double b, double a)
        {
            var ofxParam = (OFXRGBAParameter)ofx[param];
            var color = new OFXColor(r, g, b, a);
            ofxParam.IsAnimated = false;
            ofxParam.Value = color;
        }
        public static void SetParameterRGBA(OFXEffect ofx, string param, double r, double g, double b, double a, Timecode timecode)
        {
            var ofxParam = (OFXRGBAParameter)ofx[param];
            var color = new OFXColor(r, g, b, a);
            if (!ofxParam.IsAnimated) ofxParam.IsAnimated = true;
            ofxParam.SetValueAtTime(timecode, color);
        }

        /// <summary>
        /// RGB + animated
        /// </summary>
        /// <param name="ofx">OFXEffect</param>
        /// <param name="param">Parameter name</param>
        /// <param name="r">Red: 0.0 to 1</param>
        /// <param name="g">Green: 0.0 to 1</param>
        /// <param name="b">Blue: 0.0 to 1</param>
        public static void SetParameterRGB(OFXEffect ofx, string param, double r, double g, double b)
        {
            var color = new OFXColor(r, g, b);
            SetParameterRGB(ofx, param, color);
        }
        public static void SetParameterRGB(OFXEffect ofx, string param, OFXColor color)
        {
            var ofxParam = (OFXRGBParameter)ofx[param];
            ofxParam.IsAnimated = false;
            ofxParam.Value = color;
        }
        public static void SetParameterRGB(OFXEffect ofx, string param, double r, double g, double b, Timecode timecode)
        {
            var color = new OFXColor(r, g, b);
            SetParameterRGB(ofx, param, color, timecode);
        }
        public static void SetParameterRGB(OFXEffect ofx, string param, OFXColor color, Timecode timecode)
        {
            var ofxParam = (OFXRGBParameter)ofx[param];
            if (!ofxParam.IsAnimated) ofxParam.IsAnimated = true;
            ofxParam.SetValueAtTime(timecode, color);
        }
        /// <summary>
        /// string + animated
        /// </summary>
        public static void SetParameterString(OFXEffect ofx, string param, string value)
        {
            var ofxParam = (OFXStringParameter)ofx[param];
            ofxParam.IsAnimated = false;
            ofxParam.Value = value;
        }
        public static void SetParameterString(OFXEffect ofx, string param, string value, Timecode timecode)
        {
            var ofxParam = (OFXStringParameter)ofx[param];
            if (!ofxParam.IsAnimated) ofxParam.IsAnimated = true;
            ofxParam.SetValueAtTime(timecode, value);
        }









        /// <summary>
        /// Set the preset of an effect by name
        /// </summary>
        /// <param name="effect">Effect</param>
        /// <param name="name">Preset name</param>
        public static void SetPreset(Effect effect, string name)
        {
            var preset = effect.Presets.FirstOrDefault(x => x.Name == name)?.Name;
            if (preset != null || preset != "") effect.Preset = preset;
        }
        /// <summary>
        /// Set the preset of an effect by index
        /// </summary>
        /// <param name="effect">Effect</param>
        /// <param name="index">Preset index</param>
        public static void SetPreset(Effect effect, int index)
        {
            effect.Preset = effect.Presets[index].Name;
        }


    }
}
