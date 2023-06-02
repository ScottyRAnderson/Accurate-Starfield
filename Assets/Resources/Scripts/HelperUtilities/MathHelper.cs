using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MathHelper
{
    /// <summary> Normalizes a value between 0 - 1 given the minimum and maximum of the given value. E.g. Normalize(0, -1, 1) = 0.5 </summary>
    public static float NormalizeValue(float value, float min, float max){
        return (value - min) / (max - min);
    }
}