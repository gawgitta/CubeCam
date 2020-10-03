using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyesMove : MonoBehaviour
{
    public bool isOnLeft = false;
    public Vector3 onLeft;
    public Vector3 onRight;
    public GameObject triggerRight;
    public GameObject triggerLeft;

    void Update()
    {
        if (isOnLeft == false)
        {
            if (Input.GetKeyDown("a"))
            {
                transform.localPosition = onLeft;
                isOnLeft = true;
            }
        }
        else
        {
            if (Input.GetKeyDown("d"))
            {
                transform.localPosition = onRight;
                isOnLeft = false;
            }
        }
        if (Input.GetMouseButtonDown(0))
        {
            if (isOnLeft == true)
            {
                triggerLeft.GetComponent<MeshRenderer>().enabled = true;
                triggerLeft.GetComponent<BoxCollider>().enabled = true;
                Invoke("DisableLeftTrigger", 0.25f);
            }
            else
            {
                triggerRight.GetComponent<MeshRenderer>().enabled = true;
                triggerRight.GetComponent<BoxCollider>().enabled = true;
                Invoke("DisableRightTrigger", 0.25f);
            }
        }
    }
    public void DisableRightTrigger()
    {
        triggerRight.GetComponent<MeshRenderer>().enabled = false;
        triggerRight.GetComponent<BoxCollider>().enabled = false;
    }
    public void DisableLeftTrigger()
    {
        triggerLeft.GetComponent<MeshRenderer>().enabled = false;
        triggerLeft.GetComponent<BoxCollider>().enabled = false;
    }
}
