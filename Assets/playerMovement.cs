using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float moveSpeed = 10f;
    //public float jumpHeight = 5f;

    private float xInput;
    private float zInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(xInput);
        //Debug.Log(zInput);
        ProcessInputs();
    }

    private void FixedUpdate()
    {
        Move();
        //Jump();
    }

    private void ProcessInputs()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");
    }

    private void Move()
    {
        rb.AddForce(new Vector3(xInput, 0, zInput) * moveSpeed);
    }

    /*private void Jump()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0, jumpHeight, 0));
        }    
    }*/
}
