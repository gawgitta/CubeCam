using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComboSolver : MonoBehaviour
{
    public int number;
    public int correctNum = 529336;
    public GameObject gate;
    public int orderPressed = 100000;

    private void Update()
    {
        if (number == correctNum)
        {
            gate.GetComponent<MeshRenderer>().enabled = false;
            gate.GetComponent<BoxCollider>().enabled = false;
        }
    }

    public void OrderUp()
    {
        Debug.Log("Ordered up");
        orderPressed /= 10;
    }
}
