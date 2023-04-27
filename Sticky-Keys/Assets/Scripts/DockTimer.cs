using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DockTimer : MonoBehaviour
{
    public TMP_Text Timer;
    public static float currentTime = 0f;
    private bool once = true;
    float dockTimeLength = 9f;

   
    // Update is called once per frame
    void Update()
    {
        Timer.color = Color.white;
        currentTime -= 1 * Time.deltaTime;
        Timer.text = currentTime.ToString("0");

       
        if (LetterSpawnerManager.dock == false && once == true)
        {
            currentTime = dockTimeLength;
            once = false;
        }
        if (currentTime <= 0f)
        {
            Timer.color = Color.green;
            Timer.text = "Dock Available";
            LetterSpawnerManager.dock = true;
            once = true;
        }

    }
}
