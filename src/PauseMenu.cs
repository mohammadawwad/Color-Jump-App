using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject quitMenuUI;
    public AudioSource Click;

    // Update is called once per frame
    void update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {


            if (GameIsPaused)
            {
                Resume();
                pauseMenuUI.gameObject.SetActive(false);
                Time.timeScale = 1f;
                GameIsPaused = false;
            }
            else
            {
                Pause();
                pauseMenuUI.gameObject.SetActive(true);
                Time.timeScale = 0f;
                GameIsPaused = true;
            }
        }
    
    }

    public void Resume()
    {
        pauseMenuUI.gameObject.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        Click.Play();
        pauseMenuUI.gameObject.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void QuitGameMenu()
    {
        quitMenuUI.gameObject.SetActive(true);
        pauseMenuUI.gameObject.SetActive(false);
    }
    public void DontQuitGame()
    {
        quitMenuUI.gameObject.SetActive(false);
        Pause();
    }
    public void YesQuitGame()
    {
        Application.Quit();
    }
    public void Options()
    {
        if (GameIsPaused)
        {
            Resume();
        }
        else
        {
            Pause();
        }
    }
    
}
