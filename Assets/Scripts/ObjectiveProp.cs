using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveProp : MonoBehaviour
{

    private bool isCurrentObjective;

    public void Start()
    {
        //El GameMamager se crea en el awake así que esto debería ser seguro, pero....
        if (GameManager.instance != null)
        {
            //Si no es random, puedo asumir que se ha elegido el orden a mano desde el editor
            if (GameManager.instance.IsRandomMode()) { 
                GameManager.instance.AddNewObjectiveProp(this);
            }
        }
    }

    public void SetAsCurrentObjective()
    {
        isCurrentObjective = true;

        //Debug
        Debug.DrawLine(transform.position, Vector3.up * 10, Color.red);
    }

    public void OnCollisionEnter(Collision collision)
    {
        //Si he colisionado con un player...
        PlayerInformation info = collision.collider.GetComponent<PlayerInformation>();
        if (info != null)
        {
            if (isCurrentObjective)
            {
                GameManager.instance.OnObjectiveCollected(this, info);
                isCurrentObjective = false;
            }
        }
    }
}
