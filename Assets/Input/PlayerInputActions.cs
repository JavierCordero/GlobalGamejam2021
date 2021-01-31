// GENERATED AUTOMATICALLY FROM 'Assets/Input/PlayerInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""Player1Actions"",
            ""id"": ""a996ed18-03c2-4e71-a03b-fec79b906a39"",
            ""actions"": [
                {
                    ""name"": ""Pulse"",
                    ""type"": ""Button"",
                    ""id"": ""64810467-3d89-44eb-81f2-3f06bd268147"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PowerUp"",
                    ""type"": ""Button"",
                    ""id"": ""5f9e4b4f-43af-4a34-8782-81f44e0f7422"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""a760d9cf-7675-427b-8b17-e1e54a463eea"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""89bc0b2c-476b-4105-81fd-af156adf04a4"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pulse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5d6c1f1b-597f-4c97-8317-092ce34cd009"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pulse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1c14b656-e0ed-4948-9708-20f6d8c9215d"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PowerUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1733f886-c136-4e34-a9a8-7db2f9a35dc5"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PowerUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""64887182-ebfe-440c-883f-e9db3a82ba84"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3c92ce4d-10f6-4a3d-9abb-bac0bcd316ee"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e75b2076-5cbe-42f6-b9b9-1739475dc7c9"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player2Actions"",
            ""id"": ""8cb90f70-50c2-4857-93fd-5dcbbfcb2dcf"",
            ""actions"": [
                {
                    ""name"": ""Pulse"",
                    ""type"": ""Button"",
                    ""id"": ""168556df-a6c9-4cc2-b276-e6f4841c6815"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PowerUp"",
                    ""type"": ""Button"",
                    ""id"": ""2b623f8f-b922-463a-b3c6-7156b751e22a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""56f26336-bd1a-40c0-ab55-53df2a669950"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pulse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1445c2d0-c428-47dc-b460-68c22daf36c2"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pulse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""11b287d7-2cdc-4806-b1c2-73b5bc84d28a"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pulse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0831154a-74d4-4e9b-ae7f-2dbb8e6f9623"",
                    ""path"": ""<Keyboard>/u"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PowerUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4f1ecbde-b45c-4c8e-9c34-112f3a005439"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PowerUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PlayerMovement"",
            ""id"": ""63971834-6b45-424b-a827-59b93cc05c2e"",
            ""actions"": [
                {
                    ""name"": ""Player1Move"",
                    ""type"": ""Value"",
                    ""id"": ""89866045-f4a3-4b81-91a2-a469b86f1ccd"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Player2Move"",
                    ""type"": ""Value"",
                    ""id"": ""b77b70b3-3267-43ad-8641-0a68db50b930"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5c828a10-2b7e-4696-a9ee-6338b38c4cbb"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Player1Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""99c99537-0b3f-42d8-a23e-15dc1c103f8b"",
                    ""path"": ""Dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player2Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""4da4b699-b1e3-4bf5-8760-bae25de0e7f0"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Player2Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""ee02d107-bebe-45a4-8eef-64fccd2fba5d"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Player2Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""316e51c6-947c-41db-9ecf-948c8147634a"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Player2Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""04b9d090-1fa9-4be7-b5ea-fa826fb86d9c"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Player2Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b10a6ac8-c6fd-4fab-8d78-79e068c8afeb"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Player2Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""1a23621e-8325-4035-89fa-bdab74cc5133"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Player2Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""5b1edec3-3373-4cdc-a042-fe6c39f861c4"",
                    ""path"": ""Dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player1Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""f527702b-d3d4-4dbc-b01f-abdd01a24971"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Player1Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""f39be474-2038-42be-8491-59c6acdf2d4e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Player1Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""30059cc6-5236-4baa-8cdb-75763b107a4b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Player1Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""90834521-1722-4f4f-84cb-8339856251e9"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Player2Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player1Actions
        m_Player1Actions = asset.FindActionMap("Player1Actions", throwIfNotFound: true);
        m_Player1Actions_Pulse = m_Player1Actions.FindAction("Pulse", throwIfNotFound: true);
        m_Player1Actions_PowerUp = m_Player1Actions.FindAction("PowerUp", throwIfNotFound: true);
        m_Player1Actions_Pause = m_Player1Actions.FindAction("Pause", throwIfNotFound: true);
        // Player2Actions
        m_Player2Actions = asset.FindActionMap("Player2Actions", throwIfNotFound: true);
        m_Player2Actions_Pulse = m_Player2Actions.FindAction("Pulse", throwIfNotFound: true);
        m_Player2Actions_PowerUp = m_Player2Actions.FindAction("PowerUp", throwIfNotFound: true);
        // PlayerMovement
        m_PlayerMovement = asset.FindActionMap("PlayerMovement", throwIfNotFound: true);
        m_PlayerMovement_Player1Move = m_PlayerMovement.FindAction("Player1Move", throwIfNotFound: true);
        m_PlayerMovement_Player2Move = m_PlayerMovement.FindAction("Player2Move", throwIfNotFound: true);
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

    // Player1Actions
    private readonly InputActionMap m_Player1Actions;
    private IPlayer1ActionsActions m_Player1ActionsActionsCallbackInterface;
    private readonly InputAction m_Player1Actions_Pulse;
    private readonly InputAction m_Player1Actions_PowerUp;
    private readonly InputAction m_Player1Actions_Pause;
    public struct Player1ActionsActions
    {
        private @PlayerInputActions m_Wrapper;
        public Player1ActionsActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Pulse => m_Wrapper.m_Player1Actions_Pulse;
        public InputAction @PowerUp => m_Wrapper.m_Player1Actions_PowerUp;
        public InputAction @Pause => m_Wrapper.m_Player1Actions_Pause;
        public InputActionMap Get() { return m_Wrapper.m_Player1Actions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player1ActionsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayer1ActionsActions instance)
        {
            if (m_Wrapper.m_Player1ActionsActionsCallbackInterface != null)
            {
                @Pulse.started -= m_Wrapper.m_Player1ActionsActionsCallbackInterface.OnPulse;
                @Pulse.performed -= m_Wrapper.m_Player1ActionsActionsCallbackInterface.OnPulse;
                @Pulse.canceled -= m_Wrapper.m_Player1ActionsActionsCallbackInterface.OnPulse;
                @PowerUp.started -= m_Wrapper.m_Player1ActionsActionsCallbackInterface.OnPowerUp;
                @PowerUp.performed -= m_Wrapper.m_Player1ActionsActionsCallbackInterface.OnPowerUp;
                @PowerUp.canceled -= m_Wrapper.m_Player1ActionsActionsCallbackInterface.OnPowerUp;
                @Pause.started -= m_Wrapper.m_Player1ActionsActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_Player1ActionsActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_Player1ActionsActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_Player1ActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Pulse.started += instance.OnPulse;
                @Pulse.performed += instance.OnPulse;
                @Pulse.canceled += instance.OnPulse;
                @PowerUp.started += instance.OnPowerUp;
                @PowerUp.performed += instance.OnPowerUp;
                @PowerUp.canceled += instance.OnPowerUp;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }
        }
    }
    public Player1ActionsActions @Player1Actions => new Player1ActionsActions(this);

    // Player2Actions
    private readonly InputActionMap m_Player2Actions;
    private IPlayer2ActionsActions m_Player2ActionsActionsCallbackInterface;
    private readonly InputAction m_Player2Actions_Pulse;
    private readonly InputAction m_Player2Actions_PowerUp;
    public struct Player2ActionsActions
    {
        private @PlayerInputActions m_Wrapper;
        public Player2ActionsActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Pulse => m_Wrapper.m_Player2Actions_Pulse;
        public InputAction @PowerUp => m_Wrapper.m_Player2Actions_PowerUp;
        public InputActionMap Get() { return m_Wrapper.m_Player2Actions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player2ActionsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayer2ActionsActions instance)
        {
            if (m_Wrapper.m_Player2ActionsActionsCallbackInterface != null)
            {
                @Pulse.started -= m_Wrapper.m_Player2ActionsActionsCallbackInterface.OnPulse;
                @Pulse.performed -= m_Wrapper.m_Player2ActionsActionsCallbackInterface.OnPulse;
                @Pulse.canceled -= m_Wrapper.m_Player2ActionsActionsCallbackInterface.OnPulse;
                @PowerUp.started -= m_Wrapper.m_Player2ActionsActionsCallbackInterface.OnPowerUp;
                @PowerUp.performed -= m_Wrapper.m_Player2ActionsActionsCallbackInterface.OnPowerUp;
                @PowerUp.canceled -= m_Wrapper.m_Player2ActionsActionsCallbackInterface.OnPowerUp;
            }
            m_Wrapper.m_Player2ActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Pulse.started += instance.OnPulse;
                @Pulse.performed += instance.OnPulse;
                @Pulse.canceled += instance.OnPulse;
                @PowerUp.started += instance.OnPowerUp;
                @PowerUp.performed += instance.OnPowerUp;
                @PowerUp.canceled += instance.OnPowerUp;
            }
        }
    }
    public Player2ActionsActions @Player2Actions => new Player2ActionsActions(this);

    // PlayerMovement
    private readonly InputActionMap m_PlayerMovement;
    private IPlayerMovementActions m_PlayerMovementActionsCallbackInterface;
    private readonly InputAction m_PlayerMovement_Player1Move;
    private readonly InputAction m_PlayerMovement_Player2Move;
    public struct PlayerMovementActions
    {
        private @PlayerInputActions m_Wrapper;
        public PlayerMovementActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Player1Move => m_Wrapper.m_PlayerMovement_Player1Move;
        public InputAction @Player2Move => m_Wrapper.m_PlayerMovement_Player2Move;
        public InputActionMap Get() { return m_Wrapper.m_PlayerMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMovementActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerMovementActions instance)
        {
            if (m_Wrapper.m_PlayerMovementActionsCallbackInterface != null)
            {
                @Player1Move.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnPlayer1Move;
                @Player1Move.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnPlayer1Move;
                @Player1Move.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnPlayer1Move;
                @Player2Move.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnPlayer2Move;
                @Player2Move.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnPlayer2Move;
                @Player2Move.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnPlayer2Move;
            }
            m_Wrapper.m_PlayerMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Player1Move.started += instance.OnPlayer1Move;
                @Player1Move.performed += instance.OnPlayer1Move;
                @Player1Move.canceled += instance.OnPlayer1Move;
                @Player2Move.started += instance.OnPlayer2Move;
                @Player2Move.performed += instance.OnPlayer2Move;
                @Player2Move.canceled += instance.OnPlayer2Move;
            }
        }
    }
    public PlayerMovementActions @PlayerMovement => new PlayerMovementActions(this);
    public interface IPlayer1ActionsActions
    {
        void OnPulse(InputAction.CallbackContext context);
        void OnPowerUp(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
    public interface IPlayer2ActionsActions
    {
        void OnPulse(InputAction.CallbackContext context);
        void OnPowerUp(InputAction.CallbackContext context);
    }
    public interface IPlayerMovementActions
    {
        void OnPlayer1Move(InputAction.CallbackContext context);
        void OnPlayer2Move(InputAction.CallbackContext context);
    }
}
