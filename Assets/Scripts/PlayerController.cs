using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems; 

public class PlayerController : MonoBehaviour
{

    public Rigidbody rigidBody;
    public InputAction playerControls;
    private Vector2 moveDirection;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }
    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }

    void Update()
    {
      moveDirection = playerControls.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        rigidBody.velocity = new Vector3(moveDirection.x * 5.0f, 0,  moveDirection.y * 5.0f);
    }
}
