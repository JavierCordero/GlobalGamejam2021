using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorComponent : MonoBehaviour
{
    [HideInInspector]
    public List<PlayerInformation> _playersInside = new List<PlayerInformation>();

    public Animator _doorAnimator;
    public float _closeDoorTime;
    private bool _doorIsClosed = false;

    public GameObject _closeDoorHint;
    private GameObject _closeDoorHintInstantiated;
    private void Start()
    {
        if (_closeDoorHint)
        {
            _closeDoorHintInstantiated = Instantiate(_closeDoorHint, transform.position, Quaternion.identity);
            _closeDoorHintInstantiated.transform.parent = transform;
            _closeDoorHintInstantiated.SetActive(false);

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerInformation PI = other.GetComponent<PlayerInformation>();
        if (PI)
        {
            _playersInside.Add(other.GetComponent<PlayerInformation>());

            if (PI._currentPowerUp == PowerUps.CLOSE_DOOR)
            {
                _closeDoorHintInstantiated.SetActive(true);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<PlayerInformation>())
        {
            _playersInside.Remove(other.GetComponent<PlayerInformation>());

            bool keepHint = false;

            foreach (PlayerInformation PI in _playersInside)
            {
                if (PI._currentPowerUp == PowerUps.CLOSE_DOOR)
                    keepHint = true;
            }

            _closeDoorHintInstantiated.SetActive(keepHint);

        }

    }


public void CloseDoor()
{
    if (!_doorIsClosed)
    {
        _doorIsClosed = true;
        _doorAnimator.SetTrigger("CloseDoor");
        Invoke("OpenDoor", _closeDoorTime);
    }
}

public void OpenDoor()
{
    _doorAnimator.SetTrigger("OpenDoor");
}

}
