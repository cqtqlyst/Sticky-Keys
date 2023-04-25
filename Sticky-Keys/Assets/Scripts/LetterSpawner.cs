using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterSpawner : MonoBehaviour
{

    public Sprite[] letters;

    void Start()
    {
        
    }

    void spawnLetters() {

        int xAdd = Random.Range(0, 33);
        int yAdd = Random.Range(0, 15);

        // below equations derived from whiteboard work
        double newXPos = ((double)xAdd * 0.5) + 0.25 - 8.5;
        double newYPos = ((double)yAdd * 0.5) + 0.25 - 3.5;

        int letter = Random.Range(1, 25); // generates a random letter for spawning

        // actually updates the individual sprite
        GetComponent<SpriteRenderer>().sprite = letters[letter];
    
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            int letter = Random.Range(1, 25);
            GetComponent<SpriteRenderer>().sprite = letters[letter];
        }
    }
}
