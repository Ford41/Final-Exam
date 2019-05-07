using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;
using UnityEditor;

public class WriteScores : MonoBehaviour
{
    public Text HighScores;
    public InputField PlayerName;
    //public InputField PlayerScore;
    public int numScores = 5;

    public void AddHighScore()
    {
        string path = "Assets/scores.txt";
        string line;
        string[] fields;
        int scoreIndex = 0;
        string newPlayer = "Unknown Name";
        string newHScore = "0";
        bool newScoreWritten = false;
        string[] writePlayers = new string[numScores];
        string[] writeScores = new string[numScores];

        HighScores.text = "";
        newPlayer = PlayerName.text;
        newHScore = ScoreKeeper.newScore.ToString();

        StreamReader reader = new StreamReader(path);
        while (!reader.EndOfStream)
        {
            line = reader.ReadLine();
            fields = line.Split(',');
            if (!newScoreWritten && scoreIndex < numScores)
            {
                if (Convert.ToInt32(newHScore) > Convert.ToInt32(fields[1]))
                {
                    HighScores.text += newPlayer + " : " + newHScore + "\n";
                    writePlayers[scoreIndex] = newPlayer;
                    writeScores[scoreIndex] = newHScore;
                    newScoreWritten = true;
                    scoreIndex += 1;
                }
            }
            if (scoreIndex < numScores)
            {
                HighScores.text += fields[0] + " : " + fields[1] + "\n";
                writePlayers[scoreIndex] = fields[0];
                writeScores[scoreIndex] = fields[1];
                scoreIndex += 1;
            }
        }
        reader.Close();

        StreamWriter writer = new StreamWriter(path);
        for (int i = 0; i < scoreIndex; i++)
        {
            writer.WriteLine(writePlayers[i] + ',' + writeScores[i]);
        }
        writer.Close();

        AssetDatabase.ImportAsset(path);
        TextAsset asset = (TextAsset)Resources.Load("scores");
    }
}
