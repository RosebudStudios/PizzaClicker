using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scr_gamecontroller : MonoBehaviour
{
    public GameObject clickermenu;
    public GameObject upgrademenu;
    public GameObject startmenu;
    public GameObject resetmenu;

    public Button pizzabutton;
    public Sprite image0;
    public Sprite image1;
    public Sprite image2;
    public Sprite image3;
    public Sprite image4;
    public Sprite image5;
    public Sprite image6;
    public Sprite image7;


    //allows the game to switch between menus
    public int gamestate;
    public int menustate;

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

    //buttons
    public GameObject page1;
    public GameObject page2;
    public GameObject page3;
    public GameObject page4;
    public GameObject page5;
    public GameObject page6;
    //button text
    #region

    public Text pep;
    public Text mush;
    public Text butt;
    public Text spec;
    public Text chees;
    public Text deep;
    public Text celeb;
    public Text square;
    public Text perfect;
    public Text zoom;
    public Text freddy;

    public Text ovenn;
    public Text auto;
    public Text pree;
    public Text chef;
    public Text top;
    public Text sent;
    public Text conv;
    public Text side;
    public Text fact;
    public Text tower;
    #endregion


    //upgrade price values
    #region
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

    public int oven = 50;           public int val1 = 1;
    public int autoboxer = 100;     public int val2 = 1;
    public int preprepper = 150;    public int val3 = 1;
    public int chefbot = 200;       public int val4 = 1;
    public int topchef = 400;       public int val5 = 1;
    public int sentient = 800;      public int val6 = 1;
    public int conveyor = 1600;     public int val7 = 1;
    public int sidelocation = 3200; public int val8 = 1;
    public int factory = 6400;      public int val9 = 1;
    public int pizzatower = 12800;  public int val10 = 1;
    #endregion


    // Start is called before the first frame update
    void Start()
    {
        gamestate = 2;
        menustate = 0;

        money = 0;
        price = 8;
        slicespersecond = 0;
       
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

      
        //clicker menu
        if (gamestate == 0) {

            clickermenu.SetActive(true);
            upgrademenu.SetActive(false);
            startmenu.SetActive(false);
            if (clicker.interactable == false) { clicker.interactable = true; }
            slicetext.text = "Slices: " + slices;
            pizzatext.text = "Pizzas: " + pizzas;
            moneytext.text = "Money: $" + money;

        }

        //upgrade menu
        if (gamestate == 1)
        {
            upgrademenu.SetActive(true);
            clickermenu.SetActive(false);
            startmenu.SetActive(false);
            if (clicker.interactable == true) { clicker.interactable = false; }
            slicetext.text = "";
            pizzatext.text = "";
            moneytext.text = "Money: $" + money;

            if (menustate == 0) { page1.SetActive(true); page2.SetActive(false); page3.SetActive(false); page4.SetActive(false); page5.SetActive(false); page6.SetActive(false); }
            if (menustate == 1) { page1.SetActive(false); page2.SetActive(true); page3.SetActive(false); page4.SetActive(false); page5.SetActive(false); page6.SetActive(false); }
            if (menustate == 2) { page1.SetActive(false); page2.SetActive(false); page3.SetActive(true); page4.SetActive(false); page5.SetActive(false); page6.SetActive(false); }
            if (menustate == 3) { page1.SetActive(false); page2.SetActive(false); page3.SetActive(false); page4.SetActive(true); page5.SetActive(false); page6.SetActive(false); }
            if (menustate == 4) { page1.SetActive(false); page2.SetActive(false); page3.SetActive(false); page4.SetActive(false); page5.SetActive(true); page6.SetActive(false); }
            if (menustate == 5) { page1.SetActive(false); page2.SetActive(false); page3.SetActive(false); page4.SetActive(false); page5.SetActive(false); page6.SetActive(true); }
        }

        //start menu
        if (gamestate == 2)
        {
            resetmenu.SetActive(false);
            upgrademenu.SetActive(false);
            clickermenu.SetActive(false);
            startmenu.SetActive(true);
            if (clicker.interactable == true) { clicker.interactable = false; }
            slicetext.text = "";
            pizzatext.text = "";
            moneytext.text = "";
        }

        if (gamestate == 3)
        {
            resetmenu.SetActive(true);
            upgrademenu.SetActive(false);
            clickermenu.SetActive(false);
            startmenu.SetActive(false);
            if (clicker.interactable == true) { clicker.interactable = false; }
            slicetext.text = "";
            pizzatext.text = "";
            moneytext.text = "";
        }

        if (slices == 0) { pizzabutton.image.sprite = image0; }
        if (slices == 1) { pizzabutton.image.sprite = image1; }
        if (slices == 2) { pizzabutton.image.sprite = image2; }
        if (slices == 3) { pizzabutton.image.sprite = image3; }
        if (slices == 4) { pizzabutton.image.sprite = image4; }
        if (slices == 5) { pizzabutton.image.sprite = image5; }
        if (slices == 6) { pizzabutton.image.sprite = image6; }
        if (slices == 7) { pizzabutton.image.sprite = image7; }

        //slice adder
        secondtimer -= Time.deltaTime;
        if (secondtimer <= 0) { slices += slicespersecond; secondtimer = 1; }

        //if 8 slices are made, converts those slices to a pie, gets rid of the slices, and adds the money to the total
        if (slices >= 8) { pizzas++; money += price; slices-=8; }

        //button text updater
        pep.text =  "$" + pepperoni;
        mush.text = "$" + mushrooms;
        butt.text = "$" + butteredcrust;
        spec.text = "$" + specialcheese;
        chees.text = "$" + cheesycrust;
        deep.text = "$" + deepdish;
        celeb.text = "$" + celebrity;
        square.text = "$" + squarepizza;
        perfect.text = "$" + perfectpizza;
        zoom.text = "$" + zoomer;
        freddy.text = "$" + mascot;
        ovenn.text = "$" + oven;
        auto.text = "$" + autoboxer;
        pree.text = "$" + preprepper;
        chef.text = "$" + chefbot;
        top.text = "$" + topchef;
        sent.text = "$" + sentient;
        conv.text = "$" + conveyor;
        side.text = "$" + sidelocation;
        fact.text = "$" + factory;
        tower.text = "$" + pizzatower;




    }
}
