using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{

    public PowerUps _myPowerUpType;

    private void OnTriggerEnter(Collider other)
    {
        PlayerInformation PI = other.GetComponent<PlayerInformation>();
        if (PI && PI._currentPowerUp == PowerUps.NONE)
        {
            other.GetComponent<PlayerInformation>()._currentPowerUp = _myPowerUpType;

            Destroy(gameObject);
        }
    }
}
