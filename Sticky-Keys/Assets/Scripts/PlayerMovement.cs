using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private bool hitObstacle;

    public float moveSpeed = 5f;
    public Transform movePoint;
    public Vector3 playerpos;
    // Start is called before the first frame update
    void Start()
    {
        movePoint.parent = null;
    }
    

    // Update is called once per frame
    void Update()
    {

        GameObject player = GameObject.Find("Player");
        Transform playerTransform = player.transform;
        playerpos = playerTransform.position;
        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, movePoint.position) == 0f) {
            if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1f) {
                movePoint.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
            }
            if (Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1f) {
                movePoint.position += new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Check to see if the tag on the collider is equal to Boundary
        movePoint.position = playerpos;
        Debug.Log("yoooo " + movePoint.position + " " + playerpos);
        
    }

}
