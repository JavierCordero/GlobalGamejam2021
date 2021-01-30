using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorTrigger : MonoBehaviour
{
    public CurrentPlayerFloor myFloor;
    private FloorsManager floorsManager_;
    private void Start()
    {
        floorsManager_ = FindObjectOfType<FloorsManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerMovement>())
        {
            if (myFloor != floorsManager_.getCurrentPlayerFloor())
                floorsManager_.changePlayerCurrentFloor(myFloor);
        }
    }
}
