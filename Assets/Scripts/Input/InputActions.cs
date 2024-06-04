//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/InputActions.inputactions
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

namespace Asteroid
{
    public partial class @InputActions: IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @InputActions()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""gameplay"",
            ""id"": ""90e4f983-a292-43a3-9e51-02d0a17eaff9"",
            ""actions"": [
                {
                    ""name"": ""MoveLeft"",
                    ""type"": ""Button"",
                    ""id"": ""48cf8dbc-7eaa-4b63-b9c9-14f4e81c5639"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MoveRight"",
                    ""type"": ""Button"",
                    ""id"": ""25ca2f87-7271-47fc-92a0-13155759da5d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MoveForward"",
                    ""type"": ""Button"",
                    ""id"": ""ad0c8ff9-009e-4606-8367-39f5f254a4a6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Fire1"",
                    ""type"": ""Button"",
                    ""id"": ""357f90d2-9f20-4edf-9d37-a36fcb23c3aa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Fire2"",
                    ""type"": ""Button"",
                    ""id"": ""2435d984-10ba-43ff-a7ea-3b5379ee54b1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""cb4abc56-849b-4f12-b716-cf646a601e43"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""17f87cd1-2845-4c38-82d0-49ac9366809b"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""18651657-9c52-40b3-a03f-438cf0cb078a"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c3baa0e5-5767-4e1b-aa16-789c0e39be9a"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""86da457b-3d9a-41bf-b7a6-9aaad72e1356"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // gameplay
            m_gameplay = asset.FindActionMap("gameplay", throwIfNotFound: true);
            m_gameplay_MoveLeft = m_gameplay.FindAction("MoveLeft", throwIfNotFound: true);
            m_gameplay_MoveRight = m_gameplay.FindAction("MoveRight", throwIfNotFound: true);
            m_gameplay_MoveForward = m_gameplay.FindAction("MoveForward", throwIfNotFound: true);
            m_gameplay_Fire1 = m_gameplay.FindAction("Fire1", throwIfNotFound: true);
            m_gameplay_Fire2 = m_gameplay.FindAction("Fire2", throwIfNotFound: true);
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

        // gameplay
        private readonly InputActionMap m_gameplay;
        private List<IGameplayActions> m_GameplayActionsCallbackInterfaces = new List<IGameplayActions>();
        private readonly InputAction m_gameplay_MoveLeft;
        private readonly InputAction m_gameplay_MoveRight;
        private readonly InputAction m_gameplay_MoveForward;
        private readonly InputAction m_gameplay_Fire1;
        private readonly InputAction m_gameplay_Fire2;
        public struct GameplayActions
        {
            private @InputActions m_Wrapper;
            public GameplayActions(@InputActions wrapper) { m_Wrapper = wrapper; }
            public InputAction @MoveLeft => m_Wrapper.m_gameplay_MoveLeft;
            public InputAction @MoveRight => m_Wrapper.m_gameplay_MoveRight;
            public InputAction @MoveForward => m_Wrapper.m_gameplay_MoveForward;
            public InputAction @Fire1 => m_Wrapper.m_gameplay_Fire1;
            public InputAction @Fire2 => m_Wrapper.m_gameplay_Fire2;
            public InputActionMap Get() { return m_Wrapper.m_gameplay; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
            public void AddCallbacks(IGameplayActions instance)
            {
                if (instance == null || m_Wrapper.m_GameplayActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_GameplayActionsCallbackInterfaces.Add(instance);
                @MoveLeft.started += instance.OnMoveLeft;
                @MoveLeft.performed += instance.OnMoveLeft;
                @MoveLeft.canceled += instance.OnMoveLeft;
                @MoveRight.started += instance.OnMoveRight;
                @MoveRight.performed += instance.OnMoveRight;
                @MoveRight.canceled += instance.OnMoveRight;
                @MoveForward.started += instance.OnMoveForward;
                @MoveForward.performed += instance.OnMoveForward;
                @MoveForward.canceled += instance.OnMoveForward;
                @Fire1.started += instance.OnFire1;
                @Fire1.performed += instance.OnFire1;
                @Fire1.canceled += instance.OnFire1;
                @Fire2.started += instance.OnFire2;
                @Fire2.performed += instance.OnFire2;
                @Fire2.canceled += instance.OnFire2;
            }

            private void UnregisterCallbacks(IGameplayActions instance)
            {
                @MoveLeft.started -= instance.OnMoveLeft;
                @MoveLeft.performed -= instance.OnMoveLeft;
                @MoveLeft.canceled -= instance.OnMoveLeft;
                @MoveRight.started -= instance.OnMoveRight;
                @MoveRight.performed -= instance.OnMoveRight;
                @MoveRight.canceled -= instance.OnMoveRight;
                @MoveForward.started -= instance.OnMoveForward;
                @MoveForward.performed -= instance.OnMoveForward;
                @MoveForward.canceled -= instance.OnMoveForward;
                @Fire1.started -= instance.OnFire1;
                @Fire1.performed -= instance.OnFire1;
                @Fire1.canceled -= instance.OnFire1;
                @Fire2.started -= instance.OnFire2;
                @Fire2.performed -= instance.OnFire2;
                @Fire2.canceled -= instance.OnFire2;
            }

            public void RemoveCallbacks(IGameplayActions instance)
            {
                if (m_Wrapper.m_GameplayActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(IGameplayActions instance)
            {
                foreach (var item in m_Wrapper.m_GameplayActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_GameplayActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public GameplayActions @gameplay => new GameplayActions(this);
        public interface IGameplayActions
        {
            void OnMoveLeft(InputAction.CallbackContext context);
            void OnMoveRight(InputAction.CallbackContext context);
            void OnMoveForward(InputAction.CallbackContext context);
            void OnFire1(InputAction.CallbackContext context);
            void OnFire2(InputAction.CallbackContext context);
        }
    }
}