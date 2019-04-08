using Rhino.PlugIns;
using Rhino.UI;
using RhinoWindows.Controls;
using RMA.UI;
using SampleWPF.View;
using System;
using System.Windows.Forms.Integration;

namespace SampleWPFRhinoPlugin
{
    ///<summary>
    /// <para>Every RhinoCommon .rhp assembly must have one and only one PlugIn-derived
    /// class. DO NOT create instances of this class yourself. It is the
    /// responsibility of Rhino to create an instance of this class.</para>
    /// <para>To complete plug-in information, please also see all PlugInDescription
    /// attributes in AssemblyInfo.cs (you might need to click "Project" ->
    /// "Show All Files" to see it in the "Solution Explorer" window).</para>
    ///</summary>
    public class SampleWPFRhinoPluginPlugIn : Rhino.PlugIns.PlugIn

    {
        public SampleWPFRhinoPluginPlugIn()
        {
            Instance = this;
        }

        ///<summary>Gets the only instance of the SampleWPFRhinoPluginPlugIn plug-in.</summary>
        public static SampleWPFRhinoPluginPlugIn Instance
        {
            get; private set;
        }

        private MainView MainView { get; set; }

        private MainViewDockBar MyDockBar { get; set; }

        // You can override methods here to change the plug-in behavior on
        // loading and shut down, add options pages to the Rhino _Option command
        // and maintain plug-in wide options in a document.
        protected override LoadReturnCode OnLoad(ref string errorMessage)
        {

            /*
            this.MainView = new MainView();
            ElementHost host = new ElementHost
            {
                Dock = System.Windows.Forms.DockStyle.Fill,
                Child = this.MainView
            };
            MRhinoUiDockBar dockBar = new MRhinoUiDockBar(Guid.NewGuid(), "MyView", host);

            MRhinoDockBarManager.CreateRhinoDockBar(
                this,
                dockBar,
                true,
                MRhinoUiDockBar.DockLocation.left,
                MRhinoUiDockBar.DockStyle.left_and_right,
                new System.Drawing.Point(200, 200));
            */

            this.CreateMyDockBar();

            Panels.RegisterPanel(this, typeof(WpfPanel), "SampleWpfPanel", System.Drawing.SystemIcons.WinLogo);

            return base.OnLoad(ref errorMessage);
        }

        private void CreateMyDockBar()
        {
            var createOptions = new DockBarCreateOptions
            {
                DockLocation = DockBarDockLocation.Left,
                Visible = false,
                DockStyle = DockBarDockStyle.LeftAndRight,
                FloatPoint = new System.Drawing.Point(0, 0)
            };
            this.MyDockBar = new MainViewDockBar();
            this.MyDockBar.Create(createOptions);
        }
    }
}