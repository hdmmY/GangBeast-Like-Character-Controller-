using UnityEngine;

namespace PlayerCore
{
    public class SampleInputController : IInputController
    {
        PlayerRawInput _playerInput;

        public SampleInputController ()
        {
            _playerInput = new PlayerRawInput ();
            _playerInput.CreateWithKeyboardBindings ();
        }

        public bool GetJumpWasPressed ()
        {
            return _playerInput.RawJumpWasPressed;
        }

        public bool GetJumpWasRealseed ()
        {
            return _playerInput.RawJumpWasReleaseed;
        }

        public bool GetJump ()
        {
            return _playerInput.RawJump;
        }

        public bool GetPick ()
        {
            return _playerInput.RawPick;
        }

        public bool GetPickWasPress ()
        {
            return _playerInput.RawPickWasPress;
        }

        public bool GetAttack ()
        {
            return _playerInput.RawAttack;
        }

        public bool GetThrowWasPressed ()
        {
            return _playerInput.RawThrowWasPressed;
        }

        public Vector2 GetMove ()
        {
            return _playerInput.RawMove;
        }

        public bool GetHasAnyInput ()
        {
            return _playerInput.RawHasAnyInput;
        }
    }
}