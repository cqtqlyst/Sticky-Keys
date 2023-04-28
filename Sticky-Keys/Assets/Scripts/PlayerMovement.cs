using System;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

// player movement class for phase1 aka letter hunt phase
public class PlayerMovement : MonoBehaviour
{

    /*
     * Methodology for grid-based movement below:
     * Use a empty object called move point and based on the players control update
     * the position of the move point
     * Then make the player move toward the move point
     */

    public Transform movePoint;

    private bool hitBorder; // used to avoid a glitch faced earlier with the boundary
    public static float moveSpeed = 5f; // move speed
    private GameObject player; // the actual player represented in code
    private Transform playerTransform; // the players position
    private int ctr = 0;

    public string horizontalAxis;
    public string verticalAxis;

    // Start is called before the first frame update
    void Start()
    {
        movePoint.parent = null; // unparenting the move point so it can move freely

        // basic player setup
        player = this.gameObject; 
        playerTransform = player.transform;

        // setup for border protection
        hitBorder = false;
    }
    

    // Update is called once per frame
    void Update()
    {
        ctr++;
        float x, y; // used for checking the change with the move point

        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime); // makes the player move toward the move point

        if (Vector3.Distance(transform.position, movePoint.position) <= 0.0f || hitBorder) { // used to stop spam controls and movement
                                                                                             // limits the amount of inputs per second
            //Debug.Log("hit border: " + hitBorder);
            if (Mathf.Abs(Input.GetAxisRaw(horizontalAxis)) == 1f) { // if there is input

                x = Input.GetAxisRaw(horizontalAxis); // get the input

                if (movePoint.position.x + x >= 9 || movePoint.position.x + x <= -9) // ensures that no glitches with the boundary occur 
                {
                    movePoint.position = playerTransform.position; // updates move point, effected on line 43
                }
                else
                {
                    movePoint.position += new Vector3(Input.GetAxisRaw(horizontalAxis), 0f, 0f);
                }
            }
            if (Mathf.Abs(Input.GetAxisRaw(verticalAxis)) == 1f) { // if there is input

                y = Input.GetAxisRaw(verticalAxis); // get the input

                if (movePoint.position.y + y >= 4 || movePoint.position.y + y <= -5) // ensures that no glitches with the boundary occur
                {
                    movePoint.position = playerTransform.position; // updates move point, effected on line 43
                }
                else
                {
                    movePoint.position += new Vector3(0f, Input.GetAxisRaw(verticalAxis), 0f); // updates move point, effected on line 43
                }
            }

            if (ctr % 5000 == 0)
            {
                hitBorder = false; // constantly updated so the player can actually move again
            }
        }

    }


    // this method is used to stop the border glitch
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // updates player movement and resets player transform position
        hitBorder = true;
        movePoint.position = playerTransform.position;
        
    }

}
