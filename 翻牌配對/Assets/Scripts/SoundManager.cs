using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    public static SoundManager instance;

    public AudioSource audioSource;
    public AudioClip rightAudio, errorAudio, lamanAudio, pearlmilkAudio, tofuAudio, meatriceAudio ,bloodcakeAudio;
   // public Card card;

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

    public void Pearlmilk()
    {
        audioSource.clip = pearlmilkAudio;
        audioSource.Play();
    }

    public void Stinktofu()
    {
        audioSource.clip = tofuAudio;
        audioSource.Play();
    }
    public void Meatrice()
    {
        audioSource.clip = meatriceAudio;
        audioSource.Play();
    }
    public void Bloodcake()
    {
        audioSource.clip = bloodcakeAudio;
        audioSource.Play();
    }
}
