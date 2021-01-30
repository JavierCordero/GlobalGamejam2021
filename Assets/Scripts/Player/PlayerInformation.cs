using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum myPlayerNumber { Player1 = 0, Player2 = 1 }

public enum PowerUps { CLOSE_DOOR, TURN_LIGHTS_OFF, ICE_ATTACK, NONE }


public class PlayerInformation : MonoBehaviour
{
    public myPlayerNumber _myPlayerNumber;
    public GameObject otherPlayer;
    public PowerUps _currentPowerUp = PowerUps.NONE;

    public SpriteRenderer powerUpRenderer;

    public float _waitLightPowerUp = 5;

    [Header("Ice Settings")]
    public Sprite icedSprite;
    public float _IceAttackDuration = 0.75f;

    private DoorComponent[] doors;
    private LightModifier lightModifier;

    private void Start()
    {
        _currentPowerUp = PowerUps.NONE;
        doors = FindObjectsOfType<DoorComponent>();
        lightModifier = FindObjectOfType<LightModifier>();
    }

    public void StartPowerUp()
    {
        switch (_currentPowerUp)
        {
            case PowerUps.CLOSE_DOOR:
                closeDoor();
                break;
            case PowerUps.TURN_LIGHTS_OFF:
                if (lightModifier)
                    StartCoroutine(ActivateLightPowerUp());
                break;
            case PowerUps.ICE_ATTACK:
                if (otherPlayer)
                    otherPlayer.GetComponent<PlayerInformation>().OnIceAttacked();
                break;
        }

        _currentPowerUp = PowerUps.NONE;
        if (powerUpRenderer.sprite != icedSprite)
        {
            powerUpRenderer.sprite = null;
        }

    }

    public void OnIceAttacked()
    {
        StartCoroutine(PlayerFreeze());

    }

    private void closeDoor()
    {
        foreach (DoorComponent d in doors)
        {
            if (d._playersInside.Contains(this))
                d.CloseDoor();
        }
    }

    IEnumerator ActivateLightPowerUp()
    {
        lightModifier.TurnOffLights(_myPlayerNumber == myPlayerNumber.Player1);
        yield return new WaitForSeconds(_waitLightPowerUp);
        lightModifier.TurnOnLights(_myPlayerNumber == myPlayerNumber.Player1);
    }

    //Desactivo el movimiento, espero y se lo vuelvo a enchufar
    IEnumerator PlayerFreeze()
    {
        GetComponent<PlayerMovement>().enabled = false;
        PowerUps oldPowerUp = _currentPowerUp;                  //No queremos que lo active?
        _currentPowerUp = PowerUps.NONE;
        Sprite oldSprite = powerUpRenderer.sprite;
        powerUpRenderer.sprite = icedSprite;

        yield return new WaitForSeconds(_IceAttackDuration);

        GetComponent<PlayerMovement>().enabled = true;
        _currentPowerUp = oldPowerUp;                           //Ahora ya si :)
        powerUpRenderer.sprite = oldSprite;

    }
}
