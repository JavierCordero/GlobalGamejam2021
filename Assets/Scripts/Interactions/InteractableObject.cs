using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    [SerializeField]
    private float _objectWeight = 1;

    public GameObject _interactuableObjectHUD = null;
    private GameObject _myInteractuableObjectHUD = null;

    private void Start()
    {
        if (!GetComponent<Rigidbody>())
            this.gameObject.AddComponent<Rigidbody>();

        _myInteractuableObjectHUD = Instantiate(_interactuableObjectHUD, transform.position, Quaternion.identity);
        _myInteractuableObjectHUD.transform.parent = transform;
        _myInteractuableObjectHUD.SetActive(false);

        _interactuableObjectHUD.SetActive(false);
        gameObject.GetComponent<Rigidbody>().mass = _objectWeight;
    }

    public void ShowObjectInteraction()
    {
        if (_myInteractuableObjectHUD)
        {
            _myInteractuableObjectHUD.SetActive(true);
        }
    }

    public void HideObjectInteraction()
    {
        if (_myInteractuableObjectHUD)
        {
            _myInteractuableObjectHUD.SetActive(false);
        }
    }
}
