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

    void setTag(string tag)
    {

    }

    //void Update()
    //{
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        int letter = Random.Range(1, 25);
    //        GetComponent<SpriteRenderer>().sprite = letters[letter];
    //    }
    //}
}
