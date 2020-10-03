using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComboButtonScript : MonoBehaviour
{
    public int buttonNumber;
    public GameObject numpad;

    void OnMouseDown()
    {
        Debug.Log("Button pressed");
        numpad.GetComponent<ComboSolver>().number += buttonNumber * numpad.GetComponent<ComboSolver>().orderPressed;
        numpad.GetComponent<ComboSolver>().OrderUp();
    }
}
