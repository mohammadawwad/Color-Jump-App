using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement
    ;
public class Finish : MonoBehaviour
{
    public int nextSceneLoaded;



    void Start()
    {
      
        Time.timeScale = 1f;
        nextSceneLoaded = SceneManager.GetActiveScene().buildIndex + 1;
      
    }
    void OnTriggerEnter2D(Collider2D col)
    {



        if (col.tag == "Player")
        {
            Debug.Log("You Won");
            SceneManager.LoadScene(nextSceneLoaded);
            if (nextSceneLoaded > PlayerPrefs.GetInt("levelAt"))
            {
                PlayerPrefs.SetInt("levelAt", nextSceneLoaded);
            }
        }
    }
}

