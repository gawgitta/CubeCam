using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowerRight : MonoBehaviour
{
    public GameObject triggerRight;
    public float force;
    public float upForce;
    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Rigidbody>().AddForce(force, upForce, 0);
    }
}
