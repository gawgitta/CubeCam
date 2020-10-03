using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameWinner : MonoBehaviour
{
    public string tagMask;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("collision");
        if (other.tag == tagMask)
        {
            Debug.Log("collisionconfirmed");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
