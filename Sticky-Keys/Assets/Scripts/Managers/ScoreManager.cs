using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text scoreDisplay;
    public static int score;
    private void Start()
    {
        scoreDisplay.text = "You Got a score of: " + score;

    }

}
