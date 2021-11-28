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
        public static Control MainForm { get; set; }
        public static int tab0 { get; set; }
        public static int tab1 { get; set; }
        public static int tab2 { get; set; }
        public static int tab3 { get; set; }

        public Data(Vegas vegas, Control mainForm)
        {
            Vegas = vegas;
            MainForm = mainForm;
        }
    }
}
