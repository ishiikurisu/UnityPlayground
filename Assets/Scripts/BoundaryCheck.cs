using UnityEngine;
using UnityEngine.SceneManagement;

public class BoundaryCheck : MonoBehaviour
{
    void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void OnTriggerEnter()
    {
        Invoke("RestartLevel", 1f);
    }
}
