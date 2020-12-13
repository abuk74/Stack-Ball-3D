using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    public bool sound = true;
    private AudioSource audioSource;
    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
        audioSource = GetComponent<AudioSource>();
    }
    public void SoundOnOff()
    {
        sound = !sound;
    }
    public void PlaySoundFX(AudioClip clip, float volume)
    {
        if (sound)
            audioSource.PlayOneShot(clip, volume);
        
    }
}
