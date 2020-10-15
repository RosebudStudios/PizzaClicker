using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_upgrade_button : MonoBehaviour
{
    public GameObject gc;
    public int upgradenumber;
    

    public void upgradebutton()
    {
        //price upgrades
        if (upgradenumber == 0)
        {
            if (gc.GetComponent<scr_gamecontroller>().money >= gc.GetComponent<scr_gamecontroller>().pepperoni)
            {
                gc.GetComponent<scr_gamecontroller>().money -= gc.GetComponent<scr_gamecontroller>().pepperoni;
                gc.GetComponent<scr_gamecontroller>().pepperoni += 8;
                gc.GetComponent<scr_gamecontroller>().price += 1;
            }
        }

        if (upgradenumber == 1)
        {
            if (gc.GetComponent<scr_gamecontroller>().money >= gc.GetComponent<scr_gamecontroller>().mushrooms)
            {
                gc.GetComponent<scr_gamecontroller>().money -= gc.GetComponent<scr_gamecontroller>().mushrooms;
                gc.GetComponent<scr_gamecontroller>().mushrooms += 16;
                gc.GetComponent<scr_gamecontroller>().price += 2;
            }
        }

        if (upgradenumber == 2)
        {
            if (gc.GetComponent<scr_gamecontroller>().money >= gc.GetComponent<scr_gamecontroller>().butteredcrust)
            {
                gc.GetComponent<scr_gamecontroller>().money -= gc.GetComponent<scr_gamecontroller>().butteredcrust;
                gc.GetComponent<scr_gamecontroller>().butteredcrust += 24;
                gc.GetComponent<scr_gamecontroller>().price += 3;
            }
        }

        if (upgradenumber == 3)
        {
            if (gc.GetComponent<scr_gamecontroller>().money >= gc.GetComponent<scr_gamecontroller>().specialcheese)
            {
                gc.GetComponent<scr_gamecontroller>().money -= gc.GetComponent<scr_gamecontroller>().specialcheese;
                gc.GetComponent<scr_gamecontroller>().specialcheese += 32;
                gc.GetComponent<scr_gamecontroller>().price += 4;
            }
        }

        if (upgradenumber == 4)
        {
            if (gc.GetComponent<scr_gamecontroller>().money >= gc.GetComponent<scr_gamecontroller>().cheesycrust)
            {
                gc.GetComponent<scr_gamecontroller>().money -= gc.GetComponent<scr_gamecontroller>().cheesycrust;
                gc.GetComponent<scr_gamecontroller>().cheesycrust += 40;
                gc.GetComponent<scr_gamecontroller>().price += 8;
            }
        }

        if (upgradenumber == 5)
        {
            if (gc.GetComponent<scr_gamecontroller>().money >= gc.GetComponent<scr_gamecontroller>().deepdish)
            {
                gc.GetComponent<scr_gamecontroller>().money -= gc.GetComponent<scr_gamecontroller>().deepdish;
                gc.GetComponent<scr_gamecontroller>().deepdish += 60;
                gc.GetComponent<scr_gamecontroller>().price += 16;
            }
        }

        if (upgradenumber == 6)
        {
            if (gc.GetComponent<scr_gamecontroller>().money >= gc.GetComponent<scr_gamecontroller>().celebrity)
            {
                gc.GetComponent<scr_gamecontroller>().money -= gc.GetComponent<scr_gamecontroller>().celebrity;
                gc.GetComponent<scr_gamecontroller>().celebrity += 80;
                gc.GetComponent<scr_gamecontroller>().price += 25;
            }
        }

        if (upgradenumber == 7)
        {
            if (gc.GetComponent<scr_gamecontroller>().money >= gc.GetComponent<scr_gamecontroller>().squarepizza)
            {
                gc.GetComponent<scr_gamecontroller>().money -= gc.GetComponent<scr_gamecontroller>().squarepizza;
                gc.GetComponent<scr_gamecontroller>().squarepizza += 120;
                gc.GetComponent<scr_gamecontroller>().price += 50;
            }
        }

        if (upgradenumber == 8)
        {
            if (gc.GetComponent<scr_gamecontroller>().money >= gc.GetComponent<scr_gamecontroller>().perfectpizza)
            {
                gc.GetComponent<scr_gamecontroller>().money -= gc.GetComponent<scr_gamecontroller>().perfectpizza;
                gc.GetComponent<scr_gamecontroller>().perfectpizza += 150;
                gc.GetComponent<scr_gamecontroller>().price += 100;
            }
        }

        if (upgradenumber == 9)
        {
            if (gc.GetComponent<scr_gamecontroller>().money >= gc.GetComponent<scr_gamecontroller>().zoomer)
            {
                gc.GetComponent<scr_gamecontroller>().money -= gc.GetComponent<scr_gamecontroller>().zoomer;
                gc.GetComponent<scr_gamecontroller>().zoomer += 250;
                gc.GetComponent<scr_gamecontroller>().price += 200;
            }
        }
        if (upgradenumber == 10)
        {
            if (gc.GetComponent<scr_gamecontroller>().money >= gc.GetComponent<scr_gamecontroller>().mascot)
            {
                gc.GetComponent<scr_gamecontroller>().money -= gc.GetComponent<scr_gamecontroller>().mascot;
                gc.GetComponent<scr_gamecontroller>().mascot += 600;
                gc.GetComponent<scr_gamecontroller>().price += 500;
            }
        }

        //slice production upgrades

        if (upgradenumber == 11)
        {
            if (gc.GetComponent<scr_gamecontroller>().money >= gc.GetComponent<scr_gamecontroller>().oven)
            {
                gc.GetComponent<scr_gamecontroller>().money -= gc.GetComponent<scr_gamecontroller>().oven;
                gc.GetComponent<scr_gamecontroller>().oven += (25* gc.GetComponent<scr_gamecontroller>().val1);
                gc.GetComponent<scr_gamecontroller>().slicespersecond += 2;
                gc.GetComponent<scr_gamecontroller>().val1++;
            }
        }
        if (upgradenumber == 12)
        {
            if (gc.GetComponent<scr_gamecontroller>().money >= gc.GetComponent<scr_gamecontroller>().autoboxer)
            {
                gc.GetComponent<scr_gamecontroller>().money -= gc.GetComponent<scr_gamecontroller>().autoboxer;
                gc.GetComponent<scr_gamecontroller>().autoboxer += (50 * gc.GetComponent<scr_gamecontroller>().val2);
                gc.GetComponent<scr_gamecontroller>().slicespersecond += 3;
                gc.GetComponent<scr_gamecontroller>().val2++;
            }
        }

        if (upgradenumber == 13)
        {
            if (gc.GetComponent<scr_gamecontroller>().money >= gc.GetComponent<scr_gamecontroller>().preprepper)
            {
                gc.GetComponent<scr_gamecontroller>().money -= gc.GetComponent<scr_gamecontroller>().preprepper;
                gc.GetComponent<scr_gamecontroller>().preprepper += (75 * gc.GetComponent<scr_gamecontroller>().val3);
                gc.GetComponent<scr_gamecontroller>().slicespersecond += 5;
                gc.GetComponent<scr_gamecontroller>().val3++;
            }
        }

        if (upgradenumber == 14)
        {
            if (gc.GetComponent<scr_gamecontroller>().money >= gc.GetComponent<scr_gamecontroller>().chefbot)
            {
                gc.GetComponent<scr_gamecontroller>().money -= gc.GetComponent<scr_gamecontroller>().chefbot;
                gc.GetComponent<scr_gamecontroller>().chefbot += (100 * gc.GetComponent<scr_gamecontroller>().val4);
                gc.GetComponent<scr_gamecontroller>().slicespersecond += 8;
                gc.GetComponent<scr_gamecontroller>().val4++;
            }
        }

        if (upgradenumber == 15)
        {
            if (gc.GetComponent<scr_gamecontroller>().money >= gc.GetComponent<scr_gamecontroller>().topchef)
            {
                gc.GetComponent<scr_gamecontroller>().money -= gc.GetComponent<scr_gamecontroller>().topchef;
                gc.GetComponent<scr_gamecontroller>().topchef += (100 * gc.GetComponent<scr_gamecontroller>().val5);
                gc.GetComponent<scr_gamecontroller>().slicespersecond += 16;
                gc.GetComponent<scr_gamecontroller>().val5++;
            }
        }

        if (upgradenumber == 16)
        {
            if (gc.GetComponent<scr_gamecontroller>().money >= gc.GetComponent<scr_gamecontroller>().sentient)
            {
                gc.GetComponent<scr_gamecontroller>().money -= gc.GetComponent<scr_gamecontroller>().sentient;
                gc.GetComponent<scr_gamecontroller>().sentient += (100 * gc.GetComponent<scr_gamecontroller>().val6);
                gc.GetComponent<scr_gamecontroller>().slicespersecond += 32;
                gc.GetComponent<scr_gamecontroller>().val6++;
            }
        }

        if (upgradenumber == 17)
        {
            if (gc.GetComponent<scr_gamecontroller>().money >= gc.GetComponent<scr_gamecontroller>().conveyor)
            {
                gc.GetComponent<scr_gamecontroller>().money -= gc.GetComponent<scr_gamecontroller>().conveyor;
                gc.GetComponent<scr_gamecontroller>().conveyor += (100 * gc.GetComponent<scr_gamecontroller>().val7);
                gc.GetComponent<scr_gamecontroller>().slicespersecond += 64;
                gc.GetComponent<scr_gamecontroller>().val7++;
            }
        }

        if (upgradenumber == 18)
        {
            if (gc.GetComponent<scr_gamecontroller>().money >= gc.GetComponent<scr_gamecontroller>().sidelocation)
            {
                gc.GetComponent<scr_gamecontroller>().money -= gc.GetComponent<scr_gamecontroller>().sidelocation;
                gc.GetComponent<scr_gamecontroller>().sidelocation += (100 * gc.GetComponent<scr_gamecontroller>().val8);
                gc.GetComponent<scr_gamecontroller>().slicespersecond += 128;
                gc.GetComponent<scr_gamecontroller>().val8++;
            }
        }

        if (upgradenumber == 19)
        {
            if (gc.GetComponent<scr_gamecontroller>().money >= gc.GetComponent<scr_gamecontroller>().factory)
            {
                gc.GetComponent<scr_gamecontroller>().money -= gc.GetComponent<scr_gamecontroller>().factory;
                gc.GetComponent<scr_gamecontroller>().factory += (100 * gc.GetComponent<scr_gamecontroller>().val9);
                gc.GetComponent<scr_gamecontroller>().slicespersecond += 256;
                gc.GetComponent<scr_gamecontroller>().val9++;
            }
        }

        if (upgradenumber == 20)
        {
            if (gc.GetComponent<scr_gamecontroller>().money >= gc.GetComponent<scr_gamecontroller>().pizzatower)
            {
                gc.GetComponent<scr_gamecontroller>().money -= gc.GetComponent<scr_gamecontroller>().pizzatower;
                gc.GetComponent<scr_gamecontroller>().pizzatower += (100 * gc.GetComponent<scr_gamecontroller>().val10);
                gc.GetComponent<scr_gamecontroller>().slicespersecond += 512;
                gc.GetComponent<scr_gamecontroller>().val10++;
            }
        }




    }
}
