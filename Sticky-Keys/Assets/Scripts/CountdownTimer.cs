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
        currentTime -= 1 * Time.deltaTime;
        Timer.text = "Countdown Time: 0" + currentTime.ToString("0");

        if (currentTime <= 0f)
        {
            currentTime = startingTime;
        }
    }
}
