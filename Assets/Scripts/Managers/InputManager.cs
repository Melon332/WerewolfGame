using UnityEngine;
using UnityEngine.InputSystem;

namespace Managers
{
    public class InputManager
    {
        //CONST STRINGS
        private const string MOVEMENT = "Movement";
        
        private PlayerInput input;
    
        public Vector2 MovementValue { get; private set; }

        public InputManager(PlayerInput _input)
        {
            input = _input;
        }

        public void DisableMovement()
        {
            input.currentActionMap.FindAction("Movement").Disable();
        }

        public void InitalizeActions()
        {
            input.currentActionMap.Enable();
            input.currentActionMap.FindAction(MOVEMENT).performed += Move;
            input.currentActionMap.FindAction(MOVEMENT).canceled += StopMoving;
        }

        private void Move(InputAction.CallbackContext ctx)
        {
            var value = ctx.ReadValue<Vector2>();
            MovementValue = value;
        }

        private void StopMoving(InputAction.CallbackContext ctx)
        {
            MovementValue = Vector2.zero;
        }
    }
}
