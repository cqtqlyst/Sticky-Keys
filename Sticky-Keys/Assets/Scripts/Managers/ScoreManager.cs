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
        if (score > 100)
        {
            scoreDisplay.color = Color.green;
            scoreDisplay.text = "You Got a score of: " + score + "!" + "\r\n" + "You were able to make: " + WordReader.wordsCreated + "\r\n" + "You Win!";
        } else
        {
            scoreDisplay.color = Color.red;
            scoreDisplay.text = "You Got a score of: " + score + "!" + "\r\n" + "You were able to make: " + WordReader.wordsCreated + "\r\n" + "You Lose!";
        }
        if (score == 0)
        {
            scoreDisplay.color = Color.magenta;
            scoreDisplay.text = "You Got a score of 0" + "\r\n" + "Try to make some words next time >:D";
        }
        totalScore += score;
    }

}
