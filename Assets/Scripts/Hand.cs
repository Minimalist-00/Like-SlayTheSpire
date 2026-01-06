using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
  List<CardObj> cardList = new List<CardObj>();

  public void AddCard(CardObj cardObj)
  {
    cardList.Add(cardObj);
    // 親をHandにする
    cardObj.transform.SetParent(transform);
    cardObj.gameObject.SetActive(true);
    ArrangeCards();
    cardObj.OnEndDragAction += ArrangeCards;
  }

  // 手札に加えられたカードを整列させる
  public void ArrangeCards()
  {
    for (int i = 0; i < cardList.Count; i++)
    {
      // 中央を0にする
      float center = (cardList.Count - 1) / 2f;
      // カードの間隔
      float gap = 100f;
      // カードの位置
      float x = (i - center) * gap;
      cardList[i].transform.localPosition = new Vector3(x, 0, 0); //localPositionは親の位置が基準
    }
  }
}
