using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GlobalSettings
{
    private static float _template = 1f;

    public static float Template
    {
        get => _template;
        set => _template = value;
    }
}
