using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterChangeManager : MonoBehaviour
{
    public bool canBeUsed = false;
    void OnControllerColliderHit(ControllerColliderHit  other)
    {
        if(other.gameObject.CompareTag("Player")){
            other.gameObject.GetComponent<CharacterChangeManager>().canBeUsed = true;
            
        }
        else if(other.gameObject.CompareTag("Concreto")){
            this.GetComponent<CharacterSoundManager>().hitGround(0);
        }
        else if(other.gameObject.CompareTag("Dirt")){
            this.GetComponent<CharacterSoundManager>().hitGround(1);
        }
        /*
        else if(other.gameObject.CompareTag("Water")){
            this.GetComponent<CharacterSoundManager>().hitGround(2);
        }
         */
    }
}
