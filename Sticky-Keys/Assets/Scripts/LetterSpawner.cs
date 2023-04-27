using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterSpawner : MonoBehaviour
{
    public int index = 0; // index to know what letter it is
    public Sprite[] letters; // sprite list to iterate through

    void Awake()
    {
        int letter = Random.Range(1, 25); // generates a random letter for spawning
        index = letter; // updating this for the global letter list
        GetComponent<SpriteRenderer>().sprite = letters[letter];// actually updates the individual sprite
    }

}
