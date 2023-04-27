using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.SceneManagement;

public class WordHuntPhaseTimer : MonoBehaviour
{
    public TMP_Text Timer;
    float currentTime = 0f;
    float startingTime = 59f;
    public string sceneName;
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        Timer.text = "Time Left: " + currentTime.ToString("0");
      
        if (currentTime <= 0)
        {
            changeScene();
        }

    }

    public void changeScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
