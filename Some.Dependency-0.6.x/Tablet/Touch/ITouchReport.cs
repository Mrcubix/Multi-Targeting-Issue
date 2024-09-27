namespace App.Lib.Tablet.Touch
{
    public interface ITouchReport : IDeviceReport
    {
        TouchPoint[] Touches { get; }
    }
}
