using UnityEngine;
using UnityEngine.UI;
public class VolumeValueChange : MonoBehaviour
{
  
    private AudioSource audioSrc;
    private AudioSource jumpAudio;
  
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
        jumpAudio = GetComponent<AudioSource>();
     
    }

    // Update is called once per frame
    void Update()
    {
        audioSrc.volume = PlayerPrefsManager.musicVolume;
        jumpAudio.volume = PlayerPrefsManager.jumpVolume;
      
        
    }
    public void SetVolume(float vol)
    {
        PlayerPrefsManager.musicVolume = vol;
        PlayerPrefsManager.jumpVolume = vol;
    }
   
}
