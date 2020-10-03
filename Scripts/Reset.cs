using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            Restart();
        }
    }

    public void LoseGame()
    {
        Invoke("Restart", 1);
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
