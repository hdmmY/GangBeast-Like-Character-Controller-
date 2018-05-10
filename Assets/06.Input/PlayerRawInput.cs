using Sirenix.OdinInspector;
using UnityEngine;

namespace PlayerCore
{
    public class PlayerRawInput
    {
        private CharacterActions _action;

        public bool RawJumpWasPressed
        {
            get
            {
                if (_action != null)
                {
                    return _action.Jump.WasPressed;
                }
                return false;
            }
        }

        public bool RawJumpWasReleaseed
        {
            get
            {
                if (_action != null)
                {
                    return _action.Jump.WasReleased;
                }
                return false;
            }
        }

        public bool RawJump
        {
            get
            {
                if (_action != null)
                {
                    return _action.Jump;
                }
                return false;
            }
        }

        public bool RawPick
        {
            get
            {
                if (_action != null)
                {
                    return _action.Pick;
                }
                return false;
            }
        }

        public bool RawPickWasPress
        {
            get
            {
                if (_action != null)
                {
                    return _action.Pick.WasPressed;
                }
                return false;
            }
        }

        public bool RawAttack
        {
            get
            {
                if (_action != null)
                {
                    return _action.Attack;
                }
                return false;
            }
        }

        public bool RawThrowWasPressed
        {
            get
            {
                if (_action != null)
                {
                    return _action.Throw.WasPressed;
                }
                return false;
            }
        }

        public Vector2 RawMove
        {
            get
            {
                if (_action != null)
                {
                    return _action.Move.Value;
                }
                return Vector2.zero;
            }
        }

        public bool RawHasAnyInput
        {
            get
            {
                if (_action != null)
                {
                    return RawAttack ||
                        RawJumpWasPressed || RawJumpWasReleaseed || RawJump ||
                        RawPick || RawPickWasPress ||
                        RawThrowWasPressed || InputUtils.ValidMove (RawMove);
                }
                return false;
            }
        }

        public void CreateWithKeyboardBindings ()
        {
            _action = CharacterActions.CreateWithKeyboardBindings ();
        }

        public void CreateWithControllerBindings ()
        {
            _action = CharacterActions.CreateWithControllerBindings ();
        }
    }
}