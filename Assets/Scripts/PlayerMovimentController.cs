using UnityEngine;

public class PlayerMovimentController : MonoBehaviour
{
    public float VelocidadMovimiento = 6f;

    private Vector3 _forward;
    private Vector3 _right;
    private Animator _anim;


    private void Awake()
    {
        _anim = GetComponent<Animator>();
    }
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

        var enMovimiento = mHorizontal != 0 || mVertical != 0;

        if (enMovimiento)
        {
            var rightMoviment = _right * VelocidadMovimiento * Time.deltaTime * mHorizontal;
            var upMoviment = _forward * VelocidadMovimiento * Time.deltaTime * mVertical;

            transform.forward = Vector3.Normalize(rightMoviment + upMoviment);
            transform.position += rightMoviment;
            transform.position += upMoviment;
        }
        _anim.SetBool("Walking", enMovimiento);

    }
}
