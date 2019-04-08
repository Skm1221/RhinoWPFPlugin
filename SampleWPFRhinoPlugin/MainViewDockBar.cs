using RhinoWindows.Controls;
using SampleWPF.View;
using System;

namespace SampleWPFRhinoPlugin
{
    public class MainViewDockBar : DockBar
    {
        private readonly MainView mainView;

        public MainViewDockBar()
            : base(SampleWPFRhinoPluginPlugIn.Instance, BarId, "WPF")
        {
            this.mainView = new MainView();
            this.SetContentControl(new WpfHost(this.mainView, null));
        }

        public static Guid BarId => new Guid("{c520731e-376a-4d82-975a-403664fca2fc}");
    }
}
