using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems; 

public class PlayerController : MonoBehaviour
{
    private Rigidbody rigidBody;

    private PlayerInput playerInput;
    private InputAction movement;
    private Vector2 moveDirection;

    private void Awake()
    {
        playerInput = new PlayerInput();
    }
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }
    private void OnEnable()
    {
        movement = playerInput.Player.Movement; 
        playerInput.Enable();
    }

    private void OnDisable()
    {
        playerInput.Disable();
    }

  /*  void Update()
    {
      moveDirection = playerControls.ReadValue<Vector2>();
    }*/

    private void FixedUpdate()
    {
        moveDirection = movement.ReadValue<Vector2>();
        rigidBody.velocity = new Vector3(moveDirection.x * 5.0f, 0,  moveDirection.y * 5.0f);
    }
}
