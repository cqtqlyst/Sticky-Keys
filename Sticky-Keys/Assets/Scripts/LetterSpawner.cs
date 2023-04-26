using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterSpawner : MonoBehaviour
{
    public int index = 0;
    public Sprite[] letters;

    void Awake() {

        int letter = Random.Range(1, 25); // generates a random letter for spawning

        // actually updates the individual sprite
        index = letter;
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
