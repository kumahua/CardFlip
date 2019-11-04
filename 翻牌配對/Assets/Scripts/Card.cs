using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public CardState cardState;
    public CardPattern cardPattern;
    public GameManager gameManager;
//    public static Card card;

    void Start()
    {
        cardState = CardState.未翻牌;
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    private void OnMouseUp()
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
        transform.eulerAngles = new Vector3(0, 180, 0);
        Foodsound();
        cardState = CardState.已翻牌;
        GetComponent<AudioSource>().Play();
    }
    private void Foodsound()
    {
        if (cardPattern.Equals(CardPattern.laman))
        {
            SoundManager.instance.Laman();
        }
    }
}

public enum CardState
{
    未翻牌, 已翻牌, 配對成功
}

public enum CardPattern
{
    無, 小籠包, 水餃, 牛肉麵, 珍奶, 蔥油餅, pie, 魷魚, laman
}
