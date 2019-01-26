using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sinMovementObject : MonoBehaviour
{
    public float amplitude;
    public float freq;
    float acumulatedTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float magnitude = amplitude*Mathf.Sin(freq * acumulatedTime);
        transform.position += new Vector3(magnitude, 0f,0f);
        Debug.Log(magnitude);
        acumulatedTime += Time.deltaTime;
    }
}
