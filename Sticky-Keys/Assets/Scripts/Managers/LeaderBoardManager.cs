using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class LeaderBoardManager : MonoBehaviour
{
    private string path;

    void Awake()
    {
        path = Application.dataPath + "/Files/leaderboard.txt";
    }


    public void ReadStringInput(string input)
    {
        writeFile(input, ScoreManager.score);
    }

    void writeFile(string name, int score)
    {
        var writer = new StreamWriter(path, true);
        writer.WriteLine(name + "," + score);
        writer.Close();
    }

    void updateLeaderboard()
    {

    }

}
