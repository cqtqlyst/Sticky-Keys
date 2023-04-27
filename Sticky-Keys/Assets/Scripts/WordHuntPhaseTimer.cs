using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class WordHuntPhaseTimer : MonoBehaviour
{
    public TMP_Text Timer;
    float currentTime = 0f;
    float startingTime = 59f;
    public string sceneName;
    // starts time at our starting time to initialize time every playthrough
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        // counts time every second incrementally
        currentTime -= 1 * Time.deltaTime;
        Timer.color = Color.white;
        if (currentTime <= 5)
        {
            Timer.color = Color.red;
        }
        // updates onscreen timer for the player to see
        Timer.text = "Time Left: " + currentTime.ToString("0");
        // changes phases after time is up
        if (currentTime <= 0)
        {
            changeScene();
        }

    }
    // runs a phase change after time is up
    public void changeScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
