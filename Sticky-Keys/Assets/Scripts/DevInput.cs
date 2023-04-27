using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DevInput : MonoBehaviour
{

    public string nextScene;

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            SceneManager.LoadScene(nextScene);
        }

        if (Input.GetButtonDown("Cancel"))
        {
            Application.Quit();
        }
    }
}