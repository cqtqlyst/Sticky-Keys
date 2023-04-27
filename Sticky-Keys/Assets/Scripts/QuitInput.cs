using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitInput : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            Application.Quit();
        }

        if (Input.GetButtonDown("Enable Debug Button 2"))
        {
            SceneManager.LoadScene("Phase2");
        }
    }
}
