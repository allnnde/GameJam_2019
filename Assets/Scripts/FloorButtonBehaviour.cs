using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorButtonBehaviour : MonoBehaviour
{
    public GameObject targetObject;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player"){
            targetObject.GetComponent<DoorBehaviour>().ActivateDoor();
        }
    }

        private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player"){
            targetObject.GetComponent<DoorBehaviour>().ActivateDoor();
        }
    }
}
