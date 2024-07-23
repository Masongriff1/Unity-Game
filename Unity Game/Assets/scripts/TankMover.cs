using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.VisualScripting;
using UnityEngine;

public class TankMover : Mover
{

    private Rigidbody rb;
    // Start is called before the first frame update
    public override void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    public override void Move(Vector3 direction, float speed)
    {
        Vector3 moveVector = direction.normalized * speed * Time.deltaTime;

        rb.MovePosition(rb.position + moveVector);
    }

    public override void Rotate(float rotationSpeed)
    {
        gameObject.transform.Rotate(0, rotationSpeed + Time.deltaTime, 0);
    }
    public override void ShootTank(object bullet, float force)
    {
        //gameObject.transform.;
    }
}
