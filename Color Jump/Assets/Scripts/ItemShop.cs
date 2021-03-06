using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemShop : MonoBehaviour
{
    public Sprite WhiteFace_0, Knob, Cry_Face_0, Spike_Ball_0;
    public SpriteRenderer sr;
    public Player player;
    public CircleCollider2D cc;

    public Text textshowed = null;
    //public const string textChanged = "NewText";
    //public const string word = "word";

    public float ScaleSpeed = 1f;
    private readonly string selectedCharacter = "SelectedCharacter";
    private readonly string Is_WhiteFace_Sold = "WhiteFace_Sold";
    private readonly string Is_CryFace_Sold = "CryFace_Sold";
    private readonly string Is_SpikeBall_Sold = "SpikeBall_Sold";

    int getWhiteFace;
    int getCryFace;
    int getSpikeBall;


    void Start()
    {
        

    }
   
    void Update()
    {
        getWhiteFace = PlayerPrefs.GetInt(Is_WhiteFace_Sold);
        getCryFace = PlayerPrefs.GetInt(Is_CryFace_Sold);
        getSpikeBall = PlayerPrefs.GetInt(Is_SpikeBall_Sold);
    }

    public void ChangeText(string word)
    {
        textshowed.text = word;

    }

    public void Buy_WhiteFace()
    {
       
        if(PlayerPrefsManager.coins > 20 && getWhiteFace == 0)
        {
            
            SetWhiteFace();
            PlayerPrefsManager.coins -= 20;
            PlayerPrefsManager.UpdateCoins();
           
            void SetWhiteFace()
            {

                //defualt size for scale = 5
                
                PlayerPrefs.SetInt(selectedCharacter, 2);
                PlayerPrefs.SetInt(Is_WhiteFace_Sold, 1);
                this.player.gameObject.GetComponent<SpriteRenderer>().sprite = WhiteFace_0;
                this.player.gameObject.GetComponent<CircleCollider2D>().radius = 0.4f;
                this.player.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
                    
              
            }
        }
        else if(getWhiteFace == 1)
        {
            SetWhiteFace();


            void SetWhiteFace()
            {

                //defualt size for scale = 5
                PlayerPrefs.SetInt(selectedCharacter, 2);
                PlayerPrefs.SetInt(Is_WhiteFace_Sold, 1);
                this.player.gameObject.GetComponent<SpriteRenderer>().sprite = WhiteFace_0;
                this.player.gameObject.GetComponent<CircleCollider2D>().radius = 0.4f;
                this.player.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);


            }
        }
    }

    public void Buy_CryFace()
    {
        if (PlayerPrefsManager.coins > 30 && getCryFace == 0)
        {
            SetCryFace();
            PlayerPrefsManager.coins -= 30;
            PlayerPrefsManager.UpdateCoins();

            void SetCryFace()
            {

                //defualt size for scale = 5
                PlayerPrefs.SetInt(selectedCharacter, 3);
                PlayerPrefs.SetInt(Is_CryFace_Sold, 1);
                this.player.gameObject.GetComponent<SpriteRenderer>().sprite = Cry_Face_0;
                this.player.gameObject.GetComponent<CircleCollider2D>().radius = 0.32f;
                this.player.transform.localScale = new Vector3(1.3f, 1.3f, 1.3f);


            }
        }
        else if (getCryFace == 1)
        {
            SetCryFace();


            void SetCryFace()
            {

                //defualt size for scale = 5
                PlayerPrefs.SetInt(selectedCharacter, 3);
                PlayerPrefs.SetInt(Is_CryFace_Sold, 1);
                this.player.gameObject.GetComponent<SpriteRenderer>().sprite = Cry_Face_0;
                this.player.gameObject.GetComponent<CircleCollider2D>().radius = 0.32f;
                this.player.transform.localScale = new Vector3(1.3f, 1.3f, 1.3f);


            }
        }
    }

    public void Buy_SpikeBall()
    {
        if (PlayerPrefsManager.coins > 40 && getSpikeBall == 0)
        {
            SetSpikeBall();
            PlayerPrefsManager.coins -= 40;
            PlayerPrefsManager.UpdateCoins();

            void SetSpikeBall()
            {

                //defualt size for scale = 5
                PlayerPrefs.SetInt(selectedCharacter, 4);
                PlayerPrefs.SetInt(Is_SpikeBall_Sold, 1);
                this.player.gameObject.GetComponent<SpriteRenderer>().sprite = Spike_Ball_0;
                this.player.gameObject.GetComponent<CircleCollider2D>().radius = 0.55f;
                this.player.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);


            }
        }
        else if (getSpikeBall == 1)
        {
            SetSpikeBall();


            void SetSpikeBall()
            { 

                //defualt size for scale = 5
                PlayerPrefs.SetInt(selectedCharacter, 4);
                PlayerPrefs.SetInt(Is_SpikeBall_Sold, 1);
                this.player.gameObject.GetComponent<SpriteRenderer>().sprite = Spike_Ball_0;
                this.player.gameObject.GetComponent<CircleCollider2D>().radius = 0.55f;
                this.player.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);


            }
        }
    }

    public void Buy_Knob()
    {
        if (PlayerPrefsManager.coins > 0)
        {
            SetKnob();
           // PlayerPrefsManager.coins -= 0;
           // PlayerPrefsManager.UpdateCoins();

            void SetKnob()
            {

                //defualt size for scale = 5
                
                PlayerPrefs.SetInt(selectedCharacter, 1);
                this.player.gameObject.GetComponent<SpriteRenderer>().sprite = Knob;
                this.player.gameObject.GetComponent<CircleCollider2D>().radius = 0.08f;
                this.player.transform.localScale = new Vector3(5.2f, 5.2f, 5.2f);


            }
        }
    }
}
