using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterSpawnerManager : MonoBehaviour
{
    public GameObject letterSpawnerPrefab;
    private ArrayList destroyList;

    void Update()
    {

        int xAdd = Random.Range(0, 33);
        int yAdd = Random.Range(0, 14);

        // below equations derived from whiteboard work
        double newXPos = ((double)xAdd * 0.5) + 0.25 - 8.5;
        double newYPos = ((double)yAdd * 0.5) + 0.25 - 3.5;

        if (Input.GetMouseButtonDown(0))
        {
            Object.Instantiate(letterSpawnerPrefab, new Vector3((float)newXPos, (float)newYPos, 0f), Quaternion.identity);
            destroyList.Add(GameObject.FindGameObjectWithTag("Destroy"));
        }

        if (Input.GetMouseButtonDown(1))
        {
            for (int i = 0; i<destroyList.Count; i++)
            {
                Object.Destroy((Object)destroyList[i]);
            }
            destroyList.Clear();
        }
    }
}