using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserScript : MonoBehaviour
{
    public GameObject manager;
    public GameObject record;
    public GameObject lens;
    public GameObject cameraObj;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "CubeCam")
        {
            other.GetComponent<Rigidbody>().useGravity = false;
            while (other.tag == "CubeCam")
            {
                other.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            }
            other.GetComponent<MeshRenderer>().enabled = false;
            other.GetComponent<BoxCollider>().enabled = false;
            record.GetComponent<Blinker>().enabled = false;
            record.GetComponent<MeshRenderer>().enabled = false;
            record.GetComponent<Transform>().position = new Vector3(0f, 0f, -100f);
            lens.GetComponent<MeshRenderer>().enabled = false;
            cameraObj.GetComponent<MeshRenderer>().enabled = false;
            manager.GetComponent<Reset>().LoseGame();
        }
    }
}
