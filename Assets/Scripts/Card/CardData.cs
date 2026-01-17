using System.Collections;
using System.Collections.Generic;
using System.IO.Enumeration;
using System.Runtime.InteropServices;
using UnityEngine;

public enum CardType { None, Attack, Defense, DrawCard, }

public enum CardElement { None, Fire, Thunder, }

// Unityエディタ上でCreateするやつ + インスペクタで設定する項目たち
[CreateAssetMenu(fileName = "NewCard", menuName = "Card/CardData")]
public class CardData : ScriptableObject
{
  public string Name;
  public string Description;
  public int Cost;
  public Sprite Icon;
  public int Attack;
  public int Defense;
  public CardType CardType;
  public CardElement Element;
}
