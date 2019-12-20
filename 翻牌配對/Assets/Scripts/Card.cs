using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public CardState cardState;
    public CardPattern cardPattern;
    public GameManager gameManager;
    public static Card card;
    //    public static Card card;

    public void Start()
    {
        cardState = CardState.未翻牌;
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    public void OnMouseUp()
    {
        if (cardState.Equals(CardState.已翻牌))
        {
            return;
        }

        if (gameManager.ReadyToCompareCards)
        {
            return;
        }

        if (cardState.Equals(CardState.配對成功))
        {
            return;
        }
        OpenCard();

        gameManager.AddCardInCardComparison(this);

        gameManager.CompareCardsInList();
    }
    void OpenCard()
    {
        GetComponent<AudioSource>().Play();
        StartCoroutine(ReloadMusic());
        transform.eulerAngles = new Vector3(0, 180, 0);
        cardState = CardState.已翻牌;
    }
    public void Foodsound()
    {
        if (cardPattern.Equals(CardPattern.臭豆腐))
        {
            SoundManager.instance.Stinktofu();
        }
        else if(cardPattern.Equals(CardPattern.蚵仔煎))
        {
            SoundManager.instance.蚵仔煎();
        }
        else if(cardPattern.Equals(CardPattern.滷肉飯))
        {
            SoundManager.instance.Meatrice();
        }
        else if (cardPattern.Equals(CardPattern.刈包))
        {
            SoundManager.instance.刈包();
        }
        else if (cardPattern.Equals(CardPattern.雞排))
        {
            SoundManager.instance.雞排();
        }
        else if (cardPattern.Equals(CardPattern.地瓜球))
        {
            SoundManager.instance.地瓜球();
        }
        else if (cardPattern.Equals(CardPattern.豬血糕))
        {
            SoundManager.instance.Bloodcake();
        }
        else if (cardPattern.Equals(CardPattern.豬腳飯))
        {
            SoundManager.instance.豬腳飯();
        }
    }

    IEnumerator ReloadMusic()
    {
        //yield return new WaitForSeconds(0.1f);
        Foodsound();
        yield return new WaitForSeconds(2f);
    }
}

public enum CardState
{
    未翻牌, 已翻牌, 配對成功
}

public enum CardPattern
{
    無, 地瓜球, 臭豆腐, 雞排, 刈包, 蚵仔煎, 豬血糕, 滷肉飯, 豬腳飯
}