using SampleWPF.View;
using System.Runtime.InteropServices;

namespace SampleWPFRhinoPlugin
{
    [Guid("0874C691-A083-4C05-9E31-96C2C63F7C7E")]
    public class WpfPanel : RhinoWindows.Controls.WpfElementHost
    {
        public WpfPanel()
            : base(new MainView(), null)
        {
        }
    }
}
