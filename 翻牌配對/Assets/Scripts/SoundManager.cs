using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    public static SoundManager instance;

    public AudioSource audioSource;
    public AudioClip rightAudio, errorAudio, lamanAudio, pearlmilkAudio, tofuAudio, meatriceAudio, bloodcakeAudio, friednoodlesAudio,
        掛包音, 蚵仔煎音, 雞排音, 地瓜球音, 豬腳飯音, 紅豆餅音, 烤玉米音, 鹽酥雞音;
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
    public void friednoodles()
    { 
        audioSource.clip = friednoodlesAudio;
        audioSource.Play();
    }
    public void 刈包()
    {
        audioSource.clip = 掛包音;
        audioSource.Play();
    }
    public void 蚵仔煎()
    {
        audioSource.clip = 蚵仔煎音;
        audioSource.Play();
    }
    public void 雞排()
    {
        audioSource.clip = 雞排音;
        audioSource.Play();
    }
    public void 地瓜球()
    {
        audioSource.clip = 地瓜球音;
        audioSource.Play();
    }
    public void 豬腳飯()
    {
        audioSource.clip = 豬腳飯音;
        audioSource.Play();
    }
    public void 紅豆餅()
    {
        audioSource.clip = 紅豆餅音;
        audioSource.Play();
    }
    public void 烤玉米()
    {
        audioSource.clip = 烤玉米音;
        audioSource.Play();
    }
    public void 鹽酥雞()
    {
        audioSource.clip = 鹽酥雞音;
        audioSource.Play();
    }
}
