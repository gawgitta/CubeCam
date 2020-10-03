using Microsoft.Win32.SafeHandles;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMover : MonoBehaviour
{
    public Rigidbody rb;
    public int force;
    bool goingLeft = true;
    public float leftx;
    public float rightx;

    private void FixedUpdate()
    {
        if (transform.position.x >= rightx)
        {
            goingLeft = true;
            rb.velocity = Vector3.zero;
        }

        if (transform.position.x <= leftx)
        {
            goingLeft = false;
            rb.velocity = Vector3.zero;
        }

        if (goingLeft)
        {
            rb.AddForce(-force, 0, 0);
        }
        else
        {
            rb.AddForce(force, 0, 0);
        }
    }
}
