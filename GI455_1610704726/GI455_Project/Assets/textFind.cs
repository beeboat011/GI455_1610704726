using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textFind : MonoBehaviour
{
    public string findword;
    public GameObject inputFinld;
    public GameObject textdisplay;


    public void Names()
    {
        findword = inputFinld.GetComponent<Text>().text;

        if(findword == "Unity")
        {
            textdisplay.GetComponent<Text>().text = "[" + findword + "]" + "is found";
        }
        else if (findword == "Unreal")
        {
            textdisplay.GetComponent<Text>().text = "[" + findword + "]" + "is found";
        }
        else if (findword == "ResidenEvil")
        {
            textdisplay.GetComponent<Text>().text = "[" + findword + "]" + "is found";
        }
        else if (findword == "Google")
        {
            textdisplay.GetComponent<Text>().text = "[" + findword + "]" + "is found";
        }
        else if (findword == "MongoDB")
        {
            textdisplay.GetComponent<Text>().text = "[" + findword + "]" + "is found";
        }
        else 
        {
            textdisplay.GetComponent<Text>().text = "[" + findword + "]" + " is not found";
        }
    }



}
