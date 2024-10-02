namespace Some.Dependency.Tablet.Touch
{
    public interface ITouchReport : IDeviceReport
    {
        TouchPoint[] Touches { get; }
    }
}
