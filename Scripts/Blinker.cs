using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blinker : MonoBehaviour
{
    private void Start()
    {
        Invoke("TurnOn", 0);
    }

    public void TurnOn()
    {
        GetComponent<MeshRenderer>().enabled = true;
        Invoke("TurnOff", 1);
    }
    public void TurnOff()
    {
        GetComponent<MeshRenderer>().enabled = false;
        Invoke("TurnOn", 1);
    }
}
