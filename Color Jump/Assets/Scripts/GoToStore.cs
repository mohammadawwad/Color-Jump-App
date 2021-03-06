using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToStore : MonoBehaviour
{
    public void ToTheStore()
    {
        SceneManager.LoadScene("Store");
    }
    public void Back()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }

}