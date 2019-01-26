using UnityEngine;

public class PlayerMovimentController : MonoBehaviour
{
    public float VelocidadMovimiento = 6f;

    private Vector3 _forward;
    private Vector3 _right;

    // Use this for initialization
    void Start()
    {
        _forward = Camera.main.transform.forward;
        _forward.y = 0;
        _forward = Vector3.Normalize(_forward);
        _right = Quaternion.Euler(new Vector3(0, 90, 0)) * _forward;
    }

    // Update is called once per frame
    void Update()
    {
        var mHorizontal = Input.GetAxis("Horizontal");
        var mVertical = Input.GetAxis("Vertical");

        if (mHorizontal != 0 || mVertical != 0)
        {
            Vector3 rightMoviment = _right * VelocidadMovimiento * Time.deltaTime * mHorizontal;
            Vector3 upMoviment = _forward * VelocidadMovimiento * Time.deltaTime * mVertical;

            var heading = Vector3.Normalize(rightMoviment + upMoviment);

            transform.forward = heading;
            transform.position += rightMoviment;
            transform.position += upMoviment;
        }

    }
}
