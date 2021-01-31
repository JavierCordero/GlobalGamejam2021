using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialManager : MonoBehaviour
{
    [SerializeField]
    Text [] texts;
    int index = 0;

    public void ChangeText()
    {
        texts[index].gameObject.SetActive(false);
        index++;
        texts[index].gameObject.SetActive(true);
    }
    public void DeactivateText()
    {
        texts[index].gameObject.SetActive(false);
    }
}
