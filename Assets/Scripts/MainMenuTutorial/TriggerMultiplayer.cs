using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerMultiplayer : MonoBehaviour
{
   TutorialManager triggerText;
   public Text[] t;
    public bool isSinglePlayer;
    private void Start()
    {
        triggerText = FindObjectOfType <TutorialManager> ();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerInformation>())
        {
            triggerText.DeactivateText();
            t[0].gameObject.SetActive(isSinglePlayer);
            t[1].gameObject.SetActive(!isSinglePlayer);

        }
    }
}
