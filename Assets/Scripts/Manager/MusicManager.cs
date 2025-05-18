using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioClip damage_Sound;
    public AudioClip point_Sound;
    public AudioClip theme_Music;
    public AudioClip click_Sound;

    public AudioSource audioSource;
    public AudioSource sfxSource;

    private void Start()
    {
        PlayMusic(theme_Music);
    }

    public void PlayMusic(AudioClip clip) 
    {
        audioSource.clip = clip;
        audioSource.Play();
    }

    public void PLaySFX(AudioClip clip) 
    {
        if(!sfxSource.isPlaying) 
        {
            sfxSource.clip = clip;
            sfxSource.Play();
            //sfxSource.PlayOneShot(clip);
        }
    }

}
