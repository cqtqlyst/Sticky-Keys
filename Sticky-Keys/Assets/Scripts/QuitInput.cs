using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitInput : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            Application.Quit();
        }    
    }
}
