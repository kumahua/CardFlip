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

public enum CardState
{
    未翻牌, 已翻牌, 配對成功
}

public enum CardPattern
{
    無, 小籠包, 臭豆腐, 牛肉麵, 珍奶, 蔥油餅, 豬血糕, 滷肉飯, 鳥蛋
}
