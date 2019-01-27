using UnityEngine;


public class PushObjectController : MonoBehaviour
{

    private Animator _anim;

    private void Awake()
    {
        _anim = GetComponentInChildren<Animator>();
    }
    private void OnTriggerStay(Collider other)
    {
        //Debug.Log(other.tag);
        if (other.CompareTag("Pushable") && Input.GetKeyDown(KeyCode.E))
        {
            var rb = other.GetComponent<Rigidbody>();
            rb.isKinematic= false;
            rb.useGravity = true;            
            var empuje = transform.GetChild(0).forward;
            rb.AddForce(empuje * 10);

            _anim.SetTrigger("UsingSkill");
        }
    }

}
