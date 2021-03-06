using UnityEngine.SceneManagement;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform player;

    void LateUpdate()
    {
        if (player.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, player.position.y, transform.position.z);
        }

        if (player.position.y < transform.position.y -13)
        {
            transform.position = new Vector3(transform.position.x, player.position.y, transform.position.z);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }
}
