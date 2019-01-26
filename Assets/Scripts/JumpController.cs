using UnityEngine;

public class JumpController : MonoBehaviour
{
    private Animator _anim;

    PlayerMovimentController _pmc;
    private void Awake()
    {
        _pmc = GetComponent<PlayerMovimentController>();
        _anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _pmc.Saltar = true;
            _anim.SetTrigger("UsingSkill");
        }

    }
}
