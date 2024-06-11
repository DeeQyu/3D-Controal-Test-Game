using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelFinishLine : MonoBehaviour
{
    public string nextSceneName; // Name of the scene to load when the finish line is crossed.

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object that crossed the finish line has a specific tag (e.g., "Player").
        if (other.CompareTag("Ball"))
        {
            // Load the next scene.
            SceneManager.LoadScene(nextSceneName);
        }
    }
}
