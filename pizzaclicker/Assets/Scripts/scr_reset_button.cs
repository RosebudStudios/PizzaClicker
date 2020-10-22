using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_reset_button : MonoBehaviour
{
    public GameObject gc;

    public void reset()
    {
        gc.GetComponent<scr_gamecontroller>().slices = 0;
        gc.GetComponent<scr_gamecontroller>().pizzas = 0;
        gc.GetComponent<scr_gamecontroller>().money = 0;
    }
}
