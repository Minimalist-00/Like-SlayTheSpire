using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
  [SerializeField] CardObj cardObjPrefab;
  [SerializeField] Hand hand;
  List<CardObj> cardList = new List<CardObj>();
  public bool IsEmpty => cardList.Count == 0;

  public void Setup()
  {
    for (int i = 0; i < 10; i++)
    {
      CardObj cardObj = Spawn(); // cardObjインスタンスを生成
      cardObj.gameObject.SetActive(false);
      cardList.Add(cardObj);
    }
  }

  public void AddCard(CardObj cardObj)
  {
    cardList.Add(cardObj);
    cardObj.transform.SetParent(transform);
    cardObj.gameObject.SetActive(false);
  }

  public CardObj DrawCard()
  {
    CardObj cardObj = cardList[0];
    cardList.RemoveAt(0);
    return cardObj;
  }

  CardObj Spawn()
  {
    return Instantiate(cardObjPrefab, transform); // transformはDeckオブジェクトのこと
  }
}
