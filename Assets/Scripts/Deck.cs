using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;

public class Deck : MonoBehaviour
{
  [SerializeField] CardObj cardObjPrefab;
  [SerializeField] Hand hand;
  List<CardObj> cardList = new List<CardObj>();
  public bool IsEmpty => cardList.Count == 0;
  public List<CardObj> CardList => cardList;
  public CardData[] AllCardData; // 全てのカードのデータを保持するリスト

  public void Setup()
  {
    for (int i = 0; i < 10; i++)
    {
      CardObj cardObj = Spawn(); // cardObjインスタンスを生成
      int randomIndex = Random.Range(0, AllCardData.Length); // ランダムなインデックスを取得
      cardObj.SetCardData(AllCardData[randomIndex]); // ランダムなカードをセットする
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
