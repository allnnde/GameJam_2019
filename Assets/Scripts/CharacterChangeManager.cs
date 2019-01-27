using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterChangeManager : MonoBehaviour
{
    public bool canBeUsed = false;
    void OnControllerColliderHit(ControllerColliderHit  other)
    {
        //Debug.Log(other.gameObject.co);
        if(other.gameObject.CompareTag("Player")){
            other.gameObject.GetComponent<CharacterChangeManager>().canBeUsed = true;
        }
    }
}
