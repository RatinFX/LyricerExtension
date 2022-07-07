using ScriptPortal.Vegas;
//using Sony.Vegas;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VegasProData;

namespace Lyricer
{
    public class GetEffectsGUID
    {
        //static FileStream inis = new FileStream(".\\EffectsGUID.txt", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None, bufferSize: 4096, useAsync: true);
        static FileStream inis = new FileStream(".\\EffectsGUID.txt", FileMode.OpenOrCreate);
        static StreamWriter iniw = new StreamWriter(inis);
        static string fullText = "";

        // TODO: try separating them to different files
        public static void GetEffects(bool isSeparate = false)
        {
            /// Get Audio Effects
            // ToText("Audio Effects");
            NewSection("Audio Effects");
            CheckListItems(Data.AudioFX, isAudio: true);

            /// Get Video Effects
            // ToText("Video Effects");
            NewSection("Video Effects");
            CheckListItems(Data.VideoFX, moreVideoChecks: true);

            /// Get Generators
            // ToText("Generators");
            NewSection("Generators");
            CheckListItems(Data.Generators);

            /// Get Transitions
            // ToText("Transitions");
            NewSection("Transitions");
            CheckListItems(Data.Transitions);

            /// Get Renderers
            // ToText("Renderers");
            NewSection("Renderers");
            foreach (var renderer in Data.Vegas.Renderers)
            {
                if (renderer == null) continue;

                var newLine = $"{renderer.FileExtension} - {renderer.FileTypeName} - {renderer.ClassID}";
                //var newLine = $"{renderer.FileExtension} - {renderer.FileTypeName} - {renderer.ClassID}\n";
                iniw.WriteLine(newLine);
                //fullText += newLine;
            }

            //iniw.Write(fullText);
            iniw.Close();
            inis.Close();
        }

        static void ToText(string section)
        {
            fullText += $"\n[ {section} ]\n";
        }

        static void NewSection(string section)
        {
            iniw.WriteLine($"\n[ {section} ]");
        }

        /// <summary>
        /// Helper Method
        /// </summary>
        /// <param name="list">List to look through</param>
        /// <param name="isAudio">Does the List contains AudioFX</param>
        /// <param name="moreVideoChecks">Use the additional checks for VideoFX</param>
        public static void CheckListItems(IEnumerable<ExtendedPlugInNode> list, bool isAudio = false, bool moreVideoChecks = false)
        {
            foreach (var fx in list)
            {
                if (fx == null || fx.Plugin == null ||
                   (isAudio && !fx.IsAudioFX) ||
                   (moreVideoChecks && !fx.IsVideoFX)) continue;

                var index = 0;
                var baseLine = $"{fx.Name} - {fx.Plugin.ClassID}";

                if (!isAudio) baseLine += $" - UID: {fx.Plugin.UniqueID} - isOFX: {fx.Plugin.IsOFX}";

                foreach (var preset in fx.Plugin.Presets)
                {
                    if (preset == null) continue;

                    var newLine = $"{baseLine} - {preset.Name} - {index}";
                    //var newLine = $"{baseLine} - {preset.Name} - {index}\n";
                    index++;
                    iniw.WriteLine(newLine);
                    //fullText += newLine;
                }
            }
        }
    }
}
