using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_pizzabutton : MonoBehaviour
{
    public GameObject gc;

    public void addslice ()
    {
        gc.GetComponent<scr_gamecontroller>().slices++;
    }

}
