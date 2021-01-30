using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{

    PlayerInputActions _playerInputActions;

    [HideInInspector]
    public bool _player1Pulse = false;

    [HideInInspector]
    public bool _player2Pulse = false;

    [HideInInspector]
    public Vector2 _movementInputP1 = new Vector2();

    [HideInInspector]
    public Vector2 _movementInputP2 = new Vector2();

    [HideInInspector]
    public bool _powerUpEnabled;

    private int P1, P2;

    private void Awake()
    {
        if (_playerInputActions == null)
            _playerInputActions = new PlayerInputActions();
    }


    private void OnEnable()
    {
        _playerInputActions.Enable();

        if (Gamepad.all.Count > 0)
        {
            if (Gamepad.all[0] != null)
                P1 = Gamepad.all[0].deviceId;

            if (Gamepad.all.Count > 1 && Gamepad.all[1] != null)
                P2 = Gamepad.all[1].deviceId;
        }
        _playerInputActions.Player1Actions.Pulse.performed += EnablePulse1;
        _playerInputActions.Player1Actions.Pulse.canceled += DisablePulse1;

        _playerInputActions.Player2Actions.Pulse.performed += EnablePulse2;
        _playerInputActions.Player2Actions.Pulse.canceled += DisablePulse2;

        _playerInputActions.PlayerMovement.Player1Move.performed += Player1_Move_Performed;
        _playerInputActions.PlayerMovement.Player1Move.canceled += Player1_Move_Canceled;

        _playerInputActions.PlayerMovement.Player2Move.performed += Player2_Move_Performed;
        _playerInputActions.PlayerMovement.Player2Move.canceled += Player2_Move_Canceled;

        _playerInputActions.Player1Actions.PowerUp.performed += Enable_PowerUp_Player1;
        _playerInputActions.Player2Actions.PowerUp.performed += Enable_PowerUp_Player2;

        _playerInputActions.Player1Actions.Pause.performed += TogglePause;
        //_playerInputActions.Player2Actions.Pause.performed += TogglePause;

    }


    private void OnDisable()
    {
        _playerInputActions.Disable();
        _playerInputActions.Player1Actions.Pulse.performed -= EnablePulse1;
        _playerInputActions.Player1Actions.Pulse.canceled -= DisablePulse1;

        _playerInputActions.Player2Actions.Pulse.performed -= EnablePulse2;
        _playerInputActions.Player2Actions.Pulse.canceled -= DisablePulse2;

        _playerInputActions.PlayerMovement.Player1Move.performed -= Player1_Move_Performed;
        _playerInputActions.PlayerMovement.Player1Move.canceled -= Player1_Move_Canceled;

        _playerInputActions.PlayerMovement.Player2Move.performed -= Player2_Move_Performed;
        _playerInputActions.PlayerMovement.Player2Move.canceled -= Player2_Move_Canceled;

        _playerInputActions.Player1Actions.PowerUp.performed -= Player1_Move_Performed;
        _playerInputActions.Player2Actions.PowerUp.performed -= Player2_Move_Performed;

        _playerInputActions.Player1Actions.Pause.performed -= TogglePause;
        //_playerInputActions.Player2Actions.Pause.performed -= TogglePause;
    }

    private void EnablePulse1(InputAction.CallbackContext context)
    {
        System.Type t = context.control.device.GetType();

        if (context.control.device.deviceId == P1 || t.FullName == "UnityEngine.InputSystem.Keyboard")
            _player1Pulse = true;
    }

    private void DisablePulse1(InputAction.CallbackContext context)
    {
        System.Type t = context.control.device.GetType();

        if (context.control.device.deviceId == P1 || t.FullName == "UnityEngine.InputSystem.Keyboard")
            _player1Pulse = false;
    }

    private void EnablePulse2(InputAction.CallbackContext context)
    {
        System.Type t = context.control.device.GetType();

        if (context.control.device.deviceId == P2 || t.FullName == "UnityEngine.InputSystem.Keyboard")
            _player2Pulse = true;
    }

    private void DisablePulse2(InputAction.CallbackContext context)
    {
        System.Type t = context.control.device.GetType();

        if (context.control.device.deviceId == P2 || t.FullName == "UnityEngine.InputSystem.Keyboard")
            _player2Pulse = false;
    }

    private void Player1_Move_Performed(InputAction.CallbackContext context)
    {
        System.Type t = context.control.device.GetType();

        if (context.control.device.deviceId == P1 || t.FullName == "UnityEngine.InputSystem.Keyboard")
            _movementInputP1 = context.ReadValue<Vector2>();
    }

    private void Player1_Move_Canceled(InputAction.CallbackContext context)
    {
        System.Type t = context.control.device.GetType();

        if (context.control.device.deviceId == P1 || t.FullName == "UnityEngine.InputSystem.Keyboard")
            _movementInputP1 = Vector2.zero;
    }

    private void Enable_PowerUp_Player1(InputAction.CallbackContext context)
    {
        System.Type t = context.control.device.GetType();
        if (context.control.device.deviceId == P1 || t.FullName == "UnityEngine.InputSystem.Keyboard")
        {
            PlayerInformation[] PI = FindObjectsOfType<PlayerInformation>();
            if (PI[0]._myPlayerNumber == myPlayerNumber.Player1)
            {
                PI[0].StartPowerUp();
            }

            else PI[1].StartPowerUp();
        }
    }

    private void Enable_PowerUp_Player2(InputAction.CallbackContext context)
    {
        System.Type t = context.control.device.GetType();
        if (context.control.device.deviceId == P2 || t.FullName == "UnityEngine.InputSystem.Keyboard")
        {
            PlayerInformation[] PI = FindObjectsOfType<PlayerInformation>();
            if (PI[0]._myPlayerNumber == myPlayerNumber.Player2)
            {
                PI[0].StartPowerUp();
            }

            else PI[1].StartPowerUp();
        }
    }

    private void Player2_Move_Performed(InputAction.CallbackContext context)
    {
        System.Type t = context.control.device.GetType();

        if (context.control.device.deviceId == P2 || t.FullName == "UnityEngine.InputSystem.Keyboard")
            _movementInputP2 = context.ReadValue<Vector2>();
    }

    private void Player2_Move_Canceled(InputAction.CallbackContext context)
    {
        System.Type t = context.control.device.GetType();

        if (context.control.device.deviceId == P2 || t.FullName == "UnityEngine.InputSystem.Keyboard")
            _movementInputP2 = Vector2.zero;
    }

    private void TogglePause(InputAction.CallbackContext context)
    {
        GameManager.instance.OnTogglePause();
    }
}
