using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject Target;
    public float AnguloX;
    public float DistanciaY;


    // Use this for initialization
    void Start()
    {
        transform.rotation = Quaternion.Euler(AnguloX,0,0);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Target.transform.position + new Vector3(0f, DistanciaY, -10f);
    }
}
