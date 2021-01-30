using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjectsManager : MonoBehaviour
{
    //Spawn Objetos grandes
    //SPawn objetos pequeños encima de los grandes (aunque alguno en el suelo puede salir)
    //Spawn discretizado por habitación

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

    //Tipos de habitaciones
    public GameObject[] BigBath;
    public GameObject[] BigKitchen;
    public GameObject[] BigBig_room;
    public GameObject[] BigChild_room;
    public GameObject[] BigGarden;
    public GameObject[] BigCorridor;
    public GameObject[] BigDyingroom; //jejejjejeej
    public GameObject[] BigLivingroom;

    //Tipos de habitaciones
    public GameObject[] SmallBath;
    public GameObject[] SmallKitchen;
    public GameObject[] SmallBig_room;
    public GameObject[] SmallChild_room;
    public GameObject[] SmallGarden;
    public GameObject[] SmallCorridor;
    public GameObject[] SmallDyingroom; //jejejjejeej
    public GameObject[] SmallLivingroom;

    // Start is called before the first frame update
    void Start()
    {
        GameObject [] bigObjectSpawns = GameObject.FindGameObjectsWithTag("BigObjectSpawn");

        foreach (GameObject g in bigObjectSpawns)
        {
            SpawnedObject so = g.GetComponent<SpawnedObject>();

            GameObject spawnedBigObject = null;
           

            switch (so._myRoomType)
            {
                case RoomType.BATH:
                    spawnedBigObject = BigBath[Random.Range(0, BigBath.Length)];
                    break;
                case RoomType.KITCHEN:
                    spawnedBigObject = BigKitchen[Random.Range(0, BigKitchen.Length)];
                    break;
                case RoomType.BIG_ROOM:
                    spawnedBigObject = BigBig_room[Random.Range(0, BigBig_room.Length)];
                    break;
                case RoomType.CHILD_ROOM:
                    spawnedBigObject = BigChild_room[Random.Range(0, BigChild_room.Length)];
                    break;
                case RoomType.GARDEN:
                    spawnedBigObject = BigGarden[Random.Range(0, BigGarden.Length)];
                    break;
                case RoomType.CORRIDOR:
                    spawnedBigObject = BigCorridor[Random.Range(0, BigCorridor.Length)];
                    break;
                case RoomType.DYINGROOM:
                    spawnedBigObject = BigDyingroom[Random.Range(0, BigDyingroom.Length)];
                    break;
                case RoomType.LIVINGROOM:
                    spawnedBigObject = BigLivingroom[Random.Range(0, BigLivingroom.Length)];
                    break;
            }

            GameObject spawnedSmallObject = null;

            if (spawnedBigObject)
            {
                GameObject go = Instantiate(spawnedBigObject, g.transform.position, Quaternion.Euler(-90,90, -90));

                foreach(Transform t in go.transform.GetChild(0).transform)
                {
                    switch (so._myRoomType)
                    {
                        case RoomType.BATH:
                            spawnedSmallObject = SmallBath[Random.Range(0, SmallBath.Length)];
                            break;
                        case RoomType.KITCHEN:
                            spawnedSmallObject = SmallKitchen[Random.Range(0, SmallKitchen.Length)];
                            break;
                        case RoomType.BIG_ROOM:
                            spawnedSmallObject = SmallBig_room[Random.Range(0, SmallBig_room.Length)];
                            break;
                        case RoomType.CHILD_ROOM:
                            spawnedSmallObject = SmallChild_room[Random.Range(0, SmallChild_room.Length)];
                            break;
                        case RoomType.GARDEN:
                            spawnedSmallObject = SmallGarden[Random.Range(0, SmallGarden.Length)];
                            break;
                        case RoomType.CORRIDOR:
                            spawnedSmallObject = SmallCorridor[Random.Range(0, SmallCorridor.Length)];
                            break;
                        case RoomType.DYINGROOM:
                            spawnedSmallObject = SmallDyingroom[Random.Range(0, SmallDyingroom.Length)];
                            break;
                        case RoomType.LIVINGROOM:
                            spawnedSmallObject = SmallLivingroom[Random.Range(0, SmallLivingroom.Length)];
                            break;
                    }

                    Instantiate(spawnedSmallObject, t.position, Quaternion.Euler(-90, 90, -90));
                }
            }
        }
    }
}
