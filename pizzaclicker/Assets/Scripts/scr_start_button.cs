using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_start_button : MonoBehaviour
{
    public GameObject gc;
    public int state;

    public void switchscreen()
    {
        gc.GetComponent<scr_gamecontroller>().gamestate = state;
    }
}
