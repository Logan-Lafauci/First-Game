using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed = 10f;
    public Transform cam;
    public Vector3 sizeChangeRate;

    private float xInput;
    private float zInput;

    // Update is called once per frame
    void Update()
    {
        ProcessInputs();

        if (Input.GetMouseButton(0) && transform.localScale.x < 4)
        {
            transform.localScale += sizeChangeRate;
        }

        if (Input.GetMouseButton(1) && transform.localScale.x > .5)
        {
            transform.localScale -= sizeChangeRate;
        }
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void ProcessInputs()
    {
        xInput = Input.GetAxisRaw("Horizontal");
        zInput = Input.GetAxisRaw("Vertical");
    }

    private void Move()
    {
        Vector3 direction = new Vector3(xInput, 0f, zInput).normalized;
        float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
        
        if(direction.magnitude > 0f)
        {
            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            rb.AddForce(moveDir.normalized * moveSpeed * Time.deltaTime);
        }
        
    }
}
