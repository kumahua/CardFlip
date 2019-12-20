using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card2 : MonoBehaviour
{
    public CardState2 cardState;
    public CardPattern2 cardPattern2;
    public GameManager2 gameManager2;
    public static Card2 card;
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
        if (cardPattern2.Equals(CardPattern2.鹽酥雞))
        {
            SoundManager.instance.鹽酥雞();
        }
        else if(cardPattern2.Equals(CardPattern2.烤玉米))
        {
            SoundManager.instance.烤玉米();
        }
        else if(cardPattern2.Equals(CardPattern2.紅豆餅))
        {
            SoundManager.instance.紅豆餅();
        }
        else if (cardPattern2.Equals(CardPattern2.珍奶))
        {
            SoundManager.instance.Pearlmilk();
        }
    }
}

public enum CardState2
{
    未翻牌, 已翻牌, 配對成功
}

public enum CardPattern2
{
    無, 鹽酥雞, 烤玉米, 紅豆餅, 珍奶
}