using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_menubuttons : MonoBehaviour
{
    public GameObject gc;
    //true = right
    public bool direction;

    public void switchscreen()
    {
        if (direction)
        {
            if (gc.GetComponent<scr_gamecontroller>().menustate == 0) { gc.GetComponent<scr_gamecontroller>().menustate = 1; }
            else if(gc.GetComponent<scr_gamecontroller>().menustate == 1) { gc.GetComponent<scr_gamecontroller>().menustate = 2; }
            else if (gc.GetComponent<scr_gamecontroller>().menustate == 2) { gc.GetComponent<scr_gamecontroller>().menustate = 0; }
        }

        if (!direction)
        {
            if (gc.GetComponent<scr_gamecontroller>().menustate == 0) { gc.GetComponent<scr_gamecontroller>().menustate = 2; }
            else if (gc.GetComponent<scr_gamecontroller>().menustate == 2) { gc.GetComponent<scr_gamecontroller>().menustate = 1; }
            else if (gc.GetComponent<scr_gamecontroller>().menustate == 1) { gc.GetComponent<scr_gamecontroller>().menustate = 0; }
        }
    }
}
