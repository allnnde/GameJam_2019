using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISignBehaviour : MonoBehaviour
{
    public Camera cam;
    
    void Start(){
        cam = Camera.main;
    }
    void Update () {
        //transform.rotation = Quaternion.LookRotation(cam.transform.forward);
    }
}
