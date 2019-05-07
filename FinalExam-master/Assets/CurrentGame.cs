using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentGame : MonoBehaviour
{
    public Text currentStats;
    // Start is called before the first frame update
    void Start()
    {
        currentStats.text = "Score: " + ScoreKeeper.newScore.ToString() + "\n"
            + "Lives: " + LivesTracker.lives.ToString();
    }
}
