using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class UISignBehaviour : MonoBehaviour
{
    public Camera cam;
    public Canvas canvas;
    public float sizeInUnits = 2;

    void Start(){
        cam = Camera.main;
        float ratio = sizeInUnits / canvas.GetComponent<RectTransform>().rect.width;
        transform.localScale = new Vector3(ratio,ratio,ratio);
    }
}
