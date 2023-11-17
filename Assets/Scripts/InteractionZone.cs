using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionZone : MonoBehaviour
{
    DPSController _controller;

    void Awake()
    {
        _controller = GetComponentInParent<DPSController>();
    }

    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Recogible")
        {
            _controller.objectToGrab = collider.gameObject;
        }
    }

    void OnTriggerExit(Collider collider)
    {
        if(collider.gameObject.tag == "Recogible")
        {
            _controller.objectToGrab = null;
        }
    }
}
