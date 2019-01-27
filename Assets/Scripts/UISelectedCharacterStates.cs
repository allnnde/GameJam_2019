using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public enum BadgeStates{
    locked,
    notSelected,
    selected
}
public class UISelectedCharacterStates : MonoBehaviour
{
    public BadgeStates states;
    public GameObject charImage;


    public void setState(BadgeStates s){
        if(s == BadgeStates.locked){
            states = BadgeStates.locked;
            this.GetComponent<Image>().color = new Color(255,255,255, 0);
            var tempColor = charImage.GetComponent<Image>().color =  new Color(0,0,0, 10f);
            tempColor.a = 0.3f;
            charImage.GetComponent<Image>().color =  tempColor;
        }
        else if(s == BadgeStates.notSelected){
            Debug.Log("Enters here");
            states = BadgeStates.notSelected;
            this.GetComponent<Image>().color = new Color(255,255,255, 0);
            charImage.GetComponent<Image>().color =  new Color(255,255,255, 255);
        }
        else if(s == BadgeStates.selected){
            states = BadgeStates.selected;
            this.GetComponent<Image>().color = new Color(255,255,255, 150);
            charImage.GetComponent<Image>().color =  new Color(255,255,255, 255);
        }
    }
}
