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
            other.GetComponent<Rigidbody>().useGravity = true;

            _anim.SetTrigger("UsingSkill");
        }
    }

}
