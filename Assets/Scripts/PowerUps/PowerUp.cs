using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{

    public PowerUps _myPowerUpType;
    public Sprite powerUpSprite;

    private void OnTriggerEnter(Collider other)
    {
        PlayerInformation PI = other.GetComponent<PlayerInformation>();
        if (PI && PI._currentPowerUp == PowerUps.NONE)
        {
            other.GetComponent<PlayerInformation>()._currentPowerUp = _myPowerUpType;
            other.GetComponent<PlayerInformation>().powerUpRenderer.sprite = powerUpSprite;

            Destroy(gameObject);
        }
    }
}
