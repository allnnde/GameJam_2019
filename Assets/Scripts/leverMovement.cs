using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leverMovement : MonoBehaviour
{
    public GameObject leverPivot;
    public float speed = 1;
    public bool isActive = false;

    public Vector3 targetAngle = new Vector3(90f, 0f, 0f);
 
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
            currentAngle = new Vector3(
             Mathf.LerpAngle(currentAngle.x, targetAngle.x, Time.deltaTime * speed),
             Mathf.LerpAngle(currentAngle.y, targetAngle.y, Time.deltaTime * speed),
             Mathf.LerpAngle(currentAngle.z, targetAngle.z, Time.deltaTime * speed));
            leverPivot.transform.eulerAngles = currentAngle;
        }
    }
}
