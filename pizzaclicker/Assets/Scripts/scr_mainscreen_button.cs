using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_mainscreen_button : MonoBehaviour
{
    public GameObject gc;

    public void switchscreen()
    {
        if (gc.GetComponent<scr_gamecontroller>().gamestate == 0) {gc.GetComponent<scr_gamecontroller>().gamestate = 1;}
        else {gc.GetComponent<scr_gamecontroller>().gamestate = 0;}
    }
}
