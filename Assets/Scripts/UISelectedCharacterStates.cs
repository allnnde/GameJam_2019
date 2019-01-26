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
    public Sprite charImage;
    public Sprite disabledImage;

    public void setState(BadgeStates s){
        if(s == BadgeStates.locked){
            states = BadgeStates.locked;
            transform.localScale = new Vector3(1, 1, 1);
            this.GetComponent<Image>().sprite = disabledImage;
        }
        if(s == BadgeStates.notSelected){
            states = BadgeStates.notSelected;
            transform.localScale = new Vector3(1, 1, 1);
            this.GetComponent<Image>().sprite = charImage;
        }
        if(s == BadgeStates.selected){
            states = BadgeStates.selected;
            this.GetComponent<Image>().sprite = charImage;
            transform.localScale = new Vector3(1.5f, 1.5f, 1);
        }
    }
}
