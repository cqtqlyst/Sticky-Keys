using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private bool hitBorder;

    public float moveSpeed = 5f;
    public Transform movePoint;
    private GameObject player;
    private Transform playerTransform;


    // Start is called before the first frame update
    void Start()
    {
        movePoint.parent = null;

        player = GameObject.Find("Player");
        playerTransform = player.transform;
        hitBorder = false;
    }
    

    // Update is called once per frame
    void Update()
    {

        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);

        if (movePoint.position.x > 8.5 || movePoint.position.x < -8.5 || movePoint.position.y < 4.5 || movePoint.position.y < -4.5) {
            if (Vector3.Distance(transform.position, movePoint.position) <= 0f || hitBorder) {
                if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1f) {
                    movePoint.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
                }
                if (Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1f) {
                    movePoint.position += new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f);
                }
                hitBorder = false;
            }
        }

        Debug.Log("status of hit border: " + hitBorder);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Check to see if the tag on the collider is equal to Boundary

        Collider2D collider = collision.collider;

        hitBorder = true;

        movePoint.position = playerTransform.position;
        Debug.Log("yoooo " + movePoint.position + " " + playerTransform.position);
        
    }

}
