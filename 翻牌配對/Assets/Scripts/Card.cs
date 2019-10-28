﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public CardState cardState;
    public CardPattern cardPattern;
    public GameManager gameManager;

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

        OpenCard();
        gameManager.AddCardInCardComparison(this);
        gameManager.CompareCardsInList();
    }
    void OpenCard()
    {
        transform.eulerAngles = new Vector3(0, 180, 0);
        cardState = CardState.已翻牌;
        GetComponent<AudioSource>().Play();
    }
}

public enum CardState
{
    未翻牌, 已翻牌, 配對成功
}

public enum CardPattern
{
    無, fries, 柳橙, hamburger, 水蜜桃, 芭樂, pie, sandwich, sausage
}