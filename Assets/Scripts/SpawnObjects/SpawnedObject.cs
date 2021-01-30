using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
     * Baño
     * Cocina
     * Adulto room
     * Niño room
     * Jardin
     * Pasillo
     * Comedor
     * Sala de estar
     */

public enum RoomType { BATH, KITCHEN, BIG_ROOM, CHILD_ROOM, GARDEN, CORRIDOR, DYINGROOM, LIVINGROOM}

public class SpawnedObject : MonoBehaviour
{

    public RoomType _myRoomType;

}
