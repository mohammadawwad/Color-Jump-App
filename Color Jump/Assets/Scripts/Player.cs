using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public AudioSource jumpAudio;
    public AudioSource deadAudio;
    public AudioSource coinAudio;

    public float jumpForce = 15f;
    public float restartDelay = 1f;
    public float ScaleSpeed = 1f;

    public int nextSceneLoaded;

    public string currentColor;
    public Sprite Knob, WhiteFace_0 , Cry_Face_0, Spike_Ball_0;
    public Rigidbody2D rb;
    public SpriteRenderer sr;
    public CircleCollider2D cc;
    public Transform player;
    public Color colorCyan;
    public Color colorYellow;
    public Color colorPink;
    public Color colorMagenta;
    private readonly string selectedCharacter = "SelectedCharacter";

    void Start()
    {
        SetRandomColor();
        Time.timeScale = 1f;
        int getCharacter;
        getCharacter = PlayerPrefs.GetInt(selectedCharacter);
        switch (getCharacter)
        {
            case 1:
                sr.sprite = Knob;
                this.player.gameObject.GetComponent<CircleCollider2D>().radius = 0.08f;
                this.player.transform.localScale = new Vector3(5.2f, 5.2f, 5.2f);
                break;
            case 2:
                sr.sprite = WhiteFace_0;
                this.player.gameObject.GetComponent<CircleCollider2D>().radius = 0.4f;
                this.player.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
                break;
            case 3:
                sr.sprite = Cry_Face_0;
                this.player.gameObject.GetComponent<CircleCollider2D>().radius = 0.32f;
                this.player.transform.localScale = new Vector3(1.3f, 1.3f, 1.3f);
                break;
            case 4:
                sr.sprite = Spike_Ball_0;
                this.player.gameObject.GetComponent<CircleCollider2D>().radius = 0.55f;
                this.player.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
                break;
            default:
                sr.sprite = Knob;
                this.player.gameObject.GetComponent<CircleCollider2D>().radius = 0.08f;
                this.player.transform.localScale = new Vector3(5.2f, 5.2f, 5.2f);
                break;
        }
        
    }

    void Awake()
    {
        sr = this.GetComponent<SpriteRenderer>();


    }
    
    void LateUpdate()    {
        if(Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jumpForce;
            jumpAudio.Play();
           
        }
       
        if (transform.position.y < -3)
        {
            this.gameObject.GetComponent<Rigidbody2D>().gravityScale = 0.0f;
        }
        else
        {
            this.gameObject.GetComponent<Rigidbody2D>().gravityScale = 3.0f;
        }
        
        

    }
    void OnTriggerEnter2D(Collider2D col)
    {
 
        if (col.tag == "ColorChanger")
        {
            SetRandomColor();
            Destroy(col.gameObject);
            return;
        }
        else if (col.tag == "Money")
        {
            coinAudio.Play();
            IncreaseCoins();
            Destroy(col.gameObject);
            return;
        }
        else if (col.tag != currentColor)
        {
            Debug.Log("game over");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            deadAudio.Play();
            return;
        }

   

        
    }

  



    void SetRandomColor()
    {
        int index = Random.Range(0, 4);
        switch (index)
        {
            case 0:
                currentColor = "Cyan";
                sr.color = colorCyan;
                break;
            case 1:
                currentColor = "Yellow";
                sr.color = colorYellow;
                break;
            case 2:
                currentColor = "Magenta";
                sr.color = colorMagenta;
                break;
            case 3:
                currentColor = "Pink";
                sr.color = colorPink;
                break;
        }

    }


    public void IncreaseCoins()
    {
        PlayerPrefsManager.coins += 10;
        PlayerPrefsManager.UpdateCoins();
    }
   
}
