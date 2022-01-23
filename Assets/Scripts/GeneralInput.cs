// GENERATED AUTOMATICALLY FROM 'Assets/Input System/GeneralInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @GeneralInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @GeneralInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GeneralInput"",
    ""maps"": [
        {
            ""name"": ""Quit"",
            ""id"": ""5dd2e752-730b-4fcc-aa34-28c163604aa5"",
            ""actions"": [
                {
                    ""name"": ""PressKey"",
                    ""type"": ""Button"",
                    ""id"": ""60a93534-a2a9-4577-be05-322bfa5069a2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""24d54ec5-ae5d-4dd4-b1b5-ccd1dafe4a33"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PressKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Quit
        m_Quit = asset.FindActionMap("Quit", throwIfNotFound: true);
        m_Quit_PressKey = m_Quit.FindAction("PressKey", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Quit
    private readonly InputActionMap m_Quit;
    private IQuitActions m_QuitActionsCallbackInterface;
    private readonly InputAction m_Quit_PressKey;
    public struct QuitActions
    {
        private @GeneralInput m_Wrapper;
        public QuitActions(@GeneralInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @PressKey => m_Wrapper.m_Quit_PressKey;
        public InputActionMap Get() { return m_Wrapper.m_Quit; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(QuitActions set) { return set.Get(); }
        public void SetCallbacks(IQuitActions instance)
        {
            if (m_Wrapper.m_QuitActionsCallbackInterface != null)
            {
                @PressKey.started -= m_Wrapper.m_QuitActionsCallbackInterface.OnPressKey;
                @PressKey.performed -= m_Wrapper.m_QuitActionsCallbackInterface.OnPressKey;
                @PressKey.canceled -= m_Wrapper.m_QuitActionsCallbackInterface.OnPressKey;
            }
            m_Wrapper.m_QuitActionsCallbackInterface = instance;
            if (instance != null)
            {
                @PressKey.started += instance.OnPressKey;
                @PressKey.performed += instance.OnPressKey;
                @PressKey.canceled += instance.OnPressKey;
            }
        }
    }
    public QuitActions @Quit => new QuitActions(this);
    public interface IQuitActions
    {
        void OnPressKey(InputAction.CallbackContext context);
    }
}
