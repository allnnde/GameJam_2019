using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISelectedCharacterBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    public Image[] family;
    int currentlySelected = 0;
    void Start()
    {
        foreach(Image m in family){
            m.GetComponent<UISelectedCharacterStates>().setState(BadgeStates.locked);
        }
        setSelected(currentlySelected);
    }
    void setSelected(int character){
        family[currentlySelected].GetComponent<UISelectedCharacterStates>().setState(BadgeStates.notSelected);
        currentlySelected = character;
        family[currentlySelected].GetComponent<UISelectedCharacterStates>().setState(BadgeStates.selected);
    }
}
