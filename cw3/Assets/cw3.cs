using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cw3 : MonoBehaviour
{
    string heroname = "andrew";
    int heropower = 999;
    string villainname = "raj";
    int villainpower = 999;
    float playerspeed = 50f;
    float newspeed = 25.5f;
    // Start is called before the first frame update
    void Start()
    {
        if (heropower > villainpower)
        {
            print(" the hero is stronger");
        }

        else if (heropower == villainpower)
        {
            print("they are equal");
        }

        else
        {
            print("the villain is stronger");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void setspeed(float newspeed)
    {
        print("old speed is" + playerspeed);
        playerspeed = newspeed;
        print("new speed is" + playerspeed);
    }
}
