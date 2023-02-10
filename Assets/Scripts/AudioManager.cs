using UnityEngine.Audio;
using UnityEngine;
using UnityEngine.UI;
using System;


public class AudioManager : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
   
    public Sound[] sounds;
    
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("musicVol"))
        {
            PlayerPrefs.SetFloat("musicVol", 1);
            Load();
        }
        else
        {
            Load();
        }
    }
    void Awake()
    {
     
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }
    }
    public void Play(string name)
    {
        Sound s = Array.Find(sounds, Sound => Sound.name == name);
        s.source.Play();
    }
    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        Save();
        
    }
    private void Save()
    {
        PlayerPrefs.SetFloat("musicVol", volumeSlider.value);
    }
    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("musicVol");
    }


}
