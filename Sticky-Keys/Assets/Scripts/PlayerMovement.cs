using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody2D rb;
    public float horizontalForce = 1000f;
    public float verticalForce = 1000f;
    private float horizontalMove;
    private float verticalMove;

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * horizontalForce;
        verticalMove = Input.GetAxisRaw("Vertical") * verticalForce;

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate() {
        rb.AddForce(new Vector2(horizontalMove * Time.deltaTime, verticalMove * Time.deltaTime));
    }

}
