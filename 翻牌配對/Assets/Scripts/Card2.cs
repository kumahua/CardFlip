using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card2 : MonoBehaviour
{
    public CardState2 cardState;
    public CardPattern2 cardPattern;
    public GameManager2 gameManager2;
//    public static Card card;

    public void Start()
    {
        cardState = CardState2.未翻牌;
        gameManager2 = GameObject.FindGameObjectWithTag("GameManager2").GetComponent<GameManager2>();
    }

    public void OnMouseUp()
    {
        if (cardState.Equals(CardState2.已翻牌))
        {
            return;
        }

        if (gameManager2.ReadyToCompareCards)
        {
            return;
        }

        if (cardState.Equals(CardState2.配對成功))
        {
            return;
        }

        OpenCard();
        gameManager2.AddCardInCardComparison(this);

        gameManager2.CompareCardsInList();
    }
    void OpenCard()
    {
        transform.eulerAngles = new Vector3(0, 180, 0);
        Foodsound();
        cardState = CardState2.已翻牌;
        GetComponent<AudioSource>().Play();
    }
    public void Foodsound()
    {
        if (cardPattern.Equals(CardPattern.臭豆腐))
        {
            SoundManager.instance.Stinktofu();
        }
        else if(cardPattern.Equals(CardPattern.珍奶))
        {
            SoundManager.instance.Pearlmilk();
        }
        else if(cardPattern.Equals(CardPattern.滷肉飯))
        {
            SoundManager.instance.Meatrice();
        }
    }
}

public enum CardState2
{
    未翻牌, 已翻牌, 配對成功
}

public enum CardPattern2
{
    無, 小籠包, 臭豆腐, 牛肉麵, 珍奶,
}