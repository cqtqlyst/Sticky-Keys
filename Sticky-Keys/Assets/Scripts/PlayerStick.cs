using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStick : MonoBehaviour
{

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


    }
}
