using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    public void BackGame()
    {
        SceneManager.LoadScene("Menu");
    }
}

