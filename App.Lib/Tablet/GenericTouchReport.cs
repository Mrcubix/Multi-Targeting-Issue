//using OpenTabletDriver.Plugin.Tablet.Touch;
using App.Lib.Tablet.Touch;

namespace App.Lib.Tablet
{
    public class GenericTouchReport : ITouchReport
    {
        public TouchPoint[] Touches { get; set; } = new TouchPoint[0];

        public byte[] Raw { get; set; } = new byte[0];
    }
}