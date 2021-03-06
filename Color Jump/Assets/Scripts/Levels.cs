using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour
{
    public void AllLevels()
    {
        SceneManager.LoadScene("All Levels");
        Time.timeScale = 1f;
    }
}
