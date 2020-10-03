using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scr_gamecontroller : MonoBehaviour
{
    public int pizzas;
    public int slices;

    public Text slicetext;
    public Text pizzatext;

    // Start is called before the first frame update
    void Start()
    {
        slices = 0;
        pizzas = 0;
        slicetext.text = "";
        pizzatext.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        slicetext.text = "Slices: " + slices;
        pizzatext.text = "Pizzas: " + pizzas;
        if (slices >= 8) { pizzas++; slices = 0; }
    }
}
