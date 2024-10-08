﻿using System.Numerics;

namespace Some.Dependency.Tablet.Touch
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
