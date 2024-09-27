using System.Numerics;

namespace App.Lib.Tablet.Touch
{
    public class TouchPoint
    {
        public byte TouchID;
        public Vector2 Position;

        public override string ToString()
        {
            return $"Point #{TouchID}: {Position};";
        }
    }
}
