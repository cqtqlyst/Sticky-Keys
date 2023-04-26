using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterSpawnerManager : MonoBehaviour
{
    public GameObject letterSpawnerPrefab;
    public int numOfLettersToSpawn = 10;
    public static bool ranOnce = false;

    void Start()
    {
        spawnLetters();
    }


    void Update()
    {
        //Debug.Log(CountdownTimer.currentTime.ToString());

        if (Input.GetButtonDown("Fire3"))
        {
            GameObject[] docked = GameObject.FindGameObjectsWithTag("Connected");
            foreach (GameObject target in docked)
            {
                //Debug.Log(target.GetComponent<LetterSpawner>().index - 1);
                Debug.Log("start " + WordReader.letters[target.GetComponent<LetterSpawner>().index - 1]);
                WordReader.letters[target.GetComponent<LetterSpawner>().index - 1] += 1;
                Debug.Log("end " + WordReader.letters[target.GetComponent<LetterSpawner>().index - 1]);
                GameObject.Destroy(target);
            }
        }

        if (CountdownTimer.currentTime <= 0.2f && !ranOnce)
        {
            resetLetters();
            ranOnce = true;
        }    
    }

    public void resetLetters()
    {
        GameObject[] destroy = GameObject.FindGameObjectsWithTag("Destroy");
        foreach (GameObject target in destroy)
        {
            GameObject.Destroy(target);
        }


        spawnLetters();
    }

    void spawnLetters()
    {
        for (int i = 0; i < numOfLettersToSpawn; i++)
        {
            int xAdd = Random.Range(0, 33);
            int yAdd = Random.Range(0, 14);

            // below equations derived from whiteboard work
            double newXPos = ((double)xAdd * 0.5) + 0.25 - 8.5;
            double newYPos = ((double)yAdd * 0.5) + 0.25 - 3.5;

            Object.Instantiate(letterSpawnerPrefab, new Vector3((float)newXPos, (float)newYPos, 0f), Quaternion.identity);
        }
    }
}
