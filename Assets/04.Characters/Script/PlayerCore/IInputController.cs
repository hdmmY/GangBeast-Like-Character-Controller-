using UnityEngine;

namespace PlayerCore
{
    public interface IInputController
    {
        bool GetJumpWasPressed ();

        bool GetJumpWasRealseed ();

        bool GetJump ();

        bool GetPick ();

        bool GetPickWasPress ();

        bool GetAttack ();

        bool GetThrowWasPressed ();

        Vector2 GetMove ();

        bool GetHasAnyInput ();
    }
}