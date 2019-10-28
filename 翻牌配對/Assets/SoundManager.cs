using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    public static SoundManager instance;

    public AudioSource audioSource;
    public AudioClip rightAudio, errorAudio;

    public void Awake()
    {
        instance = this;
    }

    public void RightAudio()
    {
        audioSource.clip = rightAudio;
        audioSource.Play();
    }

    public void ErrorAudio()
    {
        audioSource.clip = errorAudio;
        audioSource.Play();
    }
}
