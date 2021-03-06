using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class SwitchLevels : MonoBehaviour
{
    public Button[] lvlButtons;
    

    void Start()
    {
        int levelAt = PlayerPrefs.GetInt("levelAt", 2);
        for (int i = 0; i < lvlButtons.Length; i++)
        {

            Time.timeScale = 1f;


            if (i + 2 > levelAt)
            {
                lvlButtons[i].interactable = false;
            }

        }
    }
    
    public void Select(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }




   /* public Button[] lvlButtons;

    void Start()
    {
        int levelAt = PlayerPrefs.GetInt("levelAt", 4);
        for (int i = 0; i < lvlButtons.Length; i++)
        {
            
           Time.timeScale = 1f;
            

            if (i + 4 > levelAt)
            {
                lvlButtons[i].interactable = false;
            }
                
        }
    }
    */
    /*
    public void Level3()
    {
        SceneManager.LoadScene(5);
        Time.timeScale = 1f;
    }
    public void Level4()
    {
        SceneManager.LoadScene(6);
        Time.timeScale = 1f;
    }
    public void Level1()
    {
        SceneManager.LoadScene(3);
        Time.timeScale = 1f;
    }
    public void Level2()
    {
        SceneManager.LoadScene(4);
        Time.timeScale = 1f;
    }
    public void Level5()
    {
        SceneManager.LoadScene(7);
        Time.timeScale = 1f;
    }
    */
}
