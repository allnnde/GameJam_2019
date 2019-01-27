using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAudioEventsTriggers : MonoBehaviour
{
    CharacterSoundManager csm;

    void Start(){
        csm = this.gameObject.GetComponentInParent<CharacterSoundManager>();
    }
    public void step(){
        csm.playStepSound();
    }
}
