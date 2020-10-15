using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scr_gamecontroller : MonoBehaviour
{
    //allows the game to switch between menus
    public int gamestate;

    //basic stats
    public int pizzas;
    public int slices;
    public int money;

    //the amount the price per full pizza increases
    public int price;
    //the amount of slices generated per second
    public int slicespersecond;
    public float secondtimer;

    //text objects
    public Text slicetext;
    public Text pizzatext;
    public Text moneytext;

    //buttons
    public Button clicker;
    public Button pep;
    public Button mush;
    public Button butt;
    public Button spec;
    public Button chees;
    public Button deep;
    public Button celeb;
    public Button square;
    public Button perfect;
    public Button zoom;
    public Button freddy;

    public Button ovenn;
    public Button auto;
    public Button pree;
    public Button chef;
    public Button top;
    public Button sent;
    public Button conv;
    public Button side;
    public Button fact;
    public Button tower;

    //screen sprite objects that flip between eachother
    public GameObject mainscreen;
    public GameObject updatescreen;


    //upgrade price values
    public int pepperoni = 16;
    public int mushrooms = 32;
    public int butteredcrust = 48;
    public int specialcheese = 56;
    public int cheesycrust = 64;
    public int deepdish = 80;
    public int celebrity = 120;
    public int squarepizza = 200;
    public int perfectpizza = 500;
    public int zoomer = 1000;
    public int mascot = 2000;

    public int oven = 50;           public int val1 = 0;
    public int autoboxer = 100;     public int val2 = 0;
    public int preprepper = 150;    public int val3 = 0;
    public int chefbot = 200;       public int val4 = 0;
    public int topchef = 400;       public int val5 = 0;
    public int sentient = 800;      public int val6 = 0;
    public int conveyor = 1600;     public int val7 = 0;
    public int sidelocation = 3200; public int val8 = 0;
    public int factory = 6400;      public int val9 = 0;
    public int pizzatower = 12800;  public int val10 = 0;


    // Start is called before the first frame update
    void Start()
    {
        money = 0;
        price = 8;
        slicespersecond = 1;

        mainscreen.SetActive(true);
        updatescreen.SetActive(false);
        gamestate = 0;
        slices = 0;
        pizzas = 0;
        slicetext.text = "";
        pizzatext.text = "";
        moneytext.text = "Money: " + money;

        secondtimer = 1;
    }

    // Update is called once per frame
    void Update()
    {
        moneytext.text = "Money: $" + money;
      
        //clicker menu
        if (gamestate == 0) {
            mainscreen.SetActive(true);
            updatescreen.SetActive(false);
            slicetext.text = "Slices: " + slices;
            pizzatext.text = "Pizzas: " + pizzas;
            
        }

        //upgrade menu
        if (gamestate == 1)
        {
            updatescreen.SetActive(true);
            mainscreen.SetActive(false);
            slicetext.text = "";
            pizzatext.text = "";
        }

        //if 8 slices are made, converts those slices to a pie, gets rid of the slices, and adds the money to the total
        if (slices >= 8) { pizzas++; money += price; slices = 0; }

        secondtimer -= Time.deltaTime;
        if (secondtimer <= 0) {slices += slicespersecond; secondtimer = 1;}




    }
}
