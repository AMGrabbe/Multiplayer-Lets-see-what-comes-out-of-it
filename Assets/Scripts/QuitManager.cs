using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class QuitManager : MonoBehaviour
{
    private GeneralInput generalInput;
    private InputAction quit;
    
    private void Awake()
    {
        generalInput = new GeneralInput();
    }

     private void OnEnable()
    {
        generalInput.Quit.PressKey.performed += DoQuit;
        generalInput.Enable();
    }

    private void OnDisable()
    {
        generalInput.Disable();
    }

    private void DoQuit(InputAction.CallbackContext obj)
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    private void FixedUpdate()
    {

    }
}
