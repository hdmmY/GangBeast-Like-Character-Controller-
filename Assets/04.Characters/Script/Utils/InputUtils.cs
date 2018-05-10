using InControl;
using UnityEngine;

public static class InputUtils
{
    public static bool ValidMove (Vector2 move)
    {
        float tolerance = 0.1f;

        return (move.x < -tolerance || move.x > tolerance) ||
            (move.y < -tolerance || move.y > tolerance);
    }
}

