using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// © 2017 TheFlyingKeyboard and released under MIT License
// theflyingkeyboard.net
//Deactivates given GameObject on collision
public class DeactivateOnCollision3D : MonoBehaviour
{
    [SerializeField] private GameObject objectToDeactivate;
    [SerializeField] private string objectTagName;
    [SerializeField] private string objectName;
    [SerializeField] private bool deactivateThisObject = false;
    private void Start()
    {
        if (deactivateThisObject)
        {
            objectToDeactivate = gameObject;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(objectTagName) || collision.gameObject.name == objectName)
        {
            objectToDeactivate.SetActive(false);
        }
    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag(objectTagName) || collider.gameObject.name == objectName)
        {
            objectToDeactivate.SetActive(false);
        }
    }
}