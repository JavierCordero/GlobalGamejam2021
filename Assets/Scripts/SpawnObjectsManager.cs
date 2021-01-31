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

        List<GameObject> SmallBathL = new List<GameObject>(SmallBath);
        List<GameObject> SmallKitchenL = new List<GameObject>(SmallKitchen);
        List<GameObject> SmallBig_roomL = new List<GameObject>(SmallBig_room);
        List<GameObject> SmallChild_roomL = new List<GameObject>(SmallChild_room);
        List<GameObject> SmallGardenL = new List<GameObject>(SmallGarden);
        List<GameObject> SmallCorridorL = new List<GameObject>(SmallCorridor);
        List<GameObject> SmallDyingroomL = new List<GameObject>(SmallDyingroom);
        List<GameObject> SmallLivingroomL = new List<GameObject>(SmallLivingroom);

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

                foreach (Transform t in go.transform.GetChild(0).transform)
                {
                    spawnedSmallObject = null;

                    switch (so._myRoomType)
                    {
                       
                        case RoomType.BATH:
                            if (SmallBathL.Count > 0)
                            {
                                int rnd = Random.Range(0, SmallBathL.Count);
                                spawnedSmallObject = SmallBathL[rnd];
                                SmallBathL.RemoveAt(rnd);
                            }
                            break;
                        case RoomType.KITCHEN:
                            if (SmallKitchenL.Count > 0)
                            {
                                int rnd1 = Random.Range(0, SmallKitchenL.Count);
                                spawnedSmallObject = SmallKitchenL[rnd1];
                                SmallKitchenL.RemoveAt(rnd1);
                            }
                            break;
                        case RoomType.BIG_ROOM:
                            if (SmallBig_roomL.Count > 0)
                            {
                                int rnd2 = Random.Range(0, SmallBig_roomL.Count);
                                spawnedSmallObject = SmallBig_roomL[rnd2];
                                SmallBig_roomL.RemoveAt(rnd2);
                            }
                            break;
                        case RoomType.CHILD_ROOM:
                            if (SmallChild_roomL.Count > 0)
                            {
                                int rnd3 = Random.Range(0, SmallChild_roomL.Count);
                                spawnedSmallObject = SmallChild_roomL[rnd3];
                                SmallChild_roomL.RemoveAt(rnd3);
                            }
                            break;
                        case RoomType.GARDEN:
                            if (SmallGardenL.Count > 0)
                            {
                                int rnd4 = Random.Range(0, SmallGardenL.Count);
                                spawnedSmallObject = SmallGardenL[rnd4];
                                SmallGardenL.RemoveAt(rnd4);
                            }
                            break;
                        case RoomType.CORRIDOR:
                            if (SmallCorridorL.Count > 0)
                            {
                                int rnd5 = Random.Range(0, SmallCorridorL.Count);
                                spawnedSmallObject = SmallCorridorL[rnd5];
                                SmallCorridorL.RemoveAt(rnd5);
                            }
                            break;
                        case RoomType.DYINGROOM:
                            if (SmallDyingroomL.Count > 0)
                            {
                                int rnd6 = Random.Range(0, SmallDyingroomL.Count);
                                spawnedSmallObject = SmallDyingroomL[rnd6];
                                SmallDyingroomL.RemoveAt(rnd6);
                            }
                            break;
                        case RoomType.LIVINGROOM:
                            if (SmallLivingroomL.Count > 0)
                            {
                                int rnd7 = Random.Range(0, SmallLivingroomL.Count);
                                spawnedSmallObject = SmallLivingroomL[rnd7];
                                SmallLivingroomL.RemoveAt(rnd7);
                            }
                            break;
                    }

                    if(spawnedSmallObject)
                        Instantiate(spawnedSmallObject, t.position, Quaternion.Euler(-90, 90, -90));


                }
            }
        }
    }
}
