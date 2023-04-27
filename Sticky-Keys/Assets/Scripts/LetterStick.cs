using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterStick : MonoBehaviour
{

    public GameObject player;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");    
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject letter = collision.gameObject;

        if (letter.tag == "Destroy")
        {
            letter.transform.SetParent(player.transform);
            letter.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;

            letter.tag = "Connected";
        }
    }
}
