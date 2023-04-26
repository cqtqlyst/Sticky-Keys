using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SoundManager : MonoBehaviour
{
    
    void Awake() {

        GameObject[] musicObj = GameObject.FindGameObjectsWithTag("MenuMusic");

        if (musicObj.Length > 1) {
            //Debug.Log("We are trying to destroy it");
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);

    }


}
