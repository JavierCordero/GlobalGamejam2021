using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum myPlayerNumber { Player1 = 0, Player2 = 1 }

public enum PowerUps { CLOSE_DOOR, TURN_LIGHTS_OFF, NONE}


public class PlayerInformation : MonoBehaviour
{
    public myPlayerNumber _myPlayerNumber;
    public PowerUps _currentPowerUp = PowerUps.NONE;

    private DoorComponent[] doors;

    private void Start()
    {
        _currentPowerUp = PowerUps.NONE;
        doors = FindObjectsOfType<DoorComponent>();
    }

    public void StartPowerUp()
    {
        switch (_currentPowerUp)
        {
            case PowerUps.CLOSE_DOOR:
                closeDoor();
                break;
            case PowerUps.TURN_LIGHTS_OFF:
                break;
        }

        _currentPowerUp = PowerUps.NONE;

    }

    private void closeDoor()
    {
        foreach(DoorComponent d in doors)
        {
            if (d._playersInside.Contains(this))
                d.CloseDoor();
        }
    }


}
