using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public AudioSource clickSound;
    public void StartGame()
    {
        SceneManager.LoadScene("Level1");
        Time.timeScale = 1f;
        clickSound.Play();
    }
    
}
