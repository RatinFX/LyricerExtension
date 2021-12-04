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

        public Data(Vegas vegas, Control mainForm)
        {
            Vegas = vegas;
            MainForm = mainForm;
        }
    }
}
