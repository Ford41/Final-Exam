using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DataManager : MonoBehaviour
{
    private float startTime;
    private float delay;
    public Text textSpeed;
    public Text textSize;
    public Text textTime;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        textSize.text = DropdownManager.sizetext;
        textSpeed.text = DropdownManager.speedtext;
        textTime.text = DropdownManager.timetext.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        textTime.text = (DropdownManager.timetext - delay).ToString();

        delay = Time.time - startTime;
        if (delay >= DropdownManager.timetext)
        {
            SceneManager.LoadScene("4Exit");
        }
    }
}
