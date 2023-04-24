using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
    public TMP_Text Timer;
    public string sceneName;

    float currentTime = 0f;
    float startingTime = 119f;

    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        if (currentTime > 60f)
        {
            if ((currentTime-60)> 9)
            {
                Timer.text = "Time Left: 1:" + (currentTime-60).ToString("0");
            } else
            {
                Timer.text = "Time Left: 1:0" + (currentTime - 60).ToString("0");
            }
                
        } else
        {
            if (currentTime  > 9)
            {
                Timer.text = "Time Left: 0:" + currentTime.ToString("0");
            }
            else
            {
                Timer.text = "Time Left: 0:0" + currentTime.ToString("0");
            }
        }
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