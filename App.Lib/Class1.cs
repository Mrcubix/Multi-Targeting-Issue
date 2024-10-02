//using OpenTabletDriver.Plugin.Tablet.Touch;
using Some.Dependency.Tablet.Touch;
using App.Lib.Tablet;

namespace App.Lib;

public class Class1
{
    public ITouchReport TouchReport { get; set; } = new GenericTouchReport();
}
