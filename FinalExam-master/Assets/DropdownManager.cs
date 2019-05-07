using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownManager : MonoBehaviour
{
    //public string timer;
    //public string size;
    //public string speed;
    public Dropdown size;
    public Dropdown speed;
    public Dropdown timer;

    public static string sizetext = "Normal";
    public static string speedtext = "Normal";
    public static float timetext = 15f;

    public void Size()
    {
        switch (size.value)
        {
            case 0:
                sizetext = "Normal";
                break;

            case 1:
                sizetext = "Small";
                break;
        }
    }

    public void Speed()
    {
        switch (speed.value)
        {
            case 0:
                speedtext = "Normal";
                break;

            case 1:
                speedtext = "Slow";
                break;
        }
    }

    public void Time()
    {
        switch (timer.value)
        {
            case 0:
                timetext = 15f;
                break;

            case 1:
                timetext = 30f;
                break;
        }
    }
}
