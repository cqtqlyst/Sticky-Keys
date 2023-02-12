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
        float x, y; // used for checking the change with the movePoint

        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);

        
            if (Vector3.Distance(transform.position, movePoint.position) <= 0f || hitBorder) {
                if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1f) {
                    x = Input.GetAxisRaw("Horizontal");
                    if (movePoint.position.x + x >= 9 || movePoint.position.x + x <= -9) {
                        movePoint.position = playerTransform.position;
                    }
                    else {
                        movePoint.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
                    }
                }
                if (Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1f) {
                    y = Input.GetAxisRaw("Vertical");
                    if (movePoint.position.y + y >= 5 || movePoint.position.y + y <= -5) {
                        movePoint.position = playerTransform.position;
                    }
                    else {
                        movePoint.position += new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f);
                    }
                }
                hitBorder = false;
            }
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
