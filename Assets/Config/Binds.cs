//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.0
//     from Assets/Config/Binds.inputactions
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

public partial class @Binds: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Binds()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Binds"",
    ""maps"": [
        {
            ""name"": ""GameSpaceInput"",
            ""id"": ""e777e23c-42bc-4277-9904-57758de28711"",
            ""actions"": [
                {
                    ""name"": ""CardinalMovement"",
                    ""type"": ""Value"",
                    ""id"": ""b7a3cfdb-7e98-4118-9b1f-493fde23fe4b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""1861cf77-0e86-4bca-8ff9-8c6a7b2cca35"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Pointer"",
                    ""type"": ""Value"",
                    ""id"": ""3a9fa23f-ba3a-4066-b93c-3f6179c3fb99"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""162f2744-e671-4b07-bdca-b62b9d1885ec"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Alternative Fire"",
                    ""type"": ""Button"",
                    ""id"": ""ea492a5f-4c14-43a9-a6b9-e8c2b21d1d13"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""dfff2179-5a40-45cf-85d3-0ef53d9b3a7c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""e21ff37a-716e-4426-9923-5d7a04176f07"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CardinalMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""52da02c3-886a-44ea-a027-48037bcd9bf1"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CardinalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""75b5ceb7-3923-4029-b9d0-d52cc1ff2216"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CardinalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5ff097bd-7446-4957-84ce-3a97eb133318"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CardinalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""32c56cca-138c-4137-9aa6-89abc088895c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CardinalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""fd3b7ab8-4384-4652-810f-1f89151e8367"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pointer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""03f12ce9-d054-4232-8e62-2ec211f54bca"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2bd82178-96ef-493a-a9db-387ecc791c6f"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Alternative Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0f1551cb-fb88-4a8f-b67b-deb95f069db4"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""505957cf-ab27-4953-b47b-37a4162ea45d"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // GameSpaceInput
        m_GameSpaceInput = asset.FindActionMap("GameSpaceInput", throwIfNotFound: true);
        m_GameSpaceInput_CardinalMovement = m_GameSpaceInput.FindAction("CardinalMovement", throwIfNotFound: true);
        m_GameSpaceInput_Jump = m_GameSpaceInput.FindAction("Jump", throwIfNotFound: true);
        m_GameSpaceInput_Pointer = m_GameSpaceInput.FindAction("Pointer", throwIfNotFound: true);
        m_GameSpaceInput_Fire = m_GameSpaceInput.FindAction("Fire", throwIfNotFound: true);
        m_GameSpaceInput_AlternativeFire = m_GameSpaceInput.FindAction("Alternative Fire", throwIfNotFound: true);
        m_GameSpaceInput_Crouch = m_GameSpaceInput.FindAction("Crouch", throwIfNotFound: true);
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

    // GameSpaceInput
    private readonly InputActionMap m_GameSpaceInput;
    private List<IGameSpaceInputActions> m_GameSpaceInputActionsCallbackInterfaces = new List<IGameSpaceInputActions>();
    private readonly InputAction m_GameSpaceInput_CardinalMovement;
    private readonly InputAction m_GameSpaceInput_Jump;
    private readonly InputAction m_GameSpaceInput_Pointer;
    private readonly InputAction m_GameSpaceInput_Fire;
    private readonly InputAction m_GameSpaceInput_AlternativeFire;
    private readonly InputAction m_GameSpaceInput_Crouch;
    public struct GameSpaceInputActions
    {
        private @Binds m_Wrapper;
        public GameSpaceInputActions(@Binds wrapper) { m_Wrapper = wrapper; }
        public InputAction @CardinalMovement => m_Wrapper.m_GameSpaceInput_CardinalMovement;
        public InputAction @Jump => m_Wrapper.m_GameSpaceInput_Jump;
        public InputAction @Pointer => m_Wrapper.m_GameSpaceInput_Pointer;
        public InputAction @Fire => m_Wrapper.m_GameSpaceInput_Fire;
        public InputAction @AlternativeFire => m_Wrapper.m_GameSpaceInput_AlternativeFire;
        public InputAction @Crouch => m_Wrapper.m_GameSpaceInput_Crouch;
        public InputActionMap Get() { return m_Wrapper.m_GameSpaceInput; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameSpaceInputActions set) { return set.Get(); }
        public void AddCallbacks(IGameSpaceInputActions instance)
        {
            if (instance == null || m_Wrapper.m_GameSpaceInputActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GameSpaceInputActionsCallbackInterfaces.Add(instance);
            @CardinalMovement.started += instance.OnCardinalMovement;
            @CardinalMovement.performed += instance.OnCardinalMovement;
            @CardinalMovement.canceled += instance.OnCardinalMovement;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @Pointer.started += instance.OnPointer;
            @Pointer.performed += instance.OnPointer;
            @Pointer.canceled += instance.OnPointer;
            @Fire.started += instance.OnFire;
            @Fire.performed += instance.OnFire;
            @Fire.canceled += instance.OnFire;
            @AlternativeFire.started += instance.OnAlternativeFire;
            @AlternativeFire.performed += instance.OnAlternativeFire;
            @AlternativeFire.canceled += instance.OnAlternativeFire;
            @Crouch.started += instance.OnCrouch;
            @Crouch.performed += instance.OnCrouch;
            @Crouch.canceled += instance.OnCrouch;
        }

        private void UnregisterCallbacks(IGameSpaceInputActions instance)
        {
            @CardinalMovement.started -= instance.OnCardinalMovement;
            @CardinalMovement.performed -= instance.OnCardinalMovement;
            @CardinalMovement.canceled -= instance.OnCardinalMovement;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @Pointer.started -= instance.OnPointer;
            @Pointer.performed -= instance.OnPointer;
            @Pointer.canceled -= instance.OnPointer;
            @Fire.started -= instance.OnFire;
            @Fire.performed -= instance.OnFire;
            @Fire.canceled -= instance.OnFire;
            @AlternativeFire.started -= instance.OnAlternativeFire;
            @AlternativeFire.performed -= instance.OnAlternativeFire;
            @AlternativeFire.canceled -= instance.OnAlternativeFire;
            @Crouch.started -= instance.OnCrouch;
            @Crouch.performed -= instance.OnCrouch;
            @Crouch.canceled -= instance.OnCrouch;
        }

        public void RemoveCallbacks(IGameSpaceInputActions instance)
        {
            if (m_Wrapper.m_GameSpaceInputActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IGameSpaceInputActions instance)
        {
            foreach (var item in m_Wrapper.m_GameSpaceInputActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GameSpaceInputActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public GameSpaceInputActions @GameSpaceInput => new GameSpaceInputActions(this);
    public interface IGameSpaceInputActions
    {
        void OnCardinalMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnPointer(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnAlternativeFire(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
    }
}
