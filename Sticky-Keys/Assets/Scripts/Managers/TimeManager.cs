using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;
using TMPro;

public class TimerManager : MonoBehaviour
{

    public int seconds = 120;
    private System.Timers.Timer timer;
    public int timeBetweenCoolDown = 1000;

    public TextMeshPro text;


    void Start()
    {
        timer = new Systems.Timers.Timer(timeBetweenCoolDown);
        Timer.Elapsed += Timer_Elapsed;
        Timer.Enabled = true;
        Timer.AutoReset = true;
        Timer.Start();
    }

    private void Timer_Elapsed(object sender, ElapsedEventArgs e)
    {
        seconds--;
    }

    // Update is called once per frame
    void Update()
    {



    }
}