//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Scripts/Module/Input/InputActionManager.inputactions
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

namespace SpaceInvader.Module.Input
{
    public partial class @InputActionManager : IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @InputActionManager()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActionManager"",
    ""maps"": [
        {
            ""name"": ""Input"",
            ""id"": ""f9fd197e-cd31-497c-8ad8-0eca10b4ee7a"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""ada16c75-c0c4-47ce-9891-674d2fd1d8ef"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)"",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""91b3cb0e-379c-4fc9-a895-7a68fbd9ac11"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""85f13eac-62f4-47f7-8474-1f4dd8a53a5e"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""CS"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""e4ee2f1b-aa9a-41b0-a7a3-e361b076c487"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""CS"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""CS"",
            ""bindingGroup"": ""CS"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
            // Input
            m_Input = asset.FindActionMap("Input", throwIfNotFound: true);
            m_Input_Move = m_Input.FindAction("Move", throwIfNotFound: true);
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

        // Input
        private readonly InputActionMap m_Input;
        private IInputActions m_InputActionsCallbackInterface;
        private readonly InputAction m_Input_Move;
        public struct InputActions
        {
            private @InputActionManager m_Wrapper;
            public InputActions(@InputActionManager wrapper) { m_Wrapper = wrapper; }
            public InputAction @Move => m_Wrapper.m_Input_Move;
            public InputActionMap Get() { return m_Wrapper.m_Input; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(InputActions set) { return set.Get(); }
            public void SetCallbacks(IInputActions instance)
            {
                if (m_Wrapper.m_InputActionsCallbackInterface != null)
                {
                    @Move.started -= m_Wrapper.m_InputActionsCallbackInterface.OnMove;
                    @Move.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnMove;
                    @Move.canceled -= m_Wrapper.m_InputActionsCallbackInterface.OnMove;
                }
                m_Wrapper.m_InputActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Move.started += instance.OnMove;
                    @Move.performed += instance.OnMove;
                    @Move.canceled += instance.OnMove;
                }
            }
        }
        public InputActions @Input => new InputActions(this);
        private int m_CSSchemeIndex = -1;
        public InputControlScheme CSScheme
        {
            get
            {
                if (m_CSSchemeIndex == -1) m_CSSchemeIndex = asset.FindControlSchemeIndex("CS");
                return asset.controlSchemes[m_CSSchemeIndex];
            }
        }
        public interface IInputActions
        {
            void OnMove(InputAction.CallbackContext context);
        }
    }
}
