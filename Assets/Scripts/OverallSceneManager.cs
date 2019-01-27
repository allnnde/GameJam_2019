using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverallSceneManager : MonoBehaviour
{
    public GameObject father;
    public GameObject mother;
    public GameObject bambi;
    public GameObject cam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1) && father.gameObject.GetComponent<CharacterChangeManager>().canBeUsed){
            mother.GetComponent<JumpController>().enabled = false;
            mother.GetComponent<PlayerMovimentController>().isSelected = false;
            bambi.GetComponent<SneakController>().enabled = false;
            bambi.GetComponent<PlayerMovimentController>().isSelected = false;
            father.GetComponent<PushObjectController>().enabled = true;
            father.GetComponent<PlayerMovimentController>().isSelected = true;
            cam.GetComponent<CameraController>().Target = father;
        }
        if(Input.GetKeyDown(KeyCode.Alpha2) &&  mother.gameObject.GetComponent<CharacterChangeManager>().canBeUsed){
            father.GetComponent<PushObjectController>().enabled = false;
            father.GetComponent<PlayerMovimentController>().isSelected = false;
            bambi.GetComponent<SneakController>().enabled = false;
            bambi.GetComponent<PlayerMovimentController>().isSelected = false;
            mother.GetComponent<JumpController>().enabled = true; 
            mother.GetComponent<PlayerMovimentController>().isSelected = true;
            cam.GetComponent<CameraController>().Target = mother;
        }
        if(Input.GetKeyDown(KeyCode.Alpha3) &&  bambi.gameObject.GetComponent<CharacterChangeManager>().canBeUsed){
            mother.GetComponent<JumpController>().enabled = false;
            mother.GetComponent<PlayerMovimentController>().isSelected = false;
            father.GetComponent<PushObjectController>().enabled = false;
            father.GetComponent<PlayerMovimentController>().isSelected = false;
            bambi.GetComponent<SneakController>().enabled = true;
            bambi.GetComponent<PlayerMovimentController>().isSelected = true;
            cam.GetComponent<CameraController>().Target = bambi;
        }
    }
}
