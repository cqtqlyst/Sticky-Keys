using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text scoreDisplay;
    public static int score;
    public static int totalScore;
    private void Start()
    {
        scoreDisplay.text = "You Got a score of: " + score;
        if (score > 0)
        {
            scoreDisplay.text = "You Got a score of: " + score + "!" + "\r\n" + "You were able to make: " + WordReader.wordsCreated;
        }
        totalScore += score;
    }

}
