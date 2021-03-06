using UnityEngine;
using UnityEngine.SceneManagement;

public class Quiter : MonoBehaviour
{
    public void StartGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
