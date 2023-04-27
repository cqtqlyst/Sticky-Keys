using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterStick : MonoBehaviour
{

    public GameObject player;
    public bool isTouchingBoundary = false;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");    
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject letter = collision.gameObject;

        if (letter.tag == "Boundary")
        {
            isTouchingBoundary = true;
        }

        if (letter.tag == "Destroy" && this.gameObject.tag == "Connected")
        {
            letter.transform.SetParent(player.transform);
            //letter.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;

            letter.tag = "Connected";
        }

    }
}
