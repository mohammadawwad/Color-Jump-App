using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public void GoTOCredits()
    {
        SceneManager.LoadScene("Credits");
        Time.timeScale = 1f;
    }
    public void GoBack()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }
}

