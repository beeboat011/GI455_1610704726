using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class findword : MonoBehaviour
{

    public string find;
    public GameObject Serash;
    public GameObject Display;

    public void Names()
    {

        find = Serash.GetComponent<Text>().text;

        if (find == "Boom")
        {
            Display.GetComponent<Text>().text = "[ <color=purple> " + find + "</color> ]" + "is found";
        }
        else if (find == "Poison")
        {
            Display.GetComponent<Text>().text = "[ <color=purple> " + find + "</color> ]" + "is found";
        }
        else if (find == "ResidentEvil")
        {
            Display.GetComponent<Text>().text = "[ <color=purple> " + find + "</color> ]" + "is found";
        }
        else if (find == "Comic")
        {
            Display.GetComponent<Text>().text = "[ <color=purple> " + find + "</color> ]" + "is found";
        }
        else if (find == "Thailand")
        {
            Display.GetComponent<Text>().text = "[ <color=purple> " + find + "</color> ]" + "is found";
        }
        else
        {
            Display.GetComponent<Text>().text = "[ <color=red> " + find + "</color> ]" + "not found";
        }


    }

}

