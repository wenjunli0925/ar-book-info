using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class MultipleVB : MonoBehaviour
{
    public GameObject GrannetBird, Koala, Elephant, LionCub, Horse, SquirrelMonkey;

    VirtualButtonBehaviour[] vrb;

    // Start is called before the first frame update
    void Start()
    {
        GrannetBird.SetActive(false);
        Koala.SetActive(false);
        Elephant.SetActive(false);
        LionCub.SetActive(false);
        Horse.SetActive(false);
        SquirrelMonkey.SetActive(false);

        vrb = GetComponentsInChildren<VirtualButtonBehaviour>();

        for (int i = 0; i < vrb.Length; i++)
        {
            vrb[i].RegisterOnButtonPressed(onButtonPressed);
            vrb[i].RegisterOnButtonReleased(onButtonReleased);
        }
    }

    public void onButtonPressed(VirtualButtonBehaviour vb)
    {
        if (vb.VirtualButtonName == "GRANNET BIRD")
        {
            GrannetBird.SetActive(true);
            Koala.SetActive(false);
            Elephant.SetActive(false);
            LionCub.SetActive(false);
            Horse.SetActive(false);
            SquirrelMonkey.SetActive(false);

            Debug.Log(vb.VirtualButtonName + " is pressed");
        }

        else if (vb.VirtualButtonName == "KOALA")
        {
            GrannetBird.SetActive(false);
            Koala.SetActive(true);
            Elephant.SetActive(false);
            LionCub.SetActive(false);
            Horse.SetActive(false);
            SquirrelMonkey.SetActive(false);

            Debug.Log(vb.VirtualButtonName + " is pressed");
        }

        else if (vb.VirtualButtonName == "ELEPHANT")
        {
            GrannetBird.SetActive(false);
            Koala.SetActive(false);
            Elephant.SetActive(true);
            LionCub.SetActive(false);
            Horse.SetActive(false);
            SquirrelMonkey.SetActive(false);

            Debug.Log(vb.VirtualButtonName + " is pressed");
        }

        else if (vb.VirtualButtonName == "LION CUB")
        {
            GrannetBird.SetActive(false);
            Koala.SetActive(false);
            Elephant.SetActive(false);
            LionCub.SetActive(true);
            Horse.SetActive(false);
            SquirrelMonkey.SetActive(false);

            Debug.Log(vb.VirtualButtonName + " is pressed");
        }

        else if (vb.VirtualButtonName == "HORSE")
        {
            GrannetBird.SetActive(false);
            Koala.SetActive(false);
            Elephant.SetActive(false);
            LionCub.SetActive(false);
            Horse.SetActive(true);
            SquirrelMonkey.SetActive(false);

            Debug.Log(vb.VirtualButtonName + " is pressed");
        }

        else if (vb.VirtualButtonName == "SQUIRREL MONKEY")
        {
            GrannetBird.SetActive(false);
            Koala.SetActive(false);
            Elephant.SetActive(false);
            LionCub.SetActive(false);
            Horse.SetActive(false);
            SquirrelMonkey.SetActive(true);

            Debug.Log(vb.VirtualButtonName + " is pressed");
        }

        else
        {
            throw new UnityException(vb.VirtualButtonName + "Virtual Button is not supported.");
        }
    }


    public void onButtonReleased(VirtualButtonBehaviour vb)
    {
        //GrannetBird.SetActive(false);
        //Koala.SetActive(false);
        //Elephant.SetActive(false);
        //LionCub.SetActive(false);
        //Horse.SetActive(false);
        //SquirrelMonkey.SetActive(false);

        Debug.Log("Button Released");
    }
}