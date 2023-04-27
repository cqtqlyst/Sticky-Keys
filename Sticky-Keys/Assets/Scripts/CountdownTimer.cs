using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CountdownTimer : MonoBehaviour
{
    public TMP_Text Timer;
    public static float currentTime = 0f;
    float startingTime = 9f;

    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        Timer.color = Color.white;
        if (currentTime <= 3f)
        {
            Timer.color = Color.red;
        }
        currentTime -= 1 * Time.deltaTime;
        Timer.text = "Countdown Time: " + currentTime.ToString("0");

        if (currentTime <= 0f)
        {
            currentTime = startingTime;
        }
       
        if (currentTime >= 8f)
        {
            LetterSpawnerManager.ranOnce = false;
        }
    }
}
