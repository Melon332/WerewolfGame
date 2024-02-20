using System;
using Managers;
using ScriptableObjects;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Player
{
    public class Player : MonoBehaviour
    {
        private bool initalized = false;
        private Rigidbody rb;
        private PlayerInput playerInput;
        
        //Non monobehaviour classes
        private PlayerMovement playerMovement;
        private InputManager inputManager;
        
        [SerializeField] private SO_PlayerData playerData;

        private void Awake()
        {
            rb = GetComponent<Rigidbody>();
            playerInput = GetComponent<PlayerInput>();
            
            playerMovement = new PlayerMovement(playerData, rb);
            inputManager = new InputManager(playerInput);
            inputManager.InitalizeActions();


            initalized = true;
        }

        private void FixedUpdate()
        {
            if (!initalized) return;
            playerMovement.Move(inputManager.MovementValue);
        }
    }
}
