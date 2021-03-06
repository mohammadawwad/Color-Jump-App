using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPrefsManager : MonoBehaviour
{
    public const string Coins = "Coins";
    public static int coins = 0;

    public const string MusicVolume = "MusicVolume";
    public static float musicVolume = 0.7f;

    public const string JumpVolume = "JumpVolume";
    public static float jumpVolume = 0.7f;
    void Start()
    {
        coins = PlayerPrefs.GetInt("Coins");

    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetFloat("MusicVolume", musicVolume);
        musicVolume = PlayerPrefs.GetFloat("MusicVolume");
        PlayerPrefs.SetFloat("JumpVolume", jumpVolume);
        jumpVolume = PlayerPrefs.GetFloat("JumpVolume");
    }
    public static void UpdateCoins()
    {
        PlayerPrefs.SetInt("Coins", coins);
        coins = PlayerPrefs.GetInt("Coins");
        PlayerPrefs.Save();
    }
   
    public static void UpdateVolume()
    {

        PlayerPrefs.SetFloat("MusicVolume", musicVolume);
        musicVolume = PlayerPrefs.GetFloat("MusicVolume");
        PlayerPrefs.SetFloat("JumpVolume", jumpVolume);
        jumpVolume = PlayerPrefs.GetFloat("JumpVolume");
        PlayerPrefs.Save();
    }
}
