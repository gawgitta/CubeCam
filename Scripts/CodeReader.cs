using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeReader : MonoBehaviour
{
    public TextMesh text;
    public GameObject numpad;

    private void Update()
    {
        if (numpad.GetComponent<ComboSolver>().number == 0)
        {
            text.text = "000000";
        }
        else
        {
            text.text = numpad.GetComponent<ComboSolver>().number.ToString();
        }
    }
}
