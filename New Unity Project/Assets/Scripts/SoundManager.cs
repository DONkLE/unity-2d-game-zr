using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    public AudioSource audioSource;

    public AudioClip coinCollectSound;

    public AudioClip hitSound;

    public AudioClip winSound;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void PlayCoinCollectSound()
    {
        audioSource.clip = coinCollectSound;
        audioSource.Play();
    }
    public void PlayHitSound()
    {
        audioSource.clip = hitSound;
        audioSource.Play();
    }
    public void PlayWinSound()
    {
        audioSource.clip = winSound;
        audioSource.Play();
    }
}

