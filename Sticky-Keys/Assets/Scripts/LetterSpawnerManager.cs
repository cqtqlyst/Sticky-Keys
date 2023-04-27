using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterSpawnerManager : MonoBehaviour
{
    public GameObject letterSpawnerPrefab;
    public int numOfLettersToSpawn = 10;
    public static bool ranOnce = false; // avoids an error with manipulation
    public static bool dock;

    void Start()
    {
        // resets global list
        for (int i = 0; i < 26; i++)
        {
            WordReader.letters[i] = 0;
        }
        spawnLetters(); // spawns letters for the first time
        dock = true;
    }


    void Update()
    {
        //Debug.Log(CountdownTimer.currentTime.ToString());

        if (Input.GetButtonDown("Fire3"))
        {
            if (dock == true)
            {
                GameObject[] docked = GameObject.FindGameObjectsWithTag("Connected");
                foreach (GameObject target in docked)
                {
                    //Debug.Log(target.GetComponent<LetterSpawner>().index - 1);
                    //Debug.Log("start " + WordReader.letters[target.GetComponent<LetterSpawner>().index - 1]);

                    WordReader.letters[target.GetComponent<LetterSpawner>().index - 1] += 1; // updates the global list

                    //Debug.Log("end " + WordReader.letters[target.GetComponent<LetterSpawner>().index - 1]);
                    GameObject.Destroy(target); // destroys the docked gameobjects
                }
                dock = false;
                Debug.Log("Great Dock!!!");
            }
        }

        // destroys old blocks and adds new blocks
        if (CountdownTimer.currentTime <= 0.2f && !ranOnce)
        {
            resetLetters();
            ranOnce = true;
        }    
    }

    // function 
    public void resetLetters()
    {
        // destroys all letters that have not been collected
        GameObject[] destroy = GameObject.FindGameObjectsWithTag("Destroy");
        foreach (GameObject target in destroy)
        {
            GameObject.Destroy(target);
        }

        spawnLetters();
    }

    // function used to spawn letters every 10 seconds
    void spawnLetters()
    {
        for (int i = 0; i < numOfLettersToSpawn; i++)
        {
            // below equations derived from whiteboard work
            int xAdd = Random.Range(0, 33);
            int yAdd = Random.Range(0, 14);
            double newXPos = ((double)xAdd * 0.5) + 0.25 - 8.5;
            double newYPos = ((double)yAdd * 0.5) + 0.25 - 3.5;

            // instantiates the actual object on the screen
            Object.Instantiate(letterSpawnerPrefab, new Vector3((float)newXPos, (float)newYPos, 0f), Quaternion.identity);
        }
    }
}
