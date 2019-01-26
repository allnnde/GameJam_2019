using UnityEngine;

public class PlayerMovimentController : MonoBehaviour
{
    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;

    private Vector3 moveDirection = Vector3.zero;
    private CharacterController controller;
    private Animator _anim;

    void Start()
    {
        controller = GetComponent<CharacterController>();

        // let the gameObject fall down
        gameObject.transform.position = new Vector3(0, 5, 0);
        _anim = GetComponent<Animator>();
    }

    void Update()
    {

        var mHorizaontal = Input.GetAxis("Horizontal");
        var mVertical = Input.GetAxis("Vertical");

        if (controller.isGrounded)
        {
            // We are grounded, so recalculate
            // move direction directly from axes
            moveDirection = new Vector3(mHorizaontal, 0.0f, mVertical);
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;           

        }

        // Apply gravity
        moveDirection.y -= (gravity * Time.deltaTime);

        // Move the controller
        controller.Move(moveDirection * Time.deltaTime);


        _anim.SetBool("Walking", mHorizaontal  != 0 || mVertical != 0);
    }
}
