using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class findword : MonoBehaviour
{

    public string findWord;
    public GameObject inputField;
    public GameObject textDisplay;

    public void Names()
    {

        findWord = inputField.GetComponent<Text>().text;

        if (findWord == "Unity")
        {
            textDisplay.GetComponent<Text>().text = "[" + findWord + "]" + "is found";
        }
        else if (findWord == "Unreal")
        {
            textDisplay.GetComponent<Text>().text = "[" + findWord + "]" + "is found";
        }
        else if (findWord == "ResidentEvil")
        {
            textDisplay.GetComponent<Text>().text = "[" + findWord + "]" + "is found";
        }
        else if (findWord == "Google")
        {
            textDisplay.GetComponent<Text>().text = "[" + findWord + "]" + "is found";
        }
        else if (findWord == "MongoDB")
        {
            textDisplay.GetComponent<Text>().text = "[" + findWord + "]" + "is found";
        }
        else
        {
            textDisplay.GetComponent<Text>().text = "[" + findWord + "]" + "not found";
        }


    }

}

