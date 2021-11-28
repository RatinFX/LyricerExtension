using ScriptPortal.Vegas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;

namespace Lyricer
{
    public class LyricerDockControl : DockableControl
    {
        private MainForm form = null;

        public LyricerDockControl() : base("ILyricer")
        {
            // name of the tab in Vegas
            DisplayName = "Lyricer";
        }

        public override DockWindowStyle DefaultDockWindowStyle
        {
            get { return DockWindowStyle.Docked; }
        }

        public override Size DefaultFloatingSize
        {
            get { return new Size(640, 480); }
        }

        protected override void OnLoad(EventArgs e)
        {
            form = new MainForm(myVegas)
            {
                Dock = DockStyle.Fill
            };
            Controls.Add(form);
            myVegas.TrackCountChanged += form.HandleTrackCountChange;
        }

        protected override void OnClosed(EventArgs args)
        {
            myVegas.TrackCountChanged -= form.HandleTrackCountChange;

            base.OnClosed(args);
        }
    }

}

/// <summary>
/// Handles the user click under the selected CommandCategory menu
/// </summary>
public class CustomCommandModule : ICustomCommandModule
{
    public Vegas myVegas = null;
    CustomCommand CCM = new CustomCommand(CommandCategory.View, "Lyricer"); // name of the tab in Vegas

    public void InitializeModule(Vegas vegas)
    {
        myVegas = vegas;
        CCM.MenuItemName = "Lyricer";
    }

    public ICollection GetCustomCommands()
    {
        // handle MenuPopup and Invoke of the CustomCommand
        CCM.MenuPopup += HandleMenuPopup;
        CCM.Invoked += HandleInvoked;
        CustomCommand[] cmds = new CustomCommand[] { CCM };
        return cmds;
    }

    private void HandleMenuPopup(object sender, EventArgs e)
    {
        // find and see if the extension is docked or not
        CCM.Checked = myVegas.FindDockView("ILyricer");
    }

    private void HandleInvoked(object sender, EventArgs e)
    {
        // if it isn't docked yet
        if (!myVegas.ActivateDockView("ILyricer"))
        {
            // create the new DockableControl
            Lyricer.LyricerDockControl Dock = new Lyricer.LyricerDockControl();
            Dock.AutoLoadCommand = CCM;

            // keeps it open all the time + reload on Vegas reload
            Dock.PersistDockWindowState = true;
            myVegas.LoadDockView(Dock);
        }
    }
}
