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
  }
}
