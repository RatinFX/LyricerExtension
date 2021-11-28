using ScriptPortal.Vegas;
//using Sony.Vegas;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lyricer
{
    public class GetEffectsGUID
    {
        //static FileStream inis = new FileStream(".\\EffectsGUID.txt", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None, bufferSize: 4096, useAsync: true);
        static FileStream inis = new FileStream(".\\EffectsGUID.txt", FileMode.OpenOrCreate);
        static StreamWriter iniw = new StreamWriter(inis);
        static string fullText = "";

        // TODO: try separating them to different files
        public static void GetEffects(Vegas myVegas, bool isSeparate = false)
        {
            /// Get Audio Effects
            iniw.WriteLine("\n[ Audio Effects ]");
            //fullText += "[ Audio Effects ]\n";
            CheckListItems(myVegas.AudioFX, true);

            /// Get Video Effects
            iniw.WriteLine("\n[ Video Effects ]");
            //fullText += "\n[ Video Effects ]\n";
            CheckListItems(myVegas.VideoFX, false, true);

            /// Get Generators
            iniw.WriteLine("\n[ Generators ]");
            //fullText += "\n[ Generators ]\n";
            CheckListItems(myVegas.Generators);

            /// Get Transitions
            iniw.WriteLine("\n[ Transitions ]");
            //fullText += "\n[ Transitions ]\n";
            CheckListItems(myVegas.Transitions);

            /// Get Renderers
            iniw.WriteLine("\n[ Renderers ]");
            //fullText += "\n[ Renderers ]\n";
            foreach (Renderer renderer in myVegas.Renderers)
            {
                if (renderer == null) continue;

                var newLine = $"{renderer.FileExtension} - {renderer.FileTypeName} - {renderer.ClassID}";
                //var newLine = $"{renderer.FileExtension} - {renderer.FileTypeName} - {renderer.ClassID}\n";
                iniw.WriteLine(newLine);
                //fullText += newLine;
            }

            iniw.Write(fullText);
            iniw.Close();
            inis.Close();
            //MessageBox.Show("Processing done.");
        }

        /// <summary>
        /// Helper Method
        /// </summary>
        /// <param name="list">List to look through</param>
        /// <param name="isAudio">Does the List contains AudioFX</param>
        /// <param name="moreVideoChecks">Use the additional checks for VideoFX</param>
        public static void CheckListItems(PlugInNode list, bool isAudio = false, bool moreVideoChecks = false)
        {
            foreach (PlugInNode fx in list)
            {
                if (fx == null) continue;
                if (isAudio && (!fx.IsAudio || fx.IsContainer || fx.IsPackage)) continue;
                if (moreVideoChecks && (!fx.IsVideo || fx.IsContainer || fx.IsPackage)) continue;

                var index = 0;
                var baseLine = $"{fx.Name} - {fx.ClassID}";

                if (!isAudio) baseLine += $" - UID: {fx.UniqueID} - isOFX: {fx.IsOFX}";

                foreach (EffectPreset preset in fx.Presets)
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
