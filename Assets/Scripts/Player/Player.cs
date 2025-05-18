using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed;
    public float directionalSpeed;
    public float rotationSpeed;

    public Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector3(Input.acceleration.x * directionalSpeed, 0, playerSpeed * Time.deltaTime);
        Vector3 pos = rb.position;
        pos.x = Mathf.Clamp(pos.x, -2.5f, 2.5f);
        rb.position = pos;
        transform.Rotate(Vector3.right * rotationSpeed);
    }
}
