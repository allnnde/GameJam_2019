using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject door;
    //public GameObject opositeDoor;
    public float speed;
    public Transform pointA;
    public Transform pointB;

    public bool isActive = true;
    bool shouldGoToPointB = false;

    Vector3 target;
    void Start()
    {
        if(shouldGoToPointB) target = pointB.position;
        else target = pointA.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(isActive){
            door.transform.position = Vector3.Lerp(door.transform.position, target, Time.deltaTime * speed);
            if(Vector3.Distance(door.transform.position, target) < 0.1f){
                isActive = false;
            }
        }
    }

    public void ActivateDoor(){
        Debug.Log(this.gameObject.name);
        shouldGoToPointB = !shouldGoToPointB;
        if(shouldGoToPointB) target = pointB.position;
        else target = pointA.position;
        isActive = true;
    }
}
