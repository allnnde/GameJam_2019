using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject Target;
    public float CamaraAnguloX;
    public float CamaraAnguloY;


    public float smoothing = 5f;

    private Vector3 _offset;

    // Use this for initialization
    void Start()
    {
        EnfocarAlPlayer();
    }

    public void EnfocarAlPlayer()
    {
        transform.rotation = Quaternion.Euler(CamaraAnguloX, CamaraAnguloY, 0);
        _offset = transform.position - Target.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 targetCamPos = Target.transform.position + _offset;
        transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);
    }
}
