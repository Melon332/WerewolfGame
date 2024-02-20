using ScriptableObjects;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;

namespace Player
{
    public class PlayerMovement
    {
        private float walkSpeed;
        private float sprintSpeed;
        private float acceleration;
        private Rigidbody rb;

        public PlayerMovement(SO_PlayerData playerData, Rigidbody _rb)
        {
            walkSpeed = playerData.WalkSpeed;
            sprintSpeed = playerData.SprintSpeed;
            acceleration = playerData.Acceleration;
            rb = _rb;
        }

        public void Move(Vector2 movementValues)
        {
            if (movementValues == Vector2.zero) return;
            Debug.Log($"Move X: {movementValues.x}\nMove Y: {movementValues.y}");
        }

        public void ReinitalizeMovementValues(SO_PlayerData playerData)
        {
            walkSpeed = playerData.WalkSpeed;
            sprintSpeed = playerData.SprintSpeed;
            acceleration = playerData.Acceleration;
        }
    }
}
