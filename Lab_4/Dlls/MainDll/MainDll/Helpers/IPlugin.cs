﻿using Lab_4.Helpers;

namespace Lab_4.Helpers
{
    public interface IPlugin
    {
        string GetName();
        string GetParent();
        Hierarchy GetHierarchy();
    }
}
