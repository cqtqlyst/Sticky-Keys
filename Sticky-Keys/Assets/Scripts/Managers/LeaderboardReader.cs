using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class LeaderboardReader : MonoBehaviour
{
    Dictionary<string, int> leaderboard;
    [SerializeField] private TextAsset file;


    void Start()
    {
        // intializes the dictionary
        leaderboard = new Dictionary<string, int>();
        // reads file and adds words to dictionary
        ReadFile();
    }

    void ReadFile()
    {
        // reads file and splits file by new line to save words and their points 
        var splitFile = new string[] { "\r\n", "\r", "\n" };
        var splitLine = new char[] { ',' };
        var Lines = file.text.Split(splitFile, System.StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < Lines.Length; i++)
        {
            var line = Lines[i].Split(splitLine, System.StringSplitOptions.None);
            string name = line[0];
            string v = line[1];
            int score = int.Parse(v);
            leaderboard.Add(name, score);
        }
    }




}
