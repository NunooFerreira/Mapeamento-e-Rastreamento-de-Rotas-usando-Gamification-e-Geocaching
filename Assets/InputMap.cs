//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/InputMap.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @InputMap : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMap()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMap"",
    ""maps"": [
        {
            ""name"": ""Touch"",
            ""id"": ""809b5f00-5614-4ea6-8a03-d1df74044c2f"",
            ""actions"": [
                {
                    ""name"": ""TouchPosition"",
                    ""type"": ""Value"",
                    ""id"": ""b47039b4-3edc-456f-826c-e9a83498ca7c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""TouchPress"",
                    ""type"": ""Button"",
                    ""id"": ""c19f0da0-8b1f-4895-8702-c9dd8d4b9510"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""63e5a50c-c986-4548-85d0-8c1e2ef60e80"",
                    ""path"": ""<Touchscreen>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""InputControlScheme"",
                    ""action"": ""TouchPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3801870e-2995-4329-8fc7-56f1d7157a76"",
                    ""path"": ""<Touchscreen>/Press"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""InputControlScheme"",
                    ""action"": ""TouchPress"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""InputControlScheme"",
            ""bindingGroup"": ""InputControlScheme"",
            ""devices"": []
        }
    ]
}");
        // Touch
        m_Touch = asset.FindActionMap("Touch", throwIfNotFound: true);
        m_Touch_TouchPosition = m_Touch.FindAction("TouchPosition", throwIfNotFound: true);
        m_Touch_TouchPress = m_Touch.FindAction("TouchPress", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Touch
    private readonly InputActionMap m_Touch;
    private ITouchActions m_TouchActionsCallbackInterface;
    private readonly InputAction m_Touch_TouchPosition;
    private readonly InputAction m_Touch_TouchPress;
    public struct TouchActions
    {
        private @InputMap m_Wrapper;
        public TouchActions(@InputMap wrapper) { m_Wrapper = wrapper; }
        public InputAction @TouchPosition => m_Wrapper.m_Touch_TouchPosition;
        public InputAction @TouchPress => m_Wrapper.m_Touch_TouchPress;
        public InputActionMap Get() { return m_Wrapper.m_Touch; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TouchActions set) { return set.Get(); }
        public void SetCallbacks(ITouchActions instance)
        {
            if (m_Wrapper.m_TouchActionsCallbackInterface != null)
            {
                @TouchPosition.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnTouchPosition;
                @TouchPosition.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnTouchPosition;
                @TouchPosition.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnTouchPosition;
                @TouchPress.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnTouchPress;
                @TouchPress.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnTouchPress;
                @TouchPress.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnTouchPress;
            }
            m_Wrapper.m_TouchActionsCallbackInterface = instance;
            if (instance != null)
            {
                @TouchPosition.started += instance.OnTouchPosition;
                @TouchPosition.performed += instance.OnTouchPosition;
                @TouchPosition.canceled += instance.OnTouchPosition;
                @TouchPress.started += instance.OnTouchPress;
                @TouchPress.performed += instance.OnTouchPress;
                @TouchPress.canceled += instance.OnTouchPress;
            }
        }
    }
    public TouchActions @Touch => new TouchActions(this);
    private int m_InputControlSchemeSchemeIndex = -1;
    public InputControlScheme InputControlSchemeScheme
    {
        get
        {
            if (m_InputControlSchemeSchemeIndex == -1) m_InputControlSchemeSchemeIndex = asset.FindControlSchemeIndex("InputControlScheme");
            return asset.controlSchemes[m_InputControlSchemeSchemeIndex];
        }
    }
    public interface ITouchActions
    {
        void OnTouchPosition(InputAction.CallbackContext context);
        void OnTouchPress(InputAction.CallbackContext context);
    }
}
