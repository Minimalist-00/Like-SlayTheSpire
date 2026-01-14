using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscardArea : MonoBehaviour
{
    // 捨て札のカードを管理する
    public List<CardObj> cards = new List<CardObj>();

    public void AddCard(CardObj cardObj)
    {
        cards.Add(cardObj);
        cardObj.transform.SetParent(transform);
        cardObj.gameObject.SetActive(false);
    }
}
