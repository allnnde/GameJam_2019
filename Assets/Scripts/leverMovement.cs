using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leverMovement : MonoBehaviour
{
    public GameObject leverPivot;
    public float speed = 1;
    public bool isActive = false;

    public Vector3 targetAngle = new Vector3(-90f, 0f, 0f);
    public GameObject[] objectsToActive;
    private Vector3 currentAngle;

    // Start is called before the first frame update
    void Start()
    {
        currentAngle = leverPivot.transform.eulerAngles;

    }

    // Update is called once per frame
    void Update()
    {
        if(isActive){
            leverPivot.transform.localEulerAngles = new Vector3(-90f, 180, 90);
        }
        isActive = false;
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player" && Input.GetKeyDown(KeyCode.E)){
            foreach(GameObject obj in objectsToActive){
                if(!obj.GetComponent<DoorBehaviour>().isActive)
                    obj.GetComponent<DoorBehaviour>().ActivateDoor();
            }
            isActive = true;
        }
    }
}
