using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

[RequireComponent(typeof(ThirdPersonCharacter))]
public class PlayerMovement : MonoBehaviour
{
    private ThirdPersonCharacter m_Character;   // A reference to the ThirdPersonCharacter on the object
    public Transform m_Cam;                     // A reference to the main camera in the scenes transform
    private Vector3 m_CamForward;               // The current forward direction of the camera
    private Vector3 m_Move;

    private PlayerInput _playerInput;

    private PlayerInformation _playerInformation;

    private float h = 0, v = 0;

    private void Start()
    {
        // get the transform of the main camera
        if (Camera.main == null)
        {
            Debug.LogWarning(
                "Warning: no main camera found. Third person character needs a Camera tagged \"MainCamera\", for camera-relative controls.", gameObject);
            // we use self-relative controls in this case, which probably isn't what the user wants, but hey, we warned them!
        }

        // get the third person character ( this should never be null due to require component )
        m_Character = GetComponent<ThirdPersonCharacter>();

        _playerInput = FindObjectOfType<PlayerInput>();

        _playerInformation = GetComponent<PlayerInformation>();
    }

    // Fixed update is called in sync with physics
    private void FixedUpdate()
    {

        h = 0;
        v = 0;

        // read inputs
        if (_playerInformation._myPlayerNumber == myPlayerNumber.Player1)
        {
            h = _playerInput._movementInputP1.x;
            v = _playerInput._movementInputP1.y;
        }

        else
        {
            h = _playerInput._movementInputP2.x;
            v = _playerInput._movementInputP2.y;
        }

        // calculate move direction to pass to character
        if (m_Cam != null)
        {
            // calculate camera relative direction to move:
            m_CamForward = Vector3.Scale(m_Cam.forward, new Vector3(1, 0, 1)).normalized;
            m_Move = v * m_CamForward + h * m_Cam.right;
        }
        else
        {
            // we use world-relative directions in the case of no main camera
            m_Move = v * Vector3.forward + h * Vector3.right;
        }

        // pass all parameters to the character control script
        m_Character.Move(m_Move, false, false);

    }
}

