using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "New Player Data", order = 1,menuName = "PlayerData")]
    public class SO_PlayerData : ScriptableObject
    {
        [Header("Player Movement")]
        public float WalkSpeed;
        public float SprintSpeed;
        public float Acceleration;
        [Space] [Header("Camera Values")] 
        public float SensX;
        public float SensY;

    }
}
