using Sirenix.OdinInspector;
using UnityEngine;

namespace PlayerCore
{
    public class PlayerInput : MonoBehaviour
    {
        public enum ControlType
        {
            None = 0,
            SampleInputController
            // SampleInputController2
            // SampleInputController3
            // ...
        }

        public ControlType m_controlType;

        private ControlType _lastControlType;

        private IInputController _inputController;

        /// <summary>
        /// Update is called every frame, if the MonoBehaviour is enabled.
        /// </summary>
        private void Update ()
        {
            if (_lastControlType != m_controlType)
            {
                _lastControlType = m_controlType;
                CreateNewInputControl ();
            }
        }

        private void CreateNewInputControl ()
        {
            switch (m_controlType)
            {
                case ControlType.None:
                    _inputController = null;
                    break;
                case ControlType.SampleInputController:
                    _inputController = new SampleInputController ();
                    break;
            }
        }

        [ShowInInspector, ReadOnly]
        public bool JumpWasPressed
        {
            get
            {
                if (_inputController != null)
                {
                    return _inputController.GetJumpWasPressed ();
                }
                return false;
            }
        }

        [ShowInInspector, ReadOnly]
        public bool JumpWasReleaseed
        {
            get
            {
                if (_inputController != null)
                {
                    return _inputController.GetJumpWasRealseed ();
                }
                return false;
            }
        }

        [ShowInInspector, ReadOnly]
        public bool Jump
        {
            get
            {
                if (_inputController != null)
                {
                    return _inputController.GetJump ();
                }
                return false;
            }
        }

        [ShowInInspector, ReadOnly]
        public bool Pick
        {
            get
            {
                if (_inputController != null)
                {
                    return _inputController.GetPick ();
                }
                return false;
            }
        }

        [ShowInInspector, ReadOnly]
        public bool PickWasPress
        {
            get
            {
                if (_inputController != null)
                {
                    return _inputController.GetPickWasPress ();
                }
                return false;
            }
        }

        [ShowInInspector, ReadOnly]
        public bool Attack
        {
            get
            {
                if (_inputController != null)
                {
                    return _inputController.GetAttack ();
                }
                return false;
            }
        }

        [ShowInInspector, ReadOnly]
        public bool ThrowWasPressed
        {
            get
            {
                if (_inputController != null)
                {
                    return _inputController.GetThrowWasPressed ();
                }
                return false;
            }
        }

        public bool HasAnyInput
        {
            get
            {
                if (_inputController != null)
                {
                    return _inputController.GetHasAnyInput ();
                }
                return false;
            }
        }

        [ShowInInspector, ReadOnly]
        public Vector2 Move
        {
            get
            {
                if (_inputController != null)
                {
                    return _inputController.GetMove ();
                }
                return Vector2.zero;
            }
        }
    }
}