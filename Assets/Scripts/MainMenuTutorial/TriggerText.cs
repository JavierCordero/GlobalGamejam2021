using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerText : MonoBehaviour
{
    private bool used = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerInformation>()&&!used){
            used = true;

            transform.parent.GetComponent<TutorialManager>().ChangeText();
            //gameObject.SetActive(false);
            Destroy(this);
        }
    } }
