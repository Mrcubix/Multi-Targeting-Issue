﻿namespace Some.Dependency
{
    public class MyObject(string name, string description = "")
    {
        public string Name { get; set; } = name;
        public string Description { get; set; } = description;
    }
}
