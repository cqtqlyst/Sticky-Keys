using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStick : MonoBehaviour
{
    public float slowDownMultiplier = 0.75f;

    void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject letter = collision.gameObject;

        if (letter.tag == "Destroy")
        {
            Vector3 currentPos = this.gameObject.transform.position;
            Vector3 letterPos = letter.transform.position;
            Vector3 difference = currentPos - letterPos;

            letter.transform.SetParent(this.gameObject.transform);
            letter.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;

            letter.tag = "Connected";
        }

        // slows down the player as it collects more objects
        GameObject[] connected = GameObject.FindGameObjectsWithTag("Connected");
        PlayerMovement.moveSpeed = (float)Math.Pow((double)slowDownMultiplier, (double)connected.Length) * PlayerMovement.moveSpeed;

    }
}
