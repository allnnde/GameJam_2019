using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SneakController : MonoBehaviour
{
    private Animator _anim;

    private void Awake()
    {
        _anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            _anim.SetTrigger("UsingSkill");

        }
    }
}
