using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterSpawner : MonoBehaviour
{

    public Sprite[] letters;

    void Awake() {

        int letter = Random.Range(1, 25); // generates a random letter for spawning

        // actually updates the individual sprite
        GetComponent<SpriteRenderer>().sprite = letters[letter];
    
    }

    void setTagConnected()
    {
        this.gameObject.tag = "Connected";
    }

    void setTagDocked()
    {
        this.gameObject.tag = "Docked";
    }

}
