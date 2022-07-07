using ScriptPortal.Vegas;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
//using Sony.Vegas;

namespace Lyricer
{
    public class Methods
    {
        //public static FileStream LogStream;
        //public static StreamWriter LogWriter;










        /// <summary>
        /// Setting parameters
        /// </summary>

        /// TODO: figure out how to make these generic
        // Did not work as expected:
        // - SetParameter<T>(...)
        // - where T : OFXParameter<T, OFXKeyframe<T>>
        // - var ofxParam = (T)ofx[param];
        /// unmanaged types -> https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/unmanaged-types

        /// bool + animated
        public static void SetParameterBool(OFXEffect ofx, string param, bool value)
        {
            var ofxParam = ofx[param] as OFXBooleanParameter;
            ofxParam.IsAnimated = false;
            ofxParam.Value = value;
        }
        public static void SetParameterBool(OFXEffect ofx, string param, bool value, Timecode timecode)
        {
            var ofxParam = ofx[param] as OFXBooleanParameter;
            if (!ofxParam.IsAnimated) ofxParam.IsAnimated = true;
            ofxParam.SetValueAtTime(timecode, value);
        }
        /// choice + animated
        public static void SetParameterChoice(OFXEffect ofx, string param, OFXChoice value)
        {
            var ofxParam = ofx[param] as OFXChoiceParameter;
            ofxParam.IsAnimated = false;
            if (value != null) ofxParam.Value = value;
        }
        public static void SetParameterChoice(OFXEffect ofx, string param, OFXChoice value, Timecode timecode)
        {
            var ofxParam = ofx[param] as OFXChoiceParameter;
            if (!ofxParam.IsAnimated) ofxParam.IsAnimated = true;
            ofxParam.SetValueAtTime(timecode, value);
        }
        /// color + animated
        public static void SetParameterColor(OFXEffect ofx, string param, string value)
        {
            var ofxParam = ofx[param] as OFXCustomParameter;
            ofxParam.IsAnimated = false;
            ofxParam.Value = value;
        }
        public static void SetParameterColor(OFXEffect ofx, string param, string value, Timecode timecode)
        {
            var ofxParam = ofx[param] as OFXCustomParameter;
            if (!ofxParam.IsAnimated) ofxParam.IsAnimated = true;
            ofxParam.SetValueAtTime(timecode, value);
        }
        /// double 2D + animated
        public static void SetParameterDouble2D(OFXEffect ofx, string param, OFXDouble2D value)
        {
            var ofxParam = ofx[param] as OFXDouble2DParameter;
            ofxParam.IsAnimated = false;
            ofxParam.Value = value;
        }
        public static void SetParameterDouble2D(OFXEffect ofx, string param, OFXDouble2D value, Timecode timecode)
        {
            var ofxParam = ofx[param] as OFXDouble2DParameter;
            if (!ofxParam.IsAnimated) ofxParam.IsAnimated = true;
            ofxParam.SetValueAtTime(timecode, value);
        }
        /// double 3D + animated
        public static void SetParameterDouble3D(OFXEffect ofx, string param, OFXDouble3D value)
        {
            var ofxParam = ofx[param] as OFXDouble3DParameter;
            ofxParam.IsAnimated = false;
            ofxParam.Value = value;
        }
        public static void SetParameterDouble3D(OFXEffect ofx, string param, OFXDouble3D value, Timecode timecode)
        {
            var ofxParam = ofx[param] as OFXDouble3DParameter;
            if (!ofxParam.IsAnimated) ofxParam.IsAnimated = true;
            ofxParam.SetValueAtTime(timecode, value);
        }
        /// double + animated
        public static void SetParameterDouble(OFXEffect ofx, string param, double value)
        {
            var ofxParam = ofx[param] as OFXDoubleParameter;
            ofxParam.IsAnimated = false;
            ofxParam.Value = value;
        }
        public static void SetParameterDouble(OFXEffect ofx, string param, double value, Timecode timecode)
        {
            var ofxParam = ofx[param] as OFXDoubleParameter;
            if (!ofxParam.IsAnimated) ofxParam.IsAnimated = true;
            ofxParam.SetValueAtTime(timecode, value);
        }
        /// int 2D + animated
        public static void SetParameterInt2D(OFXEffect ofx, string param, OFXInteger2D value)
        {
            var ofxParam = ofx[param] as OFXInteger2DParameter;
            ofxParam.IsAnimated = false;
            ofxParam.Value = value;
        }
        public static void SetParameterInt2D(OFXEffect ofx, string param, OFXInteger2D value, Timecode timecode)
        {
            var ofxParam = ofx[param] as OFXInteger2DParameter;
            if (!ofxParam.IsAnimated) ofxParam.IsAnimated = true;
            ofxParam.SetValueAtTime(timecode, value);
        }
        /// int 3D + animated
        public static void SetParameterInt3D(OFXEffect ofx, string param, OFXInteger3D value)
        {
            var ofxParam = ofx[param] as OFXInteger3DParameter;
            ofxParam.IsAnimated = false;
            ofxParam.Value = value;
        }
        public static void SetParameterInt3D(OFXEffect ofx, string param, OFXInteger3D value, Timecode timecode)
        {
            var ofxParam = ofx[param] as OFXInteger3DParameter;
            if (!ofxParam.IsAnimated) ofxParam.IsAnimated = true;
            ofxParam.SetValueAtTime(timecode, value);
        }
        /// int + animated
        public static void SetParameterInt(OFXEffect ofx, string param, int value)
        {
            var ofxParam = ofx[param] as OFXIntegerParameter;
            ofxParam.IsAnimated = false;
            ofxParam.Value = value;
        }
        public static void SetParameterInt(OFXEffect ofx, string param, int value, Timecode timecode)
        {
            var ofxParam = ofx[param] as OFXIntegerParameter;
            if (!ofxParam.IsAnimated) ofxParam.IsAnimated = true;
            ofxParam.SetValueAtTime(timecode, value);
        }
        /// RGBA + animated
        public static void SetParameterRGBA(OFXEffect ofx, string param, double r, double g, double b, double a)
        {
            var ofxParam = ofx[param] as OFXRGBAParameter;
            var color = new OFXColor(r, g, b, a);
            ofxParam.IsAnimated = false;
            ofxParam.Value = color;
        }
        public static void SetParameterRGBA(OFXEffect ofx, string param, double r, double g, double b, double a, Timecode timecode)
        {
            var ofxParam = ofx[param] as OFXRGBAParameter;
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
            var ofxParam = ofx[param] as OFXRGBParameter;
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
            var ofxParam = ofx[param] as OFXRGBParameter;
            if (!ofxParam.IsAnimated) ofxParam.IsAnimated = true;
            ofxParam.SetValueAtTime(timecode, color);
        }
        /// <summary>
        /// string + animated
        /// </summary>
        public static void SetParameterString(OFXEffect ofx, string param, string value)
        {
            var ofxParam = ofx[param] as OFXStringParameter;
            ofxParam.IsAnimated = false;
            ofxParam.Value = value;
        }
        public static void SetParameterString(OFXEffect ofx, string param, string value, Timecode timecode)
        {
            var ofxParam = ofx[param] as OFXStringParameter;
            if (!ofxParam.IsAnimated) ofxParam.IsAnimated = true;
            ofxParam.SetValueAtTime(timecode, value);
        }
        /// <summary>
        /// rich text string + animated
        /// </summary>
        public static void SetParameterRichText(OFXEffect ofx, string param, string value)
        {
            var ofxParam = ofx[param] as OFXStringParameter;
            RichTextBox rtfText = new RichTextBox
            {
                Rtf = ofxParam.Value,
                Text = value
            };
            ofxParam.IsAnimated = false;
            ofxParam.Value = rtfText.Rtf;
        }
        public static void SetParameterRichText(OFXEffect ofx, string param, string value, Timecode timecode)
        {
            var ofxParam = ofx[param] as OFXStringParameter;
            RichTextBox rtfText = new RichTextBox
            {
                Rtf = ofxParam.Value,
                Text = value
            };
            if (!ofxParam.IsAnimated) ofxParam.IsAnimated = true;
            ofxParam.SetValueAtTime(timecode, rtfText.Rtf);
        }
    }
}
