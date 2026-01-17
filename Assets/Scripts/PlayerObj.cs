using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerObj : MonoBehaviour
{
  [SerializeField] int hp;
  [SerializeField] int defense = 0;
  public int HP => hp;

  public void Damage(int damage)
  {
    // 防御があるときの処理
    if (defense > 0)
    {
      defense -= damage;
      // 防御値を超過するときの処理
      if (defense < 0)
      {
        hp += defense; // 防御に対して超過ダメージはHPに反映する
        defense = 0;
      }
    }
    // 防御がないときの処理
    else
    {
      hp -= damage;
    }
    if (hp <= 0)
    {
      // TODO: Game Over
      Debug.Log("Game Over");
    }
  }

  public void Defense(int defense)
  {
    // 1ターン限定で`defense`分の防御を付与する
    this.defense += defense;
  }
}
