using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSoundManager : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource src;
    public AudioClip [] concreteSounds;
    public AudioClip [] woodsSounds;
    public AudioClip [] waterSounds;

    AudioClip[] actualClips;
    public bool shouldPlay = false;


    void Start()
    {
        src = this.GetComponent<AudioSource>();
    }


    public void hitGround (int clipCollection){
        switch(clipCollection){
            case 0:
                actualClips = concreteSounds;
                break;
            case 1:
                actualClips = woodsSounds;
                break;
            case 3:  
                actualClips = waterSounds;
                break;
            default:
                actualClips = concreteSounds;
                break;
        }
    }

    public void playStepSound(){
        src.clip = actualClips[Random.Range(0, actualClips.Length -1)];
        src.Play();
    }
}
