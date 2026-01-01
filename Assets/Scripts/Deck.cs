using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    [SerializeField] CardObj cardObjPrefab;
    [SerializeField] Hand hand;
    List<CardObj> cardList = new List<CardObj>();
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            CardObj cardObj = Spawn(); // cardObjインスタンスを生成
            cardObj.gameObject.SetActive(false);
            cardList.Add(cardObj);
        }
    }

    int n = 0;
    void Update()
    {
        if(n < 4){
            if (Input.GetKeyDown(KeyCode.Space))
            {
                CardObj drawCard = DrawCard();
                drawCard.transform.SetParent(hand.transform);
                drawCard.gameObject.SetActive(true);
                n++;
            }
        }
    }

    private CardObj DrawCard()
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
