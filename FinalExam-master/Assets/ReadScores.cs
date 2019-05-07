using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class ReadScores : MonoBehaviour
{
    public Text HighScores;
    public int numScores = 5;

    private void Start()
    {
        DisplayScores();
    }

    public void DisplayScores()
    {
        string path = "Assets/scores.txt";
        string line;
        string[] fields;
        string[] playerNames = new string[numScores];
        int[] playerScores = new int[numScores];
        int scoreIndex = 0;

        HighScores.text = "";
        StreamReader reader = new StreamReader(path);

        while (!reader.EndOfStream && scoreIndex < numScores)
        {
            line = reader.ReadLine();
            fields = line.Split(',');
            HighScores.text += fields[0] + " : " + fields[1] + "\n";
            scoreIndex += 1;
        }
    }
}
