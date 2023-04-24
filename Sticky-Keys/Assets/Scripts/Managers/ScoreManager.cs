using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text scoreDisplay;
    public static int score;
    private void Start()
    {
        scoreDisplay.text = "You Got a score of: " + score;
    }

}
