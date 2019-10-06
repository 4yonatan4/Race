using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public float speed;

    public Rigidbody rb;

    public Vector3 movement;
    // Start is called before the first frame update
    public void Start()
    {
        speed = 10f;
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        //movement = new Vector3(Input.GetAxis("Horizontal"),0, Input.GetAxis("Vertical"));
        movement = new Vector3(Input.GetAxis("Horizontal"),0, 1f);
    }

    private void FixedUpdate()
    {
        MoveCharacter(movement);
    }

    public void MoveCharacter(Vector3 direction)
    {
        //rb.AddForce(direction*speed);
        //rb.velocity = direction * speed;
        rb.MovePosition(transform.position + (direction * speed * Time.deltaTime));
    }
}
