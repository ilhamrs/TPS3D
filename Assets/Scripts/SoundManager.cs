using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    public AudioClip uiButton;
    public AudioClip itemAudio;
    public AudioClip footstepAudio;

    private AudioSource audio;

    private void Awake()
    {
        if (instance != null)
        {
            
        }
        else
        {
            instance = this;
        }
        audio = GetComponent<AudioSource>();
    }

    public void UIClickSfx()
    {
        audio.PlayOneShot(uiButton);
    }

    public void getItemSound()
    {
        audio.PlayOneShot(itemAudio);
    }

    public void getFootstepAudio()
    {
        audio.PlayOneShot(footstepAudio);
    }

    
}
