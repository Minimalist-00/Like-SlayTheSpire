using System.Collections;
using System.Collections.Generic;
using System.IO.Enumeration;
using UnityEngine;

[CreateAssetMenu(fileName = "NewCard", menuName = "Card/CardData")]

public class CardData : ScriptableObject
{
  public string Name;
  public string Description;
  public int Cost;
  public Sprite Icon;
}
