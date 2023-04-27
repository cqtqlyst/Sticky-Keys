using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class LeaderBoardManager : MonoBehaviour
{


    public void ReadStringInput(string input)
    {
        writeFile(input, ScoreManager.score);
    }

    void writeFile(string name, int score)
    {
        string path = "/Assets/Files/leaderboard.txt";
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine("Test");
    }
}
