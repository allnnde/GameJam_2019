using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpController : MonoBehaviour
{

    PlayerMovimentController _pmc;
    private void Awake()
    {
        _pmc = GetComponent<PlayerMovimentController>();
    }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetKeyDown(KeyCode.Space))
            {
              _pmc.Saltar = true;
            }
            
    }
}
