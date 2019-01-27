using UnityEngine;

public class PlayerMovimentController : MonoBehaviour
{
    public float speed = 6.0f;
    public float jumpSpeed = 30.0f;
    public float gravity = 20.0f;

    private Vector3 moveDirection = Vector3.zero;
    private CharacterController controller;
    private Animator _anim;
    private Transform _modelo;

    public bool Saltar { get; set; }

    public bool isSelected;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();
        _anim = GetComponentInChildren<Animator>();
        _modelo = transform.GetChild(0);
    }

    void Start()
    {
    }

    void Update()
    {

        var mHorizaontal = Input.GetAxis("Horizontal");
        var mVertical = Input.GetAxis("Vertical");

        if (controller.isGrounded && isSelected)
        {
            // We are grounded, so recalculate

            // move direction directly from axes
            moveDirection = new Vector3(mHorizaontal, 0.0f, mVertical);

            if (moveDirection != Vector3.zero) _modelo.rotation = Quaternion.LookRotation(moveDirection);

            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            if (Saltar)
            {
                moveDirection.y = jumpSpeed;
                Saltar = false;
            }
        }

        // Apply gravity
        moveDirection.y -= (gravity * Time.deltaTime);

        // Move the controller
        if(isSelected) { 
            controller.Move(moveDirection * Time.deltaTime);
             _anim.SetBool("Walking", mHorizaontal  != 0 || mVertical != 0);
        }
    }
}
